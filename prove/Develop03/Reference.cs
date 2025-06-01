public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseEnd = -1;
    }

    public Reference(string book, int chapter, int verse, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseEnd = verseEnd;
    }

    public string GetDisplayText()
    {
        if (_verseEnd == -1)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
    }
}

