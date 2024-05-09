using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(bool easyDifficulty, Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string oneWord in words)
        {
            Word newWord = new Word(oneWord, easyDifficulty);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int randomNumber = random.Next(0, _words.Count());
            _words[randomNumber].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";

        for (int i = 0; i < _words.Count(); i++)
        {
            text += _words[i].GetDisplayText();
            text += " ";
        }

        return text;
    }

    public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count(); i++)
        {
            if (!_words[i].IsHidden())  // if it finds at least one word that isnt hidden
            {
                return false;
            }
        }
        // if it didnt find any non hidden words
        return true;
    }
}