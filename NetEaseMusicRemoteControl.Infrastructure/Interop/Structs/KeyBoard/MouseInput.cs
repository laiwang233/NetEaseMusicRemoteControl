using System.Runtime.InteropServices;

namespace NetEaseMusicRemoteControl.Infrastructure.Interop.Structs.KeyBoard;

/// <summary>
/// 鼠标输入结构体
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct MouseInput
{
    public int dx;           // 鼠标的水平移动距离
    public int dy;           // 鼠标的垂直移动距离
    public uint mouseData;   // 鼠标滚轮的变化数据
    public uint dwFlags;     // 鼠标事件的标志
    public uint time;        // 消息时间
    public IntPtr extraInfo; // 附加信息
}