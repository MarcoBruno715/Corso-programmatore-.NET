
/*
Gamification: il giocatore preme INVIO per lancia i dadi contro il computer, chi fa il lancio più alto vince
 Viene stampato il risultato del lancio dei dadi dell'utente e del computer e viene verificato chi ha ottenuto la somma più alta.
Se la somma dei dadi dell'utente è maggiore di quella del computer, viene stampato un messaggio che indica che l'utente ha vinto.
Se la somma dei dadi del computer è maggiore di quella dell'utente, viene stampato un messaggio che indica che l'utente ha perso.
Se le somme dei dadi sono uguali, viene stampato un messaggio che indica un pareggio.
*/


Console.WriteLine("Premi INVIO per lanciare i dadi contro il computer...");
Console.ReadLine();
Random random = new Random();

int dado1Giocatore = random.Next(1, 7);
int dado2Giocatore = random.Next(1, 7);
int sommaGiocatore = dado1Giocatore + dado2Giocatore;

Console.WriteLine("Il tuo lancio dei dadi è: " + sommaGiocatore);

int dado1Computer = random.Next(1, 7);
int dado2Computer = random.Next(1, 7);
int sommaComputer = dado1Computer + dado2Computer;

Console.WriteLine("Il lancio dei dadi del computer è: " + sommaComputer);

if (sommaGiocatore > sommaComputer)
{
    Console.WriteLine("Hai vinto!");
}
else if (sommaComputer > sommaGiocatore)
{
    Console.WriteLine("Hai perso!");
}
else
{
    Console.WriteLine("Pareggio!");
}

