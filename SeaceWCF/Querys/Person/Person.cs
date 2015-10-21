using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaceWCF.Querys
{
    public partial class Querys: Person.IPerson 
    {
        public int InsertarPersona(Dtos.personDTO dto)
        {
            try
            {
                using (var modelo = new dbSEACEappEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.usuario.Add(entity);
                    modelo.SaveChanges();

                    return entity.ID_Usuario;


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
                    var w = modelo.usuario.Where(q => q.ID_Usuario == dto.ID_Usuario).Select(q => q).FirstOrDefault();
                    if (w == null) return false;

                    Dominio.Convertidores.usuarioAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();

                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarPersona(int idperson)
        {
            try
            {
                using (var modelo = new dbSEACEappEntities())
                {
                    PersistenciaDatos.usuario x = modelo.usuario.Where(q => q.ID_Usuario == idusuario).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.usuario.Remove(x);

                    foreach (var modeloproyectoDTOX in modelo.proyecto.Where(d => d.ID_Usuario == idusuario))
                    {
                        modelo.proyecto.Remove(modeloproyectoDTOX);
                    }
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
                    var entity = modelo.usuario.Where(q => q.nombres.Contains(nombresusuario)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.usuarioAssembler.ToDTOs(entity);

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
                    var entity = modelo.usuario.Select(q => q).ToList();

                    if (entity == null) return null;

                    return Dominio.Convertidores.usuarioAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.personDTO BuscarPersonaPorID(int idperson)
        {
            try
            {
                using (var modelo = new dbSEACEappEntities())
                {
                    var entity = modelo.usuario.Where(q => q.ID_Usuario == idusuario).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.usuarioAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
