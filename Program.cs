using System;

namespace ProjectCar.ProjectEV
{
    public class Program
    {

        static Menu menu;

        static void Main(string[] args)
        {
            ListUsersWhenLogin();

            ShowMenu();
        }

        static void ListUsersWhenLogin()
        {
            Program.menu = new Menu();
        }

        static void ShowMenu()
        {
            Program.menu.ShowMenu();
            ShowMenuSpec();
            StartCharge();
            Payment();
        }


        static void ShowMenuSpec()
        {
            Console.WriteLine("Car");
            Console.WriteLine("***************");
            Speccar S1 = new Speccar();
            S1.Car = "1.MG EP";
            S1.Price = 215;
            Speccar S2 = new Speccar();
            S2.Car = "2.MG ZS EV";
            S2.Price = 192;

            Speccar S3 = new Speccar();
            S3.Car = "3.Nisan Leaf";
            S3.Price = 172;

            Speccar S4 = new Speccar();
            S4.Car = "4.Audi e-Tron";
            S4.Price = 399;

            Console.WriteLine(S1.Car);
            Console.WriteLine(S2.Car);
            Console.WriteLine(S3.Car);
            Console.WriteLine(S4.Car);
            Console.WriteLine("Input Car");
            Console.WriteLine("***************");
            int C = int.Parse(Console.ReadLine());

            if (C == 1)
            {
                Console.WriteLine("***************");
                Console.WriteLine(S1.Car);
                Console.WriteLine(S1.Price + "Bath");
                Console.WriteLine("***************");


            }
            if (C == 2)
            {
                Console.WriteLine("***************");
                Console.WriteLine(S2.Car);
                Console.WriteLine(S2.Price + "Bath");
                Console.WriteLine("***************");
            }

            if (C == 3)
            {
                Console.WriteLine("***************");
                Console.WriteLine(S3.Car);
                Console.WriteLine(S3.Price + "Bath");
                Console.WriteLine("***************");
            }
            if (C == 4)
            {
                Console.WriteLine("***************");
                Console.WriteLine(S4.Car);
                Console.WriteLine(S4.Price + "Bath");
                Console.WriteLine("***************");
            }
        }

        static void StartCharge()
        {
            CarS N1 = new CarS();
            N1.EVcar = 50.3;
            CarS N2 = new CarS();
            N2.EVcar = 44.5;
            CarS N3 = new CarS();
            N3.EVcar = 40;
            CarS N4 = new CarS();
            N4.EVcar = 95;
            CarS Point = new CarS();
            Point.EVcar = 4.3;

             double Percent;

        
            Console.WriteLine("Input Car");
            Console.WriteLine("1:MG EP,2:MG ZS EV,3:Nussan Leaf,4:Audi e-Tron");
           double N =double.Parse(Console.ReadLine());

            if (N == 1) 
            {
                Console.WriteLine("confirm  charge: Input 1 Yes/Input 2 No");
                Console.WriteLine("*******************");
                int R = int.Parse(Console.ReadLine());
                if (R == 1) 
                {
                    Console.WriteLine("............About to start charging...............");
                    Console.Write("Please Input percent:");
                    Percent = double.Parse(Console.ReadLine());
                    Console.WriteLine("............START CHARHING..........");

                }
                if (R == 2) 
                {
                    Console.WriteLine("Stop");
                }
               
                       
            }

            if (N == 2)
            {

                Console.WriteLine("confirm  charge: Input 1 Yes/Input 2 No");
                Console.WriteLine("*******************");
                int R = int.Parse(Console.ReadLine());
                if (R == 1)
                {
                    Console.WriteLine("............About to start charging...............");
                    Console.Write("Please Input percent:");
                    Percent = double.Parse(Console.ReadLine());
                    Console.WriteLine("............START CHARHING..........");
                }
                if (R == 2)
                {
                    Console.WriteLine("Stop");
                }


            }

            if (N == 3)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("confirm  charge: Input 1 Yes/Input 2 No");
                int R = int.Parse(Console.ReadLine());
                if (R == 1)
                {
                  Console.WriteLine("............About to start charging...............");
                    Console.Write("Please Input percent:");
                    Percent = double.Parse(Console.ReadLine());
                    Console.WriteLine("............START CHARHING..........");
                }
                if (R == 2)
                {
                    Console.WriteLine("Stop");
                }


            }

            if (N == 4)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("confirm  charge: Input 1 Yes/Input 2 No");
                int R = int.Parse(Console.ReadLine());
                if (R == 1)
                {
                   Console.WriteLine("............About to start charging...............");
                    Console.Write("Please Input percent:");
                    Percent = double.Parse(Console.ReadLine());
                    Console.WriteLine("............START CHARHING..........");
                }
                if (R == 2)
                {
                    Console.WriteLine("Stop");
                }


            }

        }

        static void Payment()
        {
            const double car1 = 50.3, car2 = 44.5, car3 = 40, car4 = 95;
            const double ElectricityBill = 4.2;
            double Percentage, number, TotalPrice = 0;

            Console.WriteLine("'Enter the payment process'");
            Console.ReadLine();
            Console.Write("Confirm percent:");
            double.TryParse(Console.ReadLine(), out Percentage);

            Percentage /= 100;

            Console.Write("Confirm Model :");
            double.TryParse(Console.ReadLine(), out number);
            if (number == 1)
            {
                Console.WriteLine("Model is MG EP");
                TotalPrice = Percentage * car1 * ElectricityBill;
            }
            else if (number == 2)
            {
                Console.WriteLine("Model is MG ZS EV");
                TotalPrice = Percentage * car2 * ElectricityBill;
            }
            else if (number == 3)
            {
                Console.WriteLine("Model is Nissan Leaf");
                TotalPrice = Percentage * car3 * ElectricityBill;
            }
            else if (number == 4)
            {
                Console.WriteLine("Model is Audi e-Tron");
                TotalPrice = Percentage * car4 * ElectricityBill;
            }

            Console.Write("TotalPrice : ");
            Console.WriteLine(TotalPrice);
            Console.WriteLine("Pay at Promptpay : 083-089-5092");
            Console.WriteLine("---Thank you for using the service---");
            Console.ReadKey();
        }

    }



}
