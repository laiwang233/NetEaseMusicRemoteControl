using NetEaseMusicRemoteControl.Domain.MusicPlayer.Services.Interfaces;
using NetEaseMusicRemoteControl.Infrastructure.Services.KeyboardSimulator.Interfaces;

namespace NetEaseMusicRemoteControl.Application.Music.ShortcutKey;

public class PlayerControlService(IKeyboardSimulator keyboardSimulator) : IPlayerControlService
{
    public void PlayPause() => keyboardSimulator.SendPlayPause();

    public void Previous() => keyboardSimulator.SendPrevious();

    public void Next() => keyboardSimulator.SendNext();

    public void VolumeUp() => keyboardSimulator.SendVolumeUp();

    public void VolumeDown() => keyboardSimulator.SendVolumeDown();
}