using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class MainClass
    {
        public static float calculateMoney(string type, float input, int USDorEUR)
        {
            if (type.Contains("VU") || type.Contains("VE"))
            {
                return input / USDorEUR;
            } else
            {
                return input * USDorEUR;
            }
        }

        public static String calculateYear(int first, int last)
        {
            String _first;
            String _last;

            switch (first)
            {
                case 0:
                    {
                        _first = "Canh";
                        break;
                    }
                case 1:
                    {
                        _first = "Tân";
                        break;
                    }
                case 2:
                    {
                        _first = "Nhâm";
                        break;
                    }
                case 3:
                    {
                        _first = "Quý";
                        break;
                    }
                case 4:
                    {
                        _first = "Giáp";
                        break;
                    }
                case 5:
                    {
                        _first = "Ất";
                        break;
                    }
                case 6:
                    {
                        _first = "Bính";
                        break;
                    }
                case 7:
                    {
                        _first = "Đinh";
                        break;
                    }
                case 8:
                    {
                        _first = "Mậu";
                        break;
                    }
                default:
                    {
                        _first = "Tỵ";
                        break;
                    }
            }

            switch (last)
            {
                case 0:
                    {
                        _last = "Thân";
                        break;
                    }
                case 1:
                    {
                        _last = "Dậu";
                        break;
                    }
                case 2:
                    {
                        _last = "Tuất";
                        break;
                    }
                case 3:
                    {
                        _last = "Hợi";
                        break;
                    }
                case 4:
                    {
                        _last = "Tý";
                        break;
                    }
                case 5:
                    {
                        _last = "Sửu";
                        break;
                    }
                case 6:
                    {
                        _last = "Dần";
                        break;
                    }
                case 7:
                    {
                        _last = "Mẹo";
                        break;
                    }
                case 8:
                    {
                        _last = "Thìn";
                        break;
                    }
                case 9:
                    {
                        _last = "Tỵ";
                        break;
                    }
                case 10:
                    {
                        _last = "Ngọ";
                        break;
                    }
                default:
                    {
                        _last = "Mùi";
                        break;
                    }
            }

            return _first + " " + _last;
        }

        public static int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public static int BSCNN(int a, int b)
        {
            return a*(b/USCLN(a, b));
        }
    }
}
