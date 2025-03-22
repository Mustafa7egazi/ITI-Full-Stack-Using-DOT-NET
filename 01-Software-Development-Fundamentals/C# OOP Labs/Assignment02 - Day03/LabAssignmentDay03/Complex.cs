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

        public void SetReal(int _real)
        {
            real = _real;
        }
        public int GetReal()
        {
            return real;
        }
        public void SetImg(int _img)
        {
            img = _img;
        }
        public int GetImg()
        {
            return img;
        }


        public string Print()
        {

            if (img < 0 && img != -1 && real!=0)
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
            else if (real == 0 && img != 0 && img !=1)
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



        public Complex Add(Complex right)
        {
            Complex result = new Complex();
            result.real = real + right.real;
            result.img = img + right.img;
            return result;
        }

    }
}

