using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame
{
    [Serializable]

    public class Fish : Pet
    {

        private string environment;

        #region Constructor
        public Fish(string name,Image picture,Player owner,string environment)
               :base(name,picture,owner)
        {
            this.Environment = environment;
        }
        #endregion
        #region Parameter
        public string Environment { get => environment; set => environment = value; }
        #endregion

        #region Methods
        public override string DisplayData()
        {
            string data = base.DisplayPet() + 
                         "\nEnvironment" + this.Environment;
            return data;
        }

        public override void Feed()
        {
            base.Health += 20 ;
            base.Energy += 40;
        }

        public override void Sleep()
        {
            ;
        }

        public void Clean()
        {
            {
                if (base.Owner.Coins >= 500)
                {
                    this.Owner.Coins -= 500;
                }
                else if (base.Owner.Coins < 1000)
                {
                    throw new Exception("Not enough coins to clean your fish");
                }
            }  
        }
        public override string myEnvironment()
        {
            return this.Environment;
        }
        #endregion
    }
}