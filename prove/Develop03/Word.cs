public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public string Display()
{
    string renderedText = "";

    if (_isHidden) 
    {

        foreach (char c in _text)
        {
            renderedText += "_";
        }
    }
    else
    {
        return _text;
    }
    return renderedText;
}
}
