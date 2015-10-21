using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaceWCF.Querys.Person
{
   public  interface IPerson
    {
        int InsertarPersona(Dtos.personDTO dto);
        bool ActualizarPersona(Dtos.personDTO dto);
        bool EliminarPersona(int idperson);
        IEnumerable<Dtos.personDTO> ListarPersonaXnombre(string nombrespersona);
        IEnumerable<Dtos.personDTO> ListarPersonas();
        Dtos.personDTO BuscarPersonaPorID(int idperson);
    }
}
