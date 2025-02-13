namespace NetEaseMusicRemoteControl.Infrastructure.Services.KeyboardSimulator.Interfaces;

public interface IKeyboardSimulator
{
    /// <summary>
    /// 播放/暂停
    /// </summary>
    void SendPlayPause();

    /// <summary>
    /// 上一首
    /// </summary>
    void SendPrevious();

    /// <summary>
    /// 下一首
    /// </summary>
    void SendNext();

    /// <summary>
    /// 音量加
    /// </summary>
    void SendVolumeUp();

    /// <summary>
    /// 音量减
    /// </summary>
    void SendVolumeDown();
}
