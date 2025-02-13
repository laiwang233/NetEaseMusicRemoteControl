using NetEaseMusicRemoteControl.Domain.MusicPlayer.Entities;
using NetEaseMusicRemoteControl.Domain.MusicPlayer.Services.Interfaces;
using NetEaseMusicRemoteControl.Infrastructure.Services.MusicInfo.Interface;

namespace NetEaseMusicRemoteControl.Application.Music;

public class MusicService(IMusicInfo musicInfo) : IMusicService
{
    public MusicInformation GetMusicInfo() => musicInfo.GetMusicInfo();
}