using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Suit
{
    public class Suit
    {
        private string playerSuit;
        private Image picture;

        #region constructors
        public Suit(string playerSuit, Image picture)
        {
            this.PlayerSuit = playerSuit;
            this.Picture = picture;
        }
        #endregion

        #region properties
        public string PlayerSuit { get => playerSuit; set => playerSuit = value; }
        public Image Picture { get => picture; set => picture = value; }
        #endregion

        #region methods

        #endregion
    }
}