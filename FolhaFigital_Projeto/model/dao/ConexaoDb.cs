using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.model.dao
{
    public class ConexaoDb
    {
        SqlConnection url = new SqlConnection();
    
        public ConexaoDb()
        {
            url.ConnectionString = @"Data Source=DESKTOP-6MM7300\HEXTEC;Initial Catalog = db_HexTec; Integrated Security = True";
        }

        public SqlConnection conectar()
        {
            if(url.State == System.Data.ConnectionState.Closed)
            {
                url.Open();
            }
            return url;
            
        }
        public void desconectar()
        {
            if (url.State == System.Data.ConnectionState.Open)
            {
                url.Close();
            }

        }
    }
}
