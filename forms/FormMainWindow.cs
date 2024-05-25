using MouseHelper.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseHelper
{
    public partial class FormMainWindow : Form
    {
        // Application variables.
        private const uint          MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint          MOUSEEVENTF_LEFTUP   = 0x0004;

        private GlobalMouseEvents   m_gMouseEvents       = new GlobalMouseEvents();
        private KeyboardHook        m_gKeyEvents         = new KeyboardHook();

        private bool                m_timerState         = false;
        private bool                m_trackCursor        = false;
        public ProgramState         m_programState       = ProgramState.IDLE;

        // Application managers.
        private DragManager         m_dragManager;

        // Application setting parameters.
        public int                 m_nSettingDelay         = 100;
        public bool                m_bSettingReturnCursor  = false;
        public Point               m_ReturnCursorLocation  = new Point();
        public bool                m_SetNewScriptRunKey    = false;
        public Keys                m_ScriptRunKey          = Keys.F1;

        // Other


        public enum ProgramState
        {
            IDLE,
            RUNNING,
            PAUSED,
            STOPPING
        }
        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }


        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);


        public FormMainWindow()
        {
            InitializeComponent();
            m_gMouseEvents.MouseDown += GlobalMouseEvents_MouseDown;
            m_gKeyEvents.KeyDown     += OnButtonPressed_QuickRunScriptKey;
            m_dragManager             = new DragManager(this);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(135, 135, 135), ButtonBorderStyle.Solid);
        }

        #region Mouse Function(s)
        private void GlobalMouseEvents_MouseDown(object sender, MouseEventArgs e)
        {
            //this.Cursor = new Cursor(Cursor.Current.Handle);
            //m_nCursorPositionX = Cursor.Position.X;
            //m_nCursorPositionY = Cursor.Position.Y;
            m_gMouseEvents.Stop();
        }
        private void ButtonTrackMousePosition(object sender, EventArgs e)
        {
            m_gMouseEvents.Start();

            // Toggle the global application timer.
            m_timerState = !m_timerState;
            if (m_timerState)
                timer.Start();
            else
                timer.Stop();

        }
        #endregion

        #region Simulated Mouse Function(s)
        private static void MOUSE_ACTION(uint mouseEventFlag)
        {
            uint dx = (uint)Cursor.Position.X;
            uint dy = (uint)Cursor.Position.Y;

            mouse_event(mouseEventFlag, dx, dy, 0, 0);
        }
        private static void MOUSE_DOWN()
        {
            MOUSE_ACTION(MOUSEEVENTF_LEFTDOWN);
        }
        private static void MOUSE_UP()
        { 
            MOUSE_ACTION(MOUSEEVENTF_LEFTUP); 
        }
        private async static void MOUSE_CLICK()
        {
            MOUSE_ACTION(MOUSEEVENTF_LEFTDOWN);
            await Task.Delay(25);
            MOUSE_ACTION(MOUSEEVENTF_LEFTUP);
        }
        private static void MOUSE_MOVE(Point location)
        { 
            Cursor.Position = location;
        }
        private async static void MOUSE_MOVE_CLICK(Point location)
        {
            Cursor.Position = location;
            await Task.Delay(50);
            MOUSE_CLICK();
        }
        #endregion

        #region Button Function(s)
        private void        OnButtonPressed_QuickRunScriptKey(object sender, KeyEventArgs e)
        {
            if (m_SetNewScriptRunKey)
            {
                m_ScriptRunKey = e.KeyCode;
                m_SetNewScriptRunKey = false;
                buttonRunScript.Text = "Run ( " + e.KeyCode.ToString() + " )";
                this.panelHeader.Focus();
                return;
            }

            // Handle events related to quick starting a script.
            if (e.KeyCode == m_ScriptRunKey)
            {
                e.Handled = true;
                RunScript();
            }
        }
        private void        OnButtonPressed_CloseApplication(object sender, EventArgs e)
        {
            this.Close();
        }
        private void        OnButtonPressed_SetScriptKey(object sender, EventArgs e)
        {
            m_SetNewScriptRunKey = true;
        }
        private void        OnButtonPressed_OpenSettings(object sender, EventArgs e)
        {
            FormToolkitSettings settings = new FormToolkitSettings(this);
            settings.ShowDialog();
        }
        public void UpdateApplicationSettings(int nDefaultDelay, bool bReturnToOrigin)
        {
            m_nSettingDelay        = nDefaultDelay;
            m_bSettingReturnCursor = bReturnToOrigin;
        }
        public object[] LoadApplicationSetting()
        {
            object[] objects = new object[2];
            objects[0] = m_bSettingReturnCursor;
            objects[1] = m_nSettingDelay;
            return objects;
        }
        private async void  RunScript()
        {
            if (m_programState == ProgramState.STOPPING) return;
            if (m_programState == ProgramState.RUNNING) { m_programState = ProgramState.STOPPING; return; }

            if (m_programState == ProgramState.IDLE)
            {
                ToggleComponentInputState();
                buttonRunScript.Text = "Stop ( " + m_ScriptRunKey.ToString() + " )";
                m_programState = ProgramState.RUNNING;

                if (m_bSettingReturnCursor)
                    m_ReturnCursorLocation = Cursor.Position;

                foreach (ActionEventComponent comp in actionEventPanel1.ActionEventComponentList)
                {
                    if (m_programState == ProgramState.RUNNING)
                    {
                        // Set the handle of the color of the currently parsed event.
                        //comp.SetHandleColor(Color.Green);
                        comp.ToggleActive();

                        switch (comp.EventType)
                        {
                            case ActionEventComponent.EventComponentType.MOUSE_DOWN:
                                MOUSE_DOWN();
                                break;

                            case ActionEventComponent.EventComponentType.MOUSE_UP:
                                MOUSE_UP();
                                break;

                            case ActionEventComponent.EventComponentType.MOUSE_CLICK:
                                MOUSE_CLICK();
                                break;

                            case ActionEventComponent.EventComponentType.MOUSE_MOVE:
                                MOUSE_MOVE(comp.ClickLocation);
                                break;

                            case ActionEventComponent.EventComponentType.MOUSE_MOVE_CLICK:
                                MOUSE_MOVE_CLICK(comp.ClickLocation);
                                break;
                        }



                        // Wait for the determined time and adjust the handle color to the default value.
                        int delay = comp.Value > m_nSettingDelay ? comp.Value : m_nSettingDelay;
                        await Task.Delay(delay);
                        comp.ToggleActive();
                    }
                    else
                    {
                        if (m_bSettingReturnCursor)
                            Cursor.Position = m_ReturnCursorLocation;

                        m_programState = ProgramState.STOPPING;
                        comp.StopActive();
                        buttonRunScript.Text = "Stopping";
                        buttonRunScript.Enabled = false;

                        await Task.Delay(1500);

                        m_programState = ProgramState.IDLE;
                        comp.Reset();
                        ToggleComponentInputState();
                        buttonRunScript.Text = "Run ( " + m_ScriptRunKey.ToString() + " )";
                        buttonRunScript.Enabled = true;

                        return;
                    }
                }

                m_programState = ProgramState.IDLE;
                ToggleComponentInputState();
                buttonRunScript.Text = "Run ( " + m_ScriptRunKey.ToString() + " )";
                actionEventPanel1.BlockInput = false;

                if (m_bSettingReturnCursor)
                    Cursor.Position = m_ReturnCursorLocation;

            }
        }

        private void ToggleComponentInputState()
        {
            foreach (ActionEventComponent comp in actionEventPanel1.ActionEventComponentList)
                comp.BlockInput = !comp.BlockInput;
        }

        private void  OnButtonPressed_RunScript(object sender, EventArgs e)
        {
            RunScript();
        }
        private async void  OnButtonPressed_TrackCursor(object sender, EventArgs e)
        {
            m_trackCursor = !m_trackCursor;
            Point location = new Point(0, 0);

            while (m_trackCursor)
            {
                if (Cursor.Position != location)
                {
                    location = Cursor.Position;
                    buttonTrackCursor.Text = "X:" + location.X.ToString("0000") + " Y:" + location.Y.ToString("0000");
                }
                await Task.Delay(125);
            }
        }
        #endregion

        #region Dragging Function(s)
        private void OnDrag_MouseDown(object sender, MouseEventArgs e) => m_dragManager.MouseDown(sender, e);
        private void OnDrag_MouseMove(object sender, MouseEventArgs e) => m_dragManager.MouseMove(sender, e);
        private void OnDrag_MouseUp(object sender, MouseEventArgs e) => m_dragManager.MouseUp(sender, e);
        #endregion
    }
}
