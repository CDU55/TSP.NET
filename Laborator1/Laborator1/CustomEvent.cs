using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator1
{
    class CustomEvent : EventArgs
    {
        public String CryptoText { get; set; }
        public CustomEvent(string CryptoText)
        {
            this.CryptoText = CryptoText;
        }
    }
}
