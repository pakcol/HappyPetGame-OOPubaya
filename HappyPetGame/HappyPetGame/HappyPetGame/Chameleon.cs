using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame
{
    [Serializable]

    public class Chameleon : Pet
    {
        private Color currentColor;
        #region Constructor
        public Chameleon(string name, Image picture, Player owner, Color currentColor):base(name,picture,owner)
        {
            this.CurrentColor = currentColor;
        }
        #endregion
        #region Properties
        public Color CurrentColor { get => currentColor; set => currentColor = value; }
        #endregion

        #region Methods
        public override string DisplayData()
        {
            string data = base.DisplayPet() +
                        "\nColor : " + this.CurrentColor;
            return data;
        }

        public override void Feed()
        {
            base.Health += 30;
            base.Energy += 50;
        }

        public override void Sleep()
        {
            base.Health += 60;
            base.Health += 60;
        }

        public void ChangeColor(Color newColor)
        {
            this.CurrentColor = newColor;
        }
        #endregion
    }
}