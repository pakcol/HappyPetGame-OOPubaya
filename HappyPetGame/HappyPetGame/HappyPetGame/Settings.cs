using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPetGame
{
    public class Settings
    {
        //static karena tidak bisa diubah
        private static int width;
        private static int height;
        private static string directions;

        public static int Width { get => width; set => width = value; }
        public static int Height { get => height; set => height = value; }
        public static string Directions { get => directions; set => directions = value; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            Directions = "Left";
        }
    }
}