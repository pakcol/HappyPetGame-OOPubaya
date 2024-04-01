using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame
{
    [Serializable]

    public abstract class Pet
    {

        private string name;
        private int health;
        private int energy;
        private int happiness;
        private Image picture;
        private Player owner;//1 pet has 1 owner (Aggregation)
        private List<Toy> listToys; // 1 pat has n toys (Composition)

        #region Constructor
        protected Pet(string name, Image picture, Player owner)
        {
            this.Name = name;
            this.Health = 100;
            this.Energy = 100;
            this.Happiness = 100;
            this.Picture = picture;
            this.Owner = owner;
            this.ListToys = new List<Toy>();
        }
        #endregion

        #region Properties
        public string Name 
        { 
            get => name; 
            set
            {
                if(value !="")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Pet name can not be empty");
                }
            }
        }
        public int Health 
        { 
            get => health; 
            set
            {
                if(value >=10 & value <=100)
                {
                    health = value;
                }
                else if( value <10)
                {
                    health = 10;
                }
                else
                {
                    health = 100;
                }
            }
        }
        public int Energy 
        { 
            get => energy; 
            set
            {
                if(value >= 10 & value <=100)
                {
                    energy = value;
                }
                else if( value < 10)
                {
                    health = 10;
                }
                else
                {
                    health = 100;
                }
            }
        }
        public int Happiness 
        { 
            get => happiness; 
            set
            {
                if (value >= 10 & value <= 100)
                {
                    happiness = value;
                }
                else if (value < 10)
                {
                    happiness = 10;
                }
                else
                {
                    happiness = 100;
                }
            }
        }
        public Image Picture { get => picture; set => picture = value; }
        public Player Owner { get => owner; set => owner = value; }
        public List<Toy> ListToys { get => listToys; set => listToys = value; }
        #endregion

        #region Method
        public abstract string DisplayData();

        protected string DisplayPet()
        {
            string data = this.Name +
                         "\nHealth :" + this.Health + 
                         "% Energy : " + this.Energy + 
                         "% Happiness : " + this.Happiness + "%";
            return data;
                         
        }

        public abstract void Feed();

        public virtual void Sleep()
        {
            ;
        }

        public virtual void Toys()
        {
            ;
        }
        //asumsikan kalau jenis pet lainnya bisa main juga
        public virtual void Play(Toy toy)
        { }

        public void Buy(Toy newToy)
        {
            if(this.Owner.Coins>= newToy.Price)
            {
                bool sudahPunya = false;
                foreach(Toy t in this.ListToys)
                {
                    if(t.Name == newToy.Name)
                    {
                        sudahPunya = true;
                        break;
                    }
                }
                if(sudahPunya == false)
                {
                    this.ListToys.Add(newToy);
                    this.owner.Coins -= newToy.Price;
                }
                else
                {
                    throw new Exception("Your Pet Already have that toy");
                }

            }
            else
            {
                throw new Exception("Not enogh coins to buy this toy");
            }


        }
        //mthod buat check health
        public string CheckHealth()
        {
            string condition = "";
            if(this.Health>=10 && this.Health <=25)
            {
                condition = "Very Poor";
            }
            else if (this.Health >= 26 && this.Health <= 60)
            {
                condition = "Poor";
            }
            else if (this.Health >= 61 && this.Health <= 80)
            {
                condition = "Good";
            }
            else
            {
                condition = "Very Good";
            }
            return condition;
        }
        public string CheckEnergy()
        {
            string condition = "";
            if (this.Energy >= 10 && this.Energy <= 50)
            {
                condition = "Weak";
            }
            else if (this.Energy >= 51 && this.Energy <= 75)
            {
                condition = "Moderate";
            }
            else
            {
                condition = "Strong";
            }
            return condition;
        }
        public string CheckHappiness()
        {
            string condition = "";
            if (this.Happiness>= 10 && this.Happiness <= 60)
            {
                condition = "Unhappy";
            }
            else if (this.Happiness >= 61 && this.Happiness <= 100)
            {
                condition = "Happy";
            }
            return condition;
        }

        public virtual string myEnvironment()
        {
            return "";
        }
        #endregion
    }
}