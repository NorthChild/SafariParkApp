using System;
using System.Collections.Generic;

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


            //var list = new ShoppingList()
            //{
            //    Bread = 2,
            //    Potato = 6,
            //    Milk = 2
            //};


            //var paula = new Person() { FirstName = "paula", LastName = "Kendra", Age = 23 };


            //Point3d point = new Point3d(3, 6, 2);
            //var p2 = new Point3d();
            //Point3d p3;
            //Point3d p4 = new Point3d(1, 7);


            //Person john = new Person("Johnny", "Uhta") { Age = 27 };
            //Point3d pt3d =  new Point3d(3,9,6);

            //DemoMethod(pt3d, john);

            ////Console.WriteLine("Point X: " + point.x) ;

            ////// INHERITANCE EXAMPLES
            //Hunter hunterMan = new Hunter("Nick", "Stolkes", "Canon") { Age = 32 };

            //var h2 = new Hunter("marion", "jones", "leica") { Age = 32 };

            //Console.WriteLine($"h Equals h2? {hunterMan.Equals(h2)}");
            //Console.WriteLine($"h HashCodel : {hunterMan.GetHashCode()}");
            //Console.WriteLine($"h Type : {hunterMan.GetType()}");
            //Console.WriteLine($"h ToString : {hunterMan.ToString()}");

            //Console.WriteLine("#################");

            //Console.WriteLine(hunterMan.GetFullName());
            //Console.WriteLine(hunterMan.Age);
            //Console.WriteLine(hunterMan.Shoot());


            //Hunter emptyHunter = new Hunter();

            //Console.WriteLine(emptyHunter.Shoot());
            //Console.WriteLine($"hunterMan: {hunterMan}");


            //// abstract and sealed classes 
            //Rectangle ShapeMan = new Rectangle(5,10);            
            //Console.WriteLine(ShapeMan.CalculateArea());




            // VEHICLE AND AEROPLANE CLASSES



            //Vehicle car = new Vehicle(5, 40);

            ////Console.WriteLine(car.Speed);
            ////Console.WriteLine(car.numPassengers);
            ////Console.WriteLine(car.Position);


            //Aeroplane a = new Aeroplane(200, 100, "JetsRUS") { numPassengers = 150 };

            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);
            //a.Descend(200);
            //Console.WriteLine(a.Move());
            //a.Move();
            //Console.WriteLine(a);

            //Console.WriteLine("######");

            //Console.WriteLine($"{a.ToString()}");
            //Console.WriteLine($"{h2.ToString()}");

            //Console.WriteLine("######");



            // POLYMORPHISM



            //List<Object> gameObjects = new List<object>()
            //{

            //    new Person("Cathy", "French"),
            //    new Aeroplane(400, 200, "Booing") {numPassengers = 55},
            //    new Vehicle(12, 20) {numPassengers = 6},
            //    new Hunter("Henry", "Hodgkins", "Pentax")
            //};

            //// when we call object from the list, it runs ToString() describing the instantiation
            //foreach (var element in gameObjects)
            //{
            //    Console.WriteLine(element);
            //}

            //Console.WriteLine(" ");

            //Person Yolanda = new Person("Yolanda", "Grayson");
            //Hunter Yosmite = new Hunter("Yosemite", "Buck", "Canon");

            //SpartaWrite(Yolanda);
            //SpartaWrite(Yosmite);

            //// you can also apply this method to objs present inside of a obj list
            //SpartaWrite(gameObjects[2]);

            ////Console.WriteLine(gameObjects[2].ToString());

            //Console.WriteLine(" ");

            //// we can create objects and then insert them in a list later
            //Vehicle TestLa = new Vehicle(5, 150);

            //List<object> MovingPeople = new List<object>()
            //{
            //    TestLa,
            //    new Person("Usain", "Bolt", 41),
            //    new Aeroplane(400, 200, "Wooooh") {numPassengers = 525},
            //    new Vehicle(12, 20) {numPassengers = 3},
            //};


            //foreach (var el in MovingPeople) 
            //{

            //    if (el is Person)
            //    {
            //        var PersonObj = (Person)el;
            //        Console.WriteLine(PersonObj.Move(2));
            //    }
            //    else if (el is Vehicle && el is not Aeroplane)
            //    {
            //        var VehicleObj = (Vehicle)el;
            //        Console.WriteLine(VehicleObj.Move(34));
            //    }
            //    else if (el is Aeroplane) 
            //    {
            //        var AeroplaneObj = (Aeroplane)el;
            //        Console.WriteLine(AeroplaneObj.Move(500));
            //    }

            //}

            Camera pentax = new Camera("Pentax");
            WaterPistol pistol = new WaterPistol("Supersoaker");
            LaserGun laserGun = new LaserGun("Acme");
            Hunter nish = new Hunter("Nish", "Mandal", pentax);

            Console.WriteLine("Polymorphic Shootout");
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());


            
            List<IShootable> WeaponList = new List<IShootable>()
            {
                // no need for the exercise output
            };

            foreach (var el in WeaponList) 
            {
                Console.WriteLine(el.Shoot());
            }


        }

        public static void SpartaWrite(object obj) 
        {
            Console.WriteLine(obj.ToString());

            if (obj is Hunter) 
            {
                var hunterObj = (Hunter)obj;

                Console.WriteLine(hunterObj.Shoot());

            }
            if (obj is Vehicle)
            {
                var VehicleObj = (Vehicle)obj;

                Console.WriteLine(VehicleObj.Move());
                Console.WriteLine(VehicleObj.ToString());

            }
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
