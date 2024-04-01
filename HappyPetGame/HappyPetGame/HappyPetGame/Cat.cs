using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame
{
    [Serializable]

    public class Cat : Pet
    {
        private bool vaccinationStatus;

        #region Constructor
        public Cat(string name, Image picture,Player owner,bool vaccinationStatus)
               :base(name,picture,owner)
        {
            this.VaccinationStatus = false;
        }
        #endregion
        #region Properties
        public bool VaccinationStatus { get => vaccinationStatus; set => vaccinationStatus = value; }
        #endregion
        #region methods
        public override string DisplayData()
        {
            string status = "No";
            if(this.VaccinationStatus == true)
            {
                status = "Yes";
            }
            string data = base.DisplayPet() +
                         "\nVaccination status : " + status;
            return data;

        }

        public override void Feed()
        {
            base.Health += 30;
            base.Energy += 50;
            base.Owner.Coins += (int)(0.5 * 30 * 100);
            base.Owner.Coins += (int)(0.5 * 50 * 100);
        }

        public override void Sleep()
        {
            base.Health += 20;
            base.Energy += 70;
            base.Owner.Coins += (int)(0.5 * 20 * 100);
            base.Owner.Coins += (int)(0.5 * 70 * 100);
        }


        public void Bath()
        {
            base.Health += 30;
            base.Owner.Coins += (int)(0.5 * 30 * 100);
        }

        public void Vaccinate()
        {
            if(base.Owner.Coins >= 1000 && this.VaccinationStatus == false)
            {
                this.VaccinationStatus = true;
                this.Owner.Coins -= 1000;
                base.Health += 40;
                base.Happiness -= 10;
                base.Owner.Coins += (int)(0.5 * 40 * 100);
            }
            else if (base.Owner.Coins < 1000)
            {
                throw new Exception("Not enough coins to vaccinate your cat");
            }
            else if(this.VaccinationStatus == true)
            {
                throw new Exception("Your cat can only be vaccinate only once");
            }
        }
        public void Buy(Toy newToy)
        {
            if(this.Owner.Coins >= newToy.Price)
            {
                this.ListToys.Add(newToy);

                this.Owner.Coins -= newToy.Price;
            }
            else
            {
                throw new Exception("Not Enough Coins to buy a new toys");
            }

        }

        public override void Play(Toy toy)
        {
            base.Happiness += 50;
            base.Energy += 30;

            if(toy != null)
            {
                base.Happiness += toy.Benefit;
            }
        }
    }
        #endregion
    
}