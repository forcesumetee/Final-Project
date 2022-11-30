class User
{
    protected string name;
    protected string surname;
    protected string tel;
    protected string email;
    protected string password;

    public User(string name, string surname, string tel, string email, string password) 
    {
        this.name = name;
        this.surname = surname;
        this.tel = tel;
        this.email = email;
        this.password = password;;
    }
        public string GetName() 
        {
            return this.name;
        }

         public string GetSurname() 
        {
            return this.surname;
        }

         public string GetTel() 
        {
            return this.tel;
        }

         public string GetEmail() 
        {
            return this.email;
        }

         public string GetPassword() 
        {
            return this.password;
        }
}