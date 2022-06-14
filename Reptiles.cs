using System;

namespace day2 
{
    public class Reptile : Animal
    {
        public bool isCoolBlooded = true;
        public string scaleTexture;
        public bool canRegrowLimb;

        public Reptile(string sp, int numLegs, double wgt, string clr, string scale, bool regrow)
        {
            scaleTexture = scale;
            canRegrowLimb = regrow;
        }
        

    }

}