﻿using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class MateriasModelo : IdentificadorModelo
    {
        public string Nome { get; set; }
        public ProfessorModelo ProfessorTitular { get; set; }
        public int CargaHora { get; set; }

        public IList<ConteudoMateriaModelo> conteudoMaterias { get; set; }
        public MateriasEntidade Transformar(MateriasModelo objeto)
        {

            return new MateriasEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                CargaHora = objeto.CargaHora,
                conteudoMaterias = (List<ConteudoMateriaEntidade>)objeto.conteudoMaterias,
                ProfessorTitular = ProfessorTitular.Transformar(objeto.ProfessorTitular),
            };
        }
        public MateriasModelo Transformar(MateriasEntidade objeto)
        {

            return new MateriasModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                CargaHora = objeto.CargaHora,
                conteudoMaterias = (IList<ConteudoMateriaModelo>)objeto.conteudoMaterias,
                ProfessorTitular = ProfessorTitular.Transformar(objeto.ProfessorTitular),
            };
        }

    }
}