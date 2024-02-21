﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kursach
{
    [Serializable]
    class Watermelon : IGrowable, IMakeJuice, IKurs
    {
        public string MakeJuice()
        {
            if (_is)
            {
                ;
                return "Вы сорвали 2 яблока, и сделали себе фреш.";
            }
            else return "На дереве нету фруктов, что бы сделать сок";
        }
        string IGrowable.GetName()
        {
            return "Арбуз";
        }
        private bool _is;
        public Watermelon() 
        {
            _is = false;
        }
        public string Grow() 
        {
            if (!_is)
            {
                _is = true;
                return "Вы вырастили арбуз его можно сорвать.";
            }
            else
                return "Арбуз уже вырос его можно сорвать.";
        }

        public string harvest_fruits()
        {
            string answ;
            if (!_is) { answ = "Вырастите сначала арбуз, что бы его сорвать."; }
            else { _is = false; answ = "Вы срезали арбуз."; }
            return answ;
        }

        public override string ToString()
        {
            return string.Format("Арбуз\n {0}",_is?"живой":"не живой");
        }
        public List<Func<string>> GenerateDelegateList()
        {
            return new List<Func<string>>() { harvest_fruits, Grow , MakeJuice };
        }

    }
}
