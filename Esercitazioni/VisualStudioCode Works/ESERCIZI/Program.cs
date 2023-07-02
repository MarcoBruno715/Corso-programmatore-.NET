
/***********************************************************************************************************************
 * Scrivi un programma che dichiara un array di interi contenente i numeri 3, 5, 7, 9 e 11,                            *
 * quindi calcola e stampa la somma di tutti i numeri dell'array nella console.                                        *
 ***********************************************************************************************************************/


// dichiara un array di interi contenente i numeri 3, 5, 7, 9 e 11
int[] numbers = { 3, 5, 7, 9, 11 }; 
int sum = 0; // dichiara una variabile intera contenente il valore 0
foreach (int number in numbers)
{ // per ogni numero nell'array
    sum += number; // aggiungi il numero alla variabile sum , incremento il numero nella varie posizioni
}
Console.WriteLine("La somma dei numeri e': " + sum);