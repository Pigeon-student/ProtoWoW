using System;
namespace ProtoWoW;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        
        var hogger = new Unit("Подрібнювач", 5, 100, 50); // Створюємо моба 
        //Unit player = new Unit("Медів з Каражану"); // Створюємо "гравця"
        Player player1 = new Player("Сквізгаар", Race.Orc, Specialisation.Hunter);


        const byte xSize = 10; // Розмір поля по X
        const byte ySize = 10; // Розмір поля по Y
        byte[] battlefield = new byte[2] { xSize, ySize }; // Створюємо поле бою 10х10        

        Random rand = new Random(); // Створюємо екземпляр класу Random для генерації випадкових чисел
        byte xCoord = (byte)rand.Next(10);
        byte yCoord = (byte)rand.Next(10);
        var xPlayerCoord = (byte)rand.Next(10);
        var yPlayerCoord = (byte)rand.Next(10);

        hogger.Position = new byte[2] { xCoord, yCoord };
        player1.Position = new byte[2] { xPlayerCoord, yPlayerCoord };

        player1.GetPosition(); //Виввід позицій
        hogger.GetPosition();

        player1.GetInfo(); // Вивід інформації про "гравця"
        player1.GetPlayerInfo(); // Вивід інформації про гравця

        Move(player1, hogger, xSize, ySize); // Виклик методу пересування гравця по полю






        static void Move(Unit player1, Unit hogger, byte xSize, byte ySize) // Метод пересування гравця по полю
        {
            bool isExit = false;
            bool isMeet = false;

            while (!isExit && !isMeet)
            {
                //Console.Write("\nEnter move: ");
                var but = Console.ReadKey().Key;

                switch (but)
                {
                    case ConsoleKey.D:

                        if (player1.Position[1] < ySize)
                        {
                            player1.Position[1]++;
                            //Console.WriteLine($"Y: {player.position[1]}");
                            if (player1.Position[0] == hogger.Position[0] && player1.Position[1] == hogger.Position[1])
                            {
                                Console.WriteLine($"\n{player1.Name} зустрів {hogger.Name}!");
                                isMeet = true;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nВихід за межі поля");
                        }
                        continue;


                    case ConsoleKey.A:

                        if (player1.Position[1] > 0)
                        {
                            player1.Position[1]--;
                            // Console.WriteLine($"Y: {player.position[1]}");
                            if (player1.Position[0] == hogger.Position[0] && player1.Position[1] == hogger.Position[1])
                            {
                                Console.WriteLine($"\n{player1.Name} зустрів {hogger.Name}!");
                                isMeet = true;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nВихід за межі поля");
                        }
                        continue;

                    case ConsoleKey.S:

                        if (player1.Position[0] > 0)
                        {
                            player1.Position[0]--;
                            //Console.WriteLine($"X: {player.position[0]}");
                            if (player1.Position[0] == hogger.Position[0] && player1.Position[1] == hogger.Position[1])
                            {
                                Console.WriteLine($"\n{player1.Name} зустрів {hogger.Name}!");
                                isMeet = true;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nВихід за межі поля");
                        }
                        continue;

                    case ConsoleKey.W:

                        if (player1.Position[0] < xSize)
                        {
                            player1.Position[0]++;
                            //Console.WriteLine($"X: {player.position[0]}");
                            if (player1.Position[0] == hogger.Position[0] && player1.Position[1] == hogger.Position[1])
                            {
                                Console.WriteLine($"\n{player1.Name} зустрів {hogger.Name}!");
                                isMeet = true;
                            }
                            break;
                        }
                        else
                            Console.WriteLine("\nВихід за межі поля");
                        continue;

                    case ConsoleKey.X: // Вихід з програми
                        isExit = true;
                        break;

                    default:
                        {
                            Console.WriteLine("\nНеправильна кнопка\n");
                        }
                        continue;
                }
            }
        } //Метод пересування гравця по полю
    }
}