Console.WriteLine("Calcolatrice");

while (true)    // esegue il ciclo finché non si inseriscono due numeri e si sceglie un'operazione
{
    Console.Write("Inserisci il primo numero: ");
    string input1 = Console.ReadLine();
    double num1;    // dichiara una variabile di tipo double per memorizzare il primo numero inserito dall'utente
    bool success1 = double.TryParse(input1, out num1); // tenta di convertire la stringa in un numero decimale

    if (!success1)  // verifica che la conversione sia andata a buon fine
    {
        Console.WriteLine("Input non valido! Inserisci un numero.");
        continue;   // se la conversione non è andata a buon fine, ripete il ciclo
    }

    Console.Write("Inserisci il secondo numero: ");
    string input2 = Console.ReadLine();
    double num2;    // dichiara una variabile di tipo double per memorizzare il secondo numero inserito dall'utente
    bool success2 = double.TryParse(input2, out num2);

    if (!success2)
    {
        Console.WriteLine("Input non valido! Inserisci un numero.");
        continue;  // se la conversione non è andata a buon fine, ripete il ciclo
    }

    Console.WriteLine("Scegli un'operazione:");
    Console.WriteLine("1. Addizione");
    Console.WriteLine("2. Sottrazione");
    Console.WriteLine("3. Moltiplicazione");
    Console.WriteLine("4. Divisione");

    Console.Write("Operazione scelta: ");   // chiede all'utente di scegliere un'operazione 
    string scelta = Console.ReadLine();    // memorizza la scelta dell'utente in una variabile di tipo string

    double risultato;   // dichiara una variabile di tipo double per memorizzare il risultato dell'operazione

    switch (scelta) // esegue un'operazione diversa a seconda della scelta dell'utente
    {
        case "1":   // se l'utente ha scelto l'addizione
            risultato = num1 + num2;    // esegue l'addizione
            Console.WriteLine("Il risultato dell'addizione è: " + risultato);
            break;  // esce dal ciclo
        case "2":   // se l'utente ha scelto la sottrazione
            risultato = num1 - num2;    // esegue la sottrazione
            Console.WriteLine("Il risultato della sottrazione è: " + risultato);
            break;  // esce dal ciclo
        case "3":   // se l'utente ha scelto la moltiplicazione
            risultato = num1 * num2;    // esegue la moltiplicazione
            Console.WriteLine("Il risultato della moltiplicazione è: " + risultato);
            break;  // esce dal ciclo
        case "4":   // se l'utente ha scelto la divisione
            if (num2 == 0)  // verifica che il secondo numero non sia zero
            {
                Console.WriteLine("Impossibile dividere per zero!");
            }
            else
            {
                risultato = num1 / num2;    // esegue la divisione
                Console.WriteLine("Il risultato della divisione è: " + risultato);
            }
            break;  // esce dal ciclo
        default:    // se l'utente non ha inserito un'operazione valida (1, 2, 3 o 4)
                    // default è una parola chiave che indica il codice da eseguire se nessuna delle altre condizioni è soddisfatta
            Console.WriteLine("Operazione non valida! Riprova.");
            break; // esce dal ciclo
    }
}






























































