using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference ScriptureReference { get; private set; }
    private List<Word> Words;
    private Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        ScriptureReference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsFullyHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public string GetScriptureWithHints()
    {
        return $"{ScriptureReference}\n{string.Join(" ", Words.Select(word => word.GetHint()))}";
    }

    public override string ToString()
    {
        return $"{ScriptureReference}\n{string.Join(" ", Words)}";
    }
}


