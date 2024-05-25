using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseHelper
{
    public partial class ActionEventComponent : UserControl
    {
        private bool m_active = false;

        public bool BlockInput { get; set; }
        public int ComponentIndex { get; set; }
        public int Value { get; set; }
        public Label TextLabel { get; set; }
        public Point ClickLocation { get; set; }
        public ActionEventPanel ParentContorl { get; set; }
        public EventComponentType EventType { get; set; }

        public enum EventComponentType
        {
            // Generic events.
            NONE,
            DELAY,
            KEY_PRESS,

            // Mouse interaction events.
            MOUSE_UP,
            MOUSE_DOWN,
            MOUSE_CLICK,

            // Mouse movement / interaction events.
            MOUSE_MOVE,
            MOUSE_MOVE_CLICK
        }

        public enum ComponentImage
        {
            MOUSE_UP,
            MOUSE_DOWN,
            MOUSE_MOVE,
            MOUSE_CLICK,
            STOPWATCH,
            KEY
        }


        public ActionEventComponent(ActionEventPanel parent)
        {
            InitializeComponent();

            ParentContorl = parent;
            TextLabel     = labelText1;
            Value         = 0;
            EventType     = EventComponentType.NONE;
        }

        private void OnButtonPressed_RemoveComponent(object sender, EventArgs e)
        {
            if (BlockInput) return;

            this.ParentContorl.RemoveActionEventComponent(this);
            this.Dispose();
        }
        private void OnButtonPressed_OpenSettings(object sender, EventArgs e)
        {
            Console.WriteLine(this.Name + " requested action -> open settings");
        }

        public void SetHandleColor(Color color) => panelHandle1.BackColor = color;
        public void SetLabelText(string text) => TextLabel.Text = text;
        public void ToggleActive()
        {

            m_active = !m_active;

            if (m_active)
            {
                panelHandle1.BackColor  = Color.FromArgb(000, 180, 000);
                panelControl1.BackColor = Color.FromArgb(040, 100, 040);
            }

            else
            {
                panelHandle1.BackColor  = Color.FromArgb(110, 110, 110);
                panelControl1.BackColor = Color.FromArgb(090, 090, 090);
            }
        }
        public void StopActive()
        {
            m_active = false;
            panelHandle1.BackColor  = Color.FromArgb(180, 000, 000);
            panelControl1.BackColor = Color.FromArgb(100, 040, 040);
        }
        public void Reset()
        {
            m_active = false;
            panelHandle1.BackColor  = Color.FromArgb(110, 110, 110);
            panelControl1.BackColor = Color.FromArgb(090, 090, 090);
        }
        public void SetImage(ComponentImage image)
        {
            switch (image)
            {
                case ComponentImage.STOPWATCH: this.pictureBox1.BackgroundImage = Properties.Resources.stopwatch; break;
            }
        }
    }
}
