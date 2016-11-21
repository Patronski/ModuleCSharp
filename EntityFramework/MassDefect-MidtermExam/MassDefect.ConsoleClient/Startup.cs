using MassDefect.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassDefect.ConsoleClient
{
    public class Startup
    {
        static void Main()
        {
            MassDefectContext context = new MassDefectContext();

            using (context)
            {
                context.Database.CreateIfNotExists();
            }
        }
    }
}
