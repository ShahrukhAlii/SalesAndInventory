﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace skelot
{
    public partial class frmManageUser : Form
    {
        SqlCommand cm;
        SqlConnection cn;
        SqlDataReader dr;
        ListViewItem lst;
        frmLogin login = new frmLogin();
      //  string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data.accdb";
        public frmManageUser()
        {
            InitializeComponent();
        }

        public void UpdateTrail()
        {

            try
            {
                string sql = @"INSERT INTO tblAuditTrail VALUES(@Dater,@TransacType,@Description,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblTimer.Text);
                cm.Parameters.AddWithValue("@TransacType", "Modification");
                cm.Parameters.AddWithValue("@Description", "User #: " + txtUserID.Text + " has been UPDATED!");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();

            }
            catch (SqlException l)
            {
                MessageBox.Show(l.Message);
            }
        }
        public void DeleteTrail() 
        {
            try
            {
                string sql = @"INSERT INTO tblAuditTrail VALUES(@Dater,@TransacType,@Description,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblTimer.Text);
                cm.Parameters.AddWithValue("@TransacType", "Deletion");
                cm.Parameters.AddWithValue("@Description", "User #: " + txtUserID.Text + " has been DELETED!");
                cm.Parameters.AddWithValue("@Authority", "Admin");

                cm.ExecuteNonQuery();

            }
            catch (SqlException l)
            {
                MessageBox.Show(l.Message);
            }
        
        
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {

                try
                {
                    
                 

                    string up = @"UPDATE tblLogin SET [ID] = '" + txtUserID.Text + "' ,[Age]='" + txtAge.Text + "',[Address]='" + txtAddress.Text + "',[Contact]='" + txtContact.Text + "',[Username]='" + txtUser.Text + "',[Password]='" + txtPass.Text + "'  where [FullName]='" + txtFullName.Text + "'";
                    cm = new SqlCommand(up, cn);

                    cm.Parameters.AddWithValue("@ID", txtUser.Text);
                    cm.Parameters.AddWithValue("@Age", txtAge.Text);
                    cm.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@Contact", txtContact.Text);
                    cm.Parameters.AddWithValue("@Username", txtUser.Text);
                    cm.Parameters.AddWithValue("@password", txtPass.Text);


                     cm.ExecuteNonQuery();
                     UpdateTrail();
                     Clear();
                     getData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmAdminMenu frmAM = new FrmAdminMenu();
            frmAM.Show();
          
        }

        private void frmManageUser_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(login.connection);
            cn.Open();
            getData();

            timer1.Start();
        }
        public void Clear() 
        {
            txtFullName.Text = "";
            txtAge.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtPass.Text = "";
            txtUser.Text = "";
            txtSearch.Text = "";
          
        }
        public void getData()
        {
            try
            {

                listView1.Items.Clear();
                listView1.Columns.Clear();

                listView1.Columns.Add("ID ", 0);
                listView1.Columns.Add("Full Name ", 120);
                listView1.Columns.Add("Age", 120);
                listView1.Columns.Add("Address", 150);
                listView1.Columns.Add("Contact", 120);
                listView1.Columns.Add("Username", 120);
                listView1.Columns.Add("Password", 120);



                string sql = @"Select * from tblLogin where FullName like '" + txtSearch.Text + "%'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    lst = listView1.Items.Add(dr[0].ToString());
                    lst.SubItems.Add(dr[1].ToString());
                    lst.SubItems.Add(dr[2].ToString());
                    lst.SubItems.Add(dr[3].ToString());
                    lst.SubItems.Add(dr[4].ToString());
                    lst.SubItems.Add(dr[5].ToString());
                    lst.SubItems.Add(dr[6].ToString());

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtUserID.Text == "")
            {
                MessageBox.Show("Can't Delete if TextBox(es) are/is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Do you really want to delete this User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                   DeleteTrail();
                   DeleteUsers();
                }
            }



          
        }
        public void DeleteUsers()
        {

            try
            {
                listView1.FocusedItem.Remove();
                string del = "delete from tblLogin where ID='" + txtUserID.Text + "'";
                cm = new SqlCommand(del, cn); cm.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted!");
                Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("No User to Remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUserID.Text = listView1.FocusedItem.Text;
            txtFullName.Text = listView1.FocusedItem.SubItems[1].Text;
            txtAge.Text = listView1.FocusedItem.SubItems[2].Text;
            txtAddress.Text = listView1.FocusedItem.SubItems[3].Text;

            txtContact.Text = listView1.FocusedItem.SubItems[4].Text;
            txtUser.Text = listView1.FocusedItem.SubItems[5].Text;
            txtPass.Text = listView1.FocusedItem.SubItems[6].Text;
          
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
           // string format = "MM-dd-yyy HH:mm:ss";
            lblTimer.Text = time.ToString();
           
        }

    }
}
