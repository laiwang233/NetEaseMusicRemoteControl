using System.Diagnostics;
using NetEaseMusicRemoteControl.Domain.MusicPlayer.Entities;
using NetEaseMusicRemoteControl.Infrastructure.Services.MusicInfo.Interface;

namespace NetEaseMusicRemoteControl.Infrastructure.Services.MusicInfo.Implement;

public class MusicInfo : IMusicInfo
{
    public MusicInformation GetMusicInfo()
    {
        // 通过进程名查找进程
        var process = Process.GetProcessesByName("cloudmusic").FirstOrDefault(s => s.MainWindowHandle != IntPtr.Zero);

        if (process == null) throw new Exception("未找到进程!!!!!!!!!!!!!!!!");

        var nameAndSingers = process.MainWindowTitle.Split(" - ");
        if (nameAndSingers.Length != 2) throw new Exception("歌名歌手分割失败！");
        var singerList = nameAndSingers[1].Split("/");

        /*var encodedName = Uri.EscapeDataString(nameAndSingers[0]);
        var response = await new HttpClient().GetAsync($"https://music.163.com/api/search/get?s={encodedName}&type=1");
        var content = await response.Content.ReadAsStringAsync();

        var musicData = JsonSerializer.Deserialize<SongResponse>(content, new JsonSerializerOptions
        {
            // 允许JSON属性名与C#属性名大小写不敏感
            PropertyNameCaseInsensitive = true
        });*/

        return new MusicInformation(nameAndSingers[0], singerList, null, null);
    }
}