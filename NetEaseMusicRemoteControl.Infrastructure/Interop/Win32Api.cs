using System.Runtime.InteropServices;
using System.Text;
using NetEaseMusicRemoteControl.Infrastructure.Interop.Structs.KeyBoard;

namespace NetEaseMusicRemoteControl.Infrastructure.Interop;

public class Win32Api
{
    
    [DllImport("user32.dll", SetLastError = true)]
    public static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int maxCount);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr FindWindow(string className, string windowName);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern int EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

    // 委托，用于回调每个窗口的句柄
    public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
}