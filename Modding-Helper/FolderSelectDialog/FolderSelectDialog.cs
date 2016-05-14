using System;
using System.Windows.Forms;

namespace FolderSelect
{
	public class FolderSelectDialog
	{
		System.Windows.Forms.OpenFileDialog ofd = null;

		public FolderSelectDialog()
		{
			ofd = new System.Windows.Forms.OpenFileDialog();

			ofd.Filter = "Folders|\n";
			ofd.AddExtension = false;
			ofd.CheckFileExists = false;
			ofd.DereferenceLinks = true;
			ofd.Multiselect = false;
		}

		#region Properties

		public string InitialDirectory
		{
			get { return ofd.InitialDirectory; }
			set { ofd.InitialDirectory = value == null || value.Length == 0 ? Environment.CurrentDirectory : value; }
		}

		public string Title
		{
			get { return ofd.Title; }
			set { ofd.Title = value == null ? "Select a folder" : value; }
		}

		public string FileName
		{
			get { return ofd.FileName; }
		}

		#endregion

		#region Methods

		public bool ShowDialog()
		{
			return ShowDialog(IntPtr.Zero);
		}

		public bool ShowDialog(IntPtr hWndOwner)
		{
			bool flag = false;

			if (Environment.OSVersion.Version.Major >= 6)
			{
				var r = new Reflector("System.Windows.Forms");

				uint num = 0;
				Type typeIFileDialog = r.GetType("FileDialogNative.IFileDialog");
				object dialog = r.Call(ofd, "CreateVistaDialog");
				r.Call(ofd, "OnBeforeVistaDialog", dialog);

				uint options = (uint)r.CallAs(typeof(System.Windows.Forms.FileDialog), ofd, "GetOptions");
				options |= (uint)r.GetEnum("FileDialogNative.FOS", "FOS_PICKFOLDERS");
				r.CallAs(typeIFileDialog, dialog, "SetOptions", options);

				object pfde = r.New("FileDialog.VistaDialogEvents", ofd);
				object[] parameters = new object[] { pfde, num };
				r.CallAs2(typeIFileDialog, dialog, "Advise", parameters);
				num = (uint)parameters[1];
				try
				{
					int num2 = (int)r.CallAs(typeIFileDialog, dialog, "Show", hWndOwner);
					flag = 0 == num2;
				}
				finally
				{
					r.CallAs(typeIFileDialog, dialog, "Unadvise", num);
					GC.KeepAlive(pfde);
				}
			}
			else
			{
				var fbd = new FolderBrowserDialog();
				fbd.Description = this.Title;
				fbd.SelectedPath = this.InitialDirectory;
				fbd.ShowNewFolderButton = false;
				if (fbd.ShowDialog(new WindowWrapper(hWndOwner)) != DialogResult.OK) return false;
				ofd.FileName = fbd.SelectedPath;
				flag = true;
			}

			return flag;
		}

		#endregion
	}

	public class WindowWrapper : System.Windows.Forms.IWin32Window
	{
		public WindowWrapper(IntPtr handle)
		{
			_hwnd = handle;
		}

		public IntPtr Handle
		{
			get { return _hwnd; }
		}

		private IntPtr _hwnd;
	}

}
