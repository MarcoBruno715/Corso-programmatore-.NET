class Programm
{

    static void Main(string[] args)
    { // metodo principale del programma
        for (int i = 1; i <= 100; i++)
        {// ciclo for che va da 1 a 10
            if (i % 2 == 0)
            { // se i è pari il % è il resto della divisione quindi verifica se i è divisibile per 2
                Console.WriteLine(i + " is even."); // stampa il numero e la stringa is even 

            }
            else
            {
                Console.WriteLine(i + " is odd."); // stampa il numero è la string is odd
            }
        }
    }
}
//va da 1 a 10 , per verificare se è pari 