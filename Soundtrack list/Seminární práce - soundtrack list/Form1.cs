using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using WMPLib;

namespace Seminární_práce___soundtrack_list
{
    

    public partial class Form1 : Form
    {
        #region prvotni_deklarace
        //Jednotlivé počítadla pro úkony seznamů
        public double first = 1, sst = 1, tst = 1, fost = 1, fivst = 1;
        
        //Jednotlivé počítadla pro úkony tutorialu, playboxu, timeru a listů
        public ushort help_counter = 0, play_index = 1, timing = 0, volba = 0;

        //Všechny listy + základní list se songy
        List<Song> databaze = new List<Song>();
        List<Song> first_soundtrack = new List<Song>();
        List<Song> second_soundtrack = new List<Song>();
        List<Song> third_soundtrack = new List<Song>();
        List<Song> fourth_soundtrack = new List<Song>();
        List<Song> fifth_soundtrack = new List<Song>();
        #endregion

        public Form1()
        {
            InitializeComponent();
            status_label(0);
            StartUp();
            Height = 456;
            Width = 836;
        }

        #region List_box_a_jeho_aktualizace

        //Zde se vypisuje aktuálně vybraný list
        void status_label(int vstup)
        {

            if (vstup == 0)
            {
                label_status_seznam.Text = Properties.Resources.Missing_seznam;
                label_status_seznam.ForeColor = Color.Red;

            }
            else
            {
                anglickáVerzeToolStripMenuItem.Enabled = true;
                if (Settingy.jazyk == true)
                    label_status_seznam.Text = Properties.Resources.The_Chosen_One_eng + vstup;
                else
                    label_status_seznam.Text = Properties.Resources.The_Chosen_One + vstup;
                label_status_seznam.ForeColor = Color.Green;
            }
        }

        //Zadání prvnotních songů do databáze
        void StartUp()
        {
            databaze.Add(new Song(1, "Vexento", "We Are One", 229, 1));
            databaze.Add(new Song(2, "Adventures", "A Himitsu", 224, 2));
            listBox_songy.DataSource = databaze;
        }

        //Aktualizuje první list a vypíše ho
        void SeznamFirst()
        {
            listBox_soundtrack.DataSource = null;
            listBox_soundtrack.DataSource = first_soundtrack;
            status_label(1);
        }

        //Aktualizuje druhý list a vypíše ho
        void SeznamSecond()
        {
            listBox_soundtrack.DataSource = null;
            listBox_soundtrack.DataSource = second_soundtrack;
            status_label(2);

        }

        //Aktualizuje třetí list a vypíše ho
        void SeznamThird()
        {
            listBox_soundtrack.DataSource = null;
            listBox_soundtrack.DataSource = third_soundtrack;
            status_label(3);
        }

        //Aktualizuje čtvrtý list a vypíše ho
        void SeznamFourth()
        {
            listBox_soundtrack.DataSource = null;
            listBox_soundtrack.DataSource = fourth_soundtrack;
            status_label(4);
        }

        //Aktualizuje pátý list a vypíše ho
        void SeznamFifth()
        {
            listBox_soundtrack.DataSource = null;
            listBox_soundtrack.DataSource = fifth_soundtrack;
            status_label(5);
        }
        #endregion

        #region Tool_strip_nabidka

        //Zobrazí první soundtrack
        private void prvníListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeznamFirst();
            volba = 1;
            buttony_up_and_down();
            int sekundy = 0;
            foreach (Song s in first_soundtrack)
            {
                sekundy += s.DELKA;
            }
            casy(sekundy);
            play_button_activate();
        }

        //Zobrazí druhý soundtrack
        private void druhýListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeznamSecond();
            volba = 2;
            buttony_up_and_down();
            int sekundy = 0;
            foreach (Song s in second_soundtrack)
            {
                sekundy += s.DELKA;
            }
            casy(sekundy);
            play_button_activate();
        }

        //Zobrazí třetí soundtrack
        private void třetíListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeznamThird();
            volba = 3;
            buttony_up_and_down();
            int sekundy = 0;
            foreach (Song s in third_soundtrack)
            {
                sekundy += s.DELKA;
            }
            casy(sekundy);
            play_button_activate();
        }

        //Zobrazí čtvrtý soundtrack
        private void čtvrtýListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeznamFourth();
            volba = 4;
            buttony_up_and_down();
            int sekundy = 0;
            foreach (Song s in fourth_soundtrack)
            {
                sekundy += s.DELKA;
            }
            casy(sekundy);
            play_button_activate();
        }

        //Zobrazí patý soundtrack
        private void pátýListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeznamFifth();
            volba = 5;
            buttony_up_and_down();
            int sekundy = 0;
            foreach (Song s in fifth_soundtrack)
            {
                sekundy += s.DELKA;
            }
            casy(sekundy);
            play_button_activate();
        }

        //smaže celý seznam
        private void smazatCelýListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region eng_cast
            if (Settingy.jazyk == true)
            {
                if (MessageBox.Show("Do you really want to erase this track?",
                        "Urgent question", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    switch (volba)
                    {
                        case 0:
                            MessageBox.Show("Select a list from toolbar",
                                         "List missing",
                                          MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                            break;
                        case 1:
                            first_soundtrack.Clear();
                            SeznamFirst();
                            break;
                        case 2:
                            second_soundtrack.Clear();
                            SeznamSecond();
                            break;
                        case 3:
                            third_soundtrack.Clear();
                            SeznamThird();
                            break;
                        case 4:
                            fourth_soundtrack.Clear();
                            SeznamFourth();
                            break;
                        case 5:
                            fifth_soundtrack.Clear();
                            SeznamFifth();
                            break;
                    }
                    casy(0);
                    citace();
                    buttony_up_and_down();
                    play_button_activate();
                }  

            }
            #endregion

            #region cz_cast
            else
            {

                if (MessageBox.Show("Opravdu chcete smazat tento soundtrack?", 
                        "Urgentní dotaz", MessageBoxButtons.YesNo, 
                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    switch (volba)
                    {
                        case 0:
                            MessageBox.Show(Properties.Resources.Vyberte_seznam,
                                         Properties.Resources.Chyba_vkladani_seznamu,
                                          MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                            break;
                        case 1:
                            first_soundtrack.Clear();
                            SeznamFirst();
                            break;
                        case 2:
                            second_soundtrack.Clear();
                            SeznamSecond();
                            break;
                        case 3:
                            third_soundtrack.Clear();
                            SeznamThird();
                            break;
                        case 4:
                            fourth_soundtrack.Clear();
                            SeznamFourth();
                            break;
                        case 5:
                            fifth_soundtrack.Clear();
                            SeznamFifth();
                            break;
                    }
                    casy(0);
                    citace();
                    buttony_up_and_down();
                    play_button_activate();
                }
            }
            #endregion
        }

        //import dat do vybraného seznamu z XML
        private void importovatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // import z XML
            int sekundy = 0, flop = 0;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (Settingy.jazyk == true)
            {
                openFileDialog1.Title = "Load data from file";
            }
            else
            {
                openFileDialog1.Title = "Načtěte data ze souboru";
                openFileDialog1.Filter = "XML files(.xml)|*.xml";
            }
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (volba == 0)
                    if (Settingy.jazyk == true)
                        MessageBox.Show("Choose any list", "Inserting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Vyberte nějaký soundtrack se seznamu", "Chyba při vkládání", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    {
                        string path = openFileDialog1.FileName;
                        using (XmlReader xr = XmlReader.Create(path))
                        {
                            string idcko = "";
                            int id = 0;
                            string autor = "";
                            string nazev = "";
                            int delka = 0;
                            double poradi = 0;
                            string element = "";

                            while (xr.Read())
                            {
                                // načítáme element
                                if (xr.NodeType == XmlNodeType.Element)
                                {
                                    element = xr.Name; // název aktuálního elementu
                                    if (element == "songs")
                                    {
                                        idcko = xr.GetAttribute("id");
                                        id = Convert.ToInt32(idcko);
                                    }
                                }
                                // načítáme hodnotu elementu
                                else if (xr.NodeType == XmlNodeType.Text)
                                {
                                    switch (element)
                                    {
                                        case "autor":
                                            autor = xr.Value;
                                            break;
                                        case "nazev":
                                            nazev = xr.Value;
                                            break;
                                        case "delka":
                                            delka = Convert.ToInt32(xr.Value);
                                            break;
                                        case "poradi":
                                            poradi = Convert.ToInt32(xr.Value);
                                            break;
                                    }
                                }
                                // načítáme ukončující element
                                else if ((xr.NodeType == XmlNodeType.EndElement) && (xr.Name == "songs"))
                                {
                                    switch (volba)
                                    {
                                        case 1:
                                            if (flop == 0)
                                                first_soundtrack.Clear();
                                            first_soundtrack.Add(new Song(id, autor, nazev, delka, poradi));
                                            first = poradi + 1;
                                            SeznamFirst();
                                            flop++;
                                            break;
                                        case 2:
                                            if (flop == 0)
                                                second_soundtrack.Clear();
                                            second_soundtrack.Add(new Song(id, autor, nazev, delka, poradi));
                                            sst = poradi + 1;
                                            SeznamSecond();
                                            flop++;
                                            break;
                                        case 3:
                                            if (flop == 0)
                                                third_soundtrack.Clear();
                                            third_soundtrack.Add(new Song(id, autor, nazev, delka, poradi));
                                            tst = poradi + 1;
                                            SeznamThird();
                                            flop++;
                                            break;
                                        case 4:
                                            if (flop == 0)
                                                fourth_soundtrack.Clear();
                                            fourth_soundtrack.Add(new Song(id, autor, nazev, delka, poradi));
                                            fost = poradi + 1;
                                            SeznamFourth();
                                            flop++;
                                            break;
                                        case 5:
                                            if (flop == 0)
                                                fifth_soundtrack.Clear();
                                            fifth_soundtrack.Add(new Song(id, autor, nazev, delka, poradi));

                                            fivst = poradi + 1;
                                            SeznamFifth();
                                            flop++;
                                            break;
                                    }

                                }
                            }
                        }
                    }
                }
            }
            foreach (Song s in listBox_soundtrack.Items)
            {
                sekundy += s.DELKA;
            }

            casy(sekundy);
            if (flop >= 2)
                buttony_up_and_down();
            play_button_activate();
        }

        //export dat z vybraného seznamu do XML
        private void exportovatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // export do XML
            int poradnik = 0, flop = 0;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Extensible Markup Language|*.xml";
            if (Settingy.jazyk == true)
                saveFileDialog1.Title = "Save as XML file";
            else
                saveFileDialog1.Title = "Ulozit jako XML soubor";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                string path = saveFileDialog1.FileName;

                switch (volba)
                {
                    case 0:
                        if (Settingy.jazyk == true)
                            MessageBox.Show("Nothing to export.\nAt first choose a list ", "Problem with exportem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        MessageBox.Show("Není co exportovat.\nNejprve vyberte nějaký seznam s obsahem", "Problém s exportem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case 1:
                        #region xml_writer
                        using (XmlWriter xw = XmlWriter.Create(path, settings))
                        {
                            xw.WriteStartDocument();
                            xw.WriteStartElement("songy");

                            foreach (Song u in first_soundtrack)
                            {
                                poradnik++;
                                xw.WriteStartElement("songs");
                                xw.WriteAttributeString("id", u.ID.ToString());
                                xw.WriteElementString("autor", u.AUTOR);
                                xw.WriteElementString("nazev", u.NAZEV);
                                xw.WriteElementString("poradi", Convert.ToString(poradnik));
                                xw.WriteElementString("delka", u.DELKA.ToString());
                                xw.WriteEndElement();
                                flop++;

                            }

                            xw.WriteEndElement();
                            xw.WriteEndDocument();
                            xw.Flush();
                        }
                        #endregion
                        break;

                    case 2:
                        #region xml_writer
                        using (XmlWriter xw = XmlWriter.Create(path, settings))
                        {
                            xw.WriteStartDocument();
                            xw.WriteStartElement("songy");

                            foreach (Song u in second_soundtrack)
                            {
                                poradnik++;
                                xw.WriteStartElement("songs");
                                xw.WriteAttributeString("id", u.ID.ToString());
                                xw.WriteElementString("autor", u.AUTOR);
                                xw.WriteElementString("nazev", u.NAZEV);
                                xw.WriteElementString("poradi", Convert.ToString(poradnik));
                                xw.WriteElementString("delka", u.DELKA.ToString());
                                xw.WriteEndElement();
                                flop++;
                            }

                            xw.WriteEndElement();
                            xw.WriteEndDocument();
                            xw.Flush();
                        }
                        #endregion
                        break;

                    case 3:
                        #region xml_writer
                        using (XmlWriter xw = XmlWriter.Create(path, settings))
                        {
                            xw.WriteStartDocument();
                            xw.WriteStartElement("songy");

                            foreach (Song u in third_soundtrack)
                            {
                                poradnik++;
                                xw.WriteStartElement("songs");
                                xw.WriteAttributeString("id", u.ID.ToString());
                                xw.WriteElementString("autor", u.AUTOR);
                                xw.WriteElementString("nazev", u.NAZEV);
                                xw.WriteElementString("poradi", Convert.ToString(poradnik));
                                xw.WriteElementString("delka", u.DELKA.ToString());
                                xw.WriteEndElement();
                                flop++;

                            }

                            xw.WriteEndElement();
                            xw.WriteEndDocument();
                            xw.Flush();
                        }
                        #endregion
                        break;

                    case 4:
                        #region xml_writer
                        using (XmlWriter xw = XmlWriter.Create(path, settings))
                        {
                            xw.WriteStartDocument();
                            xw.WriteStartElement("songy");

                            foreach (Song u in fourth_soundtrack)
                            {
                                poradnik++;
                                xw.WriteStartElement("songs");
                                xw.WriteAttributeString("id", u.ID.ToString());
                                xw.WriteElementString("autor", u.AUTOR);
                                xw.WriteElementString("nazev", u.NAZEV);
                                xw.WriteElementString("poradi", Convert.ToString(poradnik));
                                xw.WriteElementString("delka", u.DELKA.ToString());
                                xw.WriteEndElement();
                                flop++;

                            }

                            xw.WriteEndElement();
                            xw.WriteEndDocument();
                            xw.Flush();
                        }
                        #endregion
                        break;

                    case 5:
                        #region xml_writer
                        using (XmlWriter xw = XmlWriter.Create(path, settings))
                        {
                            xw.WriteStartDocument();
                            xw.WriteStartElement("songy");

                            foreach (Song u in fifth_soundtrack)
                            {
                                poradnik++;
                                xw.WriteStartElement("songs");
                                xw.WriteAttributeString("id", u.ID.ToString());
                                xw.WriteElementString("autor", u.AUTOR);
                                xw.WriteElementString("nazev", u.NAZEV);
                                xw.WriteElementString("poradi", Convert.ToString(poradnik));
                                xw.WriteElementString("delka", u.DELKA.ToString());
                                xw.WriteEndElement();
                                flop++;

                            }

                            xw.WriteEndElement();
                            xw.WriteEndDocument();
                            xw.Flush();
                        }
                        #endregion
                        break;
                }

            }

            if (flop >= 2)
                buttony_up_and_down();
        }

        #region Tutorial
        //zobrazí nápovědu
        private void zobrazitNápověduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_helper.Visible = true;
            label_helper_text.Visible = true;
            button_next_step.Visible = true;
            groupBox_soundtrack.Visible = false;
            groupBox_komponenty.Visible = false;
            groupBox_songy.Visible = false;
            vybratToolStripMenuItem.Visible = false;
            nápovědaToolStripMenuItem.Visible = false;
            if (Settingy.jazyk == true)
                label_helper_text.Text = Properties.Resources.File;
            else
                label_helper_text.Text = Properties.Resources.Soubor;
            button_next_step.Text = "Další krok";
        }

        //Tutorial pro snadnější ovládání ... poučí uživatele o základních funkcích
        private void button_next_step_Click(object sender, EventArgs e)
        {
            help_counter++;

            switch (help_counter)
            {
                case 1:
                    vybratToolStripMenuItem.Visible = true;
                    if (Settingy.jazyk == true)
                        label_helper_text.Text = Properties.Resources.Choose;
                    else
                        label_helper_text.Text = Properties.Resources.Vybrat;
                    break;
                case 2:

                    nápovědaToolStripMenuItem.Visible = true;
                    if (Settingy.jazyk == true)
                        label_helper_text.Text = Properties.Resources.Hint;
                    else
                        label_helper_text.Text = Properties.Resources.Napoveda;
                    break;
                case 3:
                    groupBox_songy.Visible = true;
                    if (Settingy.jazyk == true)
                        label_helper_text.Text = Properties.Resources.Songs;
                    else
                        label_helper_text.Text = Properties.Resources.Songy;
                    break;
                case 4:
                    groupBox_soundtrack.Visible = true;
                    if (Settingy.jazyk == true)
                        label_helper_text.Text = Properties.Resources.Soundtracks;
                    else
                        label_helper_text.Text = Properties.Resources.Soundtracky;
                    break;
                case 5:
                    groupBox_komponenty.Visible = true;
                    if (Settingy.jazyk == true)
                        label_helper_text.Text = Properties.Resources.Components;
                    else
                        label_helper_text.Text = Properties.Resources.Komponenty;
                    break;
                case 6:
                    if (Settingy.jazyk == true)
                        button_next_step.Text = "End of tutorial";
                    else
                        button_next_step.Text = "Konec tutorialu";
                    label_helper.Visible = false;
                    label_helper_text.Visible = false;
                    button_next_step.Visible = false;
                    help_counter = 0;
                    break;
            }

        }
        #endregion

        //zobrazí okno o autorovi
        private void oAutoroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();
            settingsForm.ShowDialog();
        }

        //zobrazí Message Box o programu
        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settingy.jazyk == true)
                MessageBox.Show("Purpose of program is to get credit\nAny abuse is criminal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Účel programu je ukázkový\nJakékoliv další šíření by mohlo být trestné", "Upozornění o programu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //Přeloží většinu textů (některé se musí aktualizovat akcí)
        private void anglickáVerzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region ajina
            if (anglickáVerzeToolStripMenuItem.Text == "Anglická verze")
            {
                Settingy.jazyk = true;
                status_label(volba);
                anglickáVerzeToolStripMenuItem.Text = "Czech version";
                vytvořitToolStripMenuItem.Text = "File";
                importovatToolStripMenuItem.Text = "Import";
                exportovatToolStripMenuItem.Text = "Export";
                prvníListToolStripMenuItem.Text = "First list";
                druhýListToolStripMenuItem.Text = "Second list";
                třetíListToolStripMenuItem.Text = "Third list";
                čtvrtýListToolStripMenuItem.Text = "Fourth list";
                pátýListToolStripMenuItem.Text = "Fifth list";
                smazatCelýListToolStripMenuItem.Text = "Clear list";
                zobrazitNápověduToolStripMenuItem.Text = "Show tutorial";
                oProgramuToolStripMenuItem.Text = "About program";
                oAutoroviToolStripMenuItem.Text = "About author";
                vybratToolStripMenuItem.Text = "Choose";
                nápovědaToolStripMenuItem.Text = "Hint";
                nastaveníToolStripMenuItem.Text = "Settings";
                groupBox_komponenty.Text = "Components";
                groupBox_songy.Text = "Songs";
                label4.Text = "Author";
                label1.Text = "Track";
                label3.Text = "Author";
                label2.Text = "Track";
                button_delete.Text = "Delete";
                button_add.Text = "Add";
                button_next_step.Text = "Next step";
                label5.Text = "Track time:";
                label6.Text = "Actual song:";
                label7.Text = "Next song:";
                label8.Text = "Time:";
                label9.Text = "Playing:";
            }
            #endregion

            #region cestina
            else
            {
                Settingy.jazyk = false;
                status_label(volba);
                anglickáVerzeToolStripMenuItem.Text = "Anglická verze";
                vytvořitToolStripMenuItem.Text = "Soubor";
                importovatToolStripMenuItem.Text = "Importovat";
                exportovatToolStripMenuItem.Text = "Exportovat";
                prvníListToolStripMenuItem.Text = "První list";
                druhýListToolStripMenuItem.Text = "Druhý list";
                třetíListToolStripMenuItem.Text = "Třetí list";
                čtvrtýListToolStripMenuItem.Text = "Čtvrtý list";
                pátýListToolStripMenuItem.Text = "Pátý list";
                smazatCelýListToolStripMenuItem.Text = "Smazat list";
                zobrazitNápověduToolStripMenuItem.Text = "Zobrazit nápovědu";
                oProgramuToolStripMenuItem.Text = "O programu";
                oAutoroviToolStripMenuItem.Text = "O autorovi";
                vybratToolStripMenuItem.Text = "Vybrat";
                nápovědaToolStripMenuItem.Text = "Nápověda";
                nastaveníToolStripMenuItem.Text = "Nastavení";
                groupBox_komponenty.Text = "Komponenty";
                groupBox_songy.Text = "Songy";
                label4.Text = "Autor";
                label1.Text = "Název";
                label3.Text = "Autor";
                label2.Text = "Název";
                button_delete.Text = "Odstranit";
                button_add.Text = "Přidat";
                button_next_step.Text = "Další krok";
                label5.Text = "Celková délka";
                label6.Text = "Aktuální song:";
                label7.Text = "Následující song:";
                label8.Text = "Čas:";
                label9.Text = "Hraje:";
            }
            #endregion
        }

        #endregion

        #region Práce_se_seznamem

        //vypočítává celkový čas soundtracku
        void casy (int sekundy)
        {
            int hodiny = sekundy / 3600;
            int minuty = (sekundy - (hodiny * 3600)) / 60;
            int vteriny = sekundy - (hodiny * 3600) - (minuty * 60);

            if (minuty >= 10 && vteriny < 10)
                label_time.Text = String.Format("{0}:{1}:{2}{3}", hodiny, minuty, "0", vteriny);


            else if (minuty < 10 && vteriny >= 10)
                label_time.Text = String.Format("{0}:{1}{2}:{3}", hodiny, "0", minuty, vteriny);


            else if (minuty < 10 && vteriny < 10)

                label_time.Text = String.Format("{0}:{1}{2}:{3}{4}", hodiny, "0", minuty, "0", vteriny);
            else

                label_time.Text = Convert.ToString(hodiny) + ":" + 
                    Convert.ToString(minuty) + ":" + Convert.ToString(vteriny);
        }

        //přidá ze seznamu písniček do vybraného soundtracku vybranou píseň, následně přepočítá celkový čas soundtracku
        private void button_add_Click(object sender, EventArgs e)
        {

            string fhope = "Bug", shope = "Bug";
            int id = 0, long_enough = 0, sekundy = 0;

            var x = listBox_songy.SelectedItem as Song;

            if (x != null)
            {
                fhope = x.AUTOR;
                shope = x.NAZEV;
                id = x.ID;
                long_enough = x.DELKA;
            }

            switch (volba)
            {
                case 0:
                    MessageBox.Show(Properties.Resources.Vyberte_seznam,
                                     Properties.Resources.Chyba_vkladani_seznamu,
                                      MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                    break;
                case 1:
                    first_soundtrack.Add(new Song(id, fhope, shope, long_enough, first));
                    SeznamFirst();
                    first++;
                    foreach (Song s in first_soundtrack)
                    {
                        sekundy += s.DELKA;
                    }
                    casy(sekundy);
                    break;
                case 2:
                    second_soundtrack.Add(new Song(id, fhope, shope, long_enough, sst));
                    SeznamSecond();
                    sst++;
                    foreach (Song s in second_soundtrack)
                    {
                        sekundy += s.DELKA;
                    }
                    casy(sekundy);
                    break;
                case 3:
                    third_soundtrack.Add(new Song(id, fhope, shope, long_enough, tst));
                    SeznamThird();
                    tst++;
                    foreach (Song s in third_soundtrack)
                    {
                        sekundy += s.DELKA;
                    }
                    casy(sekundy);
                    break;
                case 4:
                    fourth_soundtrack.Add(new Song(id, fhope, shope, long_enough, fost));
                    SeznamFourth();
                    fost++;
                    foreach (Song s in fourth_soundtrack)
                    {
                        sekundy += s.DELKA;
                    }
                    casy(sekundy);
                    break;
                case 5:
                    fifth_soundtrack.Add(new Song(id, fhope, shope, long_enough, fivst));
                    SeznamFifth();
                    fivst++;
                    foreach (Song s in fifth_soundtrack)
                    {
                        sekundy += s.DELKA;
                    }
                    casy(sekundy);
                    break;
            }
            play_button_activate();
            buttony_up_and_down();
        }

        //smaže vybranou položku z vybraného soundtracku a následně přepočítá čas celého soundtracku
        private void button_delete_Click(object sender, EventArgs e)
        {
            double id = 0;
            int sekundy = 0;
            var x = listBox_soundtrack.SelectedItem as Song;

            if (x != null)
            {
                id = x.PORADI;
                switch (volba)
                {
                    case 0:
                        MessageBox.Show(Properties.Resources.Vyberte_seznam,
                                         Properties.Resources.Chyba_vkladani_seznamu,
                                          MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                        break;
                    case 1:
                        for (int i = 0; i < first_soundtrack.Count; i++)
                        {
                            if (first_soundtrack[i].PORADI == id)
                            {
                                first_soundtrack.RemoveAt(i);
                                break;
                            }
                        }

                        SeznamFirst();
                        foreach (Song s in first_soundtrack)
                        {
                            sekundy += s.DELKA;
                        }
                        casy(sekundy);

                        break;
                    case 2:
                        for (int i = 0; i < second_soundtrack.Count; i++)
                        {
                            if (second_soundtrack[i].PORADI == id)
                            {
                                second_soundtrack.RemoveAt(i);
                                break;
                            }
                        }
                        SeznamSecond();
                        
                        foreach (Song s in second_soundtrack)
                        {
                            sekundy += s.DELKA;
                        }
                        casy(sekundy);

                        break;
                    case 3:
                        for (int i = 0; i < third_soundtrack.Count; i++)
                        {
                            if (third_soundtrack[i].PORADI == id)
                            {
                                third_soundtrack.RemoveAt(i);
                                break;
                            }
                        }
                        SeznamThird();

                        foreach (Song s in third_soundtrack)
                        {
                            sekundy += s.DELKA;
                        }
                        casy(sekundy);

                        break;
                    case 4:
                        for (int i = 0; i < fourth_soundtrack.Count; i++)
                        {
                            if (fourth_soundtrack[i].PORADI == id)
                            {
                                fourth_soundtrack.RemoveAt(i);
                                break;
                            }
                        }
                        SeznamFourth();

                        foreach (Song s in fourth_soundtrack)
                        {
                            sekundy += s.DELKA;
                        }
                        casy(sekundy);

                        break;
                    case 5:
                        for (int i = 0; i < fifth_soundtrack.Count; i++)
                        {
                            if (fifth_soundtrack[i].PORADI == id)
                            {
                                fifth_soundtrack.RemoveAt(i);
                                break;
                            }
                        }
                        SeznamFifth();

                        foreach (Song s in fifth_soundtrack)
                        {
                            sekundy += s.DELKA;
                        }
                        casy(sekundy);
                        break;
                }
            }
            play_button_activate();
            buttony_up_and_down();

        }

        //posouvá vybranou položku směrem nahoru ve vybraném seznamu
        private void button_up_Click(object sender, EventArgs e)
        {
            var x = listBox_soundtrack.SelectedItem as Song;
            double id = 0;

            if (x != null)
            {
                id = x.PORADI;

                switch (volba)
                {
                    case 1:
                        int n1 = first_soundtrack.Count;
                        for (int i = 0; i != n1; i++)
                        {

                            if (first_soundtrack[i].PORADI == id)
                            {
                                if (i == 0)
                                {
                                    if (Settingy.jazyk == true)
                                        MessageBox.Show(Properties.Resources.Out_of_range, Properties.Resources.Invalid_range, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    else
                                        MessageBox.Show(Properties.Resources.Mimo_rozsah, Properties.Resources.Neplatny_rozsah, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                                Song tmp = first_soundtrack[i];
                                first_soundtrack[i] = first_soundtrack[i - 1];
                                first_soundtrack[i - 1] = tmp;
                            }
                        }
                        SeznamFirst();
                        break;
                    case 2:
                        int n2 = second_soundtrack.Count;
                        for (int i = 0; i != n2; i++)
                        {
                            if (second_soundtrack[i].PORADI == id)
                            {
                                if (i == 0)
                                {
                                    if (Settingy.jazyk == true)
                                        MessageBox.Show(Properties.Resources.Out_of_range, Properties.Resources.Invalid_range, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    else
                                        MessageBox.Show(Properties.Resources.Mimo_rozsah, Properties.Resources.Neplatny_rozsah, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                                Song tmp = second_soundtrack[i];
                                second_soundtrack[i] = second_soundtrack[i - 1];
                                second_soundtrack[i - 1] = tmp;
                            }
                        }
                        SeznamSecond();

                        break;
                    case 3:
                        int n3 = third_soundtrack.Count;
                        for (int i = 0; i != n3; i++)
                        {
                            if (third_soundtrack[i].PORADI == id)
                            {
                                if (i == 0)
                                {
                                    if (Settingy.jazyk == true)
                                        MessageBox.Show(Properties.Resources.Out_of_range, Properties.Resources.Invalid_range, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    else
                                        MessageBox.Show(Properties.Resources.Mimo_rozsah, Properties.Resources.Neplatny_rozsah, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                                Song tmp = third_soundtrack[i];
                                third_soundtrack[i] = third_soundtrack[i - 1];
                                third_soundtrack[i - 1] = tmp;
                            }
                        }
                        SeznamThird();
                        break;
                    case 4:
                        int n4 = fourth_soundtrack.Count;
                        for (int i = 0; i != n4; i++)
                        {
                            if (fourth_soundtrack[i].PORADI == id)
                            {
                                if (i == 0)
                                {
                                    if (Settingy.jazyk == true)
                                        MessageBox.Show(Properties.Resources.Out_of_range, Properties.Resources.Invalid_range, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    else
                                        MessageBox.Show(Properties.Resources.Mimo_rozsah, Properties.Resources.Neplatny_rozsah, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                                Song tmp = fourth_soundtrack[i];
                                fourth_soundtrack[i] = fourth_soundtrack[i - 1];
                                fourth_soundtrack[i - 1] = tmp;
                            }
                        }
                        SeznamFourth();
                        break;
                    case 5:
                        int n5 = fifth_soundtrack.Count;
                        for (int i = 0; i != n5; i++)
                        {
                            if (fifth_soundtrack[i].PORADI == id)
                            {
                                if (i == 0)
                                {
                                    if (Settingy.jazyk == true)
                                        MessageBox.Show(Properties.Resources.Out_of_range, Properties.Resources.Invalid_range, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    else
                                        MessageBox.Show(Properties.Resources.Mimo_rozsah, Properties.Resources.Neplatny_rozsah, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                                Song tmp = fifth_soundtrack[i];
                                fifth_soundtrack[i] = fifth_soundtrack[i - 1];
                                fifth_soundtrack[i - 1] = tmp;
                            }
                        }
                        SeznamFifth();
                        break;
                }
            }
        }

        //posouvá vybranou položku směrem dolu ve vybraném seznamu
        private void button_down_Click(object sender, EventArgs e)
        {
            var x = listBox_soundtrack.SelectedItem as Song;
            double id = 0;
            int poradi = 0;

            if (x != null)
            {
                id = x.PORADI;

                switch (volba)
                {
                    case 1:
                        int n1 = first_soundtrack.Count;
                        do
                        {
                            if (first_soundtrack[poradi].PORADI == id)
                            {
                                break;
                            }
                            poradi++;
                        } while (poradi != n1);

                        if (poradi == n1 - 1)
                        {
                            if (Settingy.jazyk == true)
                                MessageBox.Show(Properties.Resources.Out_of_range, Properties.Resources.Invalid_range, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show(Properties.Resources.Mimo_rozsah, Properties.Resources.Neplatny_rozsah, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            Song tmp = first_soundtrack[poradi];

                            first_soundtrack[poradi] = first_soundtrack[poradi + 1];

                            first_soundtrack[poradi + 1] = tmp;
                        }

                        SeznamFirst();
                        break;
                    case 2:
                        int n2 = second_soundtrack.Count;
                        do
                        {
                            if (second_soundtrack[poradi].PORADI == id)
                            {
                                break;
                            }
                            poradi++;
                        } while (poradi != n2);

                        if (poradi == n2 - 1)
                        {
                            if (Settingy.jazyk == true)
                                MessageBox.Show(Properties.Resources.Out_of_range, Properties.Resources.Invalid_range, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show(Properties.Resources.Mimo_rozsah, Properties.Resources.Neplatny_rozsah, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            Song tmp = second_soundtrack[poradi];

                            second_soundtrack[poradi] = second_soundtrack[poradi + 1];

                            second_soundtrack[poradi + 1] = tmp;
                        }
                        SeznamSecond();

                        break;
                    case 3:
                        int n3 = third_soundtrack.Count;
                        do
                        {
                            if (third_soundtrack[poradi].PORADI == id)
                            {
                                break;
                            }
                            poradi++;
                        } while (poradi != n3);

                        if (poradi == n3 - 1)
                        {
                            if (Settingy.jazyk == true)
                                MessageBox.Show(Properties.Resources.Out_of_range, Properties.Resources.Invalid_range, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show(Properties.Resources.Mimo_rozsah, Properties.Resources.Neplatny_rozsah, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            Song tmp = third_soundtrack[poradi];

                            third_soundtrack[poradi] = third_soundtrack[poradi + 1];

                            third_soundtrack[poradi + 1] = tmp;
                        }
                        SeznamThird();
                        break;
                    case 4:
                        int n4 = fourth_soundtrack.Count;
                        do
                        {
                            if (fourth_soundtrack[poradi].PORADI == id)
                            {
                                break;
                            }
                            poradi++;
                        } while (poradi != n4);

                        if (poradi == n4 - 1)
                        {
                            if (Settingy.jazyk == true)
                                MessageBox.Show(Properties.Resources.Out_of_range, Properties.Resources.Invalid_range, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show(Properties.Resources.Mimo_rozsah, Properties.Resources.Neplatny_rozsah, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            Song tmp = fourth_soundtrack[poradi];

                            fourth_soundtrack[poradi] = fourth_soundtrack[poradi + 1];

                            fourth_soundtrack[poradi + 1] = tmp;
                        }
                        SeznamFourth();
                        break;
                    case 5:
                        int n5 = fifth_soundtrack.Count;
                        do
                        {
                            if (fifth_soundtrack[poradi].PORADI == id)
                            {
                                break;
                            }
                            poradi++;
                        } while (poradi != n5);

                        if (poradi == n5 - 1)
                        {
                            if (Settingy.jazyk == true)
                                MessageBox.Show(Properties.Resources.Out_of_range, Properties.Resources.Invalid_range, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show(Properties.Resources.Mimo_rozsah, Properties.Resources.Neplatny_rozsah, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            Song tmp = fifth_soundtrack[poradi];

                            fifth_soundtrack[poradi] = fifth_soundtrack[poradi + 1];

                            fifth_soundtrack[poradi + 1] = tmp;
                        }
                        SeznamFifth();
                        break;
                }
            }
        }

        //přetypuje u všech záznamů ve vybraném listu pořadí pro přehrátí
        void retype_poradi()
        {
            ushort count = 1;

            foreach (Song s in listBox_soundtrack.Items)
            {
                s.PLAY = count;
                count++;
            }
            #region switch_update
            /*
            switch (volba)
            {
                case 1:
                    foreach (Song s in first_soundtrack)
                    {
                        s.PLAY = count;
                        count++;
                    }
                    break;
                case 2:
                    foreach (Song s in second_soundtrack)
                    {
                        s.PLAY = count;
                        count++;
                    }
                    break;
                case 3:
                    foreach (Song s in third_soundtrack)
                    {
                        s.PLAY = count;
                        count++;
                    }
                    break;
                case 4:
                    foreach (Song s in fourth_soundtrack)
                    {
                        s.PLAY = count;
                        count++;
                    }
                    break;
                case 5:
                    foreach (Song s in fifth_soundtrack)
                    {
                        s.PLAY = count;
                        count++;
                    }
                    break;
            }*/
            #endregion
        }

        //vyresetuje čítače pro jednolivé úlohy seznamů
        void citace()
        {
            switch (volba)
            {
                case 1:
                    first = 1;
                    break;
                case 2:
                    sst = 1;
                    break;
                case 3:
                    tst = 1;
                    break;
                case 4:
                    fost = 1;
                    break;
                case 5:
                    fivst = 1;
                    break;
            }
        }

        #endregion

        #region Play_menu

        //ovládání posuvníku hlasitosti
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            trackBar1.Minimum = 0;
            trackBar1.Maximum = 10;
            WMP.settings.volume = trackBar1.Value * 10;

        }

        //spodní button pro přehrávání
        private void button_play_play_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.play();
            timer_start.Start();
        }

        //button pro pozastavení soundtracku
        private void button_pause_play_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.pause();
            timer_start.Stop();
        }

        //button pro tvrdé zastavení soundtracku
        private void button_stop_play_Click(object sender, EventArgs e)
        {
            change_play_menu_back();
            menuStrip1.Enabled = true;
            groupBox_play_menu.Enabled = false;
            groupBox_komponenty.Enabled = true;
            groupBox_songy.Enabled = true;
            groupBox_soundtrack.Enabled = true;
            Height = 456;
            Width = 836;

            WMP.Ctlcontrols.stop();
            timer_start.Stop();

            if (listBox_soundtrack.Items.Count < 2)
            {
                button_next_play.Enabled = false;
                button_back_play.Enabled = false;
            }


        }

        //button pro přeskočení písné zpět
        private void button_back_play_Click(object sender, EventArgs e)
        {
            string song = "";
            play_index--;
            set_song_count();

            WMP.Ctlcontrols.stop();
            foreach (Song s in listBox_soundtrack.Items)
            {
                if (s.PLAY == play_index)
                {
                    timing = (ushort)s.DELKA;
                    song = Convert.ToString(s.ID);
                }
            }

            label_actual_song_play.Text = String.Format("{0} - {1}", actual_band_name(), actual_song_name());
            label_next_song_play.Text = String.Format("{0} - {1}", next_band_name(), next_song_name());

            WMP.URL = song + ".mp3";
            WMP.Ctlcontrols.play();



        }
        
        //button pro přeskočení písné vpřed
        private void button_next_play_Click(object sender, EventArgs e)
        {
            string song = "";
            play_index++;
            set_song_count();


            WMP.Ctlcontrols.stop();

            foreach (Song s in listBox_soundtrack.Items)
            {
                if (s.PLAY == play_index)
                {
                    timing = (ushort)s.DELKA;
                    song = Convert.ToString(s.ID);
                }
            }

            label_actual_song_play.Text = String.Format("{0} - {1}", actual_band_name(), actual_song_name());
            label_next_song_play.Text = String.Format("{0} - {1}", next_band_name(), next_song_name());

            WMP.URL = song + ".mp3";
            WMP.Ctlcontrols.play();
        }

        //horní button pro přehrávání soundtracku
        private void button_play_Click(object sender, EventArgs e)
        {
            change_play_menu();
            play_index = 1;
            set_song_count();
            retype_poradi();
            label_actual_song_play.Text = String.Format("{0} - {1}", actual_band_name(), actual_song_name());
            label_next_song_play.Text = String.Format("{0} - {1}", next_band_name(), next_song_name());

            trackBar1.Value = WMP.settings.volume / 10;

            string song = "";

            foreach (Song s in listBox_soundtrack.Items)
            {
                if (s.PLAY == play_index)
                {
                    timing = (ushort)s.DELKA;
                    song = Convert.ToString(s.ID);
                }
            }

            try
            {
                timer_start.Start();
                WMP.URL = song + ".mp3";
                WMP.Ctlcontrols.play();

            }
            catch (Exception)
            {
                if (Settingy.jazyk == true)
                    MessageBox.Show("Error", "Hustone we have a problem", MessageBoxButtons.OK);
                else

                    MessageBox.Show("Chyba", "Hustone máme problém", MessageBoxButtons.OK);
            }

        }

        #endregion

        #region Podminky_maker

        //povoluje x zakazuje buttony na posouvání v seznamu (pokud nejsou alespoň 2 songy v soundtracku tak zakazuje)
        void buttony_up_and_down()
        {

            if (listBox_soundtrack.Items.Count >= 2)
            {
                button_down.Enabled = true;
                button_up.Enabled = true;
            }
            else
            {
                button_down.Enabled = false;
                button_up.Enabled = false;
            }

        }

        //aktivuje horní button pro přehrávání - může být aktivován, když je alespoň 1 song v soundtracku
        void play_button_activate()
        {
            if (listBox_soundtrack.Items.Count >= 1)
                button_play.Enabled = true;
            else
                button_play.Enabled = false;
        }

        //povoluje x zakazuje posouvání písní ... nesmí zajít před dolní a za horní hranici
        private void label_seznam_play_TextChanged(object sender, EventArgs e)
        {
            if (play_index != 1)
                button_back_play.Enabled = true;
            else
                button_back_play.Enabled = false;
            if (play_index == listBox_soundtrack.Items.Count)
                button_next_play.Enabled = false;
            else
                button_next_play.Enabled = true;
        }

        #endregion

        #region Upravy_formulare

        //Upravuje formular na podobu s play boxem
        void change_play_menu()
        {
            menuStrip1.Enabled = false;
            groupBox_play_menu.Enabled = true;
            groupBox_komponenty.Enabled = false;
            groupBox_songy.Enabled = false;
            groupBox_soundtrack.Enabled = false;
            Height = 530;
            Width = 836;
        }

        //Upravuje formular na podobu bez play boxu
        void change_play_menu_back()
        {
            menuStrip1.Enabled = true;
            groupBox_play_menu.Enabled = false;
            groupBox_komponenty.Enabled = true;
            groupBox_songy.Enabled = true;
            groupBox_soundtrack.Enabled = true;
            Height = 456;
            Width = 836;
        }
        #endregion

        #region Vypisovani_informaci
        //Vrátí velikost aktuálního soundtracku
        int count_song()
        {
            int promena_cs = listBox_soundtrack.Items.Count;
            return promena_cs;
        }

        //Vrátí název aktuálního songu + obsahuje starou verzy se switchem
        string actual_song_name()
        {
            string as_name = "";

            foreach (Song s in listBox_soundtrack.Items)
            {
                if (s.PLAY == play_index)
                {
                    as_name = s.NAZEV;
                    break;
                }
            }
            #region switch_version
            /*
            switch (volba)
            {
                case 1:
                    foreach (Song s in first_soundtrack)
                    {
                        if (s.PLAY == play_index)
                        {
                            as_name = s.NAZEV;
                            break;
                        }
                    }
                    break;
                case 2:
                    foreach (Song s in second_soundtrack)
                    {
                        if (s.PLAY == play_index)
                        {
                            as_name = s.NAZEV;
                            break;
                        }
                    }
                    break;
                case 3:
                    foreach (Song s in third_soundtrack)
                    {
                        if (s.PLAY == play_index)
                        {
                            as_name = s.NAZEV;
                            break;
                        }
                    }
                    break;
                case 4:
                    foreach (Song s in fourth_soundtrack)
                    {
                        if (s.PLAY == play_index)
                        {
                            as_name = s.NAZEV;
                            break;
                        }
                    }
                    break;
                case 5:
                    foreach (Song s in fifth_soundtrack)
                    {
                        if (s.PLAY == play_index)
                        {
                            as_name = s.NAZEV;
                            break;
                        }
                    }
                    break;
            }*/
            #endregion
            return as_name;
        }

        //Vrátí název aktuální kapely + obsahuje starou verzy se switchem
        string actual_band_name()
        {
            string as_name = "";

            foreach (Song s in listBox_soundtrack.Items)
            {
                if (s.PLAY == play_index)
                {
                    as_name = s.AUTOR;
                    break;
                }
            }

            #region switch_version
            /*
            switch (volba)
            {
                case 1:
                    foreach (Song s in first_soundtrack)
                    {
                        if (s.PLAY == play_index)
                        {
                            as_name = s.AUTOR;
                            break;
                        }
                    }
                    break;
                case 2:
                    foreach (Song s in second_soundtrack)
                    {
                        if (s.PLAY == play_index)
                        {
                            as_name = s.AUTOR;
                            break;
                        }
                    }
                    break;
                case 3:
                    foreach (Song s in third_soundtrack)
                    {
                        if (s.PLAY == play_index)
                        {
                            as_name = s.AUTOR;
                            break;
                        }
                    }
                    break;
                case 4:
                    foreach (Song s in fourth_soundtrack)
                    {
                        if (s.PLAY == play_index)
                        {
                            as_name = s.AUTOR;
                            break;
                        }
                    }
                    break;
                case 5:
                    foreach (Song s in fifth_soundtrack)
                    {
                        if (s.PLAY == play_index)
                        {
                            as_name = s.AUTOR;
                            break;
                        }
                    }
                    break;
            }
            */
            #endregion
            return as_name;
        }

        //Vrátí název dalšího songu + obsahuje starou verzy se switchem
        string next_song_name()
        {
            string ns_name = "";


            foreach (Song s in listBox_soundtrack.Items)
            {
                if (s.PLAY == play_index + 1)
                {
                    ns_name = s.NAZEV;
                    break;
                }
                else
                {
                    if (Settingy.jazyk == true)
                        ns_name = "End";
                    else
                        ns_name = "Konec";
                }
            }
            #region switch_version
            /*
            switch (volba)
            {
                case 1:
                    foreach (Song s in first_soundtrack)
                    {
                        if (s.PLAY == play_index + 1)
                        {
                            ns_name = s.NAZEV;
                            break;
                        }
                        else
                        {
                            ns_name = "Konec";
                        }
                    }
                    break;
                case 2:
                    foreach (Song s in second_soundtrack)
                    {
                        if (s.PLAY == play_index + 1)
                        {
                            ns_name = s.NAZEV;
                            break;
                        }
                        else
                        {
                            ns_name = "Konec";
                        }
                    }
                    break;
                case 3:
                    foreach (Song s in third_soundtrack)
                    {
                        if (s.PLAY == play_index + 1)
                        {
                            ns_name = s.NAZEV;
                            break;
                        }
                        else
                        {
                            ns_name = "Konec";
                        }
                    }
                    break;
                case 4:
                    foreach (Song s in fourth_soundtrack)
                    {
                        if (s.PLAY == play_index + 1)
                        {
                            ns_name = s.NAZEV;
                            break;
                        }
                        else
                        {
                            ns_name = "Konec";
                        }
                    }
                    break;
                case 5:
                    foreach (Song s in fifth_soundtrack)
                    {
                        if (s.PLAY == play_index + 1)
                        {
                            ns_name = s.NAZEV;
                            break;
                        }
                        else
                        {
                            ns_name = "Konec";
                        }
                    }
                    break;
            }*/
            #endregion

            return ns_name;
        }

        //Vrátí název další kapely + obsahuje starou verzy se switchem
        string next_band_name()
        {
            string nb_name = "";

            foreach (Song s in listBox_soundtrack.Items)
            {
                if (s.PLAY == play_index + 1)
                {
                    nb_name = s.AUTOR;
                    break;
                }
                else
                {
                    if (Settingy.jazyk == true)
                        nb_name = "End";
                    else
                        nb_name = "Konec";
                }
            }
            #region switch_version
            /*
            switch (volba)
            {
                case 1:
                    foreach (Song s in first_soundtrack)
                    {
                        if (s.PLAY == play_index + 1)
                        {
                            ns_name = s.AUTOR;
                            break;
                        }
                        else
                        {
                            ns_name = "Konec";
                        }
                    }
                    break;
                case 2:
                    foreach (Song s in second_soundtrack)
                    {
                        if (s.PLAY == play_index + 1)
                        {
                            ns_name = s.AUTOR;
                            break;
                        }
                        else
                        {
                            ns_name = "Konec";
                        }
                    }
                    break;
                case 3:
                    foreach (Song s in third_soundtrack)
                    {
                        if (s.PLAY == play_index + 1)
                        {
                            ns_name = s.AUTOR;
                            break;
                        }
                        else
                        {
                            ns_name = "Konec";
                        }
                    }
                    break;
                case 4:
                    foreach (Song s in fourth_soundtrack)
                    {
                        if (s.PLAY == play_index + 1)
                        {
                            ns_name = s.AUTOR;
                            break;
                        }
                        else
                        {
                            ns_name = "Konec";
                        }
                    }
                    break;
                case 5:
                    foreach (Song s in fifth_soundtrack)
                    {
                        if (s.PLAY == play_index + 1)
                        {
                            ns_name = s.AUTOR;
                            break;
                        }
                        else
                        {
                            ns_name = "Konec";
                        }
                    }
                    break;
            }*/
            #endregion
            return nb_name;
        }

        //Vypíše aktuální písničku + celkové množstvý písniček
        void set_song_count()
        {
            label_seznam_play.Text = String.Format("{0}/{1}", play_index, count_song());
        }
        #endregion

        //Timer zastává funkci odpočtu písničky a spouští navazující písničky
        private void timer_start_Tick(object sender, EventArgs e)
        {
            string song ="";

            int sekundy = timing;
            int hodiny = sekundy / 3600;
            int minuty = (sekundy - (hodiny * 3600)) / 60;
            int vteriny = sekundy - (hodiny * 3600) - (minuty * 60);

            if (minuty >= 10 && vteriny < 10)
                label_time_play.Text = 0+String.Format("{0}:{1}:{2}{3}", hodiny, minuty,"0", vteriny);

            if (minuty < 10 && vteriny >= 10)
                label_time_play.Text = 0 + String.Format("{0}:{1}{2}:{3}", hodiny,"0", minuty, vteriny);

            if (minuty < 10 && vteriny < 10)
                label_time_play.Text = 0 + String.Format("{0}:{1}{2}:{3}{4}", hodiny,"0", minuty,"0", vteriny);


            timing--;

            if (timing == 0)
            {
                play_index++;
                set_song_count();
                WMP.Ctlcontrols.stop();

                foreach (Song s in listBox_soundtrack.Items)
                {

                    if (s.PLAY == play_index)
                    {
                        timing = (ushort)s.DELKA;
                        song = Convert.ToString(s.ID);

                        label_actual_song_play.Text = String.Format("{0} - {1}", actual_band_name(), actual_song_name());
                        label_next_song_play.Text = String.Format("{0} - {1}", next_band_name(), next_song_name());
                        try
                        {

                            WMP.URL = song + ".mp3";
                            WMP.Ctlcontrols.play();
                        }
                        catch (Exception)
                        {
                            if (Settingy.jazyk == true)
                                MessageBox.Show("Error", "Hustone we have a problem", MessageBoxButtons.OK);
                            else

                                MessageBox.Show("Chyba", "Hustone máme problém", MessageBoxButtons.OK);
                        }


                    }

                    if (play_index > listBox_soundtrack.Items.Count)
                    {
                        change_play_menu_back();
                        timer_start.Stop();
                        WMP.Ctlcontrols.stop();

                    }
                }

                
                

            }
        }

        

        

       

    }

}
