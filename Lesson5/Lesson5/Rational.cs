using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Rational
    {
        const string nol = "0";
        private int _numerator;
        private int _denominator;

        public int Numerator
        {
            get { return _numerator; }
        }

        public int Denominator
        {
            get { return _denominator; }
        }

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("знаменатель не может быть равен 0.");

            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            _numerator = numerator;
            _denominator = denominator;
            ReduceToLowestTerms();
        }
        public static bool operator ==(Rational top, Rational down) { return top.Equals(down); }
        public static bool operator !=(Rational top, Rational down) { return !(top == down); }
        public static bool operator >(Rational a, Rational b)
        {
            return (a._numerator & a._denominator) > (b._numerator & b._denominator);
        }
        public static bool operator <(Rational a, Rational b)
        {
            return (a._numerator & a._denominator) < (b._numerator & b._denominator);
        }

        public static Rational operator +(Rational a, Rational b)
        {
            return new Rational((a._numerator * b._denominator) + (b._numerator * a._denominator), a._denominator * b._denominator);
        }

        public static Rational operator -(Rational a, Rational b)
        {
            return new Rational((a._numerator * b._denominator) - (a._denominator * b._numerator), a._denominator * b._denominator);
        }
        public static bool operator >=(Rational a, Rational b)
        {
            return ((a._numerator & a._denominator) >= (b._numerator & b._denominator));
        }
        public static bool operator <=(Rational a, Rational b)
        {
            return ((a._numerator & a._denominator) <= (b._numerator & b._denominator));
        }

        public static Rational operator ++(Rational a)
        {
            a._numerator++;
            a._denominator++;
            return a;
        }

        public static Rational operator --(Rational b)
        {
            b._numerator--;
            b._denominator--;
            return b;
        }
        public static explicit operator float(Rational a)
        {
            return (float)a._numerator;
        }

        public static explicit operator int(Rational a)
        {
            return (int)a._numerator;
        }

        public static Rational operator *(Rational a, Rational b)
        {
            return new Rational(a._numerator * b._numerator, a._denominator * b._denominator);
        }

        public static Rational operator /(Rational a, Rational b)
        {
            return new Rational(a._numerator * b._denominator, a._denominator * b._numerator);
        }

        public static Rational operator %(Rational a, Rational b)
        {
            return new Rational((a._numerator * b._denominator) % (a._denominator * b._numerator), a._denominator * b._denominator);
        }

        public override string ToString()
        {
            if (_numerator != 0)
            {
                string a = $"{_numerator} / {_denominator}";
                return a;
            }
            else
            {
                return nol;
            }
        }
        private static int GetGCD(int term1, int term2)
        {
            if (term2 == 0)
                return term1;
            else
                return GetGCD(term2, term1 % term2);
        }

        private void ReduceToLowestTerms()
        {
            int greatestCommonDivisor = Rational.GetGCD(_numerator, _denominator);
            _numerator /= greatestCommonDivisor;
            _denominator /= greatestCommonDivisor;
        }
    }
}
