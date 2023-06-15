using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hasta_Randevu_Alma
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-1O1C6DA;Initial Catalog=HastaRandevuAlmaProjesi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
