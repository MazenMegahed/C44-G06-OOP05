namespace AssignmentOOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //1-a
            //2 - a
            //3 - b
            //4 - b
            //5 - d
            //6 - a
            //7 - b
            //8 - a
            //9 - b
            //10 - c
            #endregion

            #region part 2 -Q1
           ICircle circle = new Circle();
            circle.displayshapeinfo();
            IRectangle rectangle = new Rectangle();
            rectangle.displayshapeinfo();
            #endregion

        }
        interface IShape
        {
            public double Area { get; set; }
            public void displayshapeinfo();

        }
        interface ICircle : IShape
        {



        }
        interface IRectangle : IShape
        {

        }
        class Circle : ICircle
        {
            public double Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void displayshapeinfo()
            {
                Console.WriteLine(  "This is Circle");            }
        }
        class Rectangle : IRectangle
        {
            public double Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void displayshapeinfo()
            {
                Console.WriteLine(  "This is Rectangle");
            }
        }
    }

}
