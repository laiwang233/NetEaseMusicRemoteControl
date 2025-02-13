using Microsoft.AspNetCore.Mvc;
using NetEaseMusicRemoteControl.Domain.MusicPlayer.Entities;
using NetEaseMusicRemoteControl.Domain.MusicPlayer.Services.Interfaces;

namespace NetEaseMusicRemoteControl.Host.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class MusicPlayerController(IPlayerControlService playerControlService, IMusicService musicService) : ControllerBase
    {
        /// <summary>
        /// 播放/暂停
        /// </summary>
        [HttpPost]
        public void PlayPause() => playerControlService.PlayPause();

        /// <summary>
        /// 上一首
        /// </summary>
        [HttpPost]
        public void Previous() => playerControlService.Previous();

        /// <summary>
        /// 下一首
        /// </summary>
        [HttpPost]
        public void Next() => playerControlService.Next();

        /// <summary>
        /// 音量加
        /// </summary>
        [HttpPost]
        public void VolumeUp() => playerControlService.VolumeUp();

        /// <summary>
        /// 音量减
        /// </summary>
        [HttpPost]
        public void VolumeDown() => playerControlService.VolumeDown();

        /// <summary>
        /// 获取当前播放音乐信息
        /// </summary>
        [HttpGet]
        public MusicInformation GetMusicInfo() => musicService.GetMusicInfo();
    }
}
