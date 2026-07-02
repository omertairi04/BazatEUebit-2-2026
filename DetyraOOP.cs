using System;
using System.Collections;

public class DetyraOOP
{
  
  public static void Main(string[] args)
  {
    Arsimtari omer = new Arsimtari("Omer", "Tairi", 21, "Enxhinjer i shkencave kompjuterike");
    Arsimtari almir = new Arsimtari("Almir", "Aliu", 14, "Enxhinjer softuerik");

    Klasa beu1 = new Klasa("Bazat e Uebit #1", almir);
    Klasa beu2 = new Klasa("Bazat e Uebit #2", omer);

    Nxenes ajan = new Nxenes("Ajan", "Aliu", 12);
    Nxenes hamza = new Nxenes("Hamza", "Memeti", 13);
    Nxenes anuar = new Nxenes("Anuar", "Memeti", 14);
    Nxenes muadh = new Nxenes("Muadh", "Kasami", 16);
    Nxenes rajan = new Nxenes("Rajan", "Memeti", 12);

    beu1.shtoNxenes(ajan);
    beu1.shtoNxenes(rajan);    
    beu1.shtoNxenes(anuar);    

    beu2.shtoNxenes(hamza);
    beu2.shtoNxenes(muadh);
    
    beu1.shfaqNxenesit();

    Console.WriteLine("---------------------");
    beu2.shfaqNxenesit();

  }
}

public class Person
{
  string emri;
  string mbiemri;
  int vitet;

  public Person(string emri, string mbiemri, int vitet)
  {
    this.emri = emri;
    this.mbiemri = mbiemri;
    this.vitet = vitet;
  }

  public string getName() {
      return this.emri;
  }

  public string displayInfo()
  {
    return this.emri + " " + this.mbiemri + " " + this.vitet;
  }

}

public class Arsimtari : Person
{
  
  string diploma;
  ArrayList klasat;

  public Arsimtari(string emri, string mbiemri, int vitet, string diploma) 
  : base(emri, mbiemri, vitet)
  {
    
    this.diploma = diploma;
    this.klasat = new ArrayList();
  }

  public void shtoKlas(Klasa klas)
  {
    this.klasat.Add(klas);
  }

  public void shfaqKlasat()
  {
    for (int i=0; i < klasat.Count; i++)
    {
    //   Console.WriteLine(klasat[i].getId());
    }
  }

}

public class Klasa
{
  string id;
  ArrayList nxenesit;
  Arsimtari kujdestari;

  public Klasa(string id , Arsimtari kujdestari)
  {
    this.id = id;
    this.kujdestari = kujdestari;
    this.nxenesit = new ArrayList();
  }

  public string getId()
  {
    return this.id;
  }

  public void shtoNxenes(Nxenes nxenesi)
  {
    this.nxenesit.Add(nxenesi);
  }

  public void shfaqNxenesit()
  {
    Console.WriteLine("Klasa " + this.id + " me kujdestar " + this.kujdestari.getName() + " ka keto nxenes: ");
    for (int i=0;i<this.nxenesit.Count;i++)
    {
    //   Console.WriteLine(nxenesit[i].displayInfo());
    }
  }

}

public class Nxenes : Person
{

  public Nxenes(string emer, string mbiemri, int vitet)
  : base(emer, mbiemri,vitet)
  {
  }
}
