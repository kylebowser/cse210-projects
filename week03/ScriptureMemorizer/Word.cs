using System;

class Word
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
        string hidden = "";
        for (int i = 0; i < _text.Length; i++)
        {
            hidden += "_";
        }

        _text = hidden;
        _isHidden = true;
    }

    public void Show()
    {

    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDispalyText()
    {
        return _text;
    }
}