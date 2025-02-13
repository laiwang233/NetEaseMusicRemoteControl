using System.Runtime.InteropServices;

namespace NetEaseMusicRemoteControl.Infrastructure.Interop.Structs.KeyBoard;

[StructLayout(LayoutKind.Explicit)]
public struct InputUnion
{
    [FieldOffset(0)]
    public HardwareInput hardwareInput;
    [FieldOffset(0)]
    public KeyboardInput keyboardInput;
    [FieldOffset(0)]
    public MouseInput mouseInput;
}