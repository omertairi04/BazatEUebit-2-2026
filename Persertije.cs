using System;
using System.Collections;

public class User
{
  string username;
  string email;
  string name;

  public User(string username, string email)
  {
    this.username = username;
    this.email = email;
    this.name = generateName(username, email);
  }

  public string generateName(string username, string email)
  {
    char[] usrChar = username.ToCharArray(); // {'o' , 'm', 'e'};
    char[] emlChar = email.ToCharArray(); // {'o'}
    
    char[] emri = {usrChar[0], usrChar[1], usrChar[2], 
    emlChar[emlChar.Length - 3], emlChar[emlChar.Length - 2],emlChar[emlChar.Length - 1]};
    return new string(emri);
  }

  public string getName()
  {
    return this.name;
  }

  public override string ToString()
  {
    return this.name;
  }
}

public class Admin : User {
  string roli = "Administrator";
  ArrayList puntort;

  int mosha;

  public Admin(string username, string email, int mosha)
  : base(username, email)
  {
    this.puntort = new ArrayList();
    this.mosha = mosha;
  }

  public void shtoPuntor(Puntor p)
  {
    this.puntort.Add(p);
  }

  public override string ToString()
  {
    string rezultati = "ADMIN " + this.mosha +  "\n";
    for (int i=0; i<this.puntort.Count;i++)
    {
      rezultati += this.puntort[i].ToString() + "\n";
    }
    return rezultati;
  }
}

public class Puntor : User
{
  string roli = "Puntor";
  string dyqani;

  public Puntor(string username, string email , string dyqani)
  : base(username, email)
  {
    this.dyqani = dyqani;
  }

  public override string ToString()
  {
    return "PUNTOR: " + base.ToString() + " , " + this.dyqani;
  }
}

public class Perseritje
{
  public static void Main(string[] args)
  {

    Admin a = new Admin("omer", "tairiomer04", 24);
    // Admin b = new Admin("ome", "o");

    Puntor p = new Puntor("tairi", "tairi", "Kipper");

    Puntor p1 = new Puntor("ajan", "almir", "KAM");
    Puntor p2 = new Puntor("almir", "hamza", "STOKOMAKI");
    
    a.shtoPuntor(p);
    a.shtoPuntor(p1);
    a.shtoPuntor(p2);

    Console.WriteLine(a);
  }
}

