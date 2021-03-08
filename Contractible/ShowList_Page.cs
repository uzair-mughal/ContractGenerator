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
    public partial class ShowList_Page : Form
    {
        public Clause obj;
        public List<Clause> objects;
        public ShowList_Page()
        {
            InitializeComponent();
            loadClauses();
        }
        public void loadClauses()
        {
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
                dataGridView.Rows.Add(clause.get_name());
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowList_Page_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
