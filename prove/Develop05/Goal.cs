public class Goal {
    private string _name;
    private string _status;
    private int _points;
    private List<string> _goals;
    private string _description;

    public string DisplayStatus()
    {
        return _status;
    }

    public virtual void RecordEvent()
    {

    }
}