﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solab.EntityFramework.Tests
{
    public static class ConnectionFactory
    {
        private const string DefaultLocalDbInstance = "Data Source=(LocalDB)\\MSSQLLocalDB";
        public const string DefaultDatabaseName = "UnitTests";

        public static SqlConnection Create(string database = DefaultDatabaseName)
        {
            var connection = new SqlConnection(DefaultLocalDbInstance);
            connection.Open();
            connection.ChangeDatabase(database);
            return connection;
        }
    }
}