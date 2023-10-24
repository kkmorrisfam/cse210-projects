public class Video
{
    public string _title;
    public string _author;
    public int _length;  //seconds
    public List<Comment> _comments;

    //constructor.  I set the other variables directly in the main program to show that I can
    //with this type of project.  I would probably make them private in the future and create getters and setters
    //or a constructor that set these values.
    public Video()
    {
        _comments = new List<Comment>();
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }

    
}