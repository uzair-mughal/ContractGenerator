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

namespace Contarctible
{
    public partial class Edit_Page : Form
    {

        public Clause obj_rec;
        public List<Clause> objects;
        public Edit_Page(Clause obj1)
        {
            InitializeComponent();
            obj_rec = obj1;
            loadClauses();
            loadTextBoxes();
        }
        public void loadClauses()
        {
            Clause obj;
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
                        if (obj.get_name() != obj_rec.get_name())
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
        }
        public void loadTextBoxes()
        {
            name_textBox.Text = obj_rec.get_name();
            descrption_textBox.Text = obj_rec.get_description();
            wording_textBox.Text = obj_rec.get_wording();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Edit_Page_Load(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {

            
        }

        private void save_button_Click_1(object sender, EventArgs e)
        {
            string name = name_textBox.Text;
            string description = descrption_textBox.Text;
            string working = wording_textBox.Text;

            if (name != "" && description != "" && working != "")
            {
                Clause obj = new Clause(name, description, working);
                objects.Add(new Clause(obj));

                string filename = "Clauses.txt";
                FileStream s = File.Open(filename, FileMode.Truncate);

                foreach (Clause clause in objects)
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(s, clause);
                }
                s.Close();
                MessageBox.Show("Clause Updated!");
                Contractible form = new Contractible();
                form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please Fill all the details!");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Contractible form = new Contractible();
            form.Show();
            this.Hide();
        }

        private void descrption_textBox_TextChanged(object sender, EventArgs e)
        {
            descrption_textBox.ScrollBars = ScrollBars.Vertical;
        }

        private void wording_textBox_TextChanged(object sender, EventArgs e)
        {
            wording_textBox.ScrollBars = ScrollBars.Vertical;
        }
    }
}