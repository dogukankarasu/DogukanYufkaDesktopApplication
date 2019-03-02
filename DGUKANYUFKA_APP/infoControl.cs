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
    public partial class infoControl : UserControl
    {
        public infoControl()
        {
            InitializeComponent();
        }
        SqlConnection conObj = new SqlConnection("Data Source=LAPTOP-UJ83ER0C\\SQLEXPRESS;Initial Catalog=dy_app;Integrated Security=True");
        private void show()
        {
            listView1.Items.Clear();
            conObj.Open();
            SqlCommand command = new SqlCommand("select *from calısan_bilgi1 ", conObj);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem addition = new ListViewItem();
               
                addition.Text = read["İSİM_SOYİSİM"].ToString();
                addition.SubItems.Add(read["BASLANGIC_TARİHİ"].ToString());
                addition.SubItems.Add(read["YAŞ"].ToString());
                addition.SubItems.Add(read["ADRES"].ToString());
                addition.SubItems.Add(read["TC"].ToString());
                


                listView1.Items.Add(addition);
            }
            conObj.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btngöster_Click(object sender, EventArgs e)
        {
            show();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            conObj.Open();
            SqlCommand command = new SqlCommand("insert into calısan_bilgi1(İSİM_SOYİSİM,BASLANGIC_TARİHİ,YAŞ,ADRES,TC)values('" + textBox1.Text.ToString() + "','" + dateTimePicker1.Value.Date +
                "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')", conObj);

            command.ExecuteNonQuery();
            conObj.Close();
            show();
        }
       
        
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
            
        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
          
        }
    }
}
