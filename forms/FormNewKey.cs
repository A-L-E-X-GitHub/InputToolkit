using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseHelper
{
    public partial class FormNewKey : Form
    {

        private ActionEventPanel m_panel;
        private DragManager m_dragManager;

        public FormNewKey(ActionEventPanel panel)
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
        private void OnButtonPressed_AddEvent(object sender, EventArgs e)
        {

        }
        #endregion

        #region Window Dragging Handling.
        private void OnDrag_MouseDown(object sender, MouseEventArgs e) => m_dragManager.MouseDown(sender, e);
        private void OnDrag_MouseMove(object sender, MouseEventArgs e) => m_dragManager.MouseMove(sender, e);
        private void OnDrag_MouseUp(object sender, MouseEventArgs e) => m_dragManager.MouseUp(sender, e);
        #endregion

    }
}
