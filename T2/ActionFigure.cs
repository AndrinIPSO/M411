using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    public class ActionFigure
    {
        /// <summary>
        /// Spielerrichtung
        /// </summary>
        public DirectionTyp Direction { get; set; }
        /// <summary>
        /// Spieler Status
        /// </summary>
        public bool isActive { get; set; }
        /// <summary>
        /// Spieler position x
        /// </summary>
        public int PositionX { get; set; }
        /// <summary>
        /// Spieler position y
        /// </summary>
        public int PositionY { get; set; }
        /// <summary>
        /// Spieler geschwindigkeit
        /// </summary>
        public double Speed { get; set; }
        /// <summary>
        /// Spieler erstellen
        /// </summary>
        public ActionFigure()
        {

        }
        /// <summary>
        /// Play methode
        /// </summary>
        public void Play()
        {

        }
        /// <summary>
        /// Richtugen
        /// </summary>
        public enum DirectionTyp
        {
            Left, 
            Right,
            Up,
            Down
        }
    }
}
