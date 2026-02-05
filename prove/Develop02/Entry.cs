using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date; {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    public void Save(StreamWriter writer)
    {
        writer.WriteLine(_date);
        writer.WriteAsync(_prompt);
        writer.WriteLine(_response);
    }
    
    public static Entry Load(StreamReader reader)
    {
        string date = reader.ReadLine();
        string prompt = reader.ReadLine();
        string response = reader.ReadLine();

        if (date == null || prompt == null || response == null)
        {
            return null;
        }

        return new Entry(date, prompt, response);
    }

    public string Getsavestring()
    {
        return $"{_date}|{_prompt}|{_response}";
    }
}