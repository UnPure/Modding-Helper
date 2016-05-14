using System.Windows.Forms;
using System.Drawing;

namespace Modding_Helper
{
    class CustomFolderButton : System.Windows.Forms.Button
    {
        public CustomFolderButton()
            : base()
        {
            FlatAppearance.BorderSize = 0;
            FlatAppearance.BorderColor = Color.Black;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BackgroundImageLayout = ImageLayout.Stretch;
            Size = Size = new Size(259, 25);
            ForeColor = Color.FromArgb(255, 159, 0);
            Dock = DockStyle.Top;
            Margin = new Padding(0, 3, 0, 3);
        }

        private bool _DisplayFocusCues = true;
        protected override bool ShowFocusCues
        {
            get
            {
                return _DisplayFocusCues;
            }
        }
        public bool DisplayFocusCues
        {
            get
            {
                return _DisplayFocusCues;
            }
            set
            {
                _DisplayFocusCues = value;
            }
        }

        private string ownerDrawText;
        public string OwnerDrawText
        {
            get { return ownerDrawText; }
            set { ownerDrawText = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(ownerDrawText))
            {
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString(ownerDrawText, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
            }
        }
    }
}
