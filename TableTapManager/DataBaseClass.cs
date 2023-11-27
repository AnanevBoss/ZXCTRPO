using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTapManager
{
    class DataBaseClass
    {
        public static string ConnectionString = "Data Source = DESKTOP-B4LL5OF\\MYSERVERNAME; Initial Catalog = TableTap; Integrated Security = true";
        public SqlConnection connection = new SqlConnection(ConnectionString);
        public SqlCommand command = new SqlCommand();
        public SqlDependency dependency = new SqlDependency();
        public DataTable resultTable = new DataTable();
        public enum act { select, manipulation };
    
    public void sqlExecute(string quety, act act)
    {
        command.Connection = connection;
        command.CommandText = quety;
        command.Notification = null;
        switch (act)
        {
            case act.select:
                dependency.AddCommandDependency(command);
                SqlDependency.Start(connection.ConnectionString);
                connection.Open();
                resultTable.Load(command.ExecuteReader());
                connection.Close();
                break;

            case act.manipulation:
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                break;
        }
    }
}
}
