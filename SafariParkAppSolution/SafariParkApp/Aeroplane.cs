using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Aeroplane : Vehicle, IMovable
    {
        private string _airline;
        private int _altitude = 0;

        public Aeroplane(int capacity) : base(capacity)
        {
        }

        public Aeroplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            this._airline = airline;
        }


        public void Ascend(int distance)
        {
            this._altitude += distance;
        }


        public void Descend(int distance)
        {
            if (this._altitude < 0)
            {
                throw new ArgumentOutOfRangeException("You cant fly under ground!?");
            }
            else
            {
                this._altitude -= distance;
            }

        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude of {this._altitude} metres";
        }

        public override string Move(int times)
        {
            base.Move();
            return $"Moving along {base.Move(times)} times at an altitude of {this._altitude} meters";
        }

        public override string ToString()
        {
            //return $"Thank you for flying {this._airline}: {base.ToString()} capacity : {this._capacity} passengers: {this.numPassengers} speed: {this.Speed} position: {this.Position} altitude: {this._altitude}";

            return $"Thank you for flying {this._airline}: {base.ToString()} altitude: {this._altitude}";
        }
    }
}
