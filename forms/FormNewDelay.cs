using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseHelper
{
    public partial class FormNewDelay : Form
    {

        private ActionEventPanel m_panel;
        private DragManager m_dragManager;

        public FormNewDelay(ActionEventPanel panel)
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
            if (!int.TryParse(textBox1.Text, out int duration)) return;
            if (duration < 100)
            {
                textBox1.Text = "100";
                return;
            }

            m_panel.AddNewActionEventComponent(m_panel.GetEventComponentType(1), duration);
            this.Close();
        }
        #endregion

        #region Dragging Function(s)
        private void OnDrag_MouseDown(object sender, MouseEventArgs e) => m_dragManager.MouseDown(sender, e);
        private void OnDrag_MouseMove(object sender, MouseEventArgs e) => m_dragManager.MouseMove(sender, e);
        private void OnDrag_MouseUp(object sender, MouseEventArgs e) => m_dragManager.MouseUp(sender, e);
        #endregion

    }
}
