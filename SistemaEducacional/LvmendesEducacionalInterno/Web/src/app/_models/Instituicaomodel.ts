
import { DatePipe } from "@angular/common";
import { AlvaraModel } from "./alvaramodel"
import { EnderecoModel } from "./enderecomodel"
import { TelefoneModel } from "./telefonemodel"
import { Moment } from 'moment';
export class InstituicaoModel {

  id: number=0
  dataCriacao?: Date
  nome: string=""
  cnpj: string=""
  ie: string=""
  situacao: boolean= true
  dataCriacaoEmpresa: string=""
  endereco: EnderecoModel = new EnderecoModel
  email: string=""
  natureza: string=""
  telefones: TelefoneModel[] = new Array<TelefoneModel>
  telefone: TelefoneModel = new TelefoneModel
}
