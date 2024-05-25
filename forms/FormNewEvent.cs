using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseHelper
{
    public partial class FormNewEvent : Form
    {

        private ActionEventPanel m_panel;
        private DragManager m_dragManager; 

        public FormNewEvent(ActionEventPanel panel)
        {
            InitializeComponent();
            m_panel = panel;
            m_dragManager = new DragManager(this);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(135, 135, 135), ButtonBorderStyle.Solid);
        }

        #region Button Function(s)
        private void OnButtonPressed_Close(object sender, EventArgs e) => this.Close();

        private void OnButtonPressed_NewMouseEvent(object sender, EventArgs e)
        {
            FormNewMouse form = new FormNewMouse(m_panel);
            form.Location = new Point(this.Location.X + 20, this.Location.Y + 20);
            form.ShowDialog(this);
        }

        private void OnButtonPressed_NewKeyEvent(object sender, EventArgs e)
        {
            FormNewKey form = new FormNewKey(m_panel);
            form.Location = new Point(this.Location.X + 20, this.Location.Y + 20);
            form.ShowDialog();
        }

        private void OnButtonPressed_NewDelayEvent(object sender, EventArgs e)
        {
            FormNewDelay form = new FormNewDelay(m_panel);
            form.Location = new Point(this.Location.X + 20, this.Location.Y + 20);
            form.ShowDialog();
        }
        #endregion

        #region Dragging Function(s)
        private void OnDrag_MouseDown(object sender, MouseEventArgs e) => m_dragManager.MouseDown(sender, e);
        private void OnDrag_MouseMove(object sender, MouseEventArgs e) => m_dragManager.MouseMove(sender, e);
        private void OnDrag_MouseUp(object sender, MouseEventArgs e) => m_dragManager.MouseUp(sender, e);
        #endregion

    }
}
