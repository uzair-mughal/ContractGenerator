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


namespace Contractible
{
    public partial class Contract : Form
    {
        public List<string> clause_names = new List<string>();
        public List<Contarctible.Clause> objects = new List<Contarctible.Clause>();
        public Contract(List<string> clause_names1, List<Contarctible.Clause> objects1)
        {
            clause_names = clause_names1;
            objects = objects1;
            InitializeComponent();
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            int i = 1;
            string filename = "Contarct.txt";
            string text_contract = "";

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (string name in clause_names)
                {
                    if (name != "")
                    {
                        foreach (Contarctible.Clause clause in objects)
                        {
                            if (clause.get_name() == name)
                            {
                                text_contract += Convert.ToString(i) + "-" + clause.get_name() + "\r\n";
                                text_contract += clause.get_wording() + "\r\n\r\n";
                                i += 1;
                            }
                        }

                    }

                }
                textBox1.Text = text_contract;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
        }
    }
}
