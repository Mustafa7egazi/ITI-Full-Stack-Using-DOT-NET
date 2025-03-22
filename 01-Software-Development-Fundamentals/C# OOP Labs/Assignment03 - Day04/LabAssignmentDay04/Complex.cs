using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentDay03
{
    public class Complex
    {

        private int real;
        private int img;

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

            if (img < 0 && img != -1 && real != 0)
            {
                return $"{real}{img}i";
            }
            else if (img < 0 && img != -1 && real == 0)
            {
                return $"{img}i";
            }
            else if (img < 0 && img == -1 && real == 0)
            {
                return $"-i";
            }
            else if (img == 0 && real != 0)
            {
                return $"{real}";
            }
            else if (real == 0 && img != 0 && img != 1)
            {
                return $"{img}i";
            }
            else if (real == 0 && img == 1)
            {
                return $"i";
            }
            else if (img == 1)
            {
                return $"{real}+i";
            }
            else if (img == -1)
            {
                return $"{real}-i";
            }
            else if (real == 0 && img == 0)
            {
                return "0";
            }
            else
            {
                return $"{real}+{img}i";
            }

        }

    }
}

