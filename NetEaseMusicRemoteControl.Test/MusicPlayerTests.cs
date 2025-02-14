using Moq;
using NetEaseMusicRemoteControl.Domain.MusicPlayer.Entities;
using NetEaseMusicRemoteControl.Infrastructure.Services.MusicInfo.Interface;

namespace NetEaseMusicRemoteControl.Test
{
    public class MusicPlayerTests
    {
        [Fact]
        public void GetMusicInfo_Successfully()
        {
            var musicInfo = new Mock<IMusicInfo>();
            musicInfo
                .Setup(s => s.GetMusicInfo())
                .Returns(new MusicInformation("TestMusicName", ["TestSinger"], "TestAlbum", "TestAlbumCover.png"));

            var res = musicInfo.Object.GetMusicInfo();

            Assert.NotNull(res);
        }
    }
}
