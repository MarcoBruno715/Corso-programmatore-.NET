
/*
Implementa codice: se la somma è inferiore alla soglia il programma chiede al giocatore di provare un altro lancio

In questo esempio, viene utilizzato un ciclo while che continua finché la somma dei dadi non supera una determinata soglia.
All'interno del ciclo, viene utilizzata la funzione Console.ReadLine() per attendere che l'utente schiacci "INVIO"
per lanciare i dadi. Dopo il lancio dei dadi, viene generata la somma dei dadi e viene verificato
se la somma è superiore alla soglia. Se la somma è maggiore della soglia, viene stampato un messaggio indicando che la somma è superiore alla soglia e il ciclo si interrompe.
Se la somma non è superiore alla soglia, viene stampato un messaggio che invita l'utente a riprovare.

*/


        int soglia = 7;

        while (true)
        {
            Console.WriteLine("Premi INVIO per lanciare i dadi...");
            Console.ReadLine();

            Random random = new Random();

            int dado1 = random.Next(1, 7);
            int dado2 = random.Next(1, 7);
            int somma = dado1 + dado2;

            Console.WriteLine("Il risultato è: " + somma);

            if (somma > soglia)
            {
                Console.WriteLine("La somma dei dadi è superiore a" + soglia);
                break;
            }
            else
            {
                Console.WriteLine("La somma dei dadi non è superiore a" + soglia);
            }
        }

