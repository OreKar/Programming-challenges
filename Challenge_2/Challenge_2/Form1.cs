using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_2
{
 
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            
        }
        //Φτιάχνω ένα stopwatch για να μετρήσω τα ms που χρειάζεται το pc για να υλοποιήσει τον κώδικα
        Stopwatch watch = new Stopwatch();


        private void button1_Click(object sender, EventArgs e)
        {
            //Το watch ξεκινάει να μετράει όταν πατηθεί το κουμπί start
            watch.Start();

            int n = int.Parse(textBox1.Text);
            string newLine = Environment.NewLine;

            //Εδώ ουσιαστικά κάθε φορά που πατιέται το start για να μην μένουν οι αριθμοί στο richTextbox από την προηγούμενη φορά που πάτησα το start, γεμίζω το richTextbox με το κενό
            richTextBox1.Text = "";

          //Εδώ αρχικοποιώ έναν πίνακα που τον γεμίζω με τον αριθμό n που έδωσε ο χρήστης. Σπάω δηλαδή τον αριθμό n του χρήστη απο το 1 μέχρι το n και γεμίζω τον πίνακα

            int[] nn = new int[n];

            for(int i =0; i<n; i++)
            {
                nn[i] = i + 1; 

           }


            //Εδώ φτιάχνω ένα Random το οποίο γεμίζει τυχαία έναν άλλον πίνακα τον ΜyRandomArray με όλα τα νούμερα του προηγούμενου πίνακα nn
            Random rnd = new Random();
            int[] MyRandomArray = nn.OrderBy(x => rnd.Next()).ToArray();




            
            // Το newline το έχω φτιάξει πάνω πάνω και το χρησιμοποιώ για να αλλάζω στο richTextbox γραμμή ώστε να φαίνονται όλοι οι αριθμοί 
            for(int i = 0; i<n; i++)
            {

                
                richTextBox1.Text += MyRandomArray[i].ToString() + newLine;
                



            }
            //Εδώ το watch σταματάει να μετράει
            watch.Stop();
            //Δημιουργώ ένα string το οποίο παίρνει την τιμή των ms που μέτρησε το watch και το εμφανίζω στο label 3 
            string elms = watch.ElapsedMilliseconds.ToString();

            label3.Text = elms;
            //Εδώ κάνω reset το watch διότι διαφορετικά θα κράταγε κάθε φορά που καλείτε τον προηγούμενο χρόνο και θα τον πρόσθεται στον καινούργιο
            watch.Reset();
            
        }
    }
}
