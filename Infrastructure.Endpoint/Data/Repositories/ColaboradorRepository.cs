﻿using Domain.Endpoint.Entities;
using Domain.Endpoint.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Endpoint.Data.Repositories
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        private readonly List<Colaborador> dataColaborador = new List<Colaborador>();

        public ColaboradorRepository()
        {
            var colaborador1 = new Colaborador
            {

                Id = Guid.NewGuid(),
                PrimerNombre = "Juaquin",
                SegundoNombre = "Jose",
                PrimerApellido = "Perez",
                SegundoApellido = "Ocon",
                Correo = "JosePerez@gmail.com",
                Estado = "Soltero",
                Sexo = "Masculino",
                UserName = "JosePerez",
                Contraseña = "Juan9087"

            };

            dataColaborador.Add(colaborador1);
        }


        public void Create(Colaborador nuevoColaborador)
        {
            dataColaborador.Add(nuevoColaborador);
        }

        public void Delete(Guid Id)
        {
            var DeleteColaborador = dataColaborador.FirstOrDefault(c => c.Id == Id);

            if (DeleteColaborador != null)
            {
                dataColaborador.Remove(DeleteColaborador);
            }
        }

        public List<Colaborador> Get()
        {
            return dataColaborador;
        }

        public void UpdateColaborador(Guid Id, Colaborador nuevosregistros)
        {
            var UpdateColaborador = dataColaborador.FirstOrDefault(c => c.Id == Id);

            if (UpdateColaborador != null)
            {
                UpdateColaborador.PrimerNombre = nuevosregistros.PrimerNombre;
                UpdateColaborador.SegundoNombre = nuevosregistros.SegundoNombre;
                UpdateColaborador.PrimerApellido = nuevosregistros.PrimerApellido;
                UpdateColaborador.SegundoApellido = nuevosregistros.SegundoApellido;
                UpdateColaborador.Correo = nuevosregistros.Correo;
                UpdateColaborador.Estado = nuevosregistros.Estado;
                UpdateColaborador.Sexo = nuevosregistros.Sexo;
                UpdateColaborador.UserName = nuevosregistros.UserName;
                UpdateColaborador.Contraseña = nuevosregistros.Contraseña;
            }
        }
    }
}
