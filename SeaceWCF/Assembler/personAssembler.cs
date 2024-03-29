//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/10/20 - 23:37:23
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using SeaceWCF.Dtos;
using SeaceWCF;

namespace SeaceWCF.Assembler
{

    /// <summary>
    /// Assembler for <see cref="person"/> and <see cref="personDTO"/>.
    /// </summary>
    public static partial class personAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="personDTO"/> converted from <see cref="person"/>.</param>
        static partial void OnDTO(this person entity, personDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="person"/> converted from <see cref="personDTO"/>.</param>
        static partial void OnEntity(this personDTO dto, person entity);

        /// <summary>
        /// Converts this instance of <see cref="personDTO"/> to an instance of <see cref="person"/>.
        /// </summary>
        /// <param name="dto"><see cref="personDTO"/> to convert.</param>
        public static person ToEntity(this personDTO dto)
        {
            if (dto == null) return null;

            var entity = new person();

            entity.idPerson = dto.idPerson;
            entity.first_name = dto.first_name;
            entity.last_name = dto.last_name;
            entity.picture = dto.picture;
            entity.email = dto.email;
            entity.active = dto.active;
            entity.username = dto.username;
            entity.password = dto.password;
            entity.last_update = dto.last_update;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="person"/> to an instance of <see cref="personDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="person"/> to convert.</param>
        public static personDTO ToDTO(this person entity)
        {
            if (entity == null) return null;

            var dto = new personDTO();

            dto.idPerson = entity.idPerson;
            dto.first_name = entity.first_name;
            dto.last_name = entity.last_name;
            dto.picture = entity.picture;
            dto.email = entity.email;
            dto.active = entity.active;
            dto.username = entity.username;
            dto.password = entity.password;
            dto.last_update = entity.last_update;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="personDTO"/> to an instance of <see cref="person"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<person> ToEntities(this IEnumerable<personDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="person"/> to an instance of <see cref="personDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<personDTO> ToDTOs(this IEnumerable<person> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
        public static void Actualizar(SeaceWCF.Dtos.personDTO dto, person entity)
        {

            entity.idPerson = dto.idPerson;
            entity.first_name = dto.first_name;
            entity.last_name = dto.last_name;
            entity.picture = dto.picture;
            entity.email = dto.email;
            entity.active = dto.active;
            entity.username = dto.username;
            entity.password = dto.password;
            entity.last_update = dto.last_update;

        }

    }
}
