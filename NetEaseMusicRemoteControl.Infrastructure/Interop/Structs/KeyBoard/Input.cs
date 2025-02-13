using System.Runtime.InteropServices;

namespace NetEaseMusicRemoteControl.Infrastructure.Interop.Structs.KeyBoard;

/// <summary>
/// SendInput方法参数类型
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct Input
{
    public uint type;
    public InputUnion inputUnion;
}