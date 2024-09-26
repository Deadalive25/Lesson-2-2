/*Сделать небольшой каталог пользователей (от 3 до 5)
С консоли вводятся данные о пользователе (не менее двух вариантов)
данные записываются в массив (либо двумерный, либо массив массивов, либо несколько разных массивов)
По окончанию запросить у пользователя какого человека он хочет вывести */

namespace Lesson_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] users = new string[3,2];
            Console.WriteLine("Введите данные пользователей");

            try
            {
                Console.WriteLine("Пользователь 1");
                Console.WriteLine("Фамилия:");
                users[0, 0] = Console.ReadLine();
                Console.WriteLine("Имя:");
                users[0, 1] = Console.ReadLine();

                Console.WriteLine("Пользователь 2");
                Console.WriteLine("Фамилия:");
                users[1, 0] = Console.ReadLine();
                Console.WriteLine("Имя:");
                users[1, 1] = Console.ReadLine();

                Console.WriteLine("Пользователь 3");
                Console.WriteLine("Фамилия:");
                users[2, 0] = Console.ReadLine();
                Console.WriteLine("Имя:");
                users[2, 1] = Console.ReadLine();

                Console.WriteLine("Какого пользователя вы хотите запросить? (1,2,3)?");





            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                // обработка исключения
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            
        }
    }
}