using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer;
using System.Data.SqlClient;
using System.Data;

namespace HRProjectWeb.Models
{
    public class Nationality
    {
        public string Name { get; set; }
        public bool  Active { get; set; }

        public List<Nationality> GetNationalityList()
        {
            List<Nationality> list = new List<Nationality>();
            var connectionString = Properties.Settings.Default.DbConnectionString;
            DataFunctions daf = new DataFunctions();
            var dataset = daf.ExecuteQuery(new SqlConnection(connectionString), "SelectNationality", null);

            if(dataset !=null && dataset.Tables.Count>0)
            {
                foreach (DataRow  datarow in dataset.Tables[0].Rows)
                {
                    list.Add(new Nationality() {
                        Active =true,
                        Name = datarow["Name"].ToString()
                    });
                }
            }
            return list;

        }
    }

  
}