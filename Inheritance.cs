using System;

public class Inheritance
{
  public static void Main(string[] args)
  {
    
    Cen c1 = new Cen("Maksi", 30, "Pitbull");
    c1.display();
    
    Maca m1 = new Maca("Ma", 20, "E kaft");
    m1.display();

  }
}


public class Kafsha
{
  public string emer;
  public int vitetQeJeton;

  public Kafsha(string emer, int vitetQeJeton)
  {
    this.emer = emer;
    this.vitetQeJeton = vitetQeJeton;
  }

  public virtual void display()
  {
    Console.WriteLine("Emri kafshes: " + this.emer);
    Console.WriteLine("Jeton deri ne " + this.vitetQeJeton);
  }
}

public class Cen : Kafsha {

  string lloji;

  public Cen(string emri, int vitetQeJeton, string lloji)
   : base(emri, vitetQeJeton)
  {
    this.lloji = lloji;
  }

  public override void display()
  {
    base.display();
    Console.WriteLine("Lloji i cenit: " + this.lloji);
  }
}

public class Maca : Kafsha
{
  string ngjyra;

  public Maca(string emri, int vitetQeJeton, string ngjyra)
  : base(emri, vitetQeJeton)
  {
    this.ngjyra = ngjyra;
  }

  public string getNgjyra()
  {
    return this.ngjyra;
  }

  public override void display()
  {
    base.display();
    Console.WriteLine("Ngjyra e maces eshte : " + this.ngjyra);
  }
}