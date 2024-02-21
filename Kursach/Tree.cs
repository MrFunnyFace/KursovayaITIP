using System;

namespace Kursach
{
    [Serializable]
    public abstract class Tree : IGrowable
    {
        string IGrowable.GetName()
        {
            return Name;
        }
        public string Grow() 
        {
            if (Health)
            {
                if (NumberFruits != 0)
                {
                    return "Собиритите сначала плоды которые уже выросли";
                }
                else
                {
                    Random random = new Random();
                    NumberFruits = random.Next(50, 1000);
                }
                return $"Можно собрать - {NumberFruits} фруктов.";
            }
            else return "Дерево мертво, что то вырастить невозможно(*)_(*)";
        }
        protected int NumberFruits { get; set; }//количество фруктов
        public bool Health { get; set; }//здоровье(Живое не живое)
        public double Height { get; set; }//высота
        public int Age { get; set; }  //возраст
        private enum _Music { Vivaldi, Poganini, Mozart }//спсиок музыки

        private string name{ get; set; }
        public string Name{ get { return name; } set { name = value; } }


        public Tree() { NumberFruits = 0; Health = false;Height = 0; Age = 0; } //конструктор объекта класса 
        public Tree(int numFruits, bool hlth, double hght, int ag) //конструктор объекта класса с переменными
        {
            NumberFruits = numFruits;
            Health = hlth;
            Height = hght;
            Age = ag;
        }
        public Tree(Tree Tree) //конструктор класса копирующий объект класса
        {
            NumberFruits = Tree.NumberFruits;
            Health = Tree.Health;
            Height = Tree.Height;
            Age = Tree.Age;
        }

        public override string ToString()// перегрузка ToString для вывода свойств объекта
        {
            string info = string.Format("Количество фруктов - {0,1}\nЗдоровье - {1}\nВысота - {2}\nВозраст - {3}\n", NumberFruits, Health ? "живое" : "мертвое", Height, Age);
            return Name + "\n" + info;
        }

        public virtual string harvest_fruits()//собрать урожай
        {
            string answ =  $"Было собрано {NumberFruits} ";
            if (Health == false)
            {
                answ = "Дерево мертво урожая нет.\n";
            }
            else
            {
                if (NumberFruits == 0)
                {
                    answ = "Фруктов на дереве нет\n";
                }
                NumberFruits = 0;
            }
            return answ;
        }

        public virtual string take_care_of()//позаботиться
        {
            string answ;
            if (Health == false)
            {
                answ = "Смысл заботиться о не живом дереве\n";
            }
            else
                answ = "Дереву приятно\n";
            return answ;
        }

        public static string Music()//получить название идеальной композиции для прогулки между деревьями
        =>string.Format("Лучшая композиция композитора {0}, под нее и прогуляться между деревьев не грех", _Music.Vivaldi);
 




        public virtual string touchTree() //потрогать под вдохновляющюю музыку
        {
            string answ, music = string.Format("Во время всего процесса играет вдохновляющая музыка {0}\n", _Music.Mozart);
            if (Health == true)
            {
                answ = "Обнимашки с деревом, вы ощутили силу земли(+ 100 к HP для вас) ";

            }
            else
            {
                answ = "Оно мертвое...Извращенец!\n";
            }
            return answ + music;
        }

        public virtual string reLife()//оживить
        {
            string answ = "Магия крч, дерево живое";
            if (Health == false)
                Health = true;
            else
                answ = "Ну тут как бы это, оно и так живое.В следующий раз думай куда тыкаешь!";
            return answ;
        }
    }
}

/*Варианты свойств: количество плодов, возраст, высота, здоровье. 
Варианты методов: собрать урожай, позаботиться, потрогать под вдохновляющую музыку, получить название идеальной композиции для прогулки меж деревьев (статический). 
*/