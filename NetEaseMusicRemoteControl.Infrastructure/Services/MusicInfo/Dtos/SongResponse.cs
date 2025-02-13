namespace NetEaseMusicRemoteControl.Infrastructure.Services.MusicInfo.Dtos;

public class SongResponse
{
    public int Code { get; set; }
    public SongResult Result { get; set; }
}

public class SongResult
{
    public int SongCount { get; set; }
    public List<Song> Songs { get; set; }
}

public class Song
{
    public Album Album { get; set; }
    public int Status { get; set; }
    public int CopyrightId { get; set; }
    public string Name { get; set; }
    public int Mvid { get; set; }
    public List<string> Alias { get; set; }
    public List<Artist> Artists { get; set; }
    public int Duration { get; set; }
    public int Id { get; set; }
}

public class Album
{
    public int Status { get; set; }
    public int CopyrightId { get; set; }
    public string Name { get; set; }
    public Artist Artist { get; set; }
    public long PublishTime { get; set; }
    public int Id { get; set; }
    public int Size { get; set; }
}

public class Artist
{
    public List<string> Alias { get; set; }
    public string PicUrl { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
}
