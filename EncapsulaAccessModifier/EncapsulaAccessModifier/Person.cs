using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulaAccessModifier
{
    class Person
    {
        //public string Name;
        public string Name{ get; set; }
        private string Surname;
        protected byte Age;
        private short _score;
        public short Score
        {
            get
            {
                return this._score;
            }
            set
            {
                if (value >= 0)
                {
                    this._score = value;
                }
            }
        }

        public int MyProperty { get; set; }

        public Person()
        {
            this.Surname = "Agayev";
            this.Age = 15;
        }
    }
}
