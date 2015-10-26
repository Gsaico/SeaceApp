using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaceWCF.Assembler;
using SeaceWCF.Dtos;

namespace SeaceWCF
{
    public partial class ServiceApp : Querys.Person.IPersonQuery 
    {
        public long InsertarPersona(Dtos.personDTO dto)
        {
            try
            {
                using (var modelo = new dbSEACEappEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.persons.Add(entity);
                    modelo.SaveChanges();

                    return entity.idPerson;


                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarPersona(Dtos.personDTO dto)
        {
            try
            {
                using (var modelo = new dbSEACEappEntities())
                {
                    var w = modelo.persons.Where(q => q.idPerson == dto.idPerson).Select(q => q).FirstOrDefault();
                    if (w == null) return false;

                    SeaceWCF.Assembler.personAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();

                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarPersona(long idperson)
        {
            try
            {
                using (var modelo = new dbSEACEappEntities())
                {
                    person x = modelo.persons.Where(q => q.idPerson == idperson).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.persons.Remove(x);

                   
                    modelo.SaveChanges();


                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Dtos.personDTO> ListarPersonaXnombre(string nombrespersona)
        {
            try
            {
                using (var modelo = new dbSEACEappEntities())
                {
                    var entity = modelo.persons.Where(q => q.first_name.Contains(nombrespersona)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return SeaceWCF.Assembler.personAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public IEnumerable<Dtos.personDTO> ListarPersonas()
        {
            try
            {
                using (var modelo = new dbSEACEappEntities())
                {
                    var entity = modelo.persons.Select(q => q).ToList();

                    if (entity == null) return null;

                    return SeaceWCF.Assembler.personAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.personDTO BuscarPersonaPorID(long idperson)
        {
            try
            {
                using (var modelo = new dbSEACEappEntities())
                {
                    var entity = modelo.persons.Where(q => q.idPerson  == idperson).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return SeaceWCF.Assembler.personAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public bool VerificarPassword(personDTO dto)
        {
            try
            {
                using (var modelo = new dbSEACEappEntities())
                {
                    var entity = modelo.persons.Where(q => q.username == dto.username && q.password == dto.password).Select(q => q).FirstOrDefault();

                    if (entity != null)   
                    {
                        //Elusuario existe.
                        return true;
                    }
                    else    
                    {
                        //El usuario no existe
                        return false;
                    }

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
