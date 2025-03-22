namespace LabAssignmentDay07
{
    class Utility
    {
        //Open closed principle violation - Every new shap require code change to add loop
        public static double SumOfAreasV1(Rectangle[] rects, Square[] squares)
        {
            double sum = 0;
            for (int i = 0; i < rects.Length; i++)
            {
                sum += rects[i].Area();
            }
            for (int i = 0; i < squares.Length; i++)
            {
                sum += squares[i].Area();
            }
            return sum;
        }

        // Establish open closed principle
        public static double SumOfAreasV2(Shape[] shapes)
        {
            double sum = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                sum += shapes[i].Area();
            }
            return sum;
        }
    }
}
