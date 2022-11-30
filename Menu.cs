using System;
using System.Collections.Generic;

enum CheckMenu 
{
    Login = 1,
    Register
}

class Menu 
{
    private Register register;
    private Login login;
    private List<User> users;

    public void ShowMenu() 
    {
        ListUsersWhenLogin();
        ShowMenuData();
    }

    private void ShowMenuData() {
        Console.Clear();
        PrintMenu();
        PrintListMenu();
        GoToMenu(InputMenu());
    }

    private void ListUsersWhenLogin() {
        this.users = new List<User>();
    }

    public CheckMenu InputMenu() {
        Console.Write("Select Menu: ");

        return (CheckMenu)(int.Parse)(Console.ReadLine());        
    }

     private void GoToMenu(CheckMenu checkmenu) {
        if (checkmenu == CheckMenu.Login) {
            ShowLogin();
            bool status = this.login.InputLogin(this.users);
            ShowMenuWhenCheckInCorrect(status);
        } else if (checkmenu == CheckMenu.Register) {
            ShowRegister();
            this.users.Add(this.register.InputNewUser());
            ShowMenuData();
        }
    }

    private void ShowMenuWhenCheckInCorrect(bool DataStatus) {
        if (!DataStatus) {
            Console.WriteLine("Data is incorrect Please try again.");
            ShowMenuData();
        }
    }

    private void ShowRegister() {
        this.register = new Register();
        this.register.ShowRegister();
    }

    private void ShowLogin() {
        this.login = new Login();
        this.login.ShowLogin();
    }

    private void PrintMenu() {
        Console.WriteLine("Welcome");
        Console.WriteLine("-------------");
    }

    private void PrintListMenu() {
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Register");
    }
}