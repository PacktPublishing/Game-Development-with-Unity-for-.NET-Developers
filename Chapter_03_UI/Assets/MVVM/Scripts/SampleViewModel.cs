using Loxodon.Framework.ViewModels;

public class SampleViewModel : ViewModelBase
{
    private string _message;
    private int _count;

    public SampleViewModel() { }

    public string Message
    {
        get { return _message; }
        set => Set<string>(ref _message, value, "Message");
    }

    public void Submit()
    {
        _count++;
        Message = $"The number of times the button is clicked: {_count}";
    }
}