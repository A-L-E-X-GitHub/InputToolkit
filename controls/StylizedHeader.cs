using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseHelper
{
    public partial class StylizedHeader : UserControl
    {

        public StylizedHeader()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            label1.Text = text;
        }
    }
}
