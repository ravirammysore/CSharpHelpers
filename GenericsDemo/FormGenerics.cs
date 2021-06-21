using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GenericsDemo
{
    public partial class FormGenerics : Form
    {
        public FormGenerics()
        {
            InitializeComponent();
            CenterToScreen();
        }

        #region GenericMethod
        private void button1_Click(object sender, EventArgs e)
        {
            int hours = 24;
            ShowMessageBox<int>(hours);

            //also works
            //ShowMessageBox(hours);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = "Krishna";
            ShowMessageBox<string>(name);

            //also works
            //ShowMessageBox(name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Exercise
        }


        private void ShowMessageBox<T>(T item)
        {
            MessageBox.Show(item.ToString());
        }
        #endregion

        #region GenericClass
        private void button6_Click(object sender, EventArgs e)
        {
            var marksStore = new Store<int>();
            marksStore.Add(75, 0);
            marksStore.Add(85, 1);

            marksStore.Remove(1);

            var first = marksStore.Get(0);
            var second = marksStore.Get(1);

            var msg = $"First item is {first} and second item is {second}";
            ShowMessageBox(msg);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var namesStore = new Store<string>();
            namesStore.Add("Amith", 0);
            namesStore.Add("Nidhi", 1);

            namesStore.Remove(1);

            var first = namesStore.Get(0);
            var second = namesStore.Get(1);

            var msg = $"First item is {first} and second item is {second}";
            ShowMessageBox(msg);

            var studs = new List<string>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Exercise           
        } 
        #endregion
    }
}
