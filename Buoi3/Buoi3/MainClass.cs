using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class MainClass
    {
        public static bool IsNotNumNullOrEmpty(string input)
        {
            float n;
            bool check = true;

            if (String.IsNullOrEmpty(input))
            {
                check = false;
            }

            if (!float.TryParse(input, out n))
            {
                check = false;
            }

            return check;
        }

        //Bai 1
        public static float Calculate(float num1, float num2, string mode)
        {
            float result = 0;

            switch (mode)
            {
                case "Cong":
                    {
                        result = num1 + num2;
                        break;
                    }
                case "Tru":
                    {
                        result = num1 - num2;
                        break;
                    }
                case "Nhan":
                    {
                        result = num1 * num2;
                        break;
                    }
                case "Chia":
                    {
                        result = num1 / num2;
                        break;
                    }
            }

            return result;
        }


        //Bai 2

    }
}
