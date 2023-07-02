

using System.IO.Compression;
Static void Main(string[] args);
{
    Console.WriteLine("inserisci una stringa: ");
    string input = Console.ReadLine();

    string reversed = reversed.RedaLine();

    Console.WriteLine("La stringa invertita è:" + reversed);

}

static string ReversedString(string str)

{
    Char[] charArray = str.ToCharArray();
    Array.Reverse(CharArray);
    return new string(charArray);
}

