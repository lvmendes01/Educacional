﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Entidades
{
    public class MateriasEntidade : IdentificadorEntidade
    {
        public string Nome { get; set; }
        public ProfessorEntidade ProfessorTitular { get; set; }
        public int CargaHora { get; set; }

        public IList<ConteudoMateriaEntidade> conteudoMaterias { get; set; }

    }
}
