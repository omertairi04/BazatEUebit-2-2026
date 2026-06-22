using System;
using System.Collections;

public class OOP3
{

  public static void Main(string[] args)
  {
    
  }

}


public class Matches
{
  FootballClub nikoqiret;
  FootballClub musafiret;

  string stadioni;

  int nikoqiretGolla;
  int musafiretGolla;

  public Matches(FootballClub nikoqiret, FootballClub musafiret, string stadioni)
  {
    this.nikoqiret = nikoqiret;
    this.musafiret = musafiret;
    this.stadioni = stadioni;
    this.nikoqiretGolla = 0;
    this.musafiretGolla = 0;
  }

  

}



public class FootballClub
{
  string emri;
  string liga;
  int pikt;

  ArrayList lojtart = new ArrayList();

  public FootballClub(string emri, string liga)
  {
    this.emri = emri;
    this.liga = liga;
    this.pikt = 0;
  }

  public void shtoLojtar(Lojtari l)
  {
    this.lojtart.Add(l);
    Console.WriteLine("Lojtari i ri: " + l);
  }
}

public class Lojtari
{
  string emer;
  string mbiemer;
  int numriIDresit;
  int gollat;

  public Lojtari(string emer, string mbiemer, int numriIDresit)
  {
    this.emer = emer;
    this.mbiemer = mbiemer;
    this.numriIDresit = numriIDresit;
    this.gollat = 0;
  }

  public override string ToString()
  {
    return this.emer + " " + this.mbiemer;
  }

}