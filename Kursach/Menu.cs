using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Kursach
{
    class Menu
    {
        private void RunMhetod(IGrowable i)
        {
            int _switch;
            if (i is Tree)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Собрать урожай\n" +
                                      "2. Позаботиться\n" +
                                      "3. Потрогать под вдохновляющую музыку\n" +
                                      "4. Оживить\n" +
                                      "5. Уникальный метод\n" +
                                      "0. Выход\n");
                    do
                    {
                        Console.WriteLine("");
                        int.TryParse(Console.ReadLine(), out _switch);
                    } while (_switch < 0 && _switch > 5);
                    switch (_switch)
                    {
                        case 1: { Console.WriteLine(((Tree)i).harvest_fruits()); WaitEnter(); break; }
                        case 2: { Console.WriteLine(((Tree)i).take_care_of()); WaitEnter(); break; }
                        case 3: { Console.WriteLine(((Tree)i).touchTree()); WaitEnter(); break; }
                        case 4: { Console.WriteLine(((Tree)i).reLife()); WaitEnter(); break; }
                        case 5:
                            {
                                if (i is AppleTree)
                                {
                                    ((AppleTree)i).Uni_foo();
                                    WaitEnter();
                                }
                                else if (i is PearTree)
                                {
                                    ((PearTree)i).Uni_foo();
                                    WaitEnter();
                                }
                                else if (i is LemonTree)
                                {
                                    ((LemonTree)i).Uni_foo();
                                    WaitEnter();
                                }
                                else if (i is OrangeTree)
                                {
                                    ((OrangeTree)i).Uni_foo();
                                    WaitEnter();
                                }
                                else Console.WriteLine("Что то явно не так, тут даже танцы с бубном не помогут");
                                break;
                            }
                    }

                } while (_switch != 0);
            }
            else if (i is Watermelon)
            {
                do
                {
                    Console.WriteLine("1. Собрать урожай\n"+
                                      "0. Выход");
                    do
                    {
                        int.TryParse(Console.ReadLine(), out _switch);
                    } while (_switch !=1 && _switch!=0);
                    switch (_switch)
                    {
                        case 1: { Console.WriteLine(((Watermelon)i).harvest_fruits()); break; }
                    }
                } while (_switch != 0);
            }
        }
        private int enter_obj(List<IGrowable> list)
        {
            int choise,temp=1;
            if (!list.Any()) { Console.WriteLine("Список пуст"); return 999; }
            else
            {
                Console.WriteLine("Выбирите объект:");
                foreach (IGrowable i in list)
                {
                    Console.WriteLine($"{temp}. {i.GetName()}");
                    temp++;
                }
                do
                {
                    int.TryParse(Console.ReadLine(),out choise);
                } while (choise < 0 && choise > list.Count);
                return choise-1;
            }
        }
        private Tree addObj(int i)
        {
            int age, numberFruits;
            double height;
            bool health;
            Console.WriteLine("Если дерево живое нажмите Y, если нет то N:");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Y && key.Key != ConsoleKey.N);
            if (key.Key == ConsoleKey.Y) health = true;
            else health = false;
            Console.WriteLine("\nВведите возраст дерева:");
            int.TryParse(Console.ReadLine(), out age);
            while (age <= 0)
            {
                while (true)
                {
                    Console.WriteLine("Значение введенно неверно, введите число больше нуля:");
                    if (!int.TryParse(Console.ReadLine(), out age)) ;
                    else break;
                }
            }
            if(health)
            { 
                Console.WriteLine("Введите количество фруктов на дереве:");
                int.TryParse(Console.ReadLine(), out numberFruits);
                while (numberFruits <= 0)
                {
                    while (true)
                    {
                        Console.WriteLine("Значение введенно неверно, введите число больше нуля:");
                        if (!int.TryParse(Console.ReadLine(), out age)) ;
                        else break;
                    }
                }
            }
            else numberFruits = 0;
            Console.WriteLine("Введите высоту дерева:");
            double.TryParse(Console.ReadLine(),out height);
            while (height <= 0)
            {
                while (true)
                {
                    Console.WriteLine("Значение введенно неверно, введите число больше нуля:");
                    if (!int.TryParse(Console.ReadLine(), out age)) ;
                    else break;
                }
            }
            switch (i)
                {
                    case 1: { Tree tree= new LemonTree(numberFruits,health,height,age); return tree;  }
                    case 2: { Tree tree= new AppleTree(numberFruits,health,height,age); return tree;  }
                    case 3: { Tree tree= new PearTree(numberFruits,health,height,age); return tree;  }
                    case 4: { Tree tree= new OrangeTree(numberFruits,health,height,age); return tree;  }
                    default: { Tree tree = new LemonTree(numberFruits, health, height, age); return tree; }
                }            
        }
        public void startMenu()
        {
            List<IGrowable> list = new List<IGrowable> ();
            Console.Clear();
            while(true)
            {
                int _switch;
                do
                {
                    Console.WriteLine("1. Создать новый объект класса\n" +
                                      "2. Вывод свойств объектов\n" +
                                      "3. Выполнение статического метода\n" +
                                      "4. Выполнение методов объекта\n"+
                                      "5. Вывод метода интерфейса");
                    do
                    {
                        Console.WriteLine("");
                        int.TryParse(Console.ReadLine(), out _switch);
                    } while (_switch < 1 && _switch > 4);
                    switch ( _switch ) 
                    {
                        case 1:
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Выберете какой объект класса вы хотите создать\n" +
                                                      "1. Лемонное дерево\n" +
                                                      "2. Яблоня\n" +
                                                      "3. Грушевое дерево\n" +
                                                      "4. Апельсиновое дерево\n"+
                                                      "5. Арбуз\n" +
                                                      "0. Выход");
                                    do
                                    {
                                        Console.WriteLine("");
                                        int.TryParse(Console.ReadLine(), out _switch);
                                    } while (_switch < 0 && _switch > 3);
                                    switch (_switch)
                                    {
                                        case 1: 
                                            {
                                                list.Add(addObj(1));
                                                break;
                                            }
                                        case 2: 
                                            {
                                                list.Add(addObj(2)); 
                                                break; 
                                            }
                                        case 3: 
                                            {
                                                list.Add(addObj(3)); 
                                                break; 
                                            }
                                        case 4: 
                                            {
                                                list.Add(addObj(4)); 
                                                break; 
                                            }
                                        case 5:
                                            {
                                                Watermelon watermelon = new Watermelon();
                                                list.Add(watermelon);
                                                break;
                                            }
                                    }
                                } while (_switch != 0);
                                break;
                            }
                        case 2:
                            {
                                if (!list.Any()) Console.WriteLine("Список пуст.");
                                else
                                {
                                    foreach(IGrowable i in list)
                                    {
                                        Console.WriteLine(i + "\n");
                                    }
                                }
                                WaitEnter();
                                break;
                            }
                        case 3:
                            {
                                Tree.Music();
                                WaitEnter();
                                break;
                            }
                        case 4:
                            {
                                int choise = enter_obj(list);
                                if (choise!=999)
                                RunMhetod(list.ElementAt<IGrowable>(choise));
                                WaitEnter();
                                break;
                            }
                        case 5:
                            {
                                int choise = enter_obj(list);
                                list.ElementAt<IGrowable>(choise).Grow();
                                WaitEnter();
                                break;
                            }
                        default: break;
                    }
                    Console.Clear ();
                } while (_switch!=0);
                
            }
        }
        public static void WaitEnter()
        {
            Console.WriteLine("Нажмите на Enter\n");
            Console.ReadLine();
        }
    }
}

