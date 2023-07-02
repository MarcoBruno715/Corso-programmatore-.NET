
/*
Gamification: il giocatore ed il computer hanno un proprio punteggio iniziale di 20
In questo esempio, vengono utilizzate due variabili, punteggioGiocatore e punteggioComputer,
per tenere traccia del punteggio dei due giocatori.
Il punteggio iniziale per entrambi i giocatori è impostato a 20. Viene utilizzata la funzione Random.Next() per generare una somma per entrambi i giocatori, quindi viene verificato chi ha ottenuto la somma più alta.
Se la somma dei dadi dell'utente è maggiore di quella del computer, viene stampato un messaggio che indica che l'utente ha vinto e viene decrementato il punteggio del computer.
Se la somma dei dadi del computer è maggiore di quella dell'utente, viene stampato un messaggio che indica che l'utente ha perso e viene decrementato il punteggio dell'utente.
Se le somme dei dadi sono uguali, viene stampato un messaggio che indica un pareggio. Viene quindi stampato il punteggio
*/


        int punteggioGiocatore = 20;
        int punteggioComputer = 20;
        Random random = new Random();

        Console.WriteLine("Il tuo punteggio iniziale è: " + punteggioGiocatore);
        Console.WriteLine("Il punteggio iniziale del computer è: " + punteggioComputer);
        Console.WriteLine("Premi INVIO per lanciare i dadi contro il computer...");
        Console.ReadLine();

// indizio codice che presenta un pattern

        int dado1Giocatore = random.Next(1, 7);
        int dado2Giocatore = random.Next(1, 7);
        int sommaGiocatore = dado1Giocatore + dado2Giocatore;

        Console.WriteLine("Il risultato del tuo lancio dei dadi è: " + sommaGiocatore);

        int dado1Computer = random.Next(1, 7);
        int dado2Computer = random.Next(1, 7);
        int sommaComputer = dado1Computer + dado2Computer;

        Console.WriteLine("Il risultato del lancio dei dadi del computer è: " + sommaComputer);

        if (sommaGiocatore > sommaComputer)
        {
            Console.WriteLine("Hai vinto! La somma dei tuoi dadi è maggiore della somma dei dadi del computer.");

            punteggioComputer--;
        }
        else if (sommaComputer > sommaGiocatore)
        {
            Console.WriteLine("Hai perso! La somma dei dadi del computer è maggiore della somma dei tuoi dadi.");

            punteggioGiocatore--;
        }
        else
        {
            Console.WriteLine("Pareggio! La somma dei tuoi dadi è uguale alla somma dei dadi del computer.");
        }

        Console.WriteLine("Il tuo punteggio attuale è: " + punteggioGiocatore);
        Console.WriteLine("Il punteggio attuale del computer è: " + punteggioComputer);

