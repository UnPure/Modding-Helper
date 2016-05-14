namespace Modding_Helper
{
    class CustomCheckBox : System.Windows.Forms.CheckBox
    {
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
    }
}
