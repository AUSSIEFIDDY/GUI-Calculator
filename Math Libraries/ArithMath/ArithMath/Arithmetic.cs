using System;

/**
 * ArithMath Library
 * Author:  Thomas Green
 * ID:      P460247
 * Date:    01/04/2019
 * Version: 1.0 
 */

namespace ArithMath
{

    /**
    * Arithmetic Class
    * 
    * Author:   Thomas Green
    * Date:     01/04/2019
    * Version:  1.0 
    */

    public class Arithmetic
    {
        //Add Method that returns a double
        public static double Add(double a, double b)
        {
            return (a + b);
        }

        //Subtract Method that returns a double
        public static double Sub(double a, double b)
        {
            return (a - b);
        }

        //Divide Method that returns a double or 
        //returns NaN if the user divides by zero
        public static double Div(double a, double b)
        {
            if (a != 0 && b != 0)
                return ((double)a / b);
            else
                return double.NaN;
        }

        //Multiply Method that returns a double
        public static double Mult(double a, double b)
        {
            return (a * b);
        }
    }
}
