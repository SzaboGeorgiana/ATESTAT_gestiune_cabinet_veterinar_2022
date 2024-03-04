using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATESTAT000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          //  tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            textBox1.Text = "";
            label4.Text = "";

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuStrip2.Visible = true;
            label9.Text = "";
            label10.Text = "";
            label54.Text = "";
            label55.Text = "";
            tabControl1.SelectedTab = tabPage3;
            preturiTableAdapter.Fill(registruDataSet.Preturi);
            DataTable t = registruDataSet.Preturi;
            for (int i = 0; i <= t.Rows.Count / 2; i++)
            {
                label9.Text += t.Rows[i]["procedura"] + "\n";
                label54.Text += " -    " + t.Rows[i]["cost"] + " ron \n";
            }
            for (int i = t.Rows.Count / 2 + 1; i < t.Rows.Count; i++)
            {
                label10.Text += t.Rows[i]["procedura"] + "\n";
                label55.Text += " -    " + t.Rows[i]["cost"] + " ron \n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text.Trim();
            string s = "abcde123";
            if (t.Length > 0)
            {
                if (string.Compare(t, s) == 0)
                {
                    menuStrip1.Visible = true;
                    label4.Text = "";
                    tabControl1.SelectedTab = tabPage4;
                    ///
                    label6.Text = "";
                    label20.Text = "";
                    monthCalendar1.SelectionStart = DateTime.Now;
                    listBox3.Items.Clear();
                    DateTime dt = monthCalendar1.SelectionStart;
                    programariTableAdapter.prog_dataX(registruDataSet.Programari, dt.ToShortDateString());
                    DataTable tab = registruDataSet.Programari;
                    for (int i = 0; i < tab.Rows.Count; i++)
                    {
                        listBox3.Items.Add(tab.Rows[i]["ID_anim"]);
                    }
                    ///
                }
                else
                {
                    textBox1.Text = "";
                    label4.Text = "Parola gresita!";


                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registruDataSet.Programari' table. You can move, or remove it, as needed.
            this.programariTableAdapter.Fill(this.registruDataSet.Programari);
            // TODO: This line of code loads data into the 'registruDataSet.Preturi' table. You can move, or remove it, as needed.
            this.preturiTableAdapter.Fill(this.registruDataSet.Preturi);
            // TODO: This line of code loads data into the 'registruDataSet.Boli' table. You can move, or remove it, as needed.
            this.boliTableAdapter.Fill(this.registruDataSet.Boli);
            // TODO: This line of code loads data into the 'registruDataSet.Informatii_Animale' table. You can move, or remove it, as needed.
            this.informatii_AnimaleTableAdapter.Fill(this.registruDataSet.Informatii_Animale);
            registruDataSet.EnforceConstraints = false;

        }

        private void preturiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            label10.Text = "";
            label54.Text = "";
            label55.Text = "";
            tabControl1.SelectedTab = tabPage3;
            preturiTableAdapter.Fill(registruDataSet.Preturi);
            DataTable t = registruDataSet.Preturi;
            for (int i = 0; i <= t.Rows.Count / 2; i++)
            {
                label9.Text += t.Rows[i]["procedura"] + "\n";
                label54.Text += " -    " + t.Rows[i]["cost"] + " ron \n";
            }
            for (int i = t.Rows.Count / 2 + 1; i < t.Rows.Count; i++)
            {
                label10.Text += t.Rows[i]["procedura"] + "\n";
                label55.Text += " -    " + t.Rows[i]["cost"] + " ron \n";
            }
        }

        private void revenireLaPaginaDeeStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            menuStrip1.Visible = false;
        }

        private void revenireLaPaginaDeStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            menuStrip2.Visible = false;
        }

        private void caracteristiciGeneraleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
            textBox2.Text = "";
            label12.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string t = textBox2.Text.Trim();
            label12.Text = "";
            if (t.Length > 0)
            {
                informatii_AnimaleTableAdapter.AnimalX(registruDataSet.Informatii_Animale, t);
                int i = 0;
                DataTable tab = registruDataSet.Informatii_Animale;
                if (tab.Rows.Count > 0)
                {
                    label12.Text += "Nume: " + tab.Rows[i]["nume"] + "\n";
                    label12.Text += "Rasa: " + tab.Rows[i]["rasa"] + "\n";
                    label12.Text += "Greutate: " + tab.Rows[i]["greutate"] + "\n";
                    label12.Text += "Gen: " + tab.Rows[i]["gen"] + "\n";
                    label12.Text += "Data nasterii: " + tab.Rows[i]["data_n"] + "\n";
                }
                else
                    label12.Text = "Nu exista niciun animal inregistrat cu acest ID.";
            }
        }

        private void viitoareProgramariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
            listBox1.Items.Clear();
            textBox3.Text = "";
            label13.Text = "";


        }


        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string t = textBox3.Text.Trim();
            label13.Text = "";
            if (t.Length > 0)
            {
                programariTableAdapter.programari_animalX(registruDataSet.Programari, t);
                DataTable tab = registruDataSet.Programari;
                if (tab.Rows.Count > 0)
                {
                    for (int i = 0; i < tab.Rows.Count; i++)
                    {
                        DateTime d = (DateTime.Parse(tab.Rows[i]["data_prog"].ToString()));
                        if (d.Year > DateTime.Now.Year)
                            listBox1.Items.Add(tab.Rows[i]["data_prog"]);
                        else
                            if (d.Year == DateTime.Now.Year)
                            {
                                if (d.Month > DateTime.Now.Month)
                                    listBox1.Items.Add(tab.Rows[i]["data_prog"]);
                                else
                                    if (d.Month == DateTime.Now.Month)
                                        if (d.Day >= DateTime.Now.Day)
                                            listBox1.Items.Add(tab.Rows[i]["data_prog"]);
                            }

                    }
                    if(listBox1.Items.Count==0)
                        label13.Text = "Nu exista nicio \nprogramare viitoare.";
                }
                else

                    label13.Text = "Nu exista niciun animal \ninregistrat cu acest ID.";
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string t = textBox3.Text.Trim();
            label13.Text = "";
            if (t.Length > 0)
            {
                programariTableAdapter.programari_animalX(registruDataSet.Programari, t);
                DataTable tab = registruDataSet.Programari;


                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    DateTime d = (DateTime.Parse(tab.Rows[i]["data_prog"].ToString()));
                    if (d.Year < DateTime.Now.Year)
                        tab.Rows[i].Delete();
                    else
                        if (d.Year == DateTime.Now.Year)
                        {
                            if (d.Month < DateTime.Now.Month)
                                tab.Rows[i].Delete();
                            else
                                if (d.Month == DateTime.Now.Month)
                                    if (d.Day < DateTime.Now.Day)
                                        tab.Rows[i].Delete();
                        }

                }
                registruDataSet.AcceptChanges();
                if (listBox1.SelectedIndex != -1)
                {

                    label13.Text += "Animalul dumneavoastra, " + tab.Rows[listBox1.SelectedIndex]["nume"] + ",\n" + "are de efectuat " + tab.Rows[listBox1.SelectedIndex]["motiv"] + ".\n";
                    label13.Text += "Veti avea de achitat: ";
                    if (string.Compare(tab.Rows[listBox1.SelectedIndex]["motiv"].ToString(), "deparazitare interna(o pastila/10 kg)") == 0)
                    {
                        int p = int.Parse(tab.Rows[listBox1.SelectedIndex]["greutate"].ToString()) / 10 + 1;
                        p = p * int.Parse(tab.Rows[listBox1.SelectedIndex]["cost"].ToString());
                        label13.Text += p + " ron";
                    }
                    else
                        label13.Text += tab.Rows[listBox1.SelectedIndex]["cost"] + " ron";
                }
            }

        }

        private void proceduriNeefectuateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
            listBox2.Items.Clear();
            textBox4.Text = "";
            label15.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string t = textBox4.Text.Trim();
            label15.Text = "";
            if (t.Length > 0)
            {
                programariTableAdapter.programari_animalX(registruDataSet.Programari, t);
                DataTable tab = registruDataSet.Programari;
                if (tab.Rows.Count > 0)
                {
                    for (int i = 0; i < tab.Rows.Count; i++)
                    {
                        DateTime d = (DateTime.Parse(tab.Rows[i]["data_prog"].ToString()));
                        if (d.Year < DateTime.Now.Year)
                        {
                            if (bool.Parse(tab.Rows[i]["efectuat"].ToString()) == false)
                                listBox2.Items.Add(tab.Rows[i]["data_prog"]);
                        }
                        else
                            if (d.Year == DateTime.Now.Year)
                            {
                                if (d.Month < DateTime.Now.Month)
                                {
                                    if (bool.Parse(tab.Rows[i]["efectuat"].ToString()) == false)
                                        listBox2.Items.Add(tab.Rows[i]["data_prog"]);
                                }
                                else
                                    if (d.Month == DateTime.Now.Month)
                                        if (d.Day < DateTime.Now.Day)
                                            if (bool.Parse(tab.Rows[i]["efectuat"].ToString()) == false)
                                                listBox2.Items.Add(tab.Rows[i]["data_prog"]);
                            }

                    }

                    if (listBox2.Items.Count == 0)
                        label15.Text = "Nu exista nicio \nconsultatie neefectuata.";
                }
                else label15.Text = "Nu exista niciun animal \ninregistrat cu acest ID.";

            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string t = textBox4.Text.Trim();
            label15.Text = "";
            if (t.Length > 0)
            {
                programariTableAdapter.programari_animalX(registruDataSet.Programari, t);
                DataTable tab = registruDataSet.Programari;


                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    DateTime d = (DateTime.Parse(tab.Rows[i]["data_prog"].ToString()));
                    if (d.Year > DateTime.Now.Year)
                        tab.Rows[i].Delete();
                    else
                        if (d.Year == DateTime.Now.Year)
                        {
                            if (d.Month > DateTime.Now.Month)
                                tab.Rows[i].Delete();
                            else
                                if (d.Month == DateTime.Now.Month)
                                    if (d.Day >= DateTime.Now.Day)
                                        tab.Rows[i].Delete();
                        }

                }
                registruDataSet.AcceptChanges();
                for (int i = 0; i < tab.Rows.Count; i++)
                    if (bool.Parse(tab.Rows[i]["efectuat"].ToString()) == true)
                        tab.Rows[i].Delete();

                registruDataSet.AcceptChanges();
                if (listBox2.SelectedIndex != -1)
                {

                    label15.Text += "Animalul dumneavoastra, " + tab.Rows[listBox2.SelectedIndex]["nume"] + ",\n" + "ar fi avut de efectuat " + tab.Rows[listBox2.SelectedIndex]["motiv"] + ".\n";
                    label15.Text += "Suma de achitat: ";
                    if (string.Compare(tab.Rows[listBox2.SelectedIndex]["motiv"].ToString(), "deparazitare interna(o pastila/10 kg)") == 0)
                    {
                        int p = int.Parse(tab.Rows[listBox2.SelectedIndex]["greutate"].ToString()) / 10 + 1;
                        p = p * int.Parse(tab.Rows[listBox2.SelectedIndex]["cost"].ToString());
                        label15.Text += p + " ron";
                    }
                    else
                        label15.Text += tab.Rows[listBox2.SelectedIndex]["cost"] + " ron";
                }
            }
        }

        private void tratamentPentruBolileDeCareSuferaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            label19.Text = "";
            textBox5.Text = "";
            label17.Text = "";
            comboBox1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label19.Text = "";
            comboBox1.Text = "";
            comboBox1.Visible = false;
            comboBox1.Items.Clear();
            string t = textBox5.Text.Trim();
            label17.Text = "";
            if (t.Length > 0)
            {
                boliTableAdapter.boli_animalX(registruDataSet.Boli, t);
                DataTable tab = registruDataSet.Boli;
                if (tab.Rows.Count > 0)
                {
                    for (int i = 0; i < tab.Rows.Count; i++)
                        comboBox1.Items.Add(tab.Rows[i]["boala"]);
                    label17.Text = "Animalul dumneavoastra, " + tab.Rows[0]["nume"] + ", \n" + "sufera in prezent urmatoarele boli: ";
                    comboBox1.Visible = true;
                }
                else
                {
                    informatii_AnimaleTableAdapter.AnimalX(registruDataSet.Informatii_Animale, t);
                    DataTable tab1 = registruDataSet.Informatii_Animale;
                    if (tab1.Rows.Count > 0)
                        label17.Text = "Animalul dumneavoastra, in prezent, \nnu sufera de nicio boala. ";
                    else
                        label17.Text = "Nu exista niciun animal inregistrat \ncu acest ID.";
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string t = textBox5.Text.Trim();
                if (t.Length > 0)
                {
                    boliTableAdapter.boli_animalX(registruDataSet.Boli, t);

                    DataTable tab = registruDataSet.Boli;
                    object o = tab.Rows[comboBox1.SelectedIndex]["tratament"];
                    if (o.ToString() != "")
                    {
                        label19.Text = "Pentru boala " + comboBox1.SelectedItem + " tratamentul recomandat \nde medic este: ";
                        label19.Text += tab.Rows[comboBox1.SelectedIndex]["tratament"] + ".";
                    }
                    else
                        label19.Text = "Pentru boala " + comboBox1.SelectedItem + " nu exista \nun tratament recomandat de medic.";
                }
            }
        }

        private void programarileZilniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            tabControl1.SelectedTab = tabPage4;
            monthCalendar1.SelectionStart = DateTime.Now;
            DateTime dt = monthCalendar1.SelectionStart;
            label6.Text = "";
            label20.Text = "";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            listBox3.Items.Clear();
            label6.Text = "";
            label20.Text = "";
            DateTime dt = monthCalendar1.SelectionStart;
            programariTableAdapter.prog_dataX(registruDataSet.Programari, dt.ToShortDateString());
            DataTable tab = registruDataSet.Programari;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox3.Items.Add(tab.Rows[i]["ID_anim"]);
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                label6.Text = "";
                label20.Text = "";
                DateTime dt = monthCalendar1.SelectionStart;
                programariTableAdapter.prog_dataX(registruDataSet.Programari, dt.ToShortDateString());
                DataTable tab = registruDataSet.Programari;
                label6.Text = "Numele animalului: " + tab.Rows[listBox3.SelectedIndex]["nume"] + "\n";
                label6.Text += "Tipul animalului: " + tab.Rows[listBox3.SelectedIndex]["tip"] + "\n";
                label6.Text += "Sexul animalului: " + tab.Rows[listBox3.SelectedIndex]["gen"] + "\n";
                label6.Text += "Rasa animalului: " + tab.Rows[listBox3.SelectedIndex]["rasa"] + "\n";
                label6.Text += "Greutatea animalului: " + tab.Rows[listBox3.SelectedIndex]["greutate"] + " kilograme" + "\n";
                label6.Text += "Data de nastere a animalului: " + tab.Rows[listBox3.SelectedIndex]["data_n"] + "\n";
                if (bool.Parse(tab.Rows[listBox3.SelectedIndex]["efectuat"].ToString()))
                    label20.Text += "Programarea a fost efectuata.\n";
                else
                    label20.Text += "Programarea nu a fost efectuata. \n";
                label20.Text += "Motivul programarii: " + tab.Rows[listBox3.SelectedIndex]["motiv"] + "\n";
                label20.Text += "Contactati stapan la numarul: " + tab.Rows[listBox3.SelectedIndex]["nr_telefon"] + "\n";
            }
        }

        private void restanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
            listBox4.Items.Clear();
            programariTableAdapter.restante(registruDataSet.Programari);
            DataTable tab = registruDataSet.Programari;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                DateTime d = (DateTime.Parse(tab.Rows[i]["data_prog"].ToString()));
                if (d.Year < DateTime.Now.Year)
                {
                    if (bool.Parse(tab.Rows[i]["efectuat"].ToString()) == false)
                        listBox4.Items.Add(tab.Rows[i]["data_prog"] + "    " + tab.Rows[i]["ID_anim"]);
                }
                else
                    if (d.Year == DateTime.Now.Year)
                    {
                        if (d.Month < DateTime.Now.Month)
                        {

                            listBox4.Items.Add(tab.Rows[i]["data_prog"] + "    " + tab.Rows[i]["ID_anim"]);
                        }
                        else
                            if (d.Month == DateTime.Now.Month)
                                if (d.Day < DateTime.Now.Day)

                                    listBox4.Items.Add(tab.Rows[i]["data_prog"] + "    " + tab.Rows[i]["ID_anim"]);
                    }

            }



        }

        /**/

        private void listBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (listBox4.SelectedIndex != -1)
            {
                label21.Text = "";
                programariTableAdapter.restante(registruDataSet.Programari);
                DataTable tab = registruDataSet.Programari;
                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    DateTime d = (DateTime.Parse(tab.Rows[i]["data_prog"].ToString()));
                    if (d.Year > DateTime.Now.Year)
                        tab.Rows[i].Delete();
                    else
                        if (d.Year == DateTime.Now.Year)
                        {
                            if (d.Month > DateTime.Now.Month)
                                tab.Rows[i].Delete();
                            else
                                if (d.Month == DateTime.Now.Month)
                                    if (d.Day >= DateTime.Now.Day)
                                        tab.Rows[i].Delete();
                        }

                }
                registruDataSet.AcceptChanges();
                label21.Text = "Numele animalului: " + tab.Rows[listBox4.SelectedIndex]["nume"] + "\n";
                label21.Text += "Tipul animalului: " + tab.Rows[listBox4.SelectedIndex]["tip"] + "\n";
                label21.Text += "Sexul animalului: " + tab.Rows[listBox4.SelectedIndex]["gen"] + "\n";
                label21.Text += "Rasa animalului: " + tab.Rows[listBox4.SelectedIndex]["rasa"] + "\n";
                label21.Text += "Greutatea animalului: " + tab.Rows[listBox4.SelectedIndex]["greutate"] + " kilograme" + "\n";
                label21.Text += "Data de nastere a animalului: " + tab.Rows[listBox4.SelectedIndex]["data_n"] + "\n";
                label21.Text += "Motivul programarii: " + tab.Rows[listBox4.SelectedIndex]["motiv"] + "\n";
                label21.Text += "Contactati stapan la numarul: " + tab.Rows[listBox4.SelectedIndex]["nr_telefon"] + "\n";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";


        }

        private void button9_Click(object sender, EventArgs e)
        {
            string tip, nume, rasa, gen, data, tel;
            float greutate;
            tip = textBox6.Text.Trim();
            nume = textBox12.Text.Trim();
            rasa = textBox11.Text.Trim();
            bool ok = float.TryParse(textBox10.Text.Trim(), out greutate);
            gen = textBox9.Text.Trim();
            data = textBox8.Text.Trim();
            tel = textBox7.Text.Trim();
            if (tip.Length > 0 && ok && nume.Length > 0 && rasa.Length > 0 && gen.Length > 0 && data.Length > 0 && tel.Length > 0)
            {
                string ID = (int.Parse(informatii_AnimaleTableAdapter.ID_MAX()) + 1).ToString();

                informatii_AnimaleTableAdapter.AdaugareAnim(ID, tip, nume, rasa, greutate, gen, data, tel);
                textBox12.Text = "";
                textBox11.Text = "";
                textBox10.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";



            }

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
            tabControl1.SelectedTab = tabPage11;
            textBox19.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            informatii_AnimaleTableAdapter.Fill(registruDataSet.Informatii_Animale);
            DataTable tab = registruDataSet.Informatii_Animale;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox6.Items.Add(tab.Rows[i]["ID"]);

            }


        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox6.SelectedIndex != -1)
            {
                informatii_AnimaleTableAdapter.AnimalX(registruDataSet.Informatii_Animale, listBox6.SelectedItem.ToString());
                DataTable tab = registruDataSet.Informatii_Animale;


                textBox19.Text = tab.Rows[0]["tip"].ToString();
                textBox13.Text = tab.Rows[0]["nume"].ToString();
                textBox14.Text = tab.Rows[0]["rasa"].ToString();
                textBox15.Text = tab.Rows[0]["greutate"].ToString();
                textBox16.Text = tab.Rows[0]["gen"].ToString();
                textBox17.Text = tab.Rows[0]["data_n"].ToString();
                textBox18.Text = tab.Rows[0]["nr_telefon"].ToString();

            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            string tip, nume, rasa, gen, data, tel;
            float greutate;
            tip = textBox19.Text.Trim();
            nume = textBox13.Text.Trim();
            rasa = textBox14.Text.Trim();
            bool ok = float.TryParse(textBox15.Text.Trim(), out greutate);
            gen = textBox16.Text.Trim();
            data = textBox17.Text.Trim();
            tel = textBox18.Text.Trim();
            if (tip.Length > 0 && ok && nume.Length > 0 && rasa.Length > 0 && gen.Length > 0 && data.Length > 0 && tel.Length > 0)
            {
                string ID = listBox6.SelectedItem.ToString();

                informatii_AnimaleTableAdapter.ModificaAnim(ID, tip, nume, rasa, greutate, gen, data, tel, ID);
                textBox19.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox18.Text = "";



            }

        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            listBox5.Items.Clear();
            informatii_AnimaleTableAdapter.Fill(registruDataSet.Informatii_Animale);
            DataTable tab = registruDataSet.Informatii_Animale;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox5.Items.Add(tab.Rows[i]["ID"]);

            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (listBox5.SelectedIndex != -1)
            {
                informatii_AnimaleTableAdapter.StergeAnim(listBox5.SelectedItem.ToString());
                listBox5.Items.Clear();
                informatii_AnimaleTableAdapter.Fill(registruDataSet.Informatii_Animale);
                DataTable tab = registruDataSet.Informatii_Animale;
                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    listBox5.Items.Add(tab.Rows[i]["ID"]);

                }
            }
        }

        private void adaugareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            textBox26.Text = "";
            textBox20.Text = "";
        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string proc = textBox20.Text.Trim();
            double cost;
            bool ok = double.TryParse(textBox26.Text.Trim(), out cost);
            if (proc.Length > 0 && ok)
            {
                preturiTableAdapter.AdaugarePret(proc, (decimal)cost);
                textBox26.Text = "";
                textBox20.Text = "";
            }
        }

        private void editareToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            listBox7.Items.Clear();
            tabControl1.SelectedTab = tabPage14;
            textBox22.Text = "";
            textBox21.Text = "";
            preturiTableAdapter.Fill(registruDataSet.Preturi);

            DataTable tab = registruDataSet.Preturi;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox7.Items.Add(tab.Rows[i]["procedura"]);

            }


        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox7.SelectedIndex != -1)
            {
                preturiTableAdapter.Fill(registruDataSet.Preturi);

                DataTable tab = registruDataSet.Preturi;

                textBox22.Text = tab.Rows[listBox7.SelectedIndex]["cost"].ToString();
                textBox21.Text = tab.Rows[listBox7.SelectedIndex]["procedura"].ToString();

            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string proc = textBox21.Text.Trim();
            double cost;
            bool ok = double.TryParse(textBox22.Text.Trim(), out cost);
            if (proc.Length > 0 && ok&&listBox7.SelectedIndex!=-1)
            {
                preturiTableAdapter.ModificariPret(proc, (decimal)cost, listBox7.SelectedItem.ToString());
                textBox21.Text = "";
                textBox22.Text = "";
                listBox7.Items.Clear();
                preturiTableAdapter.Fill(registruDataSet.Preturi);

                DataTable tab = registruDataSet.Preturi;
                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    listBox7.Items.Add(tab.Rows[i]["procedura"]);

                }

            }
        }

        private void stergereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox8.Items.Clear();
            tabControl1.SelectedTab = tabPage15;
            preturiTableAdapter.Fill(registruDataSet.Preturi);

            DataTable tab = registruDataSet.Preturi;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox8.Items.Add(tab.Rows[i]["procedura"]);

            }


        }



        private void button14_Click(object sender, EventArgs e)
        {
            if (listBox8.SelectedIndex != -1)
            {
                preturiTableAdapter.StergeProc(listBox8.SelectedItem.ToString());
                listBox8.Items.Clear();
                preturiTableAdapter.Fill(registruDataSet.Preturi);

                DataTable tab = registruDataSet.Preturi;
                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    listBox8.Items.Add(tab.Rows[i]["procedura"]);

                }
            }
        }

        private void adaugareToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            listBox13.Items.Clear();
            listBox14.Items.Clear();
            textBox28.Text = "";

            radioButton4.Checked = false;
            radioButton3.Checked = false;
            informatii_AnimaleTableAdapter.Fill(registruDataSet.Informatii_Animale);
            DataTable tab = registruDataSet.Informatii_Animale;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox13.Items.Add(tab.Rows[i]["ID"]);

            }
            preturiTableAdapter.Fill(registruDataSet.Preturi);
            DataTable tab1 = registruDataSet.Preturi;
            for (int i = 0; i < tab1.Rows.Count; i++)
            {
                listBox14.Items.Add(tab1.Rows[i]["procedura"]);

            }



        }

        private void button18_Click(object sender, EventArgs e)
        {
            string dt = textBox28.Text.Trim();

            if (dt.Length > 0 && listBox13.SelectedIndex != -1 && listBox14.SelectedIndex != -1)
            {
                if (radioButton3.Checked == false)
                {
                    if (radioButton4.Checked == true)
                    {
                        programariTableAdapter.AdaugareProg(dt, listBox14.SelectedItem.ToString(), true, listBox13.SelectedItem.ToString());

                        listBox13.Items.Clear();
                        listBox14.Items.Clear();
                        textBox28.Text = "";

                        radioButton4.Checked = false;
                        radioButton3.Checked = false;
                        informatii_AnimaleTableAdapter.Fill(registruDataSet.Informatii_Animale);
                        DataTable tab = registruDataSet.Informatii_Animale;
                        for (int i = 0; i < tab.Rows.Count; i++)
                        {
                            listBox13.Items.Add(tab.Rows[i]["ID"]);

                        }
                        preturiTableAdapter.Fill(registruDataSet.Preturi);
                        DataTable tab1 = registruDataSet.Preturi;
                        for (int i = 0; i < tab1.Rows.Count; i++)
                        {
                            listBox14.Items.Add(tab1.Rows[i]["procedura"]);

                        }
                    }
                }
                else
                    if (radioButton4.Checked == false)
                    {

                        programariTableAdapter.AdaugareProg(dt, listBox14.SelectedItem.ToString(), false, listBox13.SelectedItem.ToString());
                        listBox13.Items.Clear();
                        listBox14.Items.Clear();
                        textBox28.Text = "";

                        radioButton4.Checked = false;
                        radioButton3.Checked = false;
                        informatii_AnimaleTableAdapter.Fill(registruDataSet.Informatii_Animale);
                        DataTable tab = registruDataSet.Informatii_Animale;
                        for (int i = 0; i < tab.Rows.Count; i++)
                        {
                            listBox13.Items.Add(tab.Rows[i]["ID"]);

                        }
                        preturiTableAdapter.Fill(registruDataSet.Preturi);
                        DataTable tab1 = registruDataSet.Preturi;
                        for (int i = 0; i < tab1.Rows.Count; i++)
                        {
                            listBox14.Items.Add(tab1.Rows[i]["procedura"]);

                        }
                    }

            }
        }

        private void editareToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            listBox15.Items.Clear();
            listBox16.Items.Clear();
            listBox9.Items.Clear();
            radioButton4.Checked = false;
            radioButton3.Checked = false;
            informatii_AnimaleTableAdapter.Fill(registruDataSet.Informatii_Animale);
            DataTable tab = registruDataSet.Informatii_Animale;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox15.Items.Add(tab.Rows[i]["ID"]);
            }
        }

        private void listBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox15.SelectedIndex != -1)
            {
                listBox9.Items.Clear();
                listBox16.Items.Clear();
                programariTableAdapter.programari_animalX(registruDataSet.Programari, listBox15.SelectedItem.ToString());
                DataTable tab = registruDataSet.Programari;
                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    listBox9.Items.Add(tab.Rows[i]["data_prog"]);
                }
            }
        }

        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox9.SelectedIndex != -1)
            {
                listBox16.Items.Clear();
                listBox17.Items.Clear();
                programariTableAdapter.programari_animalX(registruDataSet.Programari, listBox15.SelectedItem.ToString());
                DataTable tab = registruDataSet.Programari;
                listBox17.Items.Add(tab.Rows[listBox9.SelectedIndex]["motiv"]);
                listBox16.Items.Clear();
                preturiTableAdapter.Fill(registruDataSet.Preturi);
                DataTable tab2 = registruDataSet.Preturi;
                for (int i = 0; i < tab2.Rows.Count; i++)
                {
                    listBox16.Items.Add(tab2.Rows[i]["procedura"]);
                }
                if ((bool)tab.Rows[listBox9.SelectedIndex]["efectuat"] == false)
                {
                    radioButton2.Checked = true;
                }
                else
                    radioButton1.Checked = true;
                listBox16.SelectedItem = tab.Rows[listBox9.SelectedIndex]["motiv"];
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {

            if (listBox9.SelectedIndex != -1 && listBox15.SelectedIndex != -1 && listBox16.SelectedIndex != -1)
            {
                if (radioButton2.Checked == false)
                {
                    if (radioButton1.Checked == true)
                    {
                        programariTableAdapter.mod_prog(listBox16.SelectedItem.ToString(), true, listBox15.SelectedItem.ToString(), 
                            listBox9.SelectedItem.ToString(), listBox17.Items[0].ToString());
                        listBox9.Items.Clear();
                        listBox17.Items.Clear();
                        listBox16.Items.Clear();
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                    }
                }
                else
                    if (radioButton1.Checked == false)
                    {
                        programariTableAdapter.mod_prog(listBox16.SelectedItem.ToString(), false, listBox15.SelectedItem.ToString(), 
                            listBox9.SelectedItem.ToString(), listBox17.Items[0].ToString());
                        listBox9.Items.Clear();
                        listBox17.Items.Clear();
                        listBox16.Items.Clear();
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                    }
            }
        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (listBox22.SelectedIndex != -1 && listBox23.SelectedIndex != -1)
            {
                programariTableAdapter.Sterge_prog(listBox22.SelectedItem.ToString(), listBox23.SelectedItem.ToString(), listBox21.SelectedItem.ToString());
                listBox23.Items.Clear();
                listBox21.Items.Clear();
            }
        }

        private void sumaCastigataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stergereToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            listBox22.Items.Clear();
            listBox23.Items.Clear();
            listBox21.Items.Clear();

            informatii_AnimaleTableAdapter.Fill(registruDataSet.Informatii_Animale);
            DataTable tab = registruDataSet.Informatii_Animale;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox22.Items.Add(tab.Rows[i]["ID"]);

            }

        }


        private void listBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox22.SelectedIndex != -1)
            {
                listBox23.Items.Clear();
                listBox21.Items.Clear();
                programariTableAdapter.programari_animalX(registruDataSet.Programari, listBox22.SelectedItem.ToString());

                DataTable tab = registruDataSet.Programari;
                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    listBox23.Items.Add(tab.Rows[i]["data_prog"]);

                }
            }
        }

        private void listBox23_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox23.SelectedIndex != -1)
            {
                listBox21.Items.Clear();

                programariTableAdapter.programari_animalX(registruDataSet.Programari, listBox22.SelectedItem.ToString());

                DataTable tab = registruDataSet.Programari;

                listBox21.Items.Add(tab.Rows[listBox23.SelectedIndex]["motiv"]);

              


            }
        }

        private void adaugareToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            listBox18.Items.Clear();
            textBox24.Text = "";
            textBox23.Text = "";

            informatii_AnimaleTableAdapter.Fill(registruDataSet.Informatii_Animale);
            DataTable tab = registruDataSet.Informatii_Animale;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox18.Items.Add(tab.Rows[i]["ID"]);

            }

        }

        private void listBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            string b, tr;
            b=textBox24.Text.Trim();
            tr=textBox23.Text.Trim();
            if (b.Length > 0 && tr.Length > 0 && listBox18.SelectedIndex != -1)
            { 
                boliTableAdapter.AdaugareBoala(b,tr,listBox18.SelectedItem.ToString());
                textBox24.Text = "";
                textBox23.Text = "";
            }
        }

        private void editareToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            listBox12.Items.Clear();
            listBox19.Items.Clear();
            textBox29.Text = "";

            informatii_AnimaleTableAdapter.Fill(registruDataSet.Informatii_Animale);
            DataTable tab = registruDataSet.Informatii_Animale;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox12.Items.Add(tab.Rows[i]["ID"]);

            }
        }

        private void listBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox12.SelectedIndex != -1)
            {
                listBox19.Items.Clear();
                boliTableAdapter.boli_animalX(registruDataSet.Boli, listBox12.SelectedItem.ToString());
                DataTable tab1 = registruDataSet.Boli;
                for (int i = 0; i < tab1.Rows.Count; i++)
                {
                    listBox19.Items.Add(tab1.Rows[i]["boala"]);

                }
            
            }
        }

        private void listBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox19.SelectedIndex != -1)
            {
                //   listBox19.Items.Clear();
                boliTableAdapter.boli_animalX(registruDataSet.Boli, listBox12.SelectedItem.ToString());
                DataTable tab1 = registruDataSet.Boli;
                textBox29.Text = tab1.Rows[listBox19.SelectedIndex]["tratament"].ToString();
            }

                
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (listBox12.SelectedIndex != -1 && listBox19.SelectedIndex != -1)
            {
                string tr = textBox29.Text.Trim();
                if(tr.Length > 0)
                {
                    boliTableAdapter.Modif_boala(tr, listBox19.SelectedItem.ToString(),listBox12.SelectedItem.ToString());
                    textBox29.Text = "";
                    listBox19.Items.Clear();
                }
            
            }
        }

        private void stergereToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            listBox11.Items.Clear();
            listBox20.Items.Clear();
            

            informatii_AnimaleTableAdapter.Fill(registruDataSet.Informatii_Animale);
            DataTable tab = registruDataSet.Informatii_Animale;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox11.Items.Add(tab.Rows[i]["ID"]);

            }
        }

        private void listBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox11.SelectedIndex != -1)
            {
                listBox20.Items.Clear();
                boliTableAdapter.boli_animalX(registruDataSet.Boli, listBox11.SelectedItem.ToString());
                DataTable tab1 = registruDataSet.Boli;
                for (int i = 0; i < tab1.Rows.Count; i++)
                {
                    listBox20.Items.Add(tab1.Rows[i]["boala"]);

                }

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (listBox11.SelectedIndex != -1 && listBox20.SelectedIndex != -1)
            {
                boliTableAdapter.sterge_boala(listBox20.SelectedItem.ToString(), listBox11.SelectedItem.ToString());
                listBox20.Items.Clear();
                boliTableAdapter.boli_animalX(registruDataSet.Boli, listBox11.SelectedItem.ToString());
                DataTable tab1 = registruDataSet.Boli;
                for (int i = 0; i < tab1.Rows.Count; i++)
                {
                    listBox20.Items.Add(tab1.Rows[i]["boala"]);

                }
            }
        }

        private void programariDeAcelasiTipToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            label63.Text = "In luna viitoare, \nin functie de programari, \nveti avea incasari de: ";
            programariTableAdapter.Prog_preturi(registruDataSet.Programari);
            double suma = 0;
            DataTable tab = registruDataSet.Programari;

            for (int i = 0; i < tab.Rows.Count; i++)
            {
                DateTime d = (DateTime.Parse(tab.Rows[i]["data_prog"].ToString()));
                if (d.Year < DateTime.Now.Year)
                    continue;
                else
                    if (d.Year == DateTime.Now.Year)
                    {
                        if (d.Month < DateTime.Now.Month)
                            continue;
                        else
                            if (d.Month == DateTime.Now.Month)
                                if (d.Day < DateTime.Now.Day)
                                    continue;
                    }
                DateTime peste_luna = DateTime.Now;

                if (d.Year > peste_luna.Year)
                    continue;
                else
                    if (d.Year == peste_luna.AddMonths(1).Year)
                    {
                        if (d.Month > peste_luna.AddMonths(1).Month)
                            continue;
                        else
                            if (d.Month == peste_luna.AddMonths(1).Month)
                                if (d.Day >= peste_luna.AddMonths(1).Day)
                                    continue;
                    }
                
                //label63.Text += tab.Rows[i]["data_prog"].ToString() + "\n";


                if (string.Compare(tab.Rows[i]["motiv"].ToString(), "deparazitare interna(o pastila/10 kg)") == 0)
                {
                    int p = int.Parse(tab.Rows[i]["greutate"].ToString()) / 10 + 1;
                    p = p * int.Parse(tab.Rows[i]["cost"].ToString());
                    suma = suma + p;
                }
                else
                    suma = suma + double.Parse(tab.Rows[i]["cost"].ToString());
            }
            label63.Text += suma.ToString() + " ron";
                    


        }

        private void sumaCastigataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            label63.Text = "In luna trecuta, \nin functie de programari, \nati avut incasari de: ";
            programariTableAdapter.Prog_preturi(registruDataSet.Programari);
            double suma = 0;
            DataTable tab = registruDataSet.Programari;

            for (int i = 0; i < tab.Rows.Count; i++)
            {
                DateTime d = (DateTime.Parse(tab.Rows[i]["data_prog"].ToString()));
                if (d.Year > DateTime.Now.Year)
                    continue;
                else
                    if (d.Year == DateTime.Now.Year)
                    {
                        if (d.Month > DateTime.Now.Month)
                            continue;
                        else
                            if (d.Month == DateTime.Now.Month)
                                if (d.Day >= DateTime.Now.Day)
                                    continue;

                    }
                if (bool.Parse(tab.Rows[i]["efectuat"].ToString()) != true)
                    continue;



                if (DateTime.Now.Year > d.AddMonths(1).Year)
                    continue;
                else
                    if (DateTime.Now.Year == d.AddMonths(1).Year)
                    {
                        if (DateTime.Now.Month > d.AddMonths(1).Month)
                            continue;
                        else
                            if (DateTime.Now.Month == d.AddMonths(1).Month)
                                if (DateTime.Now.Day >= d.AddMonths(1).Day)
                                    continue;
                    }

               // label63.Text += tab.Rows[i]["data_prog"].ToString() + "\n";


                if (string.Compare(tab.Rows[i]["motiv"].ToString(), "deparazitare interna(o pastila/10 kg)") == 0)
                {
                    int p = int.Parse(tab.Rows[i]["greutate"].ToString()) / 10 + 1;
                    p = p * int.Parse(tab.Rows[i]["cost"].ToString());
                    suma = suma + p;
                }
                else
                    suma = suma + double.Parse(tab.Rows[i]["cost"].ToString());
            }
            label63.Text += suma.ToString()+" ron";
                  
        }

        private void sumaDeCastigatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            listBox10.Items.Clear();
            label65.Text = "";

            preturiTableAdapter.Fill(registruDataSet.Preturi);

            DataTable tab = registruDataSet.Preturi;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox10.Items.Add(tab.Rows[i]["procedura"]);

            }
        }

        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox10.SelectedIndex != -1)
            {
               
                programariTableAdapter.Prog_preturi(registruDataSet.Programari);
                double suma = 0;
                DataTable tab = registruDataSet.Programari;
                label65.Text = "";
                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    DateTime d = (DateTime.Parse(tab.Rows[i]["data_prog"].ToString()));
                    if (d.Year < DateTime.Now.Year)
                        continue;
                    else
                        if (d.Year == DateTime.Now.Year)
                        {
                            if (d.Month < DateTime.Now.Month)
                                continue;
                            else
                                if (d.Month == DateTime.Now.Month)
                                    if (d.Day < DateTime.Now.Day)
                                        continue;
                        }
                    DateTime peste_luna = DateTime.Now;

                    if (d.Year > peste_luna.Year)
                        continue;
                    else
                        if (d.Year == peste_luna.AddMonths(1).Year)
                        {
                            if (d.Month > peste_luna.AddMonths(1).Month)
                                continue;
                            else
                                if (d.Month == peste_luna.AddMonths(1).Month)
                                    if (d.Day >= peste_luna.AddMonths(1).Day)
                                        continue;
                        }

                    //label63.Text += tab.Rows[i]["data_prog"].ToString() + "\n";


                    if (string.Compare(tab.Rows[i]["motiv"].ToString(), listBox10.SelectedItem.ToString()) == 0)
                    {
                        
                        suma = suma + 1;
                    }
                   
                }
                if (suma > 0)

                    label65.Text += "In luna viitoare veti avea " + suma.ToString() + " proceduri de tipul \n" + listBox10.SelectedItem.ToString()+".";
                else
                    label65.Text += "Nu aveti nicio procedura de acest tip de efectuat luna urmatoare.";
            
            }
        }

        private void programariDeAcelasiTipToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            listBox24.Items.Clear();
            label66.Text = "";

            preturiTableAdapter.Fill(registruDataSet.Preturi);

            DataTable tab = registruDataSet.Preturi;
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                listBox24.Items.Add(tab.Rows[i]["procedura"]);

            }
        }

        private void listBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            programariTableAdapter.Prog_preturi(registruDataSet.Programari);
            double suma = 0;
            DataTable tab = registruDataSet.Programari;
            label66.Text = "";
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                DateTime d = (DateTime.Parse(tab.Rows[i]["data_prog"].ToString()));
                if (d.Year > DateTime.Now.Year)
                    continue;
                else
                    if (d.Year == DateTime.Now.Year)
                    {
                        if (d.Month > DateTime.Now.Month)
                            continue;
                        else
                            if (d.Month == DateTime.Now.Month)
                                if (d.Day >= DateTime.Now.Day)
                                    continue;

                    }
                if (bool.Parse(tab.Rows[i]["efectuat"].ToString()) != true)
                    continue;



                if (DateTime.Now.Year > d.AddMonths(1).Year)
                    continue;
                else
                    if (DateTime.Now.Year == d.AddMonths(1).Year)
                    {
                        if (DateTime.Now.Month > d.AddMonths(1).Month)
                            continue;
                        else
                            if (DateTime.Now.Month == d.AddMonths(1).Month)
                                if (DateTime.Now.Day >= d.AddMonths(1).Day)
                                    continue;
                    }

               
                    if (string.Compare(tab.Rows[i]["motiv"].ToString(), listBox24.SelectedItem.ToString()) == 0)
                    {
                        
                        suma = suma + 1;
                    }
                   
                }
                if (suma > 0)

                    label66.Text += "In luna trecuta ati avut " + suma.ToString() + " proceduri de tipul \n" + listBox24.SelectedItem.ToString()+".";
                else
                    label66.Text += "Nu ati avut nicio procedura de acest tip de efectuat luna trecuta.";
                
            
        }


    }

   }
        



    

