﻿using System;

namespace Kursach
{
    [Serializable]
    class OrangeTree : Tree, IKurs
    {
        public OrangeTree() : base() { }
        public OrangeTree(string nme, int numFruits, bool hlth, double hght, int ag) : base(nme,numFruits, hlth, hght, ag) { Name = "Апельсиновое дерево"+" - "+nme; }
        public override string harvest_fruits()//собрать урожай
        {
            if (NumberFruits == 0 || Health == false)
                return Name + "\n" + base.harvest_fruits();
            else
            {
                return base.harvest_fruits() + "апельсинов";
            }
        }
        public override string take_care_of()//позаботиться
        {
            return Name + "\n" + base.take_care_of();
        }

        public override string reLife()//оживить
        {
            return Name + "\n" + base.reLife();
        }

        public override string touchTree()//потрогать под вдохновляющюю музыку
        {
            return Name + "\n" + base.touchTree();
        }

        public string Uni_foo()//уникальный метод производного класса
        =>"Уникальный метод апельсинового дерева";
        public List<Func<string>> GenerateDelegateList()
        {
            return new List<Func<string>>() {harvest_fruits,take_care_of,touchTree,reLife,Uni_foo,Grow };
        }
    }
}
