using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1
{
    public class Fraction : IEquatable<Fraction>, IComparable<Fraction>
    {
        public int Numerator { get; set; }
        public int Denominator { get; private set; }

        public Fraction() { }
        /// <summary>
        /// Creates a fraction based on the passed parameters. 
        /// </summary>
        /// <param name="Numerator"></param>
        /// <param name="Denominator"></param>
        /// <exception cref="ArgumentException">Throws an exception when the denominator is 0.</exception>
        public Fraction(int Numerator, int Denominator)
        {
            if (Denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(Denominator));
            }
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }
        /// <summary>
        /// Copies the previously created fraction.
        /// </summary>
        /// <param name="previousFraction"></param>
        public Fraction(Fraction previousFraction)
        {
            this.Numerator = previousFraction.Numerator;
            this.Denominator = previousFraction.Denominator;
        }
        /// <summary>
        /// Operators overload
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Fraction operator +(Fraction a)
        {
            return a;
        }
        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.Numerator, a.Denominator);
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + (-b);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Numerator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }
        /// <summary>
        /// Returns a string representation of the fraction.
        /// </summary>
        /// <returns>Returns a string representation of the fraction</returns>
        public override string ToString()
        {
            return $"{Numerator} / {Denominator}";
        }

        /// <summary>
        /// Checks if two fractions are equal.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Returns true when object passed as parameter is equal to the object on which the method was called, and false when it's not.</returns>
        public bool Equals(Fraction other)
        {
            if (other == null)
                return false;
            if (this.Numerator * other.Denominator == other.Numerator * this.Denominator)
            return true;
            else
            return false;
        }
        /// <summary>
        /// It is used to sort an array of fractions.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Returns -1 when (a > b), returns 0 when (a == b), returns 1 when (a < b).</returns>
        public int CompareTo(Fraction other)
        {
            if (other == null) return 1;

            int check = ((this.Numerator * other.Denominator) - (other.Numerator * this.Denominator));

            if (check > 0)
                return 1;
            else if (check == 0)
                return 0;
            else return -1;
        }
        /// <summary>
        /// Rounds up the number to the next integer greater than the fraction.
        /// </summary>
        /// <returns>Returns double value of the rounded number.</returns>
        public double RoundUp()
        {
            double Rounded = Convert.ToDouble(this.Numerator) / Convert.ToDouble(this.Denominator);
            return Math.Ceiling(Rounded);
        }
        /// <summary>
        /// Rounds down the number to the next integer greater than the fraction.
        /// </summary>
        /// <returns>Returns double value of the rounded number.</returns>
        public double RoundDown()
        {
            double Rounded = Convert.ToDouble(this.Numerator) / Convert.ToDouble(this.Denominator);
            return Math.Floor(Rounded);
        }

    }
}
