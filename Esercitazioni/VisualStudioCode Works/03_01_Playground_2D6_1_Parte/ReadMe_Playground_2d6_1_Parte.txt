// playground game hub

// in questo playground creeremo una serie di giochi di dadi utilizzabili da console

// 1. generazione di un numero casuale
// 2. lancio di un due dadi
// 3. lancio dadi con soglia
// 4. lancio dadi con verifica se sono uguali
// 5. lancio dadi con input utente per il lancio
// 6. lancio dadi finchè non si supera la soglia
// 7. lancio dadi con tentativi

/***********************************************************************************************************************
 * // 1. generazione di un numero casuale                                                                              *
 ***********************************************************************************************************************/

// nome cartella: playground-gamehub_01-Generazione-Casuale

Random random = new Random(); // Crea un oggetto di tipo Random
int numero = random.Next(1, 7); // intervallo semi-aperto

Console.WriteLine("Il numero generato è: " + numero);

/***********************************************************************************************************************
 * // 2. lancio di un due dadi                                                                                         *
 ***********************************************************************************************************************/

// nome cartella: playground-gamehub_02-Lancio-Dadi

Random random = new Random();   // Crea un oggetto di tipo Random
int dado1 = random.Next(1, 7);  // Genera un numero casuale tra 1 e 6
int dado2 = random.Next(1, 7);  // Genera un numero casuale tra 1 e 6

int somma = dado1 + dado2;

// Stampa il risultato del lancio dei dadi
Console.WriteLine("Primo Dado: " + dado1);
Console.WriteLine("Secondo Dado: " + dado2);
Console.WriteLine("Lancio: " + somma);

/***********************************************************************************************************************
 * // 3. lancio dadi con soglia                                                                                        *
 ***********************************************************************************************************************/

// nome cartella: playground-gamehub_03-Lancio-Dadi-Soglia

Random random = new Random();
int dado1 = random.Next(1, 7);
int dado2 = random.Next(1, 7);

int somma = dado1 + dado2;

int soglia = 7; // soglia di lancio

Console.WriteLine("Il risultato del lancio dei dadi è: " + somma);

if (somma > soglia)
{
	Console.WriteLine("Lancio superiore a " + soglia);
}
else
{
	Console.WriteLine("Lancio inferiore a " + soglia);
}

/***********************************************************************************************************************
 * // 4. lancio dadi con verifica se sono uguali                                                                       *
 ***********************************************************************************************************************/

// nome cartella: playground-gamehub_04-Lancio-Dadi-Uguali

Random random = new Random();
int dado1 = random.Next(1, 7);
int dado2 = random.Next(1, 7);

Console.WriteLine("Lancio: " + dado1 + " e " + dado2);

if (dado1 == dado2)
{
	Console.WriteLine("I dadi sono uguali");
}
else
{
	Console.WriteLine("I dadi non sono uguali");
}

/***********************************************************************************************************************
 * // 5. lancio dadi con verifica soglia ed input utente per lanciare i dadi                                           *
 ***********************************************************************************************************************/

// nome cartella: playground-gamehub_05-Lancio-Dadi-Soglia-Input

Console.WriteLine("Premi INVIO per lanciare i dadi...");	// Attende che l'utente schiacci "INVIO"
Console.ReadLine();	

Random random = new Random();
int dado1 = random.Next(1, 7);
int dado2 = random.Next(1, 7);
int somma = dado1 + dado2;

int soglia = 7;

	Console.WriteLine("Il risultato è: " + somma);

if (somma > soglia)
{
	Console.WriteLine("Lancio superiore alla soglia di " + soglia);
}
else
{
	Console.WriteLine("Lancio inferiore alla soglia di " + soglia);
}

/***********************************************************************************************************************
 * // 6. utilizzo di un ciclo while per continuare a lanciare i dadi finché la somma non supera una soglia             *
 ***********************************************************************************************************************/

// nome cartella: playground-gamehub_06-Lancio-Dadi-Soglia-While

int soglia = 7;	// soglia di lancio

while (true)	// Ciclo while che continua finché la somma dei dadi non supera la soglia
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
		Console.WriteLine("La somma dei dadi è inferiore a" + soglia);
	}
}

/***********************************************************************************************************************
 * // 7. continuare a lanciare i dadi finché la somma non supera una soglia e limitare il numero di tentativi          *
 ***********************************************************************************************************************/

// nome cartella: playground-gamehub_07-Lancio-Dadi-Soglia-While-Tentativi

int soglia = 7;
int tentativi = 5;	// numero di tentativi
int conteggioTentativi = 0;	// contatore dei tentativi

while (conteggioTentativi < tentativi)
{
	conteggioTentativi++;	// incrementa il contatore dei tentativi

	Console.WriteLine("Tentativo #" + conteggioTentativi + ": premi INVIO");
	Console.ReadLine();

	Random random = new Random();
	int dado1 = random.Next(1, 7);
	int dado2 = random.Next(1, 7);
	int somma = dado1 + dado2;

	Console.WriteLine("Il risultato è: " + somma);

	if (somma > soglia)
	{
		Console.WriteLine("Lancio superiore a " + soglia);
		break;
	}
	else if (conteggioTentativi == tentativi)
	{
		Console.WriteLine("Hai esaurito i tuoi tentativi.");
	 }
	else
	{
		Console.WriteLine("hai ancora " + (tentativi - conteggioTentativi) + " tentativi.");
	}
}

/***********************************************************************************************************************
 * // 8. lancio dadi contro il computer                                                                                *
 ***********************************************************************************************************************/

// nome cartella: playground-gamehub_08-Lancio-Dadi-Computer

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

/***********************************************************************************************************************
 * // 9. lancio dadi contro il computer con punteggio                                                                  *
 ***********************************************************************************************************************/

// nome cartella: playground-gamehub_09-Lancio-Dadi-Computer-Punteggio

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

/***********************************************************************************************************************
 * // 10. ciclo while per continuare a giocare finché i punteggi sono maggiori di zero                                 *
 ***********************************************************************************************************************/

// nome cartella: playground-gamehub_10-Lancio-Dadi-Computer-Punteggio-While

int punteggioGiocatore = 20;
int punteggioComputer = 20;
Random random = new Random();

Console.WriteLine("Il tuo punteggio iniziale è: " + punteggioGiocatore);
Console.WriteLine("Il punteggio iniziale del computer è: " + punteggioComputer);

while (punteggioGiocatore > 0 && punteggioComputer > 0)	// il ciclo while continua finché i punteggi sono maggiori di zero
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

/***********************************************************************************************************************
 * // 11. il risultato del lancio dei dadi viene sottratto al punteggio del giocatore o del computer che ha perso il lancio dei dadi *
 ***********************************************************************************************************************/

// nome cartella: playground-gamehub_11-Lancio-Dadi-Computer-Punteggio-While-Sottrazione

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
		punteggioComputer -= sommaGiocatore;
	}
	else if (sommaComputer > sommaGiocatore)
	{
		Console.WriteLine("Hai perso!");
		punteggioGiocatore -= sommaComputer;
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
else
{
	Console.WriteLine("Qualcosa è andato storto...");
}

/***********************************************************************************************************************
 * // 12. il programma viene suddiviso in classi e metodi per migliorare la leggibilità del codice e la manutenibilità del programma *
 ***********************************************************************************************************************/

// nome cartella: playground-gamehub_12-Lancio-Dadi-Sottrazione-Classi-Metodi

class Program
{
	static void Main(string[] args)
	{
		Giocatore giocatore = new Giocatore(20);	// creo un nuovo giocatore con un punteggio iniziale di 20
		Giocatore computer = new Giocatore(20);	// creo un nuovo giocatore con un punteggio iniziale di 20
		Dado dado = new Dado();		// creo un nuovo dado
		Random random = new Random();

		Console.WriteLine("Il tuo punteggio: " + giocatore.Punteggio);	 // giocatore.Punteggio è un'istanza della proprietà Punteggio della classe Giocatore
		Console.WriteLine("Punteggio del computer: " + computer.Punteggio);	// computer.Punteggio è un'istanza della proprietà Punteggio della classe Giocatore

		while (giocatore.Punteggio > 0 && computer.Punteggio > 0)
		{
			Console.WriteLine("Premi INVIO per lanciare i dadi...");
			Console.ReadLine();

			int sommaGiocatore = dado.LanciaDadi(random) + dado.LanciaDadi(random);	// dado.LanciaDadi(random) è un'istanza del metodo LanciaDadi della classe Dado
			int sommaComputer = dado.LanciaDadi(random) + dado.LanciaDadi(random);	// dado.LanciaDadi(random) è un'istanza del metodo LanciaDadi della classe Dado

			Console.WriteLine("Il tuo lancio: " + sommaGiocatore);	// sommaGiocatore è un'istanza della variabile sommaGiocatore
			Console.WriteLine("Lancio del computer: " + sommaComputer);	// sommaComputer è un'istanza della variabile sommaComputer

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
class Giocatore	// la classe Giocatore contiene le proprietà e i metodi che descrivono un giocatore
{
	public int Punteggio { get; private set; }	// la proprietà Punteggio è pubblica e può essere letta e modificata solo all'interno della classe Giocatore
	public Giocatore(int punteggioIniziale)	// il costruttore della classe Giocatore

	{
		Punteggio = punteggioIniziale;
	}
	public void SottraiPunteggio(int punteggioDaSottrarre)	// il metodo SottraiPunteggio è pubblico e può essere usato all'esterno della classe Giocatore
	{
		Punteggio -= punteggioDaSottrarre;	// Punteggio è una proprietà della classe Giocatore
	}
}
class Dado	// la classe Dado contiene il metodo che descrive il lancio di un dado
{
	public int LanciaDadi(Random random)	// il metodo LanciaDadi è pubblico e può essere usato all'esterno della classe Dado
	{
		return random.Next(1, 7);	// random.Next(1, 7) è un'istanza del metodo Next della classe Random
	}
}
