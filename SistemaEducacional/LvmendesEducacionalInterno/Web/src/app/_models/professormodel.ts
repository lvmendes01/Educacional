
import { EnderecoModel } from "./enderecomodel"
import { TelefoneModel } from "./telefonemodel"
export class ProfessorModel {
  id: number=0
  dataCriacao?: Date
  nome: string=""
  cpf: string=""
  dataNascimento?: Date
  endereco: EnderecoModel = new EnderecoModel
  email: string=""
  telefones: TelefoneModel[] = new Array<TelefoneModel>
  telefone: TelefoneModel = new TelefoneModel
  matricula: string=""
  
}
