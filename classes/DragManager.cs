using System.Drawing;
using System.Windows.Forms;


namespace MouseHelper
{
    public class DragManager
    {
        private Form m_form;
        private Point m_location;
        private DragState m_state;

        private enum DragState
        {
            IDLE,
            DRAGGING
        }

        #region Constructor(s)
        public DragManager(Form form) => m_form = form;
        #endregion

        #region Mouse Function(s)
        public void MouseDown(object sender, MouseEventArgs e)
        {
            // Ensures valid conditions are met.
            if (e.Button != MouseButtons.Left) return;

            // Update the drag state and store the cursor start location.
            m_state    = DragState.DRAGGING;
            m_location = e.Location;
        }
        public void MouseMove(object sender, MouseEventArgs e)
        {
            // Ensures valid conditions are met.
            if (m_state != DragState.DRAGGING) return;

            //
            Point location  = m_form.PointToScreen(e.Location);
            Point offset    = new Point(location.X - m_location.X, location.Y - m_location.Y);
            m_form.Location = offset;
        }
        public void MouseUp(object sender, MouseEventArgs e)
        {
            // Ensures valid conditions are met.
            if (m_state != DragState.DRAGGING) return;

            // Update the drag state.
            m_state = DragState.IDLE;
        }
        #endregion
    }
}
