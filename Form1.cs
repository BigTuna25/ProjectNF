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
using System.Media;

namespace ProjectNF
{
    public partial class Form1 : Form
    {
        //SpeechRecognition srClass = new SpeechRecognition();
        SpeechRecognition srClass;
        Button button;

        public Form1()
        {           
            InitializeComponent();
            SpeechRecognition.initialize_SpeechRecognition();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            srClass = new SpeechRecognition();
            SpeechRecognition.sr.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(srClass.sr_SpeechRecognized);          
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void menuSelection(int j)
        {
            //Netflix Category Menu
            if (j == 1)
            {
                //Meant to bring up movie catergory list
                //Need to link to database
                
                for (int i = 0; i < 9; ++i)
                {
                    if (i < 3)
                    {
                        button = new Button();
                        button.Text = "bananas";
                        button.Name = "Netflix";
                        button.Location = new Point(button.Width * i + 4, 0);
                        Controls.Add(button);
                    }
                    else if (i < 6)
                    {
                        button = new Button();
                        button.Text = "Oranges";
                        button.Name = "Netflix";
                        button.Location = new Point(button.Width * (i - 3) + 4, button.Height);
                        Controls.Add(button);
                    }
                    else
                    {
                        button = new Button();
                        button.Text = "Grapes";
                        button.Name = "Netflix";
                        button.Location = new Point(button.Width * (i - 6) + 4, button.Height * 2);
                        Controls.Add(button);
                    }
                }
            }
        }

        public void closeApplication()
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuSelection(2);
        }

        private void btn_Netflix_Click_1(object sender, EventArgs e)
        {
            menuSelection(1);
        }
    }
}


