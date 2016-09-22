using System;
using System.Collections.Generic;
using System.Collections;
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
        protected ArrayList innerArray;

        public bool IsReadOnly
        {
            get
            {
                return innerArray.IsReadOnly;
            }
        }

        public int Count
        {
            get
            {
                return innerArray.Count;
            }
        }

        public void Add(TwoDemensionsFigure newFigure)
        {
            innerArray.Add(newFigure);
        }

        public void CopyTo(TwoDemensionsFigure[] newFigures, int index)
        {
            innerArray.CopyTo(newFigures, index);
        }

        public bool Remove(TwoDemensionsFigure newFigure)
        {
            try
            {
                innerArray.Remove(newFigure);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Containts(TwoDemensionsFigure newFigure)
        {
           return innerArray.Contains(newFigure);
        }

        public void Clear()
        {
            innerArray.Clear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
