using System;

public class dshOOP
{
  
  public static void Main(string[] args)
  {
    Vetur kerr = new Vetur("BMW", "M4", 2025, 120000);
    Console.WriteLine(kerr); 
    kerr.levizVeturen(5000);
  }

}

class Vetur
{
  string brendi;
  string modeli;
  int vitiProdhimit;
  int cmimi;
  int kmTotale;
  string gjendja;

  public Vetur (string brendi, string modeli, 
  int vitiProdhimit, int cmimi)
  {
    this.brendi = brendi;
    this.modeli = modeli;
    this.vitiProdhimit = vitiProdhimit;
    this.cmimi = cmimi;
    this.kmTotale = 0;
    this.gjendja = "I RI";
  }

  public override string ToString()
  {
    return this.brendi + " - " + this.modeli + " - " + this.vitiProdhimit
    + " - " + this.cmimi + " - " + this.kmTotale + " - " + this.gjendja;
  }

  public void levizVeturen(int kmTeUdhtuara)
  {
    this.kmTotale += kmTeUdhtuara;

    if (kmTotale >= 300000)
    {
      this.gjendja = "I VJETER";
    } else if (kmTotale >= 150000)
    {
      this.gjendja = "I PERDORUR SHUM";
    } else if (kmTotale >= 80000)
    {
      this.gjendja = "I PERDORUR";
    }
  }

}
