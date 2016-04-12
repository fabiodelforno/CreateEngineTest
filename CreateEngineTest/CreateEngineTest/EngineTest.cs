using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            string input = typeTree.Text + " " + sourceV.Text + " " + destV.Text + " " +
                attrNBox1.Text + " " + attrNBox2.Text + " " + attrNBox3.Text + " " + attrNBox4.Text + " " + attrNBox5.Text + " " +
                attrEBox1.Text + " " + attrEBox2.Text + " " + attrEBox3.Text + " " + attrEBox4.Text + " " + attrEBox5.Text + " ";
            String enginePath = @"C:\Users\kain\Desktop\Dream Engineering_V4\Codice compilato\Engine\Engine.exe";
            Process.Start(enginePath, input);
        }

        private void engineTest_Load(object sender, EventArgs e)
        {
            string sdwConnectionString = getConnectionString();
            SqlConnection sdwDBConnection = new SqlConnection(sdwConnectionString);
            try
            {
                sdwDBConnection.Open();
            }
            catch
            {
                MessageBox.Show("Accertarsi che i parametri di connessione siano corretti.");
            }
            string query = "SELECT tipo FROM Vertex_Edge";
            SqlCommand typeTree = new SqlCommand(query, sdwDBConnection);
            SqlDataReader reader = typeTree.ExecuteReader();
            
            List<string> listTypeTree = new List<string>();
            if (reader.HasRows)
            {
                
                while (reader.Read())
                {
                    if(!listTypeTree.Contains(reader.GetString(reader.GetOrdinal("tipo"))))
                    {
                        listTypeTree.Add(reader.GetString(reader.GetOrdinal("tipo")));
                    }
                    
                    
                }
            }else
            {
                Console.WriteLine("nessun albero caricato");
            }
            int i = 0;

            while(listTypeTree.Count != i)
            {
                Console.WriteLine("" + listTypeTree[i]);
                i++;
            }
            
        }
        //ToDo
        /**
        * get string Connection db OK
        * get type tree with db OK
        * get numeric node tree
        * get list attribute
        */
        private string getConnectionString()
        {
            string envNamePc = Environment.GetEnvironmentVariable("COMPUTERNAME");
            return "Data Source = " + envNamePc + @"\SQLEXPRESS;"
                    + "user id=sa; password=planner;"
                    + "Initial Catalog = Tree_Collection;";
        }
    }
}
