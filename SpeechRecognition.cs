using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Media;

namespace ProjectNF
{
    public class SpeechRecognition : Form1
    {
        // Create new SpeechRecognizer instance.
        public static SpeechRecognizer sr = new SpeechRecognizer();

        int menuSelector;

        // SpeechRecognized Handler
        /*Need to add in confirmation of choice*/
        public void sr_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (menuSelector == 0)
            {
                switch (e.Result.Text)
                {
                    case "Netflix":
                        playSound("confirmation.wave");
                        menuSelector = 1;
                        menuSelection(menuSelector);
                        break;
                    case "Steam":
                        //System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Steam\\Steam.exe");
                        playSound("confirmation.wave");
                        menuSelector = 2;
                        menuSelection(menuSelector);
                        break;
                    case "Facebook":
                        System.Diagnostics.Process.Start("http://www.facebook.com");
                        break;
                    case "Go to Sleep":
                        closeApplication();
                        break;
                }
            }

            else if (menuSelector == 1)
            {
                switch (e.Result.Text)
                {
                    case "Comedy":
                        System.Diagnostics.Process.Start("http://www.netflix.com/browse/genres/" + "6548");
                        break;
                    case "Action":
                        System.Diagnostics.Process.Start("http://www.netflix.com/browse/genres/" + "1365");
                        break;
                    case "Thriller":
                        System.Diagnostics.Process.Start("http://www.netflix.com/browse/genres/" + "4758");
                        break;
                    case "Back":
                        //Add in deletion of buttons
                        playSound("confirmation.wave");
                        menuSelector = 0;
                        break;
                }
            }
        }

        public static void initialize_SpeechRecognition()
        {
            // Create a grammar to recognize choices.
            Choices applicationChoices = new Choices();
            applicationChoices.Add(new string[] { "Netflix", "Steam", "Facebook", "Go to Sleep", "Comedy", "Action", "Thriller", "Back" });

            // Create a GrammarBuilder object and append the choices object.
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(applicationChoices);

            // Create the grammar instance and load it into the speech recognizer.
            Grammar g = new Grammar(gb);
            //sr.LoadGrammar(g);
        }

        //Play sound
        public void playSound(string wav)
        {
            SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\" + wav);
            sound.Play();
        }
    }
}
