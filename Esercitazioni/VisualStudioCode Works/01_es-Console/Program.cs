// Leggere l'inpute dell'utente

Console.WriteLine("Inserisci il tuo nome:");
string ilmionome = Console.ReadLine();


// Visualizzare gli errori

Console.Error.WriteLine("Si è verificato un errore durante l'esecuzione del programma!");

/*
1 ESERCIZIO: In questo esempio, viene visualizzato il messaggio "Si è verificato un errore durante l'esecuzione del programma!" sulla console di errore.
viene visualizzato il messaggio "Inserisci il tuo nome:" sulla console. L'utente può quindi inserire il proprio nome sulla console, seguito dal tasto Invio.
*/

// utilizzo il metodo Writeline della classe Console per chiedere all'utente un'informazione
Console.WriteLine("Inserisci il tuo nome:");

// leggo l'input dell'utente e lo utilizzo cone variabile testo con nome "nome"
string nome = Console.ReadLine();

// utilizzo il metodo Writeline della classe Console per restituire il testo "nome"
Console.WriteLine("Ciao, " + nome + "!");

/*
È possibile utilizzare il metodo Console.ReadLine() per leggere anche altri tipi di dati, come numeri interi o decimali, ma è necessario eseguire una conversione di tipo appropriata.
In questo esempio, il metodo int.Parse() viene utilizzato per convertire la stringa letta dal metodo Console.ReadLine() in un valore numerico di tipo intero.
*/

// utilizzo il metodo Writeline della classe Console per chiedere all'utente di inserire un numero
Console.WriteLine("Inserisci un numero intero:");

// creo ed assegno una variabile INT convertendo una stringa in numero con il metodo PARSE
int numero = int.Parse(Console.ReadLine());

// utilizzo il metodo Writeline di Console per restituire la stringa comprensiva del valore inserito
Console.WriteLine("Il numero inserito è: " + numero);

/*
In alternativa, è possibile utilizzare il metodo Console.ReadKey() per leggere il primo tasto premuto dall'utente sulla console, In questo esempio, il programma visualizza il messaggio "Premi un tasto per continuare..."
sulla console, e si mette in attesa del tasto premuto dall'utente.
Una volta premuto il tasto, il programma visualizza il messaggio "Hai premuto un tasto!" sulla console.
*/

// utilizzo il metodo WriteLine per chiedere all'utente di premere un tasto
Console.WriteLine("Premi un tasto per continuare...");

// leggo quale tasto l'utente ha premuto
Console.ReadKey();

// scrivo che il tasto è stato premuto
Console.WriteLine("Hai premuto un tasto!");

// FORMATTAZIONE DEL CODICE IN CONSOLE

/*
Ecco alcuni accorgimenti per utilizzare la console in modo efficace:
Utilizzare il colore del testo: la console di Visual Studio consente di utilizzare diversi colori per il testo visualizzato sulla console.
Ad esempio, è possibile utilizzare il metodo Console.ForegroundColor per impostare il colore del testo sulla console.
In questo esempio, il testo "Questo testo è di colore rosso!" viene visualizzato in rosso sulla console.
*/

// imposto il colore del testo in console a rosso
Console.ForegroundColor = ConsoleColor.Red;

// restituisco il testo colorato
Console.WriteLine("Questo testo è di colore rosso!");

// resetto la classe console in modo da ritornare al testo nero
Console.ResetColor();

/*
Utilizzare il colore di sfondo: è possibile utilizzare il metodo Console.BackgroundColor per impostare il colore di sfondo sulla console.
In questo esempio, il testo viene visualizzato su uno sfondo giallo sulla console.
*/

// imposto il colore di sfondo delle scritte  in questo caso giallo
Console.BackgroundColor = ConsoleColor.Yellow;

// imposto il colore della scritta in questo caso nero
Console.ForegroundColor = ConsoleColor.Black;

// scrivo il testo in console
Console.WriteLine("Questo testo ha uno sfondo giallo!");

// resetto il colore a nero
Console.ResetColor();

/*
Utilizzare la tabulazione: è possibile utilizzare il carattere di tabulazione per allineare il testo sulla console.
Ad esempio, è possibile utilizzare il metodo Console.Write per visualizzare il testo allineato su due colonne.
In questo esempio, il testo viene visualizzato allineato su due colonne sulla console.
*/

// Creo le intestazioni delle colonne e creo una nuova linea
Console.Write("Colonna 1\tColonna 2\n");

// Creo gli elementi delle colonne
Console.Write("Valore 1\tValore 2");

/*
Utilizzare il cursore: è possibile utilizzare il metodo Console.SetCursorPosition per posizionare il cursore sulla console e scrivere il testo in una posizione specifica.
In questo esempio, il testo viene visualizzato nella posizione (10, 5) sulla console.
*/

// utilizzo il metodo SetCursorPosition per impostare l'inizio del testo in riga 10 colonna 5
Console.SetCursorPosition(10, 5);

// scrivo il testo in console nella posizione predefinita
Console.WriteLine("Questo testo è nella posizione (10, 5)!");

/*
Pulire la console: è possibile utilizzare il metodo Console.Clear per pulire la console e cancellare tutto il testo visualizzato sulla console
In questo esempio, la console viene pulita e cancellato tutto il testo visualizzato sulla console.
*/

// pulisce i tentativi precedenti dalla console
Console.Clear();
                