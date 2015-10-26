using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SeaceWCF.Querys.Person
{
    [ServiceContract]
    public  interface IPersonQuery
    {
        [OperationContract]
        long InsertarPersona(Dtos.personDTO dto);
        [OperationContract]
        bool ActualizarPersona(Dtos.personDTO dto);
        [OperationContract]
        bool EliminarPersona(long idperson);
        [OperationContract]
        IEnumerable<Dtos.personDTO> ListarPersonaXnombre(string nombrespersona);
        [OperationContract]
        IEnumerable<Dtos.personDTO> ListarPersonas();
        [OperationContract]
        Dtos.personDTO BuscarPersonaPorID(long idperson);
        [OperationContract]
        bool VerificarPassword(Dtos.personDTO dto);
    }
}
