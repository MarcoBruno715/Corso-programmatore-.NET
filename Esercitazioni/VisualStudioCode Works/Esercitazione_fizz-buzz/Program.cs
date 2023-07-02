/***************************************************************************************************
 *    IN QUESTO ESEMPIO, SI UTILIZZA UN CICLO "DO WHILE" PER CHIEDERE ALL'UTENTE DI INSERIRE UN    *
 *                                  NUMERO COMPRESO TRA 1 E 100.                                   *
 * SUCCESSIVAMENTE, SI UTILIZZA UNA SERIE DI ISTRUZIONI "IF" PER CONTROLLARE SE IL NUMERO INSERITO *
 * È DIVISIBILE PER 3, PER 5 O PER ENTRAMBI E SI STAMPA IL RISULTATO CORRISPONDENTE NELLA CONSOLE. *
 *  VERIFICARE CHE IL PROGRAMMA RICHIEDA L'INSERIMENTO DI UN NUMERO COMPRESO TRA 1 E 100 E STAMPI  *
 *                             "FIZZ" SE IL NUMERO È DIVISIBILE PER 3,                             *
 *                             "BUZZ" SE IL NUMERO È DIVISIBILE PER 5,                             *
 *                    "FIZZBUZZ" SE IL NUMERO È DIVISIBILE SIA PER 3 CHE PER 5,                    *
 *                  OPPURE IL NUMERO STESSO SE NON È DIVISIBILE NÉ PER 3 NÉ PER 5                  *
 ***************************************************************************************************/


    int numero; // dichiara una variabile di tipo intero

    do // esegue il ciclo almeno una volta il do while serve per fare un ciclo che si ripete finché non si inserisce un numero compreso tra 1 e 100
    {
        Console.Write("Inserisci un numero tra 1 e 100: ");
        string input = Console.ReadLine();
        bool success = int.TryParse(input, out numero);// success è una variabile booleana che indica se la conversione è andata a buon fine

        if (!success || numero < 1 || numero > 100) // verifica che l'input sia un numero intero compreso tra 1 e 100
        {
            Console.WriteLine("Input non valido!");
        }
    } while (numero < 1 || numero > 100); // ripete il ciclo finché l'input non è un numero intero compreso tra 1 e 100

    if (numero % 3 == 0 && numero % 5 == 0) // verifica se il numero è divisibile sia per 3 che per 5
    {
        Console.WriteLine("FizzBuzz"); // stampa "FizzBuzz" se il numero è divisibile sia per 3 che per 5
    }
    else if (numero % 3 == 0) // verifica se il numero è divisibile per 3
    {
        Console.WriteLine("Fizz"); // stampa "Fizz" se il numero è divisibile per 3
    }
    else if (numero % 5 == 0) // 
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(numero);
    }
