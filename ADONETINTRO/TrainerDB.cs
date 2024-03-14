using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ADONETINTRO
{
    public class TrainerDB
    {
        // 1 select all trainers

        public List<Trainer> AllTrainer()
        {
            List<Trainer> trainers = new List<Trainer>();

            string connectionString = "server= PRANAV\\SQLEXPRESS01; database= B22ADONETDB; integrated security= True";

            SqlConnection col = new SqlConnection(connectionString);
            col.Open();

            string cmndata = "select ID, Name, city, Experience from Trainer";
            SqlCommand cmn = new SqlCommand(cmndata, col);

            SqlDataReader reader  = cmn.ExecuteReader();

            if (reader.HasRows )
            {
                while (reader.Read())
                {
                    Trainer t = new Trainer();
                    t.ID = (int) reader["ID"];
                    t.Name = reader["Name"].ToString();
                    t.City = reader["City"].ToString();
                    t.Experience = reader["Experience"].ToString();

                    trainers.Add(t);
                }
            }

            return trainers;
        }

    }
}
