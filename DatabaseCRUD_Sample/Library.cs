using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace DatabaseCRUD_Sample
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }
        //Please change under the connection string in depent your choise Data Source(your server) and Database name 
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-0E029OM;Initial Catalog=Trial;Integrated Security=True");
        private void ShowDatas()
        {
            listView1.Items.Clear();
            connect.Open();
            SqlCommand command = new SqlCommand("Select * From Books",connect);
            SqlDataReader reader= command.ExecuteReader();
            while(reader.Read())
            {
                //Please change column names in depent your choise
                ListViewItem addToList= new ListViewItem();
                addToList.Text= reader["BookID"].ToString();
                addToList.SubItems.Add(reader["BookName"].ToString());
                addToList.SubItems.Add(reader["Author"].ToString());
                addToList.SubItems.Add(reader["Publisher"].ToString());
                addToList.SubItems.Add(reader["PageAmount"].ToString());

                listView1.Items.Add(addToList);
            }

            connect.Close();

        }
       
        int ListItemId = 0;
        private void btnAddData_Click(object sender, EventArgs e)
        {
            connect.Open();
            //Please change column names in depent your choise
            string SqlString = "Insert Into Books (BookName,Author,Publisher,PageAmount) Values " +
                $"('{txbBookName.Text}','{txbAuthor.Text}','{txbPublisher.Text}','{txbPage.Text}')";
            SqlCommand command = new SqlCommand(SqlString, connect);
            command.ExecuteNonQuery();
            txbBookName.Clear();
            txbAuthor.Clear();
            txbPublisher.Clear();
            txbPage.Clear();
            connect.Close();
            ShowDatas();
            MessageBox.Show("Kitap başarılı bir şekilde eklendi");  
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Seçmiş olduğunuz kitap şudur => {listView1.SelectedItems[0].SubItems[1].Text} \n " +
    $"Silmek istediğinize emin misiniz?", "Silme Ekranı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand($"Delete From Books Where id={ListItemId}", connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                    ShowDatas();
                    MessageBox.Show("Silme işlemi başarılı bir şekilde gerçekleşti", "Silme İşlemi Sonucu");
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi", "Silme İşlemi Sonucu");
                }
                

            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen kitap sırasından bir kitap seçiniz");
            }

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListItemId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
            txbUbookName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txbUauthor.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txbUpublisher.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txbUpage.Text = listView1.SelectedItems[0].SubItems[4].Text;
            lblA.Visible = true;
            lblBN.Visible = true;
            lblP.Visible = true;
            lblPage.Visible = true;
            txbUauthor.Visible = true;
            txbUbookName.Visible = true;
            txbUpage.Visible = true;
            txbUpublisher.Visible = true;
            btnUpdateCurrent.Visible = true;
            }
            catch(Exception) 
            {
                MessageBox.Show("Lütfen kitap sırasından bir kitap seçiniz");
                lblA.Visible = false;
                lblBN.Visible = false;
                lblP.Visible = false;
                lblPage.Visible = false;
                txbUauthor.Visible = false;
                txbUbookName.Visible = false;
                txbUpage.Visible = false;
                txbUpublisher.Visible = false;
                btnUpdateCurrent.Visible = false;
            }
         
        }

        private void btnUpdateCurrent_Click(object sender, EventArgs e)
        {
            
                switch(MessageBox.Show("Güncelleme İşlemini Onaylıyor Musunuz", "Güncelleme Ekranı", MessageBoxButtons.YesNoCancel))
                {
            case DialogResult.Yes:
                connect.Open();
                string SqlUpdate = $"Update Books Set BookName='{txbUbookName.Text}',Author='{txbUauthor.Text}',Publisher='{txbUpublisher.Text}',PageAmount='{txbUpage.Text}' Where BookID={ListItemId} ";
                SqlCommand command = new SqlCommand(SqlUpdate, connect);
                command.ExecuteNonQuery();
                connect.Close();
                ShowDatas();
                MessageBox.Show("Güncelleme işlemi başarılı...");
                lblA.Visible = false;
                lblBN.Visible = false;
                lblP.Visible = false;
                lblPage.Visible = false;
                txbUauthor.Visible = false;
                txbUbookName.Visible = false;
                txbUpage.Visible = false;
                txbUpublisher.Visible = false;
                btnUpdateCurrent.Visible = false;break;
            case DialogResult.No:break;
            case DialogResult.Cancel:
                lblA.Visible = false;
                lblBN.Visible = false;
                lblP.Visible = false;
                lblPage.Visible = false;
                txbUauthor.Visible = false;
                txbUbookName.Visible = false;
                txbUpage.Visible = false;
                txbUpublisher.Visible = false;
                btnUpdateCurrent.Visible = false;break;
            }
            
        }

        private void Library_Load(object sender, EventArgs e)
        {
            ShowDatas();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowDatas();
        }
    }
}
