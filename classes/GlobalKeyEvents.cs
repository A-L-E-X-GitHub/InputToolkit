using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

class KeyboardHook
{
    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0100;

    private LowLevelKeyboardProc keyboardProc;
    private IntPtr hookId = IntPtr.Zero;

    public event EventHandler<KeyEventArgs> KeyDown;

    public KeyboardHook()
    {
        keyboardProc = KeyboardHookCallback;
        hookId = SetKeyboardHook(keyboardProc);
    }

    public void Dispose()
    {
        UnhookWindowsHookEx(hookId);
    }

    private IntPtr SetKeyboardHook(LowLevelKeyboardProc proc)
    {
        using (Process process = Process.GetCurrentProcess())
        using (ProcessModule module = process.MainModule)
        {
            return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(module.ModuleName), 0);
        }
    }

    private IntPtr KeyboardHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
        {
            int vkCode = Marshal.ReadInt32(lParam);
            KeyEventArgs args = new KeyEventArgs((Keys)vkCode);
            KeyDown?.Invoke(this, args);

            if (args.Handled)
            {
                return (IntPtr)1; // If the event is handled, prevent further processing
            }
        }

        return CallNextHookEx(hookId, nCode, wParam, lParam);
    }

    private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);
}
