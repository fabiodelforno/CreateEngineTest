using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateEngineTest
{
    public partial class engineTest : Form
    {
        public engineTest()
        {
            InitializeComponent();
        }

        List<string> listTypeTree = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {


            string input = typeTreeBox.Text + " " + sourceV.Text + " " + destV.Text;
                //attrNBox1.Text + " " + attrNBox2.Text + " " + attrNBox3.Text + " " + attrNBox4.Text + " " + attrNBox5.Text + " " +
                //attrEBox1.Text + " " + attrEBox2.Text + " " + attrEBox3.Text + " " + attrEBox4.Text + " " + attrEBox5.Text;
            if(attrNBox1.Text != "")
            {
                input = input + " " + attrNBox1.Text;
            }
            if (attrNBox2.Text != "")
            {
                input = input + " " + attrNBox2.Text;
            }
            if (attrNBox3.Text != "")
            {
                input = input + " " + attrNBox3.Text;
            }
            if (attrNBox4.Text != "")
            {
                input = input + " " + attrNBox4.Text;
            }
            if (attrNBox5.Text != "")
            {
                input = input + " " + attrNBox5.Text;
            }
            if (attrEBox1.Text != "")
            {
                input = input + " " + attrEBox1.Text;
            }
            if (attrEBox2.Text != "")
            {
                input = input + " " + attrEBox2.Text;
            }
            if (attrEBox3.Text != "")
            {
                input = input + " " + attrEBox3.Text;
            }
            if (attrEBox4.Text != "")
            {
                input = input + " " + attrEBox4.Text;
            }
            if (attrEBox5.Text != "")
            {
                input = input + " " + attrNBox5.Text;
            }

            String enginePath = @"C:\Users\kain\Desktop\Dream Engineering_V4\Codice compilato\Engine\Engine.exe";
            Console.WriteLine("" + input);
            if(tenButton.Checked)
            {
                Process.Start(enginePath, input);
                //Process.Start(enginePath, input);
            }
            attrEBox1.Text = attrEBox2.Text = attrEBox3.Text = attrEBox4.Text = attrEBox5.Text = attrNBox1.Text = attrNBox2.Text = attrNBox3.Text = attrNBox4.Text = attrNBox5.Text = "";
            sourceV.Text = destV.Text = "";

        }

        private void engineTest_Load(object sender, EventArgs e)
        {
            string sdwConnectionString = getConnectionString();
            createConfigFile(sdwConnectionString);
            SqlConnection sdwDBConnection = new SqlConnection(sdwConnectionString);
            string query = @"SELECT tipo FROM Vertex_Edge";

            SqlCommand command = new SqlCommand(query, sdwDBConnection);
            command.Connection = sdwDBConnection;
            command.CommandText = query;
            
            try
            {
                sdwDBConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //sdwDBConnection.OpenAsync
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        if (!listTypeTree.Contains(reader.GetString(reader.GetOrdinal("tipo"))))
                        {
                            listTypeTree.Add(reader.GetString(reader.GetOrdinal("tipo")));
                        }


                    }
                }
                else
                {
                    Console.WriteLine("nessun albero caricato nel db");
                    MessageBox.Show("nessun albero presente nel database");
                }
            }
            catch
            {
                MessageBox.Show("Accertarsi che i parametri di connessione siano corretti.");
            }
            finally
            {
                sdwDBConnection.Close();
            }
            
            
            int i = 0;

            while(listTypeTree.Count != i)
            {
                Console.WriteLine("" + listTypeTree[i]);
                i++;
            }

            //init comboBox type tree
            foreach (string item in listTypeTree)
            {
                typeTreeBox.Items.Add(item);
            }

        }
        //ToDo
        /**
        * get string Connection db OK
        * get type tree with db OK
        * get numeric node tree NONE
        * get list attribute NONE
        */
        
        private string getConnectionString()
        {
            string envNamePc = Environment.GetEnvironmentVariable("COMPUTERNAME");
            return "Data Source = " + envNamePc + @"\SQLEXPRESS;"
                    + "user id=sa; password=planner;"
                    + "Initial Catalog = Tree_Collection;";
        }
        private void createConfigFile(string connection)
        {
            FileStream fs = File.Open("Config.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(connection);
            sw.Flush();
            fs.Close();
        }
    }
}
