using System.Runtime.InteropServices;

namespace NetEaseMusicRemoteControl.Infrastructure.Interop.Structs.KeyBoard;

/// <summary>
/// 硬件输入结构体
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct HardwareInput
{
    public uint uMsg;        // 消息
    public ushort wParamL;   // 参数L
    public ushort wParamH;   // 参数H
}