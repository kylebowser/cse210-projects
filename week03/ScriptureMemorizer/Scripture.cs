using System;

class Scripture
{
    private Reference _reference;
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        foreach (string word in text.Split(' '))
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Random random = new Random();
            int randomNum = random.Next(0, _words.Count);

            if (!_words[randomNum].isHidden())
            {
                _words[randomNum].Hide();
            }
            else if (IsCompletelyHidden())
            {
                break;
            }
            else
            {
                i--;
            }
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDispalyText();
    
        foreach (Word word in _words)
        {

            text += " ";
            text += word.GetDispalyText();
    
        }

        return text;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.isHidden() == false)
            {
                return false;
            }
        }
        return true;
    }



}