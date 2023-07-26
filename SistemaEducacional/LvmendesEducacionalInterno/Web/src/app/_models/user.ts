



export class User {
  nome?: string
  login?: string
  senha?: string
  perfil?: Perfil
  ativo?: boolean
  id?: string;
  empresa?: Empresa;
  token?: string;
}

export class Empresa {
  id?: number|0
  nome?: string
  imagem?: string
  localizacao?: string
  pix?: string
  ativo?: string
  
}
export class UserLogin {
  login?: string
  senha?: string
}
export class Perfil {
  nomePerfil?: string
  permissoes: Permiss[] | undefined
  id?: number
}

export class Permiss {
  nome?: string
  url?: string
  id?: string
}