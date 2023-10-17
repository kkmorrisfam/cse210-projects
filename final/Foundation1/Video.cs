public class Video
{
    public string _title;
    public string _author;
    public int _length;  //seconds
    public List<Comment> _comments;

    public Video()
    {
        _comments = new List<Comment>();
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }

    
}