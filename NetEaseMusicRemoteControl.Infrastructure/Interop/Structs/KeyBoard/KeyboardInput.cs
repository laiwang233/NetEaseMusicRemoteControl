using System.Runtime.InteropServices;

namespace NetEaseMusicRemoteControl.Infrastructure.Interop.Structs.KeyBoard;

/// <summary>
/// 键盘输入结构体
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct KeyboardInput(ushort keyCode, uint flag = 0)
{
    public ushort wVk = keyCode;       // 虚拟键码
    public ushort wScan;     // 扫描码
    public uint dwFlags = flag;     // 键盘按键的标志
    public uint time;        // 消息时间
    public IntPtr dwExtraInfo = IntPtr.Zero; // 附加信息
}