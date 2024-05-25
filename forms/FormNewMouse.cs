using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseHelper
{
    public partial class FormNewMouse : Form
    {

        private ActionEventPanel m_panel;
        private DragManager m_dragManager;
        private GlobalMouseEvents m_gMouseEvents = new GlobalMouseEvents();
        private Point m_pntCursorPosition;

        public FormNewMouse(ActionEventPanel panel)
        {
            InitializeComponent();
            m_panel = panel;
            m_dragManager = new DragManager(this);
            m_gMouseEvents.MouseDown += OnGlobalMouseEvent_MouseDown;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(135, 135, 135), ButtonBorderStyle.Solid);
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 3)
            {
                label1.Enabled   = false;
                label2.Enabled   = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                buttonSetPosition.Enabled = false;
            }
            else
            {
                label1.Enabled   = true;
                label2.Enabled   = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                buttonSetPosition.Enabled = true;
            }
        }

        #region Button Function(s)
        private void OnButtonPressed_Close(object sender, EventArgs e) => this.Close();
        private void OnButtonPressed_AddEvent(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;
            if (!int.TryParse(textBox1.Text, out int x)) return;
            if (!int.TryParse(textBox2.Text, out int y)) return;
            ActionEventPanel.EventComponentType eventComponentType = m_panel.GetEventComponentType(comboBox1.SelectedIndex + 3);
            m_panel.AddNewActionEventComponent(eventComponentType, new Point(x, y));
            this.Close();
        }
        #endregion

        #region Window Dragging Handling.
        private void OnDrag_MouseDown(object sender, MouseEventArgs e) => m_dragManager.MouseDown(sender, e);
        private void OnDrag_MouseMove(object sender, MouseEventArgs e) => m_dragManager.MouseMove(sender, e);
        private void OnDrag_MouseUp(object sender, MouseEventArgs e) => m_dragManager.MouseUp(sender, e);
        #endregion

        private void OnButtonPress_GetCursorPosition(object sender, EventArgs e)
        {
            timer1.Start();
            m_gMouseEvents.Start();
        }
        private void OnGlobalMouseEvent_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            m_gMouseEvents.Stop();

            textBox1.Text = Cursor.Position.X.ToString("0000");
            textBox2.Text = Cursor.Position.Y.ToString("0000");

            buttonSetPosition.Text = "Set Position";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point position = Cursor.Position;
            if (position != m_pntCursorPosition)
            {
                m_pntCursorPosition = position;
                buttonSetPosition.Text = "X:" + m_pntCursorPosition.X.ToString("0000") +" Y:" + m_pntCursorPosition.Y.ToString("0000");
            }
        }
    }
}
