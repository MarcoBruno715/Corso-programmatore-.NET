
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 }; // dichiarazione di un array di interi di nome "numbers"
        Console.WriteLine("the sum of the numbers is" + Sum(numbers) + "."); //stampa il risultato della funzione Sum
    }
    //dichiarazione di una funzione ausiliaria che prende in input un array di interi e restituisce un intero
    static int Sum(int[] numbers)
    { //int è il tipo di dato intero è [] indica che numbers è un array
        int sum = 0; // dichiarazione di una variabile intera di nome sum e inizializzazione a 0
        foreach (int number in numbers)
        { // ciclo foreach che scorre gli elementi dell'array numbers 
            sum += number; // somma il valore di sum con il valore di number
        }

        // restituisce il valore di sum 
        return sum;
    }
}

