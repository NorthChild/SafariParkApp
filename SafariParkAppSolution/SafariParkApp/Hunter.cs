using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    class Hunter : Person
    {
        private string _camera;

        // base pickes up values from the parent class
        public Hunter(string fNmame, string lName, string camera = "") : base(fNmame, lName)  
        {
            this._camera = camera;
        }


        public Hunter() 
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}";
        }


        public string Shoot() 
        {
            return $"{GetFullName()} has taken a photo with their {_camera}";
        }
    }
}
