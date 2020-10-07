using System;
using System.Collections.Generic;
using AppModels.Models;

namespace AppRepository.ClientRepository
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        int Create(Client client);
        int Update(Client client);
        bool UpdateActive(int clientId, bool isActive);
        bool Delete(int clientId);
    }
}
