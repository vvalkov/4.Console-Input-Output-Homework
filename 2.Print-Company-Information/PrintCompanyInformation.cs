using System;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please enter address:");
        string adress = Console.ReadLine();
        Console.WriteLine("Please enter phone number:");
        long phone = long.Parse(Console.ReadLine());
        Console.WriteLine("Please enter fax number:");
        long fax = long.Parse(Console.ReadLine());
        Console.WriteLine("Please enter website:");
        string website = Console.ReadLine();
        Console.WriteLine("Please enter manager name:");
        string managerName = Console.ReadLine();
        Console.WriteLine("Please enter manager age:");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please enter manager phone:");
        long managerPhone = long.Parse(Console.ReadLine());
        Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n{7}", firstName, adress, phone, fax, website, managerName, managerAge, managerPhone);
    }
}