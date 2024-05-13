using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public class CounterBase : ComponentBase
    {
        public int currentCount = 0;

        public double inches = 1;
        public double centimeter = 2.54;
        public double InchesCon
        {
            get => inches;
            set
            {
                centimeter = value * 2.54;
                inches = value;
            }
        }
        public double CentimeterCon
        {
            get => centimeter;
            set
            {
                inches = value / 2.54;
                centimeter = value;
            }
        }
        public void IncrementCount()
        {
            currentCount++;
        }

    }
}


