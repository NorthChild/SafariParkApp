using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Camera : IShootable
    {

        protected string _brand;

        public Camera(string brand)
        {
            _brand = brand;
        }


        public virtual string Shoot()
        {
            return $"Shooting a {base.ToString()} - {_brand}";
        }

        public virtual string ToString()
        {
            return $"{base.ToString()}";
        }

        
    }
}
