using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseHelper
{
    public partial class StylizedButton : Button
    {
        public StylizedButton()
        {
            InitializeComponent();

            this.FlatAppearance.BorderColor        = Color.FromArgb(150, 150, 150);
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(130, 130, 130);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 115, 115);
            this.BackColor = Color.FromArgb(110, 110, 110);
            this.ForeColor = Color.Gainsboro;
            this.FlatStyle = FlatStyle.Flat;
            this.Font      = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TabIndex  = 0;
        }

        public void SetText(string text)
        {
            button1.Text = text;
        }
    }
}
