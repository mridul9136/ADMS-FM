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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO ITEM (ITEM_ID,ITEM_NAME,UNIT,PRICE) values(" + textBox1.Text + ",'" + this.textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + ")";


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("DATA INSERTED");

                viewdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            void viewdata()
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleDataAdapter dr = new OracleDataAdapter("SELECT * FROM ITEM", conn);

                DataSet ds = new DataSet();
                ds.Tables.Add("ITEM");
                dr.Fill(ds, "ITEM");

                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "ITEM";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE ITEM SET ITEM_NAME = '" + textBox2.Text + "', UNIT ='" + textBox3.Text + "', PRICE = '" + textBox4.Text + "' " +
                    "WHERE (ITEM_ID = '" + textBox1.Text + "')";


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
                OracleDataAdapter dr = new OracleDataAdapter("SELECT * FROM ITEM", conn);

                DataSet ds = new DataSet();
                ds.Tables.Add("ITEM");
                dr.Fill(ds, "ITEM");

                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "ITEM";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM ITEM WHERE (ITEM_ID = '" + textBox1.Text + "')";


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
                OracleDataAdapter dr = new OracleDataAdapter("SELECT * FROM ITEM", conn);

                DataSet ds = new DataSet();
                ds.Tables.Add("ITEM");
                dr.Fill(ds, "ITEM");

                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "ITEM";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try

            {

                string ConString = ("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");


                using (OracleConnection con = new OracleConnection(ConString))

                {

                    OracleCommand cmd = new OracleCommand("SELECT * FROM ITEM", con);

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
