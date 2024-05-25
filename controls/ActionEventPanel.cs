using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MouseHelper
{
    public partial class ActionEventPanel : UserControl
    {

        public List<ActionEventComponent> ActionEventComponentList = new List<ActionEventComponent>();
        private ActionEventPanel m_panel;
        private int m_width = 349;

        public bool BlockInput { get; set; }

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

        public ActionEventPanel()
        {
            InitializeComponent();
            m_panel = this;
            BlockInput = false;
        }

        public void RemoveActionEventComponent(ActionEventComponent component)
        {
            if (BlockInput) return;

            if (ActionEventComponentList.Count == 10)
            {
                m_width = 349;
                foreach (ActionEventComponent comp in ActionEventComponentList)
                {
                    comp.Width = m_width;
                    comp.TextLabel.MaximumSize = new Size(m_width - 105, 30);
                }
            }

            ActionEventComponentList.Remove(component);
        }

        //private async void ButtonClick_Create_ActionEventComponent(object sender, EventArgs e)
        private void OnButtonPressed_CreateActionEventComponent(object sender, EventArgs e)
        {
            FormNewEvent form = new FormNewEvent(m_panel);
            form.ShowDialog();
        }
        public EventComponentType GetEventComponentType(int index)
        {
            switch (index)
            {
                case 1:  return EventComponentType.DELAY;
                case 2:  return EventComponentType.KEY_PRESS;
                case 3:  return EventComponentType.MOUSE_UP;
                case 4:  return EventComponentType.MOUSE_DOWN;
                case 5:  return EventComponentType.MOUSE_CLICK;
                case 6:  return EventComponentType.MOUSE_MOVE;
                case 7:  return EventComponentType.MOUSE_MOVE_CLICK;
                default: return EventComponentType.NONE;
            }
        }

        public void FormatPanelView()
        {
            if (ActionEventComponentList.Count == 10)
            {
                m_width = 326;
                foreach (ActionEventComponent comp in ActionEventComponentList)
                {
                    comp.Width = m_width;
                    comp.TextLabel.MaximumSize = new Size(m_width - 105, 30);
                }
            }
            if (m_panel.VerticalScroll.Enabled)
                m_panel.VerticalScroll.Value = m_panel.VerticalScroll.Maximum;
        }

        public void AddNewActionEventComponent(EventComponentType type, Keys key)
        {
        }
        public void AddNewActionEventComponent(EventComponentType type, int value)
        {
            ActionEventComponent eventComponent = new ActionEventComponent(this);
            eventComponent.ComponentIndex  = ActionEventComponentList.Count;
            eventComponent.Width           = m_width;
            eventComponent.TextLabel.Width = m_width - 115;
            eventComponent.Value           = value;
            eventComponent.SetLabelText("Delay {" + value + "ms}");
            eventComponent.EventType = ActionEventComponent.EventComponentType.DELAY;
            eventComponent.SetImage(ActionEventComponent.ComponentImage.STOPWATCH);

            m_panel.flowLayoutPanel1.Controls.Add(eventComponent);
            ActionEventComponentList.Add(eventComponent);
            FormatPanelView();
        }

        public void AddNewActionEventComponent(EventComponentType type, Point location)
        {
            ActionEventComponent eventComponent = new ActionEventComponent(this);
            eventComponent.ComponentIndex  = ActionEventComponentList.Count;
            eventComponent.Width           = m_width;
            eventComponent.TextLabel.Width = m_width - 115;
            eventComponent.ClickLocation   = location;

            switch (type)
            {
                case EventComponentType.MOUSE_DOWN:
                    eventComponent.EventType = ActionEventComponent.EventComponentType.MOUSE_DOWN;
                    eventComponent.SetLabelText("Mouse Down");
                    break;

                case EventComponentType.MOUSE_UP:
                    eventComponent.EventType = ActionEventComponent.EventComponentType.MOUSE_DOWN;
                    eventComponent.SetLabelText("Mouse Up");
                    break;

                case EventComponentType.MOUSE_CLICK:
                    eventComponent.EventType = ActionEventComponent.EventComponentType.MOUSE_CLICK;
                    eventComponent.SetLabelText("Mouse Click");
                    break;

                case EventComponentType.MOUSE_MOVE:
                    eventComponent.EventType = ActionEventComponent.EventComponentType.MOUSE_MOVE;
                    eventComponent.SetLabelText("Move to ( X:" + eventComponent.ClickLocation.X.ToString("0000") + " Y:" + eventComponent.ClickLocation.Y.ToString("0000") + " )");
                    break;

                case EventComponentType.MOUSE_MOVE_CLICK:
                    eventComponent.EventType = ActionEventComponent.EventComponentType.MOUSE_MOVE_CLICK;
                    eventComponent.SetLabelText("Move to & click at ( X:" + eventComponent.ClickLocation.X.ToString("0000") + " Y:" + eventComponent.ClickLocation.Y.ToString("0000") + " )");
                    break;
            }

            m_panel.flowLayoutPanel1.Controls.Add(eventComponent);
            ActionEventComponentList.Add(eventComponent);
            FormatPanelView();
        }
    }
}
