using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TextBosses
{
    Random random = new Random();
    public string NameBosses;
    public void text(int countbosses)
    {
        if (countbosses == 1)
        {
            NameBosses = "Пожиратель белка";
            int a = random.Next(0, 3);
            switch (a)
            {
                case 0:
                    Console.WriteLine("ну привет, к сожалению, мне придется добыть с тебя белок");
                    break;
                case 1:
                    Console.WriteLine("принес белка?");
                    break;
                case 2:
                    Console.WriteLine("пришло время собрать немного белка");
                    break;
            }
        }
        if (countbosses == 2)
        {
            NameBosses = "Ало";
            int a = random.Next(0, 3);
            switch (a)
            {
                case 0:
                    Console.WriteLine("ало? здесь кто-нибудь есть?");
                    break;
                case 1:
                    Console.WriteLine("ало, кто здесь?");
                    break;
                case 2:
                    Console.WriteLine("куда я попал? ало?");
                    break;
            }
        }
        if (countbosses == 3)
        {
            NameBosses = "Мистер кирпич";
            int a = random.Next(0, 3);
            switch (a)
            {
                case 0:
                    Console.WriteLine("сейчас проверим тебя на прочность");
                    break;
                case 1:
                    Console.WriteLine("посмотрим, кто из нас больше шлакоблок");
                    break;
                case 2:
                    Console.WriteLine("к великому сожалению, я мастер по дробящему оружию");
                    break;
            }
        }
        if (countbosses == 4)
        {
            NameBosses = "Огромная сопля";
            int a = random.Next(0, 3);
            switch (a)
            {
                case 0:
                    Console.WriteLine("Гплрлрр-олпрг!");
                    break;
                case 1:
                    Console.WriteLine("Лврлгрлоалг гварлирол!");
                    break;
                case 2:
                    Console.WriteLine("Бульк");
                    break;
            }
        }
    }
}