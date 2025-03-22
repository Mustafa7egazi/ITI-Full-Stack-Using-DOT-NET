using LabAssignmentDay07.EarlyBinding;
using Late = LabAssignmentDay07.LateBinding;

namespace LabAssignmentDay07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("================== Lab Assignment - Day07 ====================");
            Console.WriteLine("==============================================================");

            #region Try Early Binding VS Late Binding
            ///* Start with Early */
            //Console.WriteLine("\n\n=========================== Early Example ===========================");
            //Parent parent = new Parent("Mike");
            //Console.WriteLine(parent.SayMyName());
            //Child child = new Child("John");
            //Console.WriteLine(child.SayMyName());
            //SubChild subChild = new SubChild("Hossam");
            //Console.WriteLine(subChild.SayMyName());
            //Child child2 = new SubChild("Maged");
            //Console.WriteLine(child2.SayMyName());


            ///* End with Late */
            //Console.WriteLine("\n\n=========================== Late Example ===========================");
            //Late.Parent p = new Late.SubChild("Ali");
            //Console.WriteLine(p.SayMyName());
            //Late.Child c = new Late.SubChild("Hossam");
            //Console.WriteLine(c.SayMyName());

            #endregion

            #region Try Sum of areas from utility

            //Rectangle[] rects =
            //{
            //    new Rectangle{
            //        Dim1 = 3, Dim2 = 4,
            //    },
            //    new Rectangle{
            //        Dim1=5, Dim2 = 6,
            //    }
            //};

            //Square[] squares =
            //{
            //    new Square{ Dim1 = 3 },
            //    new Square{ Dim1 = 4 }
            //};

            ///*poor version*/
            //Console.WriteLine($"Total areas:{Utility.SumOfAreasV1(rects, squares)}");

            //// after adding new shap and used enhanced version
            
            //Shape[] shapes = [rects[0], rects[1], squares[0], squares[1]];
            
            //Console.WriteLine($"Total areas enhanced:{Utility.SumOfAreasV2(shapes)}");

            #endregion

        }
    }
}
