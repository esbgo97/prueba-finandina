using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppRepository.ClientRepository;
using AppModels.Models;

namespace AppService
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }
        public int Create(Client client)
        {
            try
            {
                return _clientRepository.Create(client);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public bool Delete(int clientId)
        {
            try
            {
                return _clientRepository.Delete(clientId);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Client> GetAll()
        {
            try
            {
                return _clientRepository.GetAll();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int Update(Client client)
        {
            try
            {
                return _clientRepository.Update(client);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public bool UpdateActive(int clientId, bool isActive)
        {
            try
            {
                return _clientRepository.UpdateActive(clientId,isActive);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
