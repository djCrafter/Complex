using System;

namespace Complex
{
    class Complex
    {
        double real, i;

        public Complex()
        {
            this.real = 0.0;
            this.i = 0.0;
        }

        public Complex(double real, double i)
        {
            this.real = real;
            this.i = i;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.real = a.real + b.real;
            res.i = a.i + b.i;
            return res;
        }

        public static Complex operator -(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.real = a.real - b.real;
            res.i = a.i - b.i;
            return res;
        }

        public static Complex operator *(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.real = a.real * b.real - a.i * b.i;
            res.i = a.i * b.real + a.real * b.i;
            return res;
        }

        public static Complex operator /(Complex a, Complex b)
        {
            double Denominator = b.real * b.real + b.i * b.i;
            return new Complex((a.real * b.real + a.i * b.i) / Denominator,
                (b.real * a.i - b.i * a.i) / Denominator);
        }

        public static bool operator ==(Complex a, Complex b)
        {
            return a.real == b.real && a.i == b.i;
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return c1.real != c2.real || c1.i != c2.i;
        }

        public override string ToString()
        {
            return String.Format("{0} + i{1}", this.real, this.i);
        }
    }

}
