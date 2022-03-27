using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

/*
    PostgreSQL veritabanı, adreslemeye izin vermiyor. (https://stackoverflow.com/questions/21534460/what-is-the-proper-syntax-in-postgres-for-addressing-tables)
    Örn.
        SELECT * FROM [database].[dbo].[table]
 */

namespace DifferentDbProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            var id = Guid.NewGuid().ToString();

            var entity = new Complex
            {
                Information = new Information
                {
                    id = id,
                    inf = yaziTxt.Text.ToString()
                },
                DLog = new DLog
                {
                    id = Guid.NewGuid().ToString(),
                    inf_id = id,
                    insert_date = DateTime.UtcNow
                }
            };

            if (ayniPlatformChck.Checked)
                AyniPlatformFonk(entity);
            if (farkliPlatfomChck.Checked)
                FarkliPlatformFonk(entity);
        }

        private void FarkliPlatformFonk(Complex model)
        {
            try
            {
                using ( SqlConnection connection = new SqlConnection(ConnnectionStringReader.GetConnectionString("OrtakMSSQLDBContext")) )
                { 
                    var q1 = new SqlCommand("insert into [DboTest].dbo.Information(id,inf) values(@p1,@p2)", connection);

                    q1.Parameters.AddWithValue("@p1", model.Information.id);
                    q1.Parameters.AddWithValue("@p2", model.Information.inf);

                    connection.Open();

                    q1.ExecuteNonQuery();
                    connection.Close();
                }
                using ( NpgsqlConnection connection = new NpgsqlConnection(ConnnectionStringReader.GetConnectionString("OrtakPostgreSQLDBContext") + "Database=DboTestLog;") )
                {
                    var q2 = new NpgsqlCommand("insert into DLog(id,inf_id,insert_date) values(@p1,@p2,@p3)", connection);

                    q2.Parameters.AddWithValue("@p1", model.DLog.id);
                    q2.Parameters.AddWithValue("@p2", model.DLog.inf_id);
                    q2.Parameters.AddWithValue("@p3", model.DLog.insert_date);

                    connection.Open();

                    q2.ExecuteNonQuery();

                    connection.Close();
                }

                MessageBox.Show("Ekleme başarılı oldu.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata meydana geldi. =>" + e.Message);
            }
        }

        private void AyniPlatformFonk(Complex model)
        {
            var cString = postgreChck.Checked ? "OrtakPostgreSQLDBContext" : "OrtakMSSQLDBContext";

            if (cString == "OrtakMSSQLDBContext" )
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnnectionStringReader.GetConnectionString(cString)))
                    {

                        var q1 = new SqlCommand("insert into [DboTest].dbo.Information(id,inf) values(@p1,@p2)",connection);
                        var q2 = new SqlCommand("insert into [DboTestLog].dbo.DLog(id,inf_id,insert_date) values(@p1,@p2,@p3)",connection);

                        q1.Parameters.AddWithValue("@p1", model.Information.id);
                        q1.Parameters.AddWithValue("@p2", model.Information.inf);

                        q2.Parameters.AddWithValue("@p1", model.DLog.id);
                        q2.Parameters.AddWithValue("@p2", model.DLog.inf_id);
                        q2.Parameters.AddWithValue("@p3", model.DLog.insert_date);

                        connection.Open();

                        q1.ExecuteNonQuery();
                        q2.ExecuteNonQuery();

                        connection.Close();

                    }

                    MessageBox.Show("Ekleme başarılı oldu.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Hata meydana geldi. =>"+ e.Message);
                }
            }

            else if (cString == "OrtakPostgreSQLDBContext")
            {
                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(ConnnectionStringReader.GetConnectionString(cString)+ "Database=DboTest;") )
                    {
                        var q1 = new NpgsqlCommand("insert into information(id,inf) values(@p1,@p2)",connection);

                        q1.Parameters.AddWithValue("@p1", model.Information.id);
                        q1.Parameters.AddWithValue("@p2", model.Information.inf);

                        connection.Open();

                        q1.ExecuteNonQuery();

                        connection.Close();
                    }

                    using ( NpgsqlConnection connection = new NpgsqlConnection(ConnnectionStringReader.GetConnectionString(cString) + "Database=DboTestLog;") )
                    {
                        var q2 = new NpgsqlCommand("insert into DLog(id,inf_id,insert_date) values(@p1,@p2,@p3)", connection);

                        q2.Parameters.AddWithValue("@p1", model.DLog.id);
                        q2.Parameters.AddWithValue("@p2", model.DLog.inf_id);
                        q2.Parameters.AddWithValue("@p3", model.DLog.insert_date);

                        connection.Open();

                        q2.ExecuteNonQuery();

                        connection.Close();
                    }

                    MessageBox.Show("Ekleme başarılı oldu.");
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("Hata meydana geldi. =>"+ e.Message);
                }
            }
        }
    }

    public class Information
    {
        public string id { get; set; }
        public string inf { get; set; }
    }

    public class DLog
    {
        public string id { get; set; }
        public string inf_id { get; set; }
        public DateTime insert_date { get; set; }
    }

    public class Complex
    {
        public Information Information { get; set; }
        public DLog DLog { get; set; }
    }
}
