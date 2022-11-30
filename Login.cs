using System.Collections.Generic;
using System;

class Login
{
    public void ShowLogin() 
    {
        Console.Clear();
        PrintLogin();
    }

    public bool InputLogin(List<User> listUsers) {
        string name = InputName();;
        string password = InputPassword();

        return false;
    }

    public string InputName() 
    {
        Console.Write("Input name: ");

        return Console.ReadLine();
    }

    public string InputPassword() 
    {
        Console.Write("Input Password: ");

        return Console.ReadLine();
    }

    private void PrintLogin() {
        Console.WriteLine("Login successfully");
        Console.WriteLine("---------------------------"); 
    }
}