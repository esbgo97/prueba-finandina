using AppModels.Mappers;
using AppModels.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AppRepository.ClientRepository
{
    public class ClientRepository : IClientRepository
    {
        public int Create(Client client)
        {
            var dt = AppDBContext.ExecuteSP(Queries.Client.CREATE, client.ToParameters().ToArray());
            return 1;
        }

        public bool Delete(int clientId)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("Id", clientId);
            var dt = AppDBContext.ExecuteSP(Queries.Client.DELETE, parameters);
            return true;
        }

        public List<Client> GetAll()
        {
            var dt = AppDBContext.ExecuteSP(Queries.Client.GET_ALL);
            return dt.Rows.ToClientList();
        }

        public int Update(Client client)
        {
            var dt = AppDBContext.ExecuteSP(Queries.Client.UPDATE, client.ToParameters().ToArray());
            return 1;
        }

        public bool UpdateActive(int clientId, bool isActive)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("Id", clientId);
            parameters[1] = new SqlParameter("IsActive", isActive);
            var dt = AppDBContext.ExecuteSP(Queries.Client.UPDATE_STATE, parameters);
            return true;
        }
    }
}
