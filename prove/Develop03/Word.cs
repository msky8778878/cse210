using System;

public class Word
{
    private string _text;
    private bool _isHidden;
    private bool _easyDifficulty; // BONUS

    public Word(string text, bool easyDifficulty)
    {
        _text = text;
        _isHidden = false;
        _easyDifficulty = easyDifficulty;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (IsHidden())
        {
            string hiddenText = "";
            for (int i = 0; i < _text.Length; i++)
            {
                // BONUS START
                if (i == 0 && _easyDifficulty)
                {
                    hiddenText += _text[i];
                }
                else
                // BONUS END
                {
                    if (Char.IsLetter(_text[i]))    // if its a letter write _, ortherwise write the symbol (eg. .,;)
                        hiddenText += '_';
                    else hiddenText += _text[i];
                }
            }
            return hiddenText;
        }
        else
        {
            return _text;
        }
    }
}