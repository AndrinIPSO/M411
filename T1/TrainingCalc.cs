using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    /// <summary>
    /// Zeitenrechner
    /// </summary>
    public class TrainingCalc
    {
        /// <summary>
        /// Zeitenarray
        /// </summary>
        public double[] Zeiten { get; set; }
        /// <summary>
        /// Standart grösse
        /// </summary>
        public const int standartsize = 11;
        /// <summary>
        /// count
        /// </summary>
        public int count { get; private set; }
        /// <summary>
        /// rechner mit eigener grösse
        /// </summary>
        /// <param name="newize">eigene grösse</param>
        public TrainingCalc(int newize)
        {
            if (newize > 0)
            {
                Zeiten = new double[newize];
            }
            else
            {
                Zeiten = new double[standartsize];
            }
            count = 0;
        }
        /// <summary>
        /// Rechner mit standartegrösse
        /// </summary>
        public TrainingCalc()
            :this(0)
        {
        }
        /// <summary>
        /// neue zeit
        /// </summary>
        /// <param name="zeit">zeit</param>
        public void add(double zeit)
        {
            grow();
            Zeiten[count] = zeit;
            count++;
            //try
            //{
            //double[] temp = new double[count];
            //if (count >= Zeiten.Length)
            //{
            //    for (int i = 0; i < Zeiten.Length; i++)
            //    {
            //        temp[i] = Zeiten[i];
            //    }
            //    Zeiten = new double[count];
            //    for (int i = 0; i < Zeiten.Length; i++)
            //    {
            //        Zeiten[i] = temp[i];
            //    }
            //}
            //Zeiten[count] = zeit;
            //count++;

            //}
            //catch
            //{
            //    throw new Exception();
            //}
        }
        /// <summary>
        /// Minimum erhalten
        /// </summary>
        /// <returns>bestzeit</returns>
        public double GetMin()
        {
            double bestzeit = Zeiten[0];
            foreach (double zeit in Zeiten)
            {
                if (zeit < bestzeit)
                {
                    bestzeit = zeit;
                }
            }
            return bestzeit;
        }
        /// <summary>
        /// Mximum erhalten
        /// </summary>
        /// <returns>schlechteste zeit</returns>
        public double GetMax()
        {
            double maxzeit = Zeiten[0];
            foreach (double zeit in Zeiten)
            {
                if (zeit > maxzeit)
                {
                    maxzeit = zeit;
                }
            }
            return maxzeit;
        }
        /// <summary>
        /// Druchsnitt erhalten
        /// </summary>
        /// <returns>durchschnitt</returns>
        public double getAvg()
        {
            double m = getSum();
            return m / count; // Bei .Lenght wird mit leeren gerehnet.
        }
        /// <summary>
        /// Summer erhalten
        /// </summary>
        /// <returns>Summe</returns>
        public double getSum()
        {
            double m = 0;
            foreach (double zeit in Zeiten)
            {
                m += zeit;
            }
            return m;
        }
        
        public void grow()
        {
            if (Zeiten.Length > count)
            {
                return;
            }
            else
            {
                int newlwnght = Zeiten.Length * 2;
                double[] newItems = new double[newlwnght];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = Zeiten[i];
                }
                Zeiten = newItems;
            }
        }
        

    }
}
