﻿namespace TASK_DEV_7.creators
{   /// <summary>
    /// Opel Car Creator
    /// </summary>
    class OpelCreator : ICreate
    {
        /// <summary>
        /// Create new Opel car
        /// </summary>
        /// <param name="Mark">mark of our car</param>
        /// <param name="Model">model of our car</param>
        /// <param name="Bodytype">body type of auto</param>
        /// <param name="Transmissiontype">type of transmission</param>
        /// <param name="Enginetype">type of engine</param>
        /// <param name="Amount">amount of engine</param>
        /// <param name="Power">amount of horsepower in the engine</param>
        /// <param name="Climate">type of climate controll</param>
        /// <param name="Carinterior">type of car interior</param>
        /// <returns>New Car</returns>
        public Car Create(string Mark, string Model, string Bodytype, string Transmissiontype, string Enginetype, string Amount, string Power, string Climate, string Carinterior)
        {
            return new Opel(Mark, Model, Bodytype, Transmissiontype, Enginetype, Amount, Power, Climate, Carinterior);
        }
    }
}

