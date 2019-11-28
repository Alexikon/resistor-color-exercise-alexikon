using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResistorColorsExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValueToColors : ContentPage
    {
        public decimal Input { get; set; }

        public string ResultValue;
        public string Result
        {
            get => ResultValue;
            set
            {
                ResultValue = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public string Color1Result;
        public string Color1
        {
            get => Color1Result;
            set
            {
                Color1Result = value;
                OnPropertyChanged(nameof(Color1));
            }
        }

        public string Color2Result;
        public string Color2
        {
            get => Color2Result;
            set
            {
                Color2Result = value;
                OnPropertyChanged(nameof(Color2));
            }
        }

        public string Color3Result;
        public string Color3
        {
            get => Color3Result;
            set
            {
                Color3Result = value;
                OnPropertyChanged(nameof(Color3));
            }
        }


        public ValueToColors()
        {
            InitializeComponent();

            BindingContext = this;
        }

        private void CalculateColors(object sender, EventArgs e)
        {
            long fl;

            if(Input % 1 == 0)
            {
                fl = (long) Input;

                // could be a for loop
                int position = 0;
                while (fl >= 100)
                {
                    if(fl % 10 != 0)
                    {
                        Result = "Number cannot be converted";

                        return;
                    }
                    fl /= 10;

                    position++;
                }

                switch(position)
                {
                    case 0: Color3 = "Black"; break;
                    case 1: Color3 = "Brown"; break;
                    case 2: Color3 = "Red"; break;
                    case 3: Color3 = "Orange"; break;
                    case 4: Color3 = "Yellow"; break;
                    case 5: Color3 = "Green"; break;
                    case 6: Color3 = "Blue"; break;
                    case 7: Color3 = "Violet"; break;
                    case 8: Color3 = "Grey"; break;
                    case 9: Color3 = "White"; break;
                    default: Result = "Number cannot be converted"; return;
                }
            }
            else if(Input * 10 % 1 == 0)
            {
                fl = (int) (Input * 10);

                Color3 = "Gold";
            }
            else if(Input * 100 % 1 == 0)
            {
                fl = (int) (Input * 100);

                Color3 = "Silver";
            }
            else
            {
                Result = "Number cannot be converted";

                return;
            }

            switch (fl % 10)
            {
                case 0: Color2 = "Black"; break;
                case 1: Color2 = "Brown"; break;
                case 2: Color2 = "Red"; break;
                case 3: Color2 = "Orange"; break;
                case 4: Color2 = "Yellow"; break;
                case 5: Color2 = "Green"; break;
                case 6: Color2 = "Blue"; break;
                case 7: Color2 = "Violet"; break;
                case 8: Color2 = "Grey"; break;
                case 9: Color2 = "White"; break;
                default: Result = "Number cannot be converted"; return;
            }

            switch ((int) (fl / 10))
            {
                case 0: Color1 = "Black"; break;
                case 1: Color1 = "Brown"; break;
                case 2: Color1 = "Red"; break;
                case 3: Color1 = "Orange"; break;
                case 4: Color1 = "Yellow"; break;
                case 5: Color1 = "Green"; break;
                case 6: Color1 = "Blue"; break;
                case 7: Color1 = "Violet"; break;
                case 8: Color1 = "Grey"; break;
                case 9: Color1 = "White"; break;
                default: Result = "Number cannot be converted"; return;
            }

            Result = $"Color 1: {Color1}\nColor 2: {Color2}\nColor 3: {Color3}";
        }
    }
}