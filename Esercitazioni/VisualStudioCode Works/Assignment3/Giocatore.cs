class Giocatore
{
    private int punteggio; 

	public Giocatore() 
	{
		
		this.punteggio = 0; // inizializzo il punteggio del giocatore a 0
	}

	public void SetPunteggio(int punteggio) // metodo per assegnare un punteggio al giocatore
	{
		this.punteggio = punteggio; // assegno il valore passato al metodo alla variabile punteggio della classe Giocatore
	}

	public int GetPunteggio() // metodo per ottenere il punteggio del giocatore
	{
		return this.punteggio; // ritorno il punteggio del giocatore
	}
}