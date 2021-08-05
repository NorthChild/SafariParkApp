using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Hunter : Person, IMovable, IShootable
    {
        // change after IShooter
        //private string _camera;
        public IShootable _brand;

        public IShootable Shooter { get { return _brand; } set { _brand = value;} }

        // base pickes up values from the parent class
        // implemented IShootable, old code is commented
        //public Hunter(string fNmame, string lName, string camera = "") : base(fNmame, lName)
        //{
        //    this._camera = camera;
        //}
        
        public Hunter(string fNmame, string lName, IShootable shootable) : base(fNmame, lName)
        {
            Shooter = shootable;
        }

        public Hunter() 
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {this._brand}";
        }

        public string Shoot()
        {
            return $"{GetFullName()}: {Shooter.Shoot()}";
        }
    }
}
