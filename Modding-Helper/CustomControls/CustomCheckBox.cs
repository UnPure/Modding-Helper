//////////////////////////////////////////////////////////////////////////////
// Modding-Helper
//
// Copyright (c) 2016 UnPure-Gaming - All rights reserved.
//
// This software is provided 'as-is', without any express or implied warranty.
// In no event will the author be held liable for any damages arising from
// the use of this software.
//
//////////////////////////////////////////////////////////////////////////////

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
