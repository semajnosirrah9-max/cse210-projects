class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitwords = text.Split(" ");
        foreach (string word in splitwords)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.Getdisplaytext());
        Console.WriteLine();

        foreach (Word word in _words)
        {
            Console.Write(word.Getdisplaytext() + " ");
        }Console.WriteLine();
    }

    public void Hiderandomwords(int numbertohide)
    {
            for (int i = 0; i < numbertohide; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool Allwordshidden()
    {
        foreach (Word word in _words)
        {
            if (!word.Hidden())
            {
                return false;
            }
        }
        return true;
    }
}