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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO EMPLOYEE (EMP_ID,EMP_NAME,PHONE,EMAIL,POSITION) values(" + textBox1.Text + ",'" + this.textBox2.Text + "'," + textBox3.Text + ",'" + this.textBox4.Text + "','" + this.textBox5.Text + "')";


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("ok");

                viewdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            void viewdata()
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleDataAdapter dr = new OracleDataAdapter("SELECT * FROM EMPLOYEE", conn);

                DataSet ds = new DataSet();
                ds.Tables.Add("EMPLOYEE");
                dr.Fill(ds, "EMPLOYEE");

                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "EMPLOYEE";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE EMPLOYEE SET EMP_NAME = '" + textBox2.Text + "', PHONE ='" + textBox3.Text + "', EMAIL = '" + textBox4.Text + "',POSITION = '" + textBox5.Text + "' " +
                    "WHERE (EMP_ID = '" + textBox1.Text + "')";


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("ok");
                viewdata();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            void viewdata()
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleDataAdapter dr = new OracleDataAdapter("SELECT * FROM EMPLOYEE", conn);

                DataSet ds = new DataSet();
                ds.Tables.Add("EMPLOYEE");
                dr.Fill(ds, "EMPLOYEE");

                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "EMPLOYEE";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM EMPLOYEE WHERE (EMP_ID = '" + textBox1.Text + "')";


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("ok");
                viewdata();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            void viewdata()
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleDataAdapter dr = new OracleDataAdapter("SELECT * FROM EMPLOYEE", conn);

                DataSet ds = new DataSet();
                ds.Tables.Add("EMPLOYEE");
                dr.Fill(ds, "EMPLOYEE");

                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "EMPLOYEE";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try

            {

                string ConString = ("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");


                using (OracleConnection con = new OracleConnection(ConString))

                {

                    OracleCommand cmd = new OracleCommand("SELECT * FROM EMPLOYEE", con);

                    OracleDataAdapter oda = new OracleDataAdapter(cmd);

                    DataSet ds = new DataSet();

                    oda.Fill(ds);

                    if (ds.Tables.Count > 0)

                    {

                        dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    }


                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
