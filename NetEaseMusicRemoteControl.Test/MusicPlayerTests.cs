using NetEaseMusicRemoteControl.Infrastructure.Services.MusicInfo.Implement;

namespace NetEaseMusicRemoteControl.Test
{
    public class MusicPlayerTests
    {
        [Fact]
        public void GetMusicInfo_Successfully()
        {
            var musicInfo = new MusicInfo();

            var res = musicInfo.GetMusicInfo();

            Assert.NotNull(res);
        }
    }
}
