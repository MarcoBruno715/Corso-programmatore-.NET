/***************************************************************************************************************
 *           IN QUESTO ESEMPIO, SI UTILIZZA IL METODO "CONSOLE.READLINE" PER CHIEDERE ALL'UTENTE DI            *
 * INSERIRE UN NUMERO INTERO E IL METODO"INT.TRYPARSE" PER CONVERTIRE LA STRINGA DI INPUT IN UN NUMERO INTERO. *
 *                   SUCCESSIVAMENTE, SI STAMPA IL DOPPIO DEL NUMERO INSERITO NELLA CONSOLE                    *
 ***************************************************************************************************************/

// Chiedio all utende di inserire un numero intero
Console.WriteLine("Inserisci un numero intero: ");
            // 
string input = Console.ReadLine();
// viene letto l'input dell utende e viene associato ad una vairabile string
int num;

// viene dichiara una variabile di tipo booleano ed il metodo TryParse restituische un intero
bool success = int.TryParse(input, out num);

// verifica si TryParse è riuscito ad effettuare la conversione o no
if (success)
{
    // restituisce il doppio solo se il numero inserito era effetivamente un numero 
     Console.WriteLine("Il doppio del numero inserito è: " + (num * 2));
      }
       else
 {
    // altrimenti restituisce la stringa "Input non valido"
     Console.WriteLine("Input non valido!");
}
