using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contractible
{
    public partial class Clause_Page : Form
    {
        public Contarctible.Clause obj;
        public Clause_Page(Contarctible.Clause obj1)
        {
            InitializeComponent();
            obj = obj1;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void Clause_Page_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Clause Name: " + obj.get_name() + "\r\n\r\nClause Description:  " + obj.get_description() + "\r\n\r\nClause Wording: " + obj.get_wording();
        }
    }
}
