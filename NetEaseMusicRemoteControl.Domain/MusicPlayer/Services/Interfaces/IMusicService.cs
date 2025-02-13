using NetEaseMusicRemoteControl.Domain.MusicPlayer.Entities;

namespace NetEaseMusicRemoteControl.Domain.MusicPlayer.Services.Interfaces;

public interface IMusicService
{
    MusicInformation GetMusicInfo();
}