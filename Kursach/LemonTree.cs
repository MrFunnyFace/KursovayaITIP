using System;

namespace Kursach

{
    [Serializable]
    sealed class LemonTree : Tree, IKurs
    {
        public LemonTree() : base() { }    

        public LemonTree(int numFruits,bool hlth,double hght,int ag) : base(numFruits,hlth,hght,ag) { Name = "Ћемонное дерево"; }

        public override string harvest_fruits()//собрать урожай
        {
            if (NumberFruits == 0 || Health == false)
                return Name + "\n" + base.harvest_fruits();
            else
            {
                return base.harvest_fruits() + "лемонов";
            }
        }
        public override string take_care_of()//позаботитьс€
        { 
            return Name + "\n" + base.take_care_of();
        }

        public override string reLife()//оживить
        {
            return Name + "\n" + base.reLife();
        }

        public override string touchTree()//потрогать под вдохновл€ющюю музыку
        { 
            return Name + "\n" + base.touchTree(); 
        }

        public string Uni_foo()//уникальный метод производного класса
        =>"”никальный метод лемонного дерева";
        public List<Func<string>> GenerateDelegateList()
        {
            return new List<Func<string>>() { harvest_fruits, take_care_of, touchTree, reLife, Uni_foo,Grow };
        }
    }
}
