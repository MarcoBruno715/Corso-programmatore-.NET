
/*
Gamification: continua il gioco fino a quando il giocatore o il computer raggiungono un punteggio sotto lo zero
In questo esempio, viene utilizzata una clausola while per continuare a giocare finché il punteggio di entrambi i giocatori è maggiore di zero.
Se uno dei due giocatori raggiunge un punteggio sotto lo zero, il gioco si interrompe. Viene verificato chi ha ottenuto la somma più alta, e il punteggio di uno dei due giocatori viene decrementato a seconda del risultato.
Viene quindi stampato il punteggio attuale dei due giocatori.
Se il punteggio di uno dei due giocatori raggiunge lo zero, viene stampato un messaggio di vittoria o sconfitta a seconda del punteggio rimanente.
In questo modo, il gioco diventa un po' più interessante e coinvolgente per l'utente, che cerca di battere il computer e mantenere il proprio punteggio al di sopra dello zero.
*/


int punteggioGiocatore = 20;
int punteggioComputer = 20;
Random random = new Random();

Console.WriteLine("Il tuo punteggio iniziale è: " + punteggioGiocatore);
Console.WriteLine("Il punteggio iniziale del computer è: " + punteggioComputer);

while (punteggioGiocatore > 0 && punteggioComputer > 0)
{
    Console.WriteLine("Premi INVIO per lanciare i dadi contro il computer...");
    Console.ReadLine();

    int dado1Giocatore = random.Next(1, 7);
    int dado2Giocatore = random.Next(1, 7);
    int sommaGiocatore = dado1Giocatore + dado2Giocatore;

    Console.WriteLine("Il risultato del tuo lancio dei dadi è: " + sommaGiocatore);

    int dado1Computer = random.Next(1, 7);
    int dado2Computer = random.Next(1, 7);
    int sommaComputer = dado1Computer + dado2Computer;

    Console.WriteLine("Il risultato del computer è: " + sommaComputer);

    if (sommaGiocatore > sommaComputer)
    {
        Console.WriteLine("Hai vinto!");

        punteggioComputer--;
    }
    else if (sommaComputer > sommaGiocatore)
    {
        Console.WriteLine("Hai perso!");

        punteggioGiocatore--;
    }
    else
    {
        Console.WriteLine("Pareggio!");
    }

    Console.WriteLine("Il tuo punteggio attuale è: " + punteggioGiocatore);
    Console.WriteLine("Il punteggio attuale del computer è: " + punteggioComputer);
}
if (punteggioGiocatore < 0)
{
    Console.WriteLine("Hai perso!");

}
else if (punteggioComputer < 0)
{
    Console.WriteLine("Hai vinto!");

}


