﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Entidades
{
    public class MatriculaEntidade : IdentificadorEntidade
    {
        public virtual AlunoEntidade Aluno { get; set; }
        public virtual InstalacaoEntidade Instalacao { get; set; }
    }
}
