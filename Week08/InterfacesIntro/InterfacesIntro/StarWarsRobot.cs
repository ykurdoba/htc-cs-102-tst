using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    class StarWarsRobot : robot
    {
        int InNumberOfMovies { get; set; }

        public StarWarsRobot(int inNumberOfMovies, double strideLength, int numLegs)
        {
            this.InNumberOfMovies = inNumberOfMovies;
            this.StrideLength = strideLength;
            this.NumLegs = numLegs;
        }
    }
}
