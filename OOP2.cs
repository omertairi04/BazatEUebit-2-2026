using System;
using System.Collections;
public class OOP2
{

  public static void FollowAccount(Account account1, Account account2)
  {
    account1.Follow(account2);
    account2.Followed(account1);
  }

  public static void Main(string[] args)
  {
    Account a = new Account("ot123", "Omer T", "Bio", "admin123");
    Account b = new Account("to321", "Tairi O", "Bio1231", "231");
    Account c = new Account("AC", "AC", "AC", "AC");
    Account d = new Account("AD", "AD", "AD", "AD");
    Account e = new Account("AE", "AE", "AE", "AE");

    FollowAccount(a, b);
    FollowAccount(b,a);
    FollowAccount(a,c);
    FollowAccount(a,d);
    FollowAccount(a,e);
    Console.WriteLine(a);
    Console.WriteLine(b);
    a.showFollowing();
  }
}

public class Account
{
  string username;
  string name;
  string bio;
  string password;
  ArrayList followers = new ArrayList();
  ArrayList following = new ArrayList();
  
  public Account(string username, string name, string bio, string password)
  {
    this.username = username;
    this.name = name;
    this.bio = bio;
    this.password = password;
  }

  public override string ToString ()
  {
    return this.username + " - " + this.name + ": " + this.followers.Count + " - " + this.following.Count;
  }
  
  public void SetName(string emriIRi)
  {
    this.name = emriIRi;
  }

  public void Follow(Account account)
  {
    this.following.Add(account);
  }

  public void Followed(Account account)
  {
    this.followers.Add(account);
  }

  public string getUsername()
  {
    return this.username;
  }

  public void showFollowing()
  {
    for (int i=0;i < this.following.Count;i++)
    {
      Console.WriteLine(this.following[i]);
    }
  }

}