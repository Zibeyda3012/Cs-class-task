using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_class_task.Models
{
    internal class Fraction
    {
        public int numerator { get; set; }

        private int _denominator;
        public int denominator
        {

            get { return _denominator; }
            set
            {
                if (value != 0)
                    _denominator = value;
            }
        }

        public Fraction(int num, int don)
        {
            numerator = num;
            denominator = don;
        }

        public Fraction Add(Fraction other)
        {
            Fraction result;
            if (this.denominator == other.denominator)
                result = new Fraction(this.numerator + other.numerator, this.denominator);

            else
            {

                int new_numerator = this.numerator * other.denominator + this.denominator * other.numerator;
                int new_denominator = this.denominator * other._denominator;
                result = new Fraction(new_numerator, new_denominator);
            }

            return result;
        }


        public Fraction Subtract(Fraction other)
        {
            Fraction result;
            if (this.denominator == other.denominator)
                result = new Fraction(this.numerator - other.numerator, this.denominator);

            else
            {

                int new_numerator = this.numerator * other.denominator - this.denominator * other.numerator;
                int new_denominator = this.denominator * other._denominator;

                result = new Fraction(new_numerator, new_denominator);
            }

            return result;
        }

        public Fraction Multiply(Fraction other)
        {
            Fraction result = new Fraction(this.numerator * other.numerator, this.denominator * other.denominator);
            return result;
        }

        public Fraction Divide(Fraction other)
        {
            Fraction result = new Fraction(this.numerator * other.denominator, this.denominator * other.numerator);
            return result;
        }

        public void Simplify()
        {

            List<int> numList = new List<int>();
            List<int> donList = new List<int>();


            for (int i = 1; i < numerator; i++)
                if (numerator % i == 0)
                    numList.Add(i);

            for (int i = 1; i < denominator; i++)
                if (denominator % i == 0)
                    donList.Add(i);

            List<int> CommonNums = new List<int>();

            foreach (var item in numList)
            {
                foreach (var item2 in donList)
                    if (item == item2)
                    {
                        CommonNums.Add(item);
                        break;
                    }

            }


            int product = 1;
            foreach (var item in CommonNums)
                product *= item;

            numerator = numerator / product;
            denominator = denominator / product;


        }

        public void print()
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }
    }
}
