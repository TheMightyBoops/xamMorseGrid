using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Morse_Grid
{
    public partial class MainPage : ContentPage
    {
        private string morseString = "", displayMessage = "", displayMorse = "";
        //Outside constructor
        IDictionary<string, string> morse = new Dictionary<string, string>();

        public MainPage()
        {
            InitializeComponent();


            //Inside constructor
            morse.Add(".-", "A");
            morse.Add("-...", "B");
            morse.Add("-.-.", "C");
            morse.Add("-..", "D");
            morse.Add(".", "E");
            morse.Add("..-.", "F");
            morse.Add("--.", "G");
            morse.Add("....", "H");
            morse.Add("..", "I");
            morse.Add(".---", "J");
            morse.Add("-.-", "K");
            morse.Add(".-..", "L");
            morse.Add("--", "M");
            morse.Add("-.", "N");
            morse.Add("---", "O");
            morse.Add(".--.", "P");
            morse.Add("--.-", "Q");
            morse.Add(".-.", "R");
            morse.Add("...", "S");
            morse.Add("-", "T");
            morse.Add("..-", "U");
            morse.Add("...-", "V");
            morse.Add("-..-", "X");
            morse.Add("-.--", "Y");
            morse.Add("--..", "Z");
            morse.Add(".----", "1");
            morse.Add("..---", "2");
            morse.Add("...--", "3");
            morse.Add("....-", "4");
            morse.Add(".....", "5");
            morse.Add("-....", "6");
            morse.Add("--...", "7");
            morse.Add("---..", "8");
            morse.Add("----.", "9");
            morse.Add("-----", "0");
        }

        public void dotClick(object sender, EventArgs eventA)
        {
            displayMorse = displayMorse + ".";
            morseString = morseString + ".";
            morseLabel.Text = morseString;
        }

        public void dashClick(object sender, EventArgs eventA)
        {
            displayMorse = displayMorse + "-";
            morseString = morseString + "-";
            morseLabel.Text = morseString;
        }

        public void spaceClick(object sender, EventArgs eventA)
        {

            if (morseString.Equals(""))
            {
                displayMessage += " ";
            }
            foreach (KeyValuePair<string, string> e in morse)
            {
                if (morseString == e.Key)
                {
                    displayMessage = displayMessage + e.Value;
                    textLabel.Text = displayMessage;
                }
            }

            morseString = "";
        }
    }
}
