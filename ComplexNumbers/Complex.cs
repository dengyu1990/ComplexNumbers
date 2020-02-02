using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public Complex(int real, int imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public override string ToString() => $"({this.Real}+{this.Imaginary}i)";
        //实现加减乘除的操作符重载
        public static Complex operator +(Complex lhs, Complex rhs) => new Complex(lhs.Real + rhs.Real, lhs.Imaginary - rhs.Imaginary);
        public static Complex operator -(Complex lhs, Complex rhs) => new Complex(lhs.Real - rhs.Real, lhs.Imaginary - rhs.Imaginary);
        public static Complex operator *(Complex lhs, Complex rhs) => new Complex(lhs.Real * rhs.Real - lhs.Imaginary * rhs.Imaginary, lhs.Imaginary * rhs.Real + lhs.Real * rhs.Imaginary);
        public static Complex operator /(Complex lhs, Complex rhs)
        {
            int realElement = (lhs.Real * rhs.Real + lhs.Imaginary * rhs.Imaginary) / (rhs.Real * rhs.Real + rhs.Imaginary * rhs.Imaginary);
            int imaginaryElement = (lhs.Imaginary * rhs.Real - lhs.Real * rhs.Imaginary) / (rhs.Real * rhs.Real + rhs.Imaginary * rhs.Imaginary);
            return new Complex(realElement, imaginaryElement);
        }
        //实现==和！=的操作符重载
        public static bool operator ==(Complex lhs, Complex rhs) => lhs.Equals(rhs);
        public static bool operator !=(Complex lhs, Complex rhs) => !(lhs.Equals(rhs));
        //这种需要重写Equal方法
        public override bool Equals(object obj)
        {
            if (obj is Complex)
            {
                Complex compare = (Complex)obj;
                return (this.Real == compare.Real) && (this.Imaginary == compare.Imaginary);
            }
            else
            {
                return false;
            }
        }
        //如定义运算符 == 或运算符 !=，必须重写 Object.GetHashCode()方法
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
