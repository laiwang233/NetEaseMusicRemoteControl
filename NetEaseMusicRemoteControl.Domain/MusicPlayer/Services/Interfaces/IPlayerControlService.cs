namespace NetEaseMusicRemoteControl.Domain.MusicPlayer.Services.Interfaces;

public interface IPlayerControlService
{
    /// <summary>
    /// 播放/暂停
    /// </summary>
    void PlayPause();

    /// <summary>
    /// 上一首
    /// </summary>
    void Previous();

    /// <summary>
    /// 下一首
    /// </summary>
    void Next();

    /// <summary>
    /// 音量加
    /// </summary>
    void VolumeUp();

    /// <summary>
    /// 音量减
    /// </summary>
    void VolumeDown();
}