using System;
using System.Collections.Generic;

public class AddressBook
{
    public Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();

    public void AddContact(Contact aContact)
    {
        try
        {
            addressBook.Add(aContact.Email, aContact);
        }
        catch (Exception ex)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"{aContact.Email} already exists!");
            Console.WriteLine("--------------------------");
        }
    }

    public Contact GetByEmail(string email)
    {
        {
            return addressBook[email];
        }
    }
}git init