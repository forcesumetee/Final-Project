using System;

class Register
{
    public void ShowRegister() 
    {
        Console.Clear();
        PrintNewRegister();
    }

    public User InputNewUser() 
    {
        string name = InputName();
        string surname = InputSurname();
        string tel = InputTel();
        string email = InputEmail();
        string password = InputPassword();

        return new User(name, surname, tel, email, password);
    }
    
    private string InputName() 
    {
        Console.Write("Input Name: ");

        return Console.ReadLine();
    }

    private string InputSurname() 
    {
        Console.Write("Input Surname: ");

        return Console.ReadLine();
    }

    private string InputTel() 
    {
        Console.Write("Input Tel: ");

        return Console.ReadLine();
    }

    private string InputEmail() 
    {
        Console.Write("Input Email: ");

        return Console.ReadLine();
    }

    private string InputPassword() 
    {
        Console.Write("Input Password: ");

        return Console.ReadLine();
    }

    private void PrintNewRegister() 
    {
        Console.WriteLine("Register new Person");
        Console.WriteLine("-------------------");
    }
}