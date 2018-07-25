using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace AdmsPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConString = ("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
            OracleConnection con = new OracleConnection(ConString);
            OracleDataAdapter oda = new OracleDataAdapter("SELECT COUNT (*) FROM LOGIN WHERE LUSER ='" + textBox1.Text + "' and LPASSWORD ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                
                Form2 myForm = new Form2();
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
