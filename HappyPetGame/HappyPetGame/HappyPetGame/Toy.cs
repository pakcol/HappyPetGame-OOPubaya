﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame
{
    [Serializable]

    public class Toy
    {
        private string name;
        private int price;
        private int benefit;
        private Image picture;

        #region Constructor
        public Toy(string name, int price, int benefit ,Image picture )
        {
            this.Name = name;
            this.Price = price;
            this.Benefit = benefit;
            this.Picture = picture;
        }
        #endregion

        #region Properties
        public string Name 
        { 
            get => name;
            set
            {
                if(value != "")
                {
                    name = value;
                }
                else
                {
                    name = "Toy 1";
                }
            }
        }
        public int Price 
        { 
            get => price; 
            set
            {
                if(value >=0)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }
        public int Benefit 
        { 
            get => benefit; 
            set
            {
                if(value > 0 )
                {
                    benefit = value;
                }
                else
                {
                    benefit = 1;
                }
            }
        }

        public Image Picture { get => picture; set => picture = value; }
        #endregion

        #region Method
        public string DisplayData()
        {
            string data = this.Name + 
                        "\n" + this.Price + " coins" + 
                        "\n+" + this.Benefit + " %";
            return data;
        }
        #endregion
    }
}