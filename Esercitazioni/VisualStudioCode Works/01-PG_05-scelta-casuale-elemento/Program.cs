/***********************************************************************************************************************
 * creare una lista e inserire i nomi dei compagni del corso di informatica:                                           *
 ***********************************************************************************************************************/

// le liste sono una collezione di elementi di un certo tipo
// le liste sono molto utili quando si hanno molti elementi dello stesso tipo
// le liste sono molto utili quando si devono aggiungere o rimuovere elementi
// le liste sono molto utili quando si devono riordinare gli elementi
// le liste sono molto utili quando si devono scegliere elementi a caso

// List è una classe che contiene una serie di elementi
// string è il tipo di dato che contiene la lista
// compagniDiCorso è il nome della lista
// new List<string>() è un costruttore della classe List che crea una nuova lista di stringhe
// () indica che il costruttore non ha parametri
// List<string> compagniDiCorso = new List<string>(); è una dichiarazione di una variabile di tipo List<string>

// Crea una nuova lista di stringhe
List<string> compagniDiCorso = new List<string>();


//aggiungi i nomi dei compagni alla lista
compagniDiCorso.Add("Josen");
compagniDiCorso.Add("Arianna");
compagniDiCorso.Add("Arash");
compagniDiCorso.Add("Andrea");
compagniDiCorso.Add("Vittorio");
compagniDiCorso.Add("Giorgio");
compagniDiCorso.Add("Marco");
compagniDiCorso.Add("Jesmina");
compagniDiCorso.Add("Davide");
compagniDiCorso.Add("Daniele");

// Stampa i nomi dei compagni nella console
Console.WriteLine("I nomi dei compagni di corso sono:");
foreach (string compagno in compagniDiCorso)    // foreach è un ciclo che scorre tutti gli elementi della lista
{
    Console.WriteLine(compagno);
}

// Attesa per l'input dell'utente prima di chiudere la finestra della console
Console.WriteLine("Premi un tasto per continuare...");
Console.ReadKey();

/***********************************************************************************************************************
 * per riordinare i nomi dei compagni del corso di informatica:                                                        *
 ***********************************************************************************************************************/

// Crea una nuova lista di stringhe e aggiungi i nomi dei compagni
List<string> compagniDiCorso = new List<string> { "Luca", "Simone", "Federica", "Alessandra", "Giulia", "Marco" };

// Riordina i nomi dei compagni in ordine alfabetico
compagniDiCorso.Sort(); // Sort è un metodo della classe List

// Stampa i nomi dei compagni riordinati nella console
Console.WriteLine("I nomi dei compagni di corso riordinati in ordine alfabetico sono:");
foreach (string compagno in compagniDiCorso)
{
    Console.WriteLine(compagno);
}

// Attesa per l'input dell'utente prima di chiudere la finestra della console
Console.WriteLine("Premi un tasto per continuare...");
Console.ReadKey();

/***********************************************************************************************************************
 * per rimuovere un nome specifico dalla lista dei compagni del corso di informatica:                                  *
 ***********************************************************************************************************************/

// Crea una nuova lista di stringhe e aggiungi i nomi dei compagni
List<string> compagniDiCorso = new List<string> { "Luca", "Simone", "Federica", "Alessandra", "Giulia", "Marco" };

// Rimuovi il nome di un compagno specifico dalla lista
compagniDiCorso.Remove("Simone");   // Remove è un metodo della classe List

// Stampa i nomi dei compagni nella console dopo la rimozione
Console.WriteLine("I nomi dei compagni di corso dopo la rimozione di Simone sono:");
foreach (string compagno in compagniDiCorso)
{
    Console.WriteLine(compagno);
}

// Attesa per l'input dell'utente prima di chiudere la finestra della console
Console.WriteLine("Premi un tasto per continuare...");
Console.ReadKey();

/***********************************************************************************************************************
 * per rimuovere più nomi specifici dalla lista dei compagni del corso di informatica:                                 *
 ***********************************************************************************************************************/

// Crea una nuova lista di stringhe e aggiungi i nomi dei compagni
List<string> compagniDiCorso = new List<string> { "Luca", "Simone", "Federica", "Alessandra", "Giulia", "Marco" };

// Rimuovi i nomi di più compagni specifici dalla lista
compagniDiCorso.RemoveAll(nome => nome == "Simone" || nome == "Giulia");    // RemoveAll è un metodo della classe List

// Stampa i nomi dei compagni nella console dopo la rimozione
Console.WriteLine("I nomi dei compagni di corso dopo la rimozione di Simone e Giulia sono:");
foreach (string compagno in compagniDiCorso)
{
    Console.WriteLine(compagno);
}

// Attesa per l'input dell'utente prima di chiudere la finestra della console
Console.WriteLine("Premi un tasto per continuare...");
Console.ReadKey();

/***********************************************************************************************************************
 * per scegliere un nome a caso dalla lista dei compagni del corso di informatica:                                     *
 ***********************************************************************************************************************/

// Crea una nuova lista di stringhe e aggiungi i nomi dei compagni
List<string> compagniDiCorso = new List<string> { "Luca", "Simone", "Federica", "Alessandra", "Giulia", "Marco" };

// Scegli un nome a caso dalla lista dei compagni


// Random è una classe che genera numeri casuali e viene utilizzata per scegliere un nome a caso
// rnd è un oggetto della classe Random
// new Random() è un costruttore della classe Random che crea un nuovo oggetto della classe Random
// indiceCasuale è un intero che contiene il numero casuale generato
// Next è un metodo della classe Random che genera un numero casuale
// Count è un metodo della classe List che conta il numero di elementi nella lista
// compagniDiCorso.Count è il numero di elementi nella lista compagniDiCorso

Random rnd = new Random();// crea un oggetto della classe Random
int indiceCasuale = rnd.Next(compagniDiCorso.Count);// genera un numero casuale tra 0 e il numero di elementi nella lista

// Prendi il nome scelto a caso dalla lista
string nomeCasuale = compagniDiCorso[indiceCasuale];

// Stampa il nome scelto a caso nella console
Console.WriteLine("Il nome scelto a caso è: " + nomeCasuale);

// Attesa per l'input dell'utente prima di chiudere la finestra della console
Console.WriteLine("Premi un tasto per continuare...");
Console.ReadKey();

/***********************************************************************************************************************
 * per scegliere un nome a caso dalla lista dei compagni del corso di informatica e rimuoverlo dalla lista:            *
 ***********************************************************************************************************************/

// Crea una nuova lista di stringhe e aggiungi i nomi dei compagni
List<string> compagniDiCorso = new List<string> { "Luca", "Simone", "Federica", "Alessandra", "Giulia", "Marco" };

// Scegli un nome a caso dalla lista dei compagni
Random rnd = new Random();
int indiceCasuale = rnd.Next(compagniDiCorso.Count);
string nomeCasuale = compagniDiCorso[indiceCasuale];

// Rimuovi il nome scelto a caso dalla lista dei compagni
compagniDiCorso.Remove(nomeCasuale);

// Stampa il nome scelto a caso e la lista dei compagni senza il nome rimosso nella console
Console.WriteLine("Il nome scelto a caso è: " + nomeCasuale);
Console.WriteLine("I nomi dei compagni di corso senza il nome rimosso sono:");
foreach (string compagno in compagniDiCorso)
{
    Console.WriteLine(compagno);
}

// Attesa per l'input dell'utente prima di chiudere la finestra della console
Console.WriteLine("Premi un tasto per continuare...");
Console.ReadKey();

/***********************************************************************************************************************
 * scegliere un nome a caso dalla lista dei compagni rimuoverlo dalla lista, finché la lista non viene esaurita:       *
 ***********************************************************************************************************************/

// Crea una nuova lista di stringhe e aggiungi i nomi dei compagni
List<string> compagniDiCorso = new List<string> { "Luca", "Simone", "Federica", "Alessandra", "Giulia", "Marco" };

// Scegli nomi a caso dalla lista dei compagni finché la lista non viene esaurita
while (compagniDiCorso.Count > 0)
{
    Random rnd = new Random();  // crea un oggetto della classe Random
    int indiceCasuale = rnd.Next(compagniDiCorso.Count);    // genera un numero casuale tra 0 e il numero di elementi nella lista
    string nomeCasuale = compagniDiCorso[indiceCasuale];    // Prendi il nome scelto a caso dalla lista
    Console.WriteLine("Il nome scelto a caso è: " + nomeCasuale);   // Stampa il nome scelto a caso nella console
    compagniDiCorso.Remove(nomeCasuale);    // Rimuovi il nome scelto a caso dalla lista dei compagni
                                            // Stampa la lista dei compagni senza il nome rimosso nella console
    Console.WriteLine("I nomi dei compagni di corso senza il nome rimosso sono:");
    foreach (string compagno in compagniDiCorso)
    {
        Console.WriteLine(compagno);
    }
    Console.WriteLine("Premi un tasto per continuare...");
    Console.ReadKey();
}

// Attesa per l'input dell'utente prima di chiudere la finestra della console
Console.WriteLine("Premi un tasto per continuare...");
Console.ReadKey();

/***********************************************************************************************************************
 * LETTURA DEL CODICE: per dividere i compagni del corso di informatica in squadre:                                    *
 ***********************************************************************************************************************/

// DIFFICOLTA' ALTA

// Crea una nuova lista di stringhe e aggiungi i nomi dei compagni
List<string> compagniDiCorso = new List<string> { "Luca", "Simone", "Federica", "Alessandra", "Giulia", "Marco" };

// Crea una nuova lista di liste di stringhe per le squadre
// List<List<string>> significa che la lista squadre contiene liste di stringhe cioè una lista di liste

List<List<string>> squadre = new List<List<string>>();

// Imposta il numero di squadre desiderate
int numeroSquadre = 2;

// Crea le squadre e aggiungi i compagni
for (int i = 0; i < numeroSquadre; i++)     // ciclo for per creare le squadre
{
    squadre.Add(new List<string>());    // aggiunge una nuova lista di stringhe alla lista squadre
}

// Assegna i compagni alle squadre in modo casuale
Random rnd = new Random();  // crea un oggetto della classe Random
while (compagniDiCorso.Count > 0)   // ciclo while per assegnare i compagni alle squadre finché la lista non viene esaurita
{
    for (int i = 0; i < squadre.Count && compagniDiCorso.Count > 0; i++)    // ciclo for per assegnare i compagni alle squadre
    {
        int indiceCasuale = rnd.Next(compagniDiCorso.Count);    // genera un numero casuale tra 0 e il numero di elementi nella lista
        string nomeCasuale = compagniDiCorso[indiceCasuale];    // Prendi il nome scelto a caso dalla lista
        compagniDiCorso.RemoveAt(indiceCasuale);    // Rimuovi il nome scelto a caso dalla lista dei compagni
        squadre[i].Add(nomeCasuale);    // Aggiungi il nome scelto a caso alla squadra
    }
}

// Stampa le squadre nella console
Console.WriteLine("Le squadre sono:");
for (int i = 0; i < squadre.Count; i++)    // ciclo for per stampare le squadre
{
    Console.WriteLine("Squadra " + (i + 1) + ":");  // Stampa il numero della squadra
    foreach (string compagno in squadre[i]) // ciclo foreach per stampare i compagni della squadra
    {
        Console.WriteLine(compagno);
    }
}

// Attesa per l'input dell'utente prima di chiudere la finestra della console
Console.WriteLine("Premi un tasto per continuare...");
Console.ReadKey();
