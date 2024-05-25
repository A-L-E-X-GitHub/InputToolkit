using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GlobalMouseEvents
{
    private const int WH_MOUSE_LL    = 14;
    private const int WM_LBUTTONDOWN = 0x0201;
    private const int WM_LBUTTONUP   = 0x0202;
    private const int WM_RBUTTONDOWN = 0x0204;
    //private const int WM_MOUSEWHEEL  = 0x020A;

    private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

    private LowLevelMouseProc mouseProc;
    private IntPtr mouseHookHandle;

    public event EventHandler<MouseEventArgs> MouseDown;
    public event EventHandler<MouseEventArgs> MouseUp;
    //public event EventHandler<MouseEventArgs> MouseWheel;

    public GlobalMouseEvents()
    {
        mouseProc = HookCallback;
    }

    public void Start()
    {
        mouseHookHandle = SetHook(mouseProc);
    }

    public void Stop()
    {
        UnhookWindowsHookEx(mouseHookHandle);
    }

    private IntPtr SetHook(LowLevelMouseProc proc)
    {
        using (Process curProcess = Process.GetCurrentProcess())
        using (ProcessModule curModule = curProcess.MainModule)
        {
            return SetWindowsHookEx(WH_MOUSE_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
        }
    }

    private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0)
        {
            if (wParam == (IntPtr)WM_LBUTTONDOWN || wParam == (IntPtr)WM_RBUTTONDOWN)
            {
                int xPos = lParam.ToInt32() & 0xFFFF;
                int yPos = (lParam.ToInt32() >> 16) & 0xFFFF;

                MouseEventArgs args = new MouseEventArgs(MouseButtons.Left, 1, xPos, yPos, 0);
                MouseDown?.Invoke(this, args);
                return new IntPtr(1);
            }

            else if (wParam == (IntPtr)WM_LBUTTONUP)
            {
                int xPos = lParam.ToInt32() & 0xFFFF;
                int yPos = (lParam.ToInt32() >> 16) & 0xFFFF;

                MouseEventArgs args = new MouseEventArgs(MouseButtons.Left, 1, xPos, yPos, 0);
                MouseUp?.Invoke(this, args);
                return new IntPtr(1);
            }
            //else if (wParam == (IntPtr)WM_MOUSEWHEEL)
            //{
            //    int delta = (int)(lParam.ToInt64() >> 16) / 120;

            //    MouseWheel?.Invoke(this, new MouseEventArgs(MouseButtons.None, 0, 0, 0, delta));
            //}
        }

        return CallNextHookEx(mouseHookHandle, nCode, wParam, lParam);
    }

    #region Windows API Functions

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    #endregion
}
