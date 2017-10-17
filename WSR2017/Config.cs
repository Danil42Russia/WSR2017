using System.Drawing;

namespace WSR2017
{
    /// <summary>
    /// Конфиг файл для проекта
    /// </summary>
    public class Config
    {
        private int minheight = 500;
        private int minwidth = 500;
        private int maxheight = 500;
        private int maxwidth = 500;

        /// <summary>
        /// Минимальное значение для высоты
        /// <value>500</value>
        /// </summary>

        public int MinHeight { get { return minheight; } }
        /// <summary>
        /// Минимальное значение для ширины
        /// <value>500</value>
        /// </summary>
        public int MinWidth { get { return minwidth; } }

        /// <summary>
        /// Максимальное значение для ширины
        /// <value>500</value>
        /// </summary>
        public int MaxHeight { get { return maxheight; } }

        /// <summary>
        /// Максимальное значение для ширины
        /// <value>500</value>
        /// </summary>
        public int MaxWidth { get { return maxwidth; } }
    }
}