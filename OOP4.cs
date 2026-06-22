using System;
using System.Collections;

public class OOP4
{

  public static void sherbe(Kafja laKafe) {
         Console.WriteLine("Mirseerdhet tek " + laKafe.getEmer() + " , qfar doni te pini");
        string mushterija1 = Console.ReadLine();
        int cmimiKafes = laKafe.merPorosin(mushterija1);
        Console.WriteLine("Totali juaj eshte: " + cmimiKafes);
    }
    
    public static void Main(string[] args)
    {
    Kafja laKafja = new Kafja("La-Kafja");
   
    sherbe(laKafja);
    sherbe(laKafja);
    sherbe(laKafja);
    
    Console.WriteLine("Ne fund te dites kemi fituar: " + laKafja.fitimiDites());
    
    Console.WriteLine("Fitimi i Paster eshte: " + laKafja.getFitimiPaster());
    
    }
}

public class Kafja
{
  string emriKafes;
  int buxhet;
    int fitimiPaster;

  public Kafja(string emriKafes)
  {
    this.emriKafes = emriKafes;
    this.buxhet = 0;
    this.fitimiPaster = 0;
  }
  
  public string getEmer() {
      return this.emriKafes;
  }
  
  public int merPorosin(string pija) {
      if (pija == "espresso") {
          this.buxhet += 60;
          this.fitimiPaster += 60 - 20;
          return 60;
      } else if (pija == "makijato")  {
          this.buxhet += 70;
          this.fitimiPaster += 70 - 40;
          return 70;
      } else if (pija == "golden eagle") {
          this.buxhet += 90;
          this.fitimiPaster += 90 - 40;
          return 90;
      } else if (pija == "latte") {
          this.buxhet += 100;
          this.fitimiPaster += 100 - 40;
          return 100;
      } 
      else {
          Console.WriteLine("Na falni, nuk e kemi pijen ketu!");
          return 0;
      }
  }
  
  public int getFitimiPaster() {
      return this.fitimiPaster;
  }
  
  public int fitimiDites() {
      return this.buxhet;
  }

}
