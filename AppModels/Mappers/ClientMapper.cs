using System;
using System.Data;
using System.Collections.Generic;
using AppModels.Models;
using System.Data.SqlClient;

namespace AppModels.Mappers
{
    public static class ClientMapper
    {
        public static Client ToClient(this DataRow row)
        {
            return new Client
            {
                Id = (int)row["Id"],
                Names = (string)row["Names"],
                LastNames = (string)row["LastNames"],
                DocNumber = (string)row["DocNumber"],
                Birth = (DateTime)row["Birth"],
                IsActive = (bool)row["IsActive"]
            };
        }

        public static List<Client> ToClientList(this DataRowCollection rows)
        {
            List<Client> result = new List<Client>();
            foreach (DataRow row in rows)
                result.Add(row.ToClient());
            return result;
        }
        public static List<SqlParameter> ToParameters(this Client client)
        {
            return new List<SqlParameter> {
                new SqlParameter("Id",client.Id),
                new SqlParameter("Names",client.Names),
                new SqlParameter("LastNames",client.LastNames),
                new SqlParameter("DocNumber",client.DocNumber),
                new SqlParameter("Birth",client.Birth),
                new SqlParameter("IsActive",client.IsActive)
            };
        }
    }
}
