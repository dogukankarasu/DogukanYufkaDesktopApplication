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
    public partial class stokControl : UserControl
    {
        public stokControl()
        {
            InitializeComponent();
        }
        SqlConnection conObj = new SqlConnection("Data Source=LAPTOP-UJ83ER0C\\SQLEXPRESS;Initial Catalog=dy_app;Integrated Security=True");
        private void show()
        {
            listView1.Items.Clear();
            conObj.Open();
            SqlCommand command = new SqlCommand("select *from stok ", conObj);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem addition = new ListViewItem();

                addition.Text = read["ÜRÜN_ADI"].ToString();
                addition.SubItems.Add(read["ÜRÜN_FİYAT"].ToString());
                addition.SubItems.Add(read["ALIŞ_FİYAT"].ToString());
                addition.SubItems.Add(read["SATIŞ_FİYAT"].ToString());
                addition.SubItems.Add(read["ADET"].ToString());
              




                listView1.Items.Add(addition);
            }
            conObj.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conObj.Open();
            SqlCommand command = new SqlCommand("insert into stok( ÜRÜN_ADI,ÜRÜN_FİYAT,ALIŞ_FİYAT,SATIŞ_FİYAT,ADET)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','"
              + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')", conObj);

            command.ExecuteNonQuery();
            conObj.Close();
            show();
        }
    }
}
