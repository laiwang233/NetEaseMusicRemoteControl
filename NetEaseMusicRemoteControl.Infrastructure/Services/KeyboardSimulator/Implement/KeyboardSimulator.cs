using System.Runtime.InteropServices;
using NetEaseMusicRemoteControl.Domain.MusicPlayer.Enums;
using NetEaseMusicRemoteControl.Infrastructure.Interop;
using NetEaseMusicRemoteControl.Infrastructure.Interop.Structs.KeyBoard;
using NetEaseMusicRemoteControl.Infrastructure.Services.KeyboardSimulator.Interfaces;

namespace NetEaseMusicRemoteControl.Infrastructure.Services.KeyboardSimulator.Implement;

public class KeyboardSimulator : IKeyboardSimulator
{
    public void SendPlayPause() => SimulateKeyPress(ShortcutKeyTypeEnum.PlayPause);

    public void SendPrevious() => SimulateKeyPress(ShortcutKeyTypeEnum.Previous);

    public void SendNext() => SimulateKeyPress(ShortcutKeyTypeEnum.Next);

    public void SendVolumeUp() => SimulateKeyPress(ShortcutKeyTypeEnum.VolumeUp);

    public void SendVolumeDown() => SimulateKeyPress(ShortcutKeyTypeEnum.VolumeDown);

    private Input CreateKeyboardInput(ushort keyCode, bool isKeyUp = false) => new()
    {
        type = 1,
        inputUnion = new InputUnion
        {
            keyboardInput = new KeyboardInput(keyCode, (uint)(isKeyUp ? 0x02 : 0x00))
        }
    };

    private void SimulateKeyPress(ShortcutKeyTypeEnum shortcutKeyTypeEnum)
    {
        var keyDic = new Dictionary<ShortcutKeyTypeEnum, List<ushort>>()
        {
            //播放/暂停
            { ShortcutKeyTypeEnum.PlayPause, [VirtualKeys.VK_CONTROL, VirtualKeys.VK_MENU, VirtualKeys.VK_P] },

            //上一首
            { ShortcutKeyTypeEnum.Previous, [VirtualKeys.VK_CONTROL, VirtualKeys.VK_MENU, VirtualKeys.VK_LEFT] },

            //下一首
            { ShortcutKeyTypeEnum.Next, [VirtualKeys.VK_CONTROL, VirtualKeys.VK_MENU, VirtualKeys.VK_RIGHT] },

            //音量加
            { ShortcutKeyTypeEnum.VolumeUp, [VirtualKeys.VK_CONTROL, VirtualKeys.VK_MENU, VirtualKeys.VK_UP] },

            //音量减
            { ShortcutKeyTypeEnum.VolumeDown, [VirtualKeys.VK_CONTROL, VirtualKeys.VK_MENU, VirtualKeys.VK_DOWN] }
        };

        keyDic.TryGetValue(shortcutKeyTypeEnum, out var keys);

        if (keys is null) throw new Exception("找不到快捷键组");

        var keyList = keys
            .Select(s => CreateKeyboardInput(s))
            .ToList();

        keys.Reverse();
        keyList.AddRange(keys.Select(s => CreateKeyboardInput(s, true)));

        var res = keyList.ToArray();

        Win32Api.SendInput((uint)res.Length, res, Marshal.SizeOf<Input>());
    }
}