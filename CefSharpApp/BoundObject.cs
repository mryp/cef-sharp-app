using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefSharpApp
{
    public class BoundObject
    {
        public int GetValue()
        {
            return 100;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show("[.NET] " + message);
        }
    }
}
