using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace ResistorColorsExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorsToValue : ContentPage
    {
        public List<string> Colors1 { get; } = new List<string>
        {
            "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Grey", "White"
        };

        public List<string> Colors2 { get; } = new List<string>
        {
            "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Grey", "White"
        };

        public List<string> Colors3 { get; } = new List<string>
        {
            "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Grey", "White", "Gold", "Silver"
        };

        public string SelectedColor1Result;
        public string SelectedColor1
        {
            get => SelectedColor1Result;
            set
            {
                SelectedColor1Result = value;
                OnPropertyChanged(nameof(SelectedColor1));
            }
        }

        public string SelectedColor2Result;
        public string SelectedColor2
        {
            get => SelectedColor2Result;
            set
            {
                SelectedColor2Result = value;
                OnPropertyChanged(nameof(SelectedColor2));
            }
        }

        public string SelectedColor3Result;
        public string SelectedColor3
        {
            get => SelectedColor3Result;
            set
            {
                SelectedColor3Result = value;
                OnPropertyChanged(nameof(SelectedColor3));
            }
        }

        public decimal ResultValue;
        public decimal Result
        {
            get => ResultValue;
            set
            {
                ResultValue = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public ColorsToValue()
        {
            InitializeComponent();

            BindingContext = this;
        }

        private void CalculateResistor(object sender, EventArgs e)
        {
            // Get the index of colors
            var index1 = Colors1.IndexOf(SelectedColor1);
            var index2 = Colors2.IndexOf(SelectedColor2);
            var index3 = Colors3.IndexOf(SelectedColor3);

            // Calculate the result
            var result = (index1 * 10 + index2) * ((Int64) Math.Pow(10, index3));

            Result = result;

            /* My Solution
             * decimal result = 0;

            switch (SelectedColor1)
            {
                case "Black": result = 0; break;
                case "Brown": result = 10; break;
                case "Red": result = 20; break;
                case "Orange": result = 30; break;
                case "Yellow": result = 40; break;
                case "Green": result = 50; break;
                case "Blue": result = 60; break;
                case "Purple": result = 70; break;
                case "Grey": result = 80; break;
                case "White": result = 90; break;
                default: result = 0; break;
            }

            switch (SelectedColor2)
            {
                case "Black": result += 0; break;
                case "Brown": result += 1; break;
                case "Red": result += 2; break;
                case "Orange": result += 3; break;
                case "Yellow": result += 4; break;
                case "Green": result += 5; break;
                case "Blue": result += 6; break;
                case "Purple": result += 7; break;
                case "Grey": result += 8; break;
                case "White": result += 9; break;
                default: result += 0; break;
            }

            switch (SelectedColor3)
            {
                case "Black": result *= 1; break;
                case "Brown": result *= 10; break;
                case "Red": result *= 100; break;
                case "Orange": result *= 1000; break;
                case "Yellow": result *= 10000; break;
                case "Green": result *= 100000; break;
                case "Blue": result *= 1000000; break;
                case "Purple": result *= 10000000; break;
                case "Grey": result *= 100000000; break;
                case "White": result *= 1000000000; break;
                case "Gold": result /= 10; break;
                case "Silver": result /= 100; break;
                default: result += 0; break;
            }

            Result = result;*/
        }
    }
}