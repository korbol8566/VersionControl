using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenace.Entities;

namespace UserMaintenace
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();

            label1.Text = Resource1.FullName;
            //label2.Text = Resource1.FirstName;
            button1.Text = Resource1.Add;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textBox1.Text
                //FirstName = textBox2.Text
            };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var s in users)
                {                    
                    sw.Write(s.ID.ToString());
                    sw.Write(s.FullName);
                    sw.Write(";");
                    sw.WriteLine();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //listBox1.DataSource = null;
            object selected = listBox1.SelectedItem;
            listBox1.Items.Remove(selected);
            textBox1.Clear();
            
           
        }
    }
}
