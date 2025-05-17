using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    public class BigNumber : IComparable<BigNumber>
    {
        public double Mantissa { get; private set; }
        public int Exponent { get; private set; }

        public BigNumber(double mantissa, int exponent)
        {
            Normalize(mantissa, exponent);
        }

        public BigNumber(double value)
        {
            if (value == 0)
            {
                Mantissa = 0;
                Exponent = 0;
            }
            else
            {
                int exp = (int)Math.Floor(Math.Log10(Math.Abs(value)));
                double man = value / Math.Pow(10, exp);
                Normalize(man, exp);
            }
        }

        private void Normalize(double mantissa, int exponent)
        {
            if (mantissa == 0)
            {
                Mantissa = 0;
                Exponent = 0;
                return;
            }

            while (Math.Abs(mantissa) >= 10)
            {
                mantissa /= 10;
                exponent++;
            }

            while (Math.Abs(mantissa) < 1)
            {
                mantissa *= 10;
                exponent--;
            }

            Mantissa = mantissa;
            Exponent = exponent;
        }

        // Операторы
        public static BigNumber operator +(BigNumber a, BigNumber b)
        {
            if (a.Exponent == b.Exponent)
                return new BigNumber(a.Mantissa + b.Mantissa, a.Exponent);

            var diff = Math.Abs(a.Exponent - b.Exponent);

            if (diff > 15)
                return a.Exponent > b.Exponent ? new BigNumber(a.Mantissa, a.Exponent) : new BigNumber(b.Mantissa, b.Exponent);

            if (a.Exponent > b.Exponent)
                return new BigNumber(a.Mantissa + b.Mantissa * Math.Pow(10, b.Exponent - a.Exponent), a.Exponent);
            else
                return new BigNumber(a.Mantissa * Math.Pow(10, a.Exponent - b.Exponent) + b.Mantissa, b.Exponent);
        }

        public static BigNumber operator -(BigNumber a, BigNumber b)
        {
            return a + (-b);
        }

        public static BigNumber operator -(BigNumber b)
        {
            return new BigNumber(-b.Mantissa, b.Exponent);
        }

        public static BigNumber operator *(BigNumber a, BigNumber b)
        {
            return new BigNumber(a.Mantissa * b.Mantissa, a.Exponent + b.Exponent);
        }

        public static BigNumber operator /(BigNumber a, BigNumber b)
        {
            return new BigNumber(a.Mantissa / b.Mantissa, a.Exponent - b.Exponent);
        }

        public static bool operator >(BigNumber a, BigNumber b) => a.CompareTo(b) > 0;
        public static bool operator <(BigNumber a, BigNumber b) => a.CompareTo(b) < 0;
        public static bool operator >=(BigNumber a, BigNumber b) => a.CompareTo(b) >= 0;
        public static bool operator <=(BigNumber a, BigNumber b) => a.CompareTo(b) <= 0;

        public int CompareTo(BigNumber other)
        {
            if (Exponent == other.Exponent)
                return Mantissa.CompareTo(other.Mantissa);

            return Exponent.CompareTo(other.Exponent);
        }

        // Форматы
        public string ToScientific(int digits = 3)
        {
            return Mantissa.ToString("0." + new string('#', digits - 1)) + "e" + Exponent;
        }

        public string ToSuffix()
        {
            string[] suffixes = { "", "K", "M", "B", "T", "Qa", "Qi", "Sx", "Sp", "Oc", "No", "Dc" };

            int group = Exponent / 3;
            if (group < suffixes.Length)
            {
                double value = Mantissa * Math.Pow(10, Exponent % 3);
                return value.ToString("0.##") + " " + suffixes[group];
            }
            else
            {
                return ToScientific(); // если превышает Dc
            }
        }

        public override string ToString() => ToScientific();
    }
}
