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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO CUSTOMER (C_ID,C_NAME,ITEM_NAME,QTY,PRICE) values(" + textBox1.Text + ",'" + this.textBox2.Text + "','" + this.textBox3.Text + "'," + textBox4.Text + "," + textBox5.Text + ")";


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
                OracleDataAdapter dr = new OracleDataAdapter("SELECT * FROM CUSTOMER", conn);

                DataSet ds = new DataSet();
                ds.Tables.Add("CUSTOMER");
                dr.Fill(ds, "CUSTOMER");

                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "CUSTOMER";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE CUSTOMER SET C_NAME = '" + textBox2.Text + "', ITEM_NAME ='" + textBox3.Text + "', QTY = '" + textBox4.Text + "',PRICE = '" + textBox5.Text + "' " +
                    "WHERE (C_ID = '" + textBox1.Text + "')";


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
                OracleDataAdapter dr = new OracleDataAdapter("SELECT * FROM CUSTOMER", conn);

                DataSet ds = new DataSet();
                ds.Tables.Add("CUSTOMER");
                dr.Fill(ds, "CUSTOMER");

                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "CUSTOMER";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM CUSTOMER WHERE (C_ID = '" + textBox1.Text + "')";


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
                OracleDataAdapter dr = new OracleDataAdapter("SELECT * FROM CUSTOMER", conn);

                DataSet ds = new DataSet();
                ds.Tables.Add("CUSTOMER");
                dr.Fill(ds, "CUSTOMER");

                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "CUSTOMER";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try

            {

                string ConString = ("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");


                using (OracleConnection con = new OracleConnection(ConString))

                {

                    OracleCommand cmd = new OracleCommand("SELECT * FROM CUSTOMER", con);

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
    }
}
