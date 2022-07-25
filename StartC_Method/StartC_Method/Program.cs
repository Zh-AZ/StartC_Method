static string[] UserSeparator()
{
    Console.Write("Введите текст: ");
    string console = Console.ReadLine();
    string[] inputed = console.Split(' ');
    return inputed;
}

static void UserConclusion()
{
    foreach (var sub in UserSeparator())
    {
        Console.WriteLine(sub);
    }
}
UserConclusion();
Console.ReadKey();



Console.WriteLine("Введите предложение: ");
string consol = Console.ReadLine();

static string[] ReverseWord(string[] user_words)
{
    Array.Reverse(user_words);
    return user_words;
}

static string[] SplitWord(string split)
{
    var splitword = split.Split(" ");
    return splitword;
}

string[] user = ReverseWord(SplitWord(consol));
foreach (var tum in user)
{
    Console.WriteLine($"{tum}");
}
Console.ReadKey();