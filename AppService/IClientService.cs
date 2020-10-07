using System.Collections.Generic;
using System.ServiceModel;
using AppModels.Models;

namespace AppService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IClientService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        List<Client> GetAll();

        [OperationContract]
        int Create(Client client);

        [OperationContract]
        int Update(Client client);

        [OperationContract]
        bool UpdateActive(int clientId, bool isActive);

        [OperationContract]
        bool Delete(int clientId);
    }
}
