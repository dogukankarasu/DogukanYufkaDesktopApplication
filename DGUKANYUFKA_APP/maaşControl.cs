using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DGUKANYUFKA_APP
{
    public partial class maaşControl : UserControl
    {
        public maaşControl()
        {
            InitializeComponent();
        }
        SqlConnection conObj = new SqlConnection("Data Source=LAPTOP-UJ83ER0C\\SQLEXPRESS;Initial Catalog=dy_app;Integrated Security=True");
        private void show()
        {
            listView1.Items.Clear();
            conObj.Open();
            SqlCommand command = new SqlCommand("select * from maas1 ", conObj);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem addition = new ListViewItem();

                addition.Text = read["İSİM_SOYİSİM"].ToString();
                addition.SubItems.Add(read["TARİH"].ToString());
                addition.SubItems.Add(read["YUFKA_KG"].ToString());
                addition.SubItems.Add(read["YUFKA_ÜCRET"].ToString());
                addition.SubItems.Add(read["MANTI_KG"].ToString());
                addition.SubItems.Add(read["MANTI_ÜCRET"].ToString());
                addition.SubItems.Add(read["SİGARA_BÖREĞİ_KG"].ToString());
                addition.SubItems.Add(read["SİGARA_BÖREĞİ_ÜCRET"].ToString());
                addition.SubItems.Add(read["TOPLAM"].ToString());





                listView1.Items.Add(addition);
            }
            conObj.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yufka, mantı, sigara;
            double toplam,yü,mü,sü;
            yufka = Convert.ToInt32(textBox1.Text);
            mantı= Convert.ToInt32(textBox2.Text);
            sigara= Convert.ToInt32(textBox3.Text);
            yü = yufka * 0.40;
            mü = mantı * 8.0;
            sü = sigara * 5.0;

            toplam = ((yufka * 0.40) + (mantı * 8.0) + (sigara * 5.0));
            label8.Text = toplam.ToString();
            label12.Text = yü.ToString();
            label13.Text = mü.ToString();
            label14.Text = sü.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conObj.Open();
            SqlCommand command = new SqlCommand("INSERT INTO maas1(İSİM_SOYİSİM,TARİH,YUFKA_KG,YUFKA_ÜCRET,MANTI_KG,MANTI_ÜCRET,SİGARA_BÖREĞİ_KG,SİGARA_BÖREĞİ_ÜCRET,TOPLAM)values('" + textBox4.Text.ToString() + "','" + dateTimePicker1.Value.Date + "','" + textBox1.Text.ToString() + "','"
              +label12.Text.ToString()+  "','" + textBox2.Text.ToString() + "','" + label13.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + label14.Text.ToString() +"','"+ label8.Text.ToString()+ "')", conObj);

            command.ExecuteNonQuery();
            conObj.Close();
            show();
        }

        private void maaşControl_Load(object sender, EventArgs e)
        {

        }
    }
}
