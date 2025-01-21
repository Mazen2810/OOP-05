using Assignment.First_Project;
using Assignment.Second_Project;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project
            // int X1 = GetValidInteger("Enter X1: ");
            // int Y1 = GetValidInteger("Enter Y1: ");
            // int Z1 = GetValidInteger("Enter Z1: ");
            // int X2 = GetValidInteger("Enter X2: ");
            // int Y2 = GetValidInteger("Enter Y2: ");
            // int Z2 = GetValidInteger("Enter Z2: ");

            // Point3D P1 = new Point3D(X1, Y1, Z1);
            // Point3D P2 = new Point3D(X2, Y2, Z2);

            //if(P1 == P2)
            // {
            //     Console.WriteLine("Yes");
            // }
            //else
            //     Console.WriteLine("No");


            //Point3D[] Point = new Point3D[3];
            //Point[0] = new Point3D(1, 2, 3);
            //Point[1] = new Point3D(10, 20, 30);
            //Point[2] = new Point3D(5, 22, 32);

            //Array.Sort(Point);
            //foreach(Point3D point in Point)
            //{
            //    Console.WriteLine(point);
            //}

            //Point3D P1 = new Point3D(10,20,30);

            //Point3D P2 = new Point3D();
            //P2 = (Point3D) P1.Clone();

            //Console.WriteLine(P2); 
            #endregion

            #region Second Project
            //int X = Maths.Add(10, 20);
            //Console.WriteLine(X);
            // X = Maths.Subtract(10, 20);
            //Console.WriteLine(X);
            // X = Maths.Multiply(10, 20);
            //Console.WriteLine(X);
            // X = Maths.Divide(10, 20);
            //Console.WriteLine(X);
            #endregion
        }
        public static int GetValidInteger(string Message)
        {
            int result;
            bool isValid;
            do
            {
                Console.Write(Message);
                isValid = int.TryParse(Console.ReadLine(), out result);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            } while (!isValid);

            return result;
        }
    }
    
}
