using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Card()
    {
        public string mast = "";
        public string kart = "";
        public void Mast(byte n)
        {
            switch (n)
            {
                case 1:
                    mast = "Пика";
                    break;
                case 2:
                    mast = "Червь";
                    break;
                case 3:
                    mast = "Буба";
                    break;
                case 4:
                    mast = "Крести";
                    break;
                default:
                    mast = "Нет такой масти";
                    break;
            }
        }
        public void Kart(byte k)
        {
            switch (k)
            {
                case 6:
                    kart = "Шестёрка";
                    break;
                case 7:
                    kart = "Семёрка";
                    break;
                case 8:
                    kart = "Воьсмёрка";
                    break;
                case 9:
                    kart = "Девятка";
                    break;
                case 10:
                    kart = "Десятка";
                    break;
                case 11:
                    kart = "Валет";
                    break;
                case 12:
                    kart = "Дама";
                    break;
                case 13:
                    kart = "Король";
                    break;
                case 14:
                    kart = "Туз";
                    break;
                default:
                    Console.WriteLine("Нет такой карты");
                    break;
            }
        }
    }
}
