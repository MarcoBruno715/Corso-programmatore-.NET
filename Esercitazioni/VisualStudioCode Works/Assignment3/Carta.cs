class Carta
{
	private string seme; // seme della carta
	private  int valore; // valore della carta
    

	public Carta(string seme, int valore) // costruttore della classe Carta che prende in ingresso il seme e il valore della carta
	{
		this.seme = seme; // assegno il valore passato al costruttore alla variabile seme della classe Carta
		this.valore = valore; // assegno il valore passato al costruttore alla variabile valore della classe Carta
	
	}

	public string GetSeme() // metodo per ottenere il seme della carta
	{
		return this.seme; // ritorno il seme della carta
	}

	public int GetValore() // metodo per ottenere il valore della carta
	{
		return this.valore; // ritorno il valore della carta
	}

}