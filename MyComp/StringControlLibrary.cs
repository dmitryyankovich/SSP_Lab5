using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyComp
{
    public partial class StringControlLibrary : Control
    {
       
        public string Head(string str,string separator)
        {
            if (separator == string.Empty) separator = ",";
            var pos = str.IndexOf(separator);
            return pos == -1 ? str : str.Substring(0, pos);
        }

        public string Tail(string str,string separator)
        {
            if (separator == string.Empty) separator = ",";
            var temp = separator.Length;
            var pos = str.IndexOf(separator);
            return pos == -1 ? str : str.Substring(pos + temp, str.Length - pos - temp);
        }

        public StringControlLibrary()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

    }
}
