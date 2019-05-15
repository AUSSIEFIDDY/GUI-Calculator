using System;

/**
 * AlgebraicMath Library
 * Author:  Thomas Green
 * ID:      P460247
 * Date:    01/04/2019
 * Version: 1.0 
 */

namespace AlgebraicMath
{

    /**
    * Algebraic Class
    * 
    * Author:   Thomas Green
    * Date:     01/04/2019
    * Version:  1.0 
    */

    public class Algebraic
    {
        //Square Root Method that returns a double
        public static double Sqrt(double a)
        {
            var root = a / 3;
            for (int i = 0; i < 32; i++)
                root = (root + a / root) / 2;

            return root;
        }

        //Cube Root Method that returns a double
        public static double Cbrt(double a)
        {
            if (a.Equals(1.0))
                return a;

            var value = Sqrt(Sqrt(a));
            return value * Cbrt(value);
        }

        //Inverse Method that returns a double
        public static double Inv(double a)
        {
            if (a != 0)
                return (1 / a);
            else
                return 0;
        }
    }
}
