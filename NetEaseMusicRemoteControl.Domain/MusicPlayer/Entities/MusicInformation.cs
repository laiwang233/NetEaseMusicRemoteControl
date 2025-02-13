namespace NetEaseMusicRemoteControl.Domain.MusicPlayer.Entities;

/// <summary>
/// 音乐信息
/// </summary>
public class MusicInformation(string name, IEnumerable<string> singers, string album, string albumCover)
{
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// 歌名
    /// </summary>
    public string Name { get; set; } = name;

    /// <summary>
    /// 歌手
    /// </summary>
    public IEnumerable<string> Singers { get; set; } = singers;

    /// <summary>
    /// 专辑名
    /// </summary>
    public string Album { get; set; } = album;

    /// <summary>
    /// 专辑封面
    /// </summary>
    public string AlbumCover { get; set; } = albumCover;
}