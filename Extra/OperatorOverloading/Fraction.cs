using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public readonly struct Fraction
    {

        private readonly int num;
        private readonly int den;

        public Fraction(int numerator, int denomitor)
        {
            if (denomitor == 0) throw new ArgumentException("Denomitor cannot be zero.", nameof(denomitor));

            num = numerator;
            den = denomitor;
        }
        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.num, a.den);
        public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
        public static Fraction operator -(Fraction a, Fraction b) => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.num * b.num, a.den * b.den);
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0) throw new DivideByZeroException();
            return new Fraction(a.num * b.den, a.den * b.num);
        }
        public override string ToString() => $"{num}/{den}";
    }
}
