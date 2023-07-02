
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 }; // dichiarazione di un array di interi di nome "numbers"

        //dichiarazione di una lista di stringhe di nome "names"
        List<string> names = new List<string>(); // List è una classe che rappresenta una lista d oggetti

        //aggiungi un elemento alla lista
        names.Add("Gio");    //Posizione 0
        names.Add("Sara");   //Posizione 1
        names.Add("Marco");   //Posizione 2

        //stampa il valore della variabile nella console con Console.WriteLine
        Console.WriteLine("the third number is" + numbers[1] + ".");
        Console.WriteLine("THe second name is" + names[2] + ".");

    }
}









