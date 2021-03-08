using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Contractible;
using Word = Microsoft.Office.Interop.Word;

namespace Contarctible
{
    public partial class Contractible : Form
    {
        public Clause obj;
        public List<Clause> objects;
        public Contractible()
        {
            InitializeComponent();
            loadClauses();
        }

        public void clear_boxes()
        {
            Search_comboBox.Items.Clear();
            comboBox1.Items.Clear(); comboBox8.Items.Clear(); comboBox15.Items.Clear(); comboBox22.Items.Clear(); comboBox29.Items.Clear();
            comboBox2.Items.Clear(); comboBox9.Items.Clear(); comboBox16.Items.Clear(); comboBox23.Items.Clear(); comboBox30.Items.Clear();
            comboBox3.Items.Clear(); comboBox10.Items.Clear(); comboBox17.Items.Clear(); comboBox24.Items.Clear(); comboBox31.Items.Clear();
            comboBox4.Items.Clear(); comboBox11.Items.Clear(); comboBox18.Items.Clear(); comboBox25.Items.Clear(); comboBox32.Items.Clear();
            comboBox5.Items.Clear(); comboBox12.Items.Clear(); comboBox19.Items.Clear(); comboBox26.Items.Clear(); comboBox33.Items.Clear();
            comboBox6.Items.Clear(); comboBox13.Items.Clear(); comboBox20.Items.Clear(); comboBox27.Items.Clear(); comboBox34.Items.Clear();
            comboBox7.Items.Clear(); comboBox14.Items.Clear(); comboBox21.Items.Clear(); comboBox28.Items.Clear(); comboBox35.Items.Clear();
            Search_comboBox.Items.Add("");
            comboBox1.Items.Add("");
            comboBox2.Items.Add("");
            comboBox3.Items.Add("");
            comboBox4.Items.Add("");
            comboBox5.Items.Add("");
            comboBox6.Items.Add("");
            comboBox7.Items.Add("");
            comboBox8.Items.Add("");
            comboBox9.Items.Add("");
            comboBox10.Items.Add("");
            comboBox11.Items.Add("");
            comboBox12.Items.Add("");
            comboBox13.Items.Add("");
            comboBox14.Items.Add("");
            comboBox15.Items.Add("");
            comboBox16.Items.Add("");
            comboBox17.Items.Add("");
            comboBox18.Items.Add("");
            comboBox19.Items.Add("");
            comboBox20.Items.Add("");
            comboBox21.Items.Add("");
            comboBox22.Items.Add("");
            comboBox23.Items.Add("");
            comboBox24.Items.Add("");
            comboBox24.Items.Add("");
            comboBox26.Items.Add("");
            comboBox27.Items.Add("");
            comboBox28.Items.Add("");
            comboBox29.Items.Add("");
            comboBox30.Items.Add("");
            comboBox31.Items.Add("");
            comboBox32.Items.Add("");
            comboBox33.Items.Add("");
            comboBox34.Items.Add("");
            comboBox35.Items.Add("");
        }

        public void loadClauses()
        {
            clear_boxes();
            objects = new List<Clause>();
            objects.Clear();
            try
            {
                FileStream s = File.Open("Clauses.txt", FileMode.Open);
                while (true)
                {
                    try
                    {
                        BinaryFormatter b = new BinaryFormatter();
                        obj = (Clause)b.Deserialize(s);
                        objects.Add(new Clause(obj));
                    }
                    catch
                    {
                        break;
                    }
                }
                s.Close();
            }
            catch
            {
                FileStream s = File.Open("Clauses.txt", FileMode.Create);
                s.Close();
            }

            objects.Sort((x, y) => x.get_name().CompareTo(y.get_name()));

            foreach (Clause clause in objects)
            {
                Search_comboBox.Items.Add(clause.get_name());
                comboBox1.Items.Add(clause.get_name());
                comboBox2.Items.Add(clause.get_name());
                comboBox3.Items.Add(clause.get_name());
                comboBox4.Items.Add(clause.get_name());
                comboBox5.Items.Add(clause.get_name());
                comboBox6.Items.Add(clause.get_name());
                comboBox7.Items.Add(clause.get_name());
                comboBox8.Items.Add(clause.get_name());
                comboBox9.Items.Add(clause.get_name());
                comboBox10.Items.Add(clause.get_name());
                comboBox11.Items.Add(clause.get_name());
                comboBox12.Items.Add(clause.get_name());
                comboBox13.Items.Add(clause.get_name());
                comboBox14.Items.Add(clause.get_name());
                comboBox15.Items.Add(clause.get_name());
                comboBox16.Items.Add(clause.get_name());
                comboBox17.Items.Add(clause.get_name());
                comboBox18.Items.Add(clause.get_name());
                comboBox19.Items.Add(clause.get_name());
                comboBox20.Items.Add(clause.get_name());
                comboBox21.Items.Add(clause.get_name());
                comboBox22.Items.Add(clause.get_name());
                comboBox23.Items.Add(clause.get_name());
                comboBox24.Items.Add(clause.get_name());
                comboBox24.Items.Add(clause.get_name());
                comboBox26.Items.Add(clause.get_name());
                comboBox27.Items.Add(clause.get_name());
                comboBox28.Items.Add(clause.get_name());
                comboBox29.Items.Add(clause.get_name());
                comboBox30.Items.Add(clause.get_name());
                comboBox31.Items.Add(clause.get_name());
                comboBox32.Items.Add(clause.get_name());
                comboBox33.Items.Add(clause.get_name());
                comboBox34.Items.Add(clause.get_name());
                comboBox35.Items.Add(clause.get_name());
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
           
        private void Contractible_Load_1(object sender, EventArgs e)
        {

        }

        private void showlist_button_Click_1(object sender, EventArgs e)
        {
            ShowList_Page form = new ShowList_Page();
            form.Show();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (Search_comboBox.Text != "")
            {
                bool check = false;
                foreach (Clause clause in objects)
                {
                    if (clause.get_name() == Search_comboBox.Text)
                    {
                        Clause_Page obj = new Clause_Page(clause);
                        obj.Show();
                        check = true;
                    }
                }
                if (check == false)
                {
                    MessageBox.Show("No Such Clause");
                }
            }
            else
            {
                MessageBox.Show("Please type a Name!");
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (Search_comboBox.Text != "")
            {
                bool check = false;
                foreach (Clause clause in objects)
                {
                    if (clause.get_name() == Search_comboBox.Text)
                    {
                        Edit_Page obj = new Edit_Page(clause);
                        obj.Show();
                        this.Hide();
                        check = true;
                    }
                }
                if (check == false)
                {
                    MessageBox.Show("No Such Clause");
                }
            }
            else
            {
                MessageBox.Show("Please type a Name!");
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string name = name_textBox.Text;
            string description = descrption_textBox.Text;
            string working = wording_textBox.Text;

            bool check = true;
            if (name != "" && description != "" && working != "")
            {
                foreach (Clause clause in objects)
                {
                    if (clause.get_name() == name)
                    {
                        MessageBox.Show("Clause already exists!");
                        check = false;
                    }
                }
                if (check == true)
                {
                    obj = new Clause(name, description, working);
                    obj.Store_Clause();
                    MessageBox.Show("Clause Added!");
                    loadClauses();
                }
            }
            else
            {
                MessageBox.Show("Please Fill all the details!");
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            string filename = "Contarct.txt";
            List<string> clause_names = new List<string>();
            string text_contract = "";

            clause_names.Add(comboBox1.Text); clause_names.Add(comboBox8.Text); clause_names.Add(comboBox15.Text); clause_names.Add(comboBox22.Text); clause_names.Add(comboBox29.Text);
            clause_names.Add(comboBox2.Text); clause_names.Add(comboBox9.Text); clause_names.Add(comboBox16.Text); clause_names.Add(comboBox23.Text); clause_names.Add(comboBox30.Text);
            clause_names.Add(comboBox3.Text); clause_names.Add(comboBox10.Text); clause_names.Add(comboBox17.Text); clause_names.Add(comboBox24.Text); clause_names.Add(comboBox31.Text);
            clause_names.Add(comboBox4.Text); clause_names.Add(comboBox11.Text); clause_names.Add(comboBox18.Text); clause_names.Add(comboBox25.Text); clause_names.Add(comboBox32.Text);
            clause_names.Add(comboBox5.Text); clause_names.Add(comboBox12.Text); clause_names.Add(comboBox19.Text); clause_names.Add(comboBox26.Text); clause_names.Add(comboBox33.Text);
            clause_names.Add(comboBox6.Text); clause_names.Add(comboBox13.Text); clause_names.Add(comboBox20.Text); clause_names.Add(comboBox27.Text); clause_names.Add(comboBox34.Text);
            clause_names.Add(comboBox7.Text); clause_names.Add(comboBox14.Text); clause_names.Add(comboBox21.Text); clause_names.Add(comboBox28.Text); clause_names.Add(comboBox35.Text);

            int i = 1;

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (string name in clause_names)
                {
                    if (name != "")
                    {
                        foreach (Clause clause in objects)
                        {
                            if (clause.get_name() == name)
                            {
                                writer.WriteLine(Convert.ToString(i) + "." + clause.get_name() +"\r\n");
                                text_contract += Convert.ToString(i) + "." + clause.get_name() + "\r\n";
                                writer.WriteLine(clause.get_wording() + "\r\n");
                                text_contract += clause.get_wording() + "\r\n";
                                writer.WriteLine();
                                i += 1;
                            }
                        }
                        
                    }
                    
                }
         
            }
            //Contract obj = new Contract(clause_names, objects);
            //obj.Show();
            // MessageBox.Show(text_contract);
            
            Word.Application objword = new Word.Application();
            objword.Visible = true;
            objword.WindowState = Word.WdWindowState.wdWindowStateNormal;

            Word.Document objdoc = objword.Documents.Add();

            Word.Paragraph objpara;
            objpara = objdoc.Paragraphs.Add();
            objpara.Range.Text = text_contract;

            objdoc.SaveAs2("Contract.docx");
            objdoc.Close();
            objword.Quit();

        }

        private void Search_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void wording_textBox_TextChanged(object sender, EventArgs e)
        {
            wording_textBox.ScrollBars = ScrollBars.Vertical;
        }

        private void descrption_textBox_TextChanged(object sender, EventArgs e)
        {
            descrption_textBox.ScrollBars = ScrollBars.Vertical;
        }
    }
}
