using System;
using System.Collections;

public class Student
{
  string emri;
  int mosha;
  int nota;

  public Student(string emri, int mosha, int nota)
  {
    this.emri = emri;
    this.mosha = mosha;
    this.nota = nota;
  }

  public string getEmri()
  {
    return this.emri;
  }

  public int getMosha()
  {
    return this.mosha;
  }

  public int getNota()
  {
    return this.nota;
  }

  public override string ToString()
  {
    return "Emri: " + emri + "\nMosha: " + mosha + "\nNota: " + nota;
  }
}

public class MenaxhimStudent
{
  public static void Main(string[] args)
  {
ArrayList studentet = new ArrayList();
    
    // Student rajan = new Student("Rajan", 14, 5);
    // Student anuar = new Student("Anuar", 15, 5);
    // Student omer = new Student("Omer", 21, 2);
    // Student ubade = new Student("Ubade", 16, 3);
    // Student ejmen = new Student("Ejmen", 13, 4);
    // Student hamza = new Student("Hamza", 15, 4);

    // studentet.Add(rajan);
    // studentet.Add(anuar);
    // studentet.Add(omer);
    // studentet.Add(ubade);
    // studentet.Add(ejmen);
    // studentet.Add(hamza);
    
    string input = Console.ReadLine();
    int numriStudentave = Convert.ToInt32(input);
    
    

    for (int i=0; i < numriStudentave;i++) {
        string emri = Console.ReadLine();
        string inputMosha = Console.ReadLine();
        int mosha = Convert.ToInt32(inputMosha);
        string inputNota = Console.ReadLine();
        int nota = Convert.ToInt32(inputNota);
        Student s = new Student(emri, mosha, nota);
        studentet.Add(s);
    }

    for (int i=0;i<studentet.Count;i++)
    {
      Console.WriteLine(studentet[i]);
      Console.WriteLine();
    }
    
    Console.WriteLine("-----------------");
    
    foreach (Student student in studentet) {
        if (student.getNota() >= 4) {
            Console.WriteLine(student);
        }
    }
    
    
    Console.WriteLine("-----------------");

    Student max = (Student) studentet[0];
    foreach(Student st in studentet)
    {
      if (st.nota > max.nota)
      {
        max = st;
      }
    }
    
    Console.WriteLine(max);


    Console.WriteLine("-----------------");
    
    int numri = 0;
    foreach(Student s in studentet) {
        if (s.getMosha() > 14) {
            numri++;
        }
    }
    
    Console.WriteLine(numri);

    
  }
}