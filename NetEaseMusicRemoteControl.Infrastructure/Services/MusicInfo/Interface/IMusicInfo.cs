using NetEaseMusicRemoteControl.Domain.MusicPlayer.Entities;

namespace NetEaseMusicRemoteControl.Infrastructure.Services.MusicInfo.Interface;

public interface IMusicInfo
{
    MusicInformation GetMusicInfo();
}