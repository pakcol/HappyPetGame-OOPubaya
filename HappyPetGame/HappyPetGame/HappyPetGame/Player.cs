using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPetGame
{
    [Serializable]

    public class Player
    {
        private string name;
        private int coins;
        private DateTime lastPlay;
        #region Constructor
        public Player(string name, int coins, DateTime lastPlay)
        {
            this.Name = name;
            this.Coins = coins;
            this.LastPlay = lastPlay;
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
                    throw new Exception("Player name cannot be empty");
                }
            }
        }
        public int Coins 
        { 
            get => coins; 
            set
            {
                if(value >= 0)
                {
                    coins = value;
                }
                else
                {
                    coins = 0;
                }
            }
        }
        public DateTime LastPlay { get => lastPlay; set => lastPlay = value; }
        #endregion
        #region Method
        //semua child harus punya method DisplayData
        public string DisplayData()
        {
            string data = this.Name + 
                          "\nCoins : " + this.Coins 
                          ;
            return data;
        }

        #endregion
    }
}