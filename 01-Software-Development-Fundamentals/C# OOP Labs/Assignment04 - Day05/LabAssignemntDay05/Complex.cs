using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentDay03
{
    public class Complex
    {

        private int real;
        private int img;


        #region NEW UPDATE - Operator overloading
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = left.Real + right.Real,
                Img = left.Img + right.Img
            };
        }

        public static Complex operator ++(Complex left)
        {
            return new Complex()
            {
                // Mathematically wrong - we just try a concept
                Real = left.real + 1,
                Img = left.img + 1
            };
        }

        public static Complex operator +(Complex left, int num)
        {
            return new Complex
            {
                Real = left.Real + num,
                Img = left.Img
            };
        }

        public static Complex operator +(int num, Complex left)
        {
            return new Complex
            {
                Real = left.Real + num,
                Img = left.Img
            };
        }

        public static bool operator >(Complex left, Complex right)
        {
            return left.Real > right.Real && left.Img > right.Img;
        }

        public static bool operator <(Complex left, Complex right)
        {
            return left.Real <  right.Real && left.Img < right.Img;
        }

        // casting int
        public static implicit operator int (Complex c)
        {
            return c.Real;
        }

        #endregion


        #region Simple Normal Property
        public int Real { get; set; }
        public int Img { get; set; }
        #endregion

        #region Spreaded Property if validation needed
        //public int Real
        //{
        //    get
        //    {
        //        return real;
        //    }
        //    set
        //    {
        //        real = value;
        //    }
        //}
        //public int Img
        //{
        //    get
        //    {
        //        return img;
        //    }
        //    set
        //    {
        //        img = value;
        //    }
        //}
        #endregion

        #region Parameterless CTOR
        public Complex()
        {
            real = 3;
            img = 4;
        }
        #endregion

        #region Parameterized CTOR - used this keyword inside also
        public Complex(int real, int img)
        {
            this.real = real;
            this.img = img;
        }
        #endregion

        #region Using this KEYWORD inside Adding method
        public Complex Add(Complex right)
        {
            Complex result = new Complex();
            result.real = this.real + right.real;
            result.img = this.img + right.img;
            return result;
        }
        #endregion


        public string Print()
        {

            if (Img < 0 && Img != -1 && Real != 0)
            {
                return $"{Real}{Img}i";
            }
            else if (Img < 0 && Img != -1 && Real == 0)
            {
                return $"{Img}i";
            }
            else if (Img < 0 && Img == -1 && Real == 0)
            {
                return $"-i";
            }
            else if (Img == 0 && Real != 0)
            {
                return $"{Real}";
            }
            else if (Real == 0 && Img != 0 && Img != 1)
            {
                return $"{Img}i";
            }
            else if (Real == 0 && Img == 1)
            {
                return $"i";
            }
            else if (Img == 1)
            {
                return $"{Real}+i";
            }
            else if (Img == -1)
            {
                return $"{Real}-i";
            }
            else if (Real == 0 && Img == 0)
            {
                return "0";
            }
            else
            {
                return $"{Real}+{Img}i";
            }

        }

    }
}

