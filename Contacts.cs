using System;
using System.Collections.Generic;

public class Contact
{
  public string Name;
  public string Phone;
  public string Address;
}

class Program
{
  public static void Main()
  {
    Contact jiwon = new Contact();
    jiwon.Name = "Jiwon";
    jiwon.Phone = "123-123-1234";
    jiwon.Address = "Thailand";

    Contact justine = new Contact();
    justine.Name = "Justine";
    justine.Phone = "234-234-2345";
    justine.Address = "Spain";

    List<Contact> AddressBook = new List<Contact> { jiwon, justine };
    foreach (Contact person in AddressBook)
    {
      Console.WriteLine(person.Name);
      Console.WriteLine(person.Phone);
      Console.WriteLine(person.Address);
    }
  }
}
