
/*
Implementa il codice in classi
Il codice rappresenta un gioco in cui il giocatore e il computer lanciano i dadi, e chi ottiene il punteggio più alto vince. 
*/


/*
class Program

La classe Program contiene il metodo Main, che gestisce il flusso del gioco.
Nelle prime righe, vengono creati due oggetti Giocatore e un oggetto Dado, con un punteggio iniziale di 20. Viene inoltre creato un oggetto Random, che verrà utilizzato per generare numeri casuali.
All'interno del ciclo while, vengono lanciati i dadi per il giocatore e il computer, e le somme vengono confrontate per determinare il vincitore di ogni lancio. Se il giocatore vince,
il punteggio del computer viene sottratto dalla somma dei dadi del giocatore, mentre se il computer vince, il punteggio del giocatore viene sottratto dalla somma dei dadi del computer.
Il ciclo while continua fino a quando il punteggio del giocatore o del computer raggiunge lo zero o meno. Alla fine del gioco, viene stampato un messaggio che indica se il giocatore ha vinto o perso.
Nella classe Program non sono presenti costruttori, ma vengono invece istanziati oggetti delle classi Giocatore, Dado e Random utilizzando i loro costruttori predefiniti.

Il costruttore predefinito di una classe viene chiamato quando si crea un nuovo oggetto della classe, e inizializza i valori predefiniti per le proprietà della classe.
In questo caso, il costruttore di Giocatore inizializza il punteggio del giocatore a 20, mentre il costruttore di Dado non richiede alcun parametro, poiché ogni dado ha sei facce.
Il costruttore di Random, invece, non richiede alcun parametro e crea un nuovo oggetto Random che viene utilizzato per generare numeri casuali.
*/

class Program
    {
        static void Main(string[] args)
        {
            Giocatore giocatore = new Giocatore(20);
            Giocatore computer = new Giocatore(20);
            Dado dado = new Dado();
            Random random = new Random();

            Console.WriteLine("Il tuo punteggio: " + giocatore.Punteggio);
            Console.WriteLine("Punteggio del computer: " + computer.Punteggio);

            while (giocatore.Punteggio > 0 && computer.Punteggio > 0)
            {
                Console.WriteLine("Premi INVIO per lanciare i dadi...");
                Console.ReadLine();

                int sommaGiocatore = dado.LanciaDadi(random) + dado.LanciaDadi(random);
                int sommaComputer = dado.LanciaDadi(random) + dado.LanciaDadi(random);

                Console.WriteLine("Il tuo lancio: " + sommaGiocatore);
                Console.WriteLine("Lancio del computer: " + sommaComputer);

                if (sommaGiocatore > sommaComputer)
                {
                    Console.WriteLine("Hai vinto!");

                    computer.SottraiPunteggio(sommaGiocatore);
                }
                else if (sommaComputer > sommaGiocatore)
                {
                    Console.WriteLine("Hai perso!");

                    giocatore.SottraiPunteggio(sommaComputer);
                }
                else
                {
                    Console.WriteLine("Pareggio!");
                }
                Console.WriteLine("Il tuo punteggio: " + giocatore.Punteggio);
                Console.WriteLine("Punteggio del computer: " + computer.Punteggio);
            }
            if (giocatore.Punteggio < 0)
            {
                Console.WriteLine("Hai perso!");
            }
            else if (computer.Punteggio < 0)
            {
                Console.WriteLine("Hai vinto!");
            }
        }
    }

/*
class Giocatore
La classe Giocatore ha un solo costruttore:

public Giocatore(int punteggioIniziale)
{
    Punteggio = punteggioIniziale;
}
Il costruttore prende in input un valore intero punteggioIniziale che rappresenta il punteggio iniziale del giocatore, e lo utilizza per inizializzare la proprietà Punteggio dell'oggetto Giocatore.
Questo valore iniziale viene memorizzato all'interno dell'oggetto, e può essere successivamente modificato utilizzando il metodo SottraiPunteggio.
Il costruttore viene utilizzato quando si crea un nuovo oggetto di tipo Giocatore, passando come parametro il punteggio iniziale desiderato. Ad esempio, nella classe Program:
Giocatore giocatore = new Giocatore(20);
Giocatore computer = new Giocatore(20);
In questo modo, vengono creati due oggetti di tipo Giocatore, uno per il giocatore umano e uno per il computer, entrambi con un punteggio iniziale di 20.

*/

class Giocatore
    {
        public int Punteggio { get; private set; }
        public Giocatore(int punteggioIniziale)

        {
            Punteggio = punteggioIniziale;
        }
        public void SottraiPunteggio(int punteggioDaSottrarre)
        {
            Punteggio -= punteggioDaSottrarre;
        }
    }

/*
class Dado

La classe Dado rappresenta un dado, che può essere lanciato per generare un valore casuale compreso tra 1 e 6.
Il metodo LanciaDadi prende in input un oggetto Random che viene utilizzato per generare un valore casuale.
Utilizzando il metodo Next dell'oggetto Random, il metodo LanciaDadi genera un numero intero casuale compreso tra 1 e 7
(il valore massimo 7 viene escluso), che viene quindi restituito come risultato.
In questo modo, ogni volta che il metodo LanciaDadi viene chiamato, viene restituito un valore casuale compreso tra 1 e 6, che rappresenta il valore ottenuto dal lancio del dado.

*/

class Dado
    {
        public int LanciaDadi(Random random)
        {
            return random.Next(1, 7);
        }
    }



