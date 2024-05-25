using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseHelper.forms
{
    public partial class FormToolkitSettings : Form
    {

        private DragManager m_dragManager;
        private FormMainWindow m_parent;

        public FormToolkitSettings(FormMainWindow parent)
        {
            InitializeComponent();
            m_dragManager = new DragManager(this);
            m_parent = parent;

            // Loading current values.
            object[] settings = m_parent.LoadApplicationSetting();
            checkBoxCursorToOrigin.Checked = (bool)settings[0];
            textBoxDefaultDelay.Text     = ((int)settings[1]).ToString();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(135, 135, 135), ButtonBorderStyle.Solid);
        }

        #region Button Function(s)
        private void OnButtonPressed_Close(object sender, EventArgs e) => this.Close();
        #endregion

        #region Dragging Function(s)
        private void OnDrag_MouseDown(object sender, MouseEventArgs e) => m_dragManager.MouseDown(sender, e);
        private void OnDrag_MouseMove(object sender, MouseEventArgs e) => m_dragManager.MouseMove(sender, e);
        private void OnDrag_MouseUp(object sender, MouseEventArgs e) => m_dragManager.MouseUp(sender, e);
        #endregion

        private void OnButtonPressed_SaveSettings(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDefaultDelay.Text, out int nDelayDuration))
            {
                MessageBox.Show("The delay duration is invalid. Value has to be a number and 0 or above.", "Error", MessageBoxButtons.OK);
                return;
            }

            m_parent.UpdateApplicationSettings(nDelayDuration, checkBoxCursorToOrigin.Checked);
            this.Close();
        }

        private void OnButtonPressed_ResetSettings(object sender, EventArgs e)
        {
            checkBoxCursorToOrigin.Checked = false;
            textBoxDefaultDelay.Text = "100";

            m_parent.m_bSettingReturnCursor = false;
            m_parent.m_nSettingDelay = 100;
        }
    }
}
