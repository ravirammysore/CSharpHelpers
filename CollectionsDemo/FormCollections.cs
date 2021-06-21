using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsDemo
{
    public partial class FormCollections : Form
    {
        public FormCollections()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //can also use: var names = new List<string>()
            ICollection<string> names = new List<string>()
            {
                "Listy","Rama","Sam","Ted", "John"
            };

            names.Add("John");

            //listbox control can work with List or Array types only
            listBox1.DataSource = names.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICollection<string> names = new HashSet<string>()
            {
                "Hashy","Rama","Sam","Ted","John"
            };

            names.Add("John");
            //listbox control can work with List or Array types only
            listBox1.DataSource = names.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var names = new List<string>()
            {
                "Rama","Sam","Ted","Mike"
            };

            //The result of a linq query is of type IEnumerable (makes sense because it is the top level in the hierachy))
            //can also use: var result = names.Where(i => i.Contains("a"));
            IEnumerable<string> result = names.Where(i => i.Contains("a"));

            //listbox control can work with List or Array types only
            listBox1.DataSource = result.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var names = new List<string>()
            {
                "Rama","Sam","Ted","Mike"
            };

            //Here IQueryable makes no difference in efficiency since we are not querying a database, but used just for illustration
            //can also use var result = names.Where(i => i.Contains("a"));
            IQueryable<string> result = names.Where(i => i.Contains("a")).AsQueryable();

            //listbox control can work with List or Array types only            
            listBox1.DataSource = result.ToList();            
        }
    }
}
