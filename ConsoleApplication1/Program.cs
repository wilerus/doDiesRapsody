using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ConsoleApplication1
{
    abstract class TwoDemensionsFigure
    {
        public virtual float[] sidesList { get; set; }

        public virtual short[] anglesList { get; set; }

        public virtual float mathArea(float firstDim, float secondDim)
        {
            Contract.Requires(!firstDim.Equals(null));
            return firstDim * secondDim;
        }
        public virtual float mathPerimiter(float firstDim, float secondDim, float thirdDim, float foughtDim = 0)
        {
            return firstDim + secondDim + thirdDim + foughtDim;
        }
    }

    class Square : TwoDemensionsFigure
    {
        public override float[] sidesList { get; set; }

        public override short[] anglesList { get; set; }

        public override float mathArea(float firstDim, float secondDim)
        {
            Contract.Requires(!firstDim.Equals(null));
            return firstDim * secondDim;
        }
        public override float mathPerimiter(float firstDim, float secondDim, float thirdDim, float foughtDim = 0)
        {
            return firstDim + secondDim + thirdDim + foughtDim;
        }
    }

    class Triangle : TwoDemensionsFigure
    {
        public override float[] sidesList { get; set; }

        public override short[] anglesList { get; set; }

        public override float mathArea(float firstDim, float secondDim)
        {
            Contract.Requires(!firstDim.Equals(null));
            return firstDim * secondDim;
        }
        public override float mathPerimiter(float firstDim, float secondDim, float thirdDim, float foughtDim = 0)
        {
            return firstDim + secondDim + thirdDim + foughtDim;
        }
    }

    class figureList : ICollection<TwoDemensionsFigure>
    {

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
