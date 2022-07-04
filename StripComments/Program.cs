using System.Text;

string text = "apples, pears # and bananas\n" +
              "grapes\n" +
              "bananas !apples";
string[] commentSymbols = { "#", "!" };

string textWithoutComments = StripComments(text, commentSymbols);

Console.WriteLine("Text with comments:\n" + text);
Console.WriteLine();
Console.WriteLine("Text without comments:\n" + textWithoutComments);
Console.ReadLine();

static string StripComments(string text, string[] commentSymbols)
{
    string[] strings = text.Split("\n");
    for (int i = 0; i < strings.Length; i++)
    {
        for (int j = 0; j < commentSymbols.Length; j++)
        {
            if (strings[i].Contains(commentSymbols[j]))
            {
                strings[i] = strings[i].Remove(strings[i].IndexOf(commentSymbols[j]));
            }
        }
        strings[i] = strings[i].TrimEnd();
    }
    StringBuilder sb = new(string.Empty);
    if (strings.Length == 1)
    {
        return strings[0];
    }
    for (int i = 0; i < strings.Length - 1; i++)
    {
        sb.Append(strings[i] + "\n");
    }
    sb.Append(strings[^1]);
    return sb.ToString();
}