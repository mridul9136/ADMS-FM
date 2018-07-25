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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {

                string ConString = ("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");


                using (OracleConnection con = new OracleConnection(ConString))

                {

                    OracleCommand cmd = new OracleCommand("UPDATE CUSTOMERTOTAL SET CUSTOMER_TOTAL = TOTALCUSTOMER()", con);

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

        private void button2_Click(object sender, EventArgs e)
        {
            try

            {

                string ConString = ("DATA SOURCE=mm:1521/XE;USER ID = MRIDUL; Password=mridul");


                using (OracleConnection con = new OracleConnection(ConString))

                {

                    OracleCommand cmd = new OracleCommand("SELECT * FROM CUSTOMERTOTAL", con);

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
