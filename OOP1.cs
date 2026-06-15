using System;
public class OOP1
{
  public static void Main(string[] args)
  {
    Perdorues user = new Perdorues("user1", "user321", "admin123");
    Perdorues omer = new Perdorues("omer1", "Omer Tairi", "admin32");


    Kerri[] kerrat = new Kerri[10];
    int indexKerrat = 0;

    Kerri bmw = new Kerri("BMW","M5", 2025, 190500.00);
    // Console.WriteLine(bmw.getKM());
    bmw.bejUdhtim(500);
    // Console.WriteLine(bmw.getKM());

    // Console.WriteLine(bmw.getCmimi());
    bmw.setCmimi(200000);
    // Console.WriteLine(bmw.getCmimi());

    kerrat[indexKerrat] = bmw;
    indexKerrat += 1;
    Kerri mercedes = new Kerri("Mercedes Benz", "C-class", 2025, 170000);
    kerrat[indexKerrat] = mercedes;
    indexKerrat += 1;

    Console.WriteLine(mercedes.ToString());
    Console.WriteLine(bmw.ToString());
  }
}

class Kerri
{
  string firma;
  string modeli;
  int viti;
  double cmimi;
  int km;

  public Kerri(string firma, string modeli, int viti, double cmimi)
  {
    this.firma = firma;
    this.modeli = modeli;
    this.viti = viti;
    this.cmimi = cmimi;
    this.km = 0;
  }

  public void setCmimi(double cmimiIRi)
  {
    this.cmimi = cmimiIRi;
  }

  public double getCmimi()
  {
    return this.cmimi;
  }

  public int getKM()
  {
    return this.km;
  }

  public void bejUdhtim(int gjatsiaUdhtimit)
  {
    this.km += gjatsiaUdhtimit;
    this.setCmimi(this.cmimi - 10000);
  }

  public string ToString()
  {
    return this.firma + " " + this.modeli + " " + this.cmimi + " - " + this.km;
  }  
}

class Perdorues
{
  public string username;
  public string fullName;
  public string password;

  public Perdorues(string username, string fullName, string password)
  {
    this.username = username;
    this.fullName = fullName;
    this.password = password;
  }




}