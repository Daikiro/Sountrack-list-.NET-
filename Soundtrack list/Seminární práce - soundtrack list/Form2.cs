using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminární_práce___soundtrack_list
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // podle jazyku se nastaví verze
            if (Settingy.jazyk == true)
            {
                label3.Text = String.Format("Date: {0:d}\n\t\t    Time {0:t}", DateTime.Now);
                button1.Text = "Close window";
                label1.Text = "I made this part only from personal incitement";
            }
            else
            {
                //vypíše aktuální datum a čas
                label3.Text = String.Format("Dnešní datum: {0:d}\n\t\t    Přibližný čas {0:t}", DateTime.Now);
                button1.Text = "Zavřít okno";
                label1.Text = "Tuto část jsem přidal pouze z hecu";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
