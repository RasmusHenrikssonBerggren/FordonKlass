using System;

public class Fordon /*Klassen "Fordon" är public och kan användas av andra klasser*/
{
    private string tillverkare; /*private gör att "tillverkare" och "modell" endast kan nås av klassen "Fordon"*/
    private string modell;

    public Fordon(string tillverkare, string modell) /*Fordon hanterar "tillverkare" och "modell"*/
    {
        this.tillverkare = tillverkare;
        this.modell = modell;
    }

    public string getTillverkare() /*Hämtar och retunerar "tillverkare"*/
    {
        return tillverkare;
    }

    public string getModell() /*Hämtar och retunerar "modell"*/
    {
        return modell;
    }

}

public class Bil : Fordon /*Klassen "Bil" blir ett arv till klassen "Fordon". Klassen Bil ärver fordonets egenskaper*/
{
    private int antalDörrar;

    public Bil (string tillverkare, string modell, int antalDörrar) /*"Bil" hanterar "tillverkare", "modell" och "antal dörrar"*/
        : base(tillverkare, modell) /*"Fordon" är basklassen i projektet. Fordon hanterar från början "tillverkare" och "modell"*/
    {
        this.antalDörrar = antalDörrar;
    }

    public int getAntalDörrar() /*Hämtar och retunerar antalet dörrar*/
    {
        return antalDörrar;
    }
}

class Program
{
    static void Main()
    {
        Bil minBil = new Bil("Ford", "Mustang", 2); /*Ny bil skapas med tillverkare, modell och antal dörrar*/
        Console.WriteLine("Tillverkare: " + minBil.getTillverkare()); /*Information om bilen skrivs ut, i form av tillverkare, modell och antal dörrar*/
        Console.WriteLine("Modell: " + minBil.getModell()); 
        Console.WriteLine("Antal dörrar: " + minBil.getAntalDörrar());
    }
}