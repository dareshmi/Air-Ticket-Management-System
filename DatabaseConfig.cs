using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; 

namespace Air_Ticket_Management_System
{
    internal static class DatabaseConfig
    {
        public static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["AirTicketDB"].ConnectionString;
    }
}