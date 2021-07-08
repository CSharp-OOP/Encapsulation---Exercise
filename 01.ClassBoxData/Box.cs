using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length
        {
            get => length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get => height;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public string Result()
        {
            double surfaceArea = (2 * Length * Width) + (2 * Length * Height) + (2 * Width * Height);
            double leteralSurfaceArea = (2 * Length * Height) + (2 * Width * Height);
            double volume = Length * Width * Height;


            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Surface Area - {surfaceArea:F2}");
            sb.AppendLine($"Lateral Surface Area - {leteralSurfaceArea:F2}");
            sb.AppendLine($"Volume - {volume:F2}");

            return sb.ToString().TrimEnd();
        }
    }
}
