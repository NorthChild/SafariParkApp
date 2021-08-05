using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class LaserGun : Weapon, IShootable
    {

        public override string Shoot()
        {
            return $"Zint!! {base.Shoot()}";
        }

        public LaserGun(string brand) : base(brand)
        {
            _brand = brand;

        }

    }
}
