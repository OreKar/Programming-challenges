using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        //Φτιάχνω μια λίστα με τα χρώματα των κουμπιών και μετά χρησιμοποιώ μια RANDOM για να επιλέγει στην τύχη κάποιο χρώμα

        List<ColorCombination> colorCombinations = new List<ColorCombination>(){
                new ColorCombination{ BackgroundColor="Red"},
                new ColorCombination{ BackgroundColor = "Yellow"},
                new ColorCombination{ BackgroundColor = "Blue"},
                new ColorCombination{ BackgroundColor = "Purple"},
                new ColorCombination{ BackgroundColor = "Green"},
                new ColorCombination{ BackgroundColor = "White"}

        };

        Random r = new Random();

        // Μέθοδος για όταν πατιέται το κάθε κουμπί να εμφανίζεται ένα Message box που δείχνει τον αριθμό του κουμπιού
        void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Name);
        }


        class ColorCombination
        {
            public string BackgroundColor;
            
        }



        public Form1()
        {
            InitializeComponent();

        }

        private void start_Click(object sender, EventArgs e)
        {


            int var = int.Parse(textBox1.Text);
            //Όι συντεταγμένες του σημείου που αρχίζει το πρώτο κουμπί
            int x = 89;
            int y = 156;

            for (int i=0; i<var; i++)
            {
                //Άμα είναι το πρώτο κουμπί
                if (i == 0)
                {

                    int c = r.Next(0, colorCombinations.Count);
                    
                    //Εδώ όπως και στην συνέχεια φτιάχνω ένα κουμπί από την αρχή και του δίνω τα χαρακτηριστικά που θέλω να έχει

                    Button b = new Button();
                    b.Location = new Point(x, y);
                    b.Name = (i+1).ToString();
                    b.Text = (i+1).ToString();
                    b.Size = new Size(60, 54);
                    b.Font = new Font("Microsoft Sans Serif", 10);
                    b.Padding = new Padding(10);
                    b.BackColor = Color.FromName(colorCombinations[c].BackgroundColor);
                    b.Click += new EventHandler(this.button_click);
                    this.Controls.Add(b);

                    

                }
                
                //Όταν ο αριθμός του κουμπιού δεν είναι πολλαπλάσιο του 10 συνεχίσει στην ίδια γραμμή το επόμενο κουμπί
                  else if(i % 10 != 0)
                    {

                    int c = r.Next(0, colorCombinations.Count);
                    x = x + 82;

                        Button b = new Button();
                        b.Location = new Point(x, y);
                        b.Name = (i+1).ToString();
                        b.Text = (i+1).ToString();
                        b.Size = new Size(60, 54);
                        b.Font = new Font("Microsoft Sans Serif", 10);
                        b.Padding = new Padding(10);
                        b.BackColor = Color.FromName(colorCombinations[c].BackgroundColor);
                    b.Click += new EventHandler(this.button_click);
                    this.Controls.Add(b);
                    }

                
                //Άμα είναι πολλαπλάσιο αλλάζει γραμμή και πάει κάτω από το χ του αρχικού κουμπιού
                else {

                    x = 89;
                    y = y + 75;
                    int c = r.Next(0, colorCombinations.Count);

                    Button b = new Button();
                    b.Location = new Point(x, y);
                    b.Name = (i+1).ToString();
                    b.Text = (i+1).ToString();
                    b.Size = new Size(60, 54);
                    b.Font = new Font("Microsoft Sans Serif", 10);
                    b.Padding = new Padding(10);
                    b.BackColor = Color.FromName(colorCombinations[c].BackgroundColor);
                    b.Click += new EventHandler(this.button_click);
                    this.Controls.Add(b);





                }


   

         
                 
               
          

            }

        }
       
    }
   
}
