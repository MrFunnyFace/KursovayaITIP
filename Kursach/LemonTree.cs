using System;

namespace Kursach

{
    [Serializable]
    sealed class LemonTree : Tree, IKurs
    {
        public LemonTree() : base() { }    

        public LemonTree(int numFruits,bool hlth,double hght,int ag) : base(numFruits,hlth,hght,ag) { Name = "�������� ������"; }

        public override string harvest_fruits()//������� ������
        {
            if (NumberFruits == 0 || Health == false)
                return Name + "\n" + base.harvest_fruits();
            else
            {
                return base.harvest_fruits() + "�������";
            }
        }
        public override string take_care_of()//������������
        { 
            return Name + "\n" + base.take_care_of();
        }

        public override string reLife()//�������
        {
            return Name + "\n" + base.reLife();
        }

        public override string touchTree()//��������� ��� ������������� ������
        { 
            return Name + "\n" + base.touchTree(); 
        }

        public string Uni_foo()//���������� ����� ������������ ������
        =>"���������� ����� ��������� ������";
        public List<Func<string>> GenerateDelegateList()
        {
            return new List<Func<string>>() { harvest_fruits, take_care_of, touchTree, reLife, Uni_foo,Grow };
        }
    }
}
