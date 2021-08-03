using System;

namespace SafariParkApp
{
    public class Program
    {
        static void Main(string[] args)
        {


            //Person Snow = new Person("Snow", "daProduct", 65);
            //Console.WriteLine(Snow.GetFullName());

            //Person Katch = new Person("Katch", "emall", 25);
            //Console.WriteLine(Katch.GetFullName());

            //Console.WriteLine(Katch.Age);

            //Person TestPers = new Person("Testi");
            //Console.WriteLine(TestPers.GetFullName());
            //Console.WriteLine(TestPers.Age);

            //Person Terry = new Person("Terry", "Crews");

            //Katch.Age = 30;

            //Console.WriteLine($"Katch is { Katch.Age}");

            ////Console.WriteLine(Katch.FullName);

            ////Person Lock = new Person("nick", "lock");
            ////Console.WriteLine(Lock.Age);

            //var zoe = new Person("zoe", "okidoki") {Age = 31 };

            //Console.WriteLine(zoe.Age);
            //Console.WriteLine(zoe.GetFullName());


            var list = new ShoppingList()
            {
                Bread = 2,
                Potato = 6,
                Milk = 2
            };


            var paula = new Person() { FirstName = "paula", LastName = "Kendra", Age = 23 };


            Point3d point = new Point3d(3, 6, 2);
            var p2 = new Point3d();
            Point3d p3;
            Point3d p4 = new Point3d(1, 7);


            Person john = new Person("Johnny", "Uhta") { Age = 27 };
            Point3d pt3d =  new Point3d(3,9,6);

            DemoMethod(pt3d, john);

            //Console.WriteLine("Point X: " + point.x) ;
        }

        public struct Point3d 
        {
            public int x;
            public int y, z;

            public Point3d(int x, int y, int z = 5) 
            {
                this.x = x;
                this.y= y;
                this.z = z;
            }


            
        }


        static void DemoMethod(Point3d pt, Person p) 
        {
            pt.y = 10000;
            p.Age = 54;

        }
    }
}
