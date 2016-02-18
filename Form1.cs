using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace ProjectNF
{
    public partial class Form1 : Form
    {
        // Create new SpeechRecognizer instance.
        SpeechRecognizer sr = new SpeechRecognizer();

        public Form1()
        {
            InitializeComponent();
            initialize_SpeechRecognition();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            sr.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sr_SpeechRecognized);
        }

        // SpeechRecognized Handler
        void sr_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "Netflix":
                    System.Diagnostics.Process.Start("http://www.netflix.com");
                    break;
                case "Steam":
                    System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Steam\\Steam.exe");
                    break;
                case "Facebook":
                    System.Diagnostics.Process.Start("http://www.facebook.com");
                    break;
                case "Go to Sleep":
                    Application.Exit();
                    break;
            }
        }

        void initialize_SpeechRecognition()
        {            
            // Create a grammar to recognize choices.
            Choices applicationChoices = new Choices();
            applicationChoices.Add(new string[] { "Netflix", "Steam", "Facebook", "Go to Sleep" });

            // Create a GrammarBuilder object and append the choices object.
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(applicationChoices);

            // Create the grammar instance and load it into the speech recognizer.
            Grammar g = new Grammar(gb);
            sr.LoadGrammar(g);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
