using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseStatic
{
    class Math
    {
        public Math()
        {

        }

        public void outInteger(out int num1, int num2)
        {
            num1 = num2 / 2;
        }
        
        public void outParameter(int num3, out int num4)
        {
            int result = num3 * 10 / 3;
            num4 = result;
        }

        public void outParameter(decimal num5, out int num6)
        {
            int result = Convert.ToInt32(num5 * 10 / 2);
            num6 = result;
        }
    }
}
