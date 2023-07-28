import { CidadeModel } from "./cidademodel"
import { EstadoModel } from "./estadomodel"

export class EnderecoModel {

  id: number=0
  dataCriacao?: Date
  logradouro: string=""
  cep: string=""
  numero: string=""
  complemento: string=""
  cidadeId: number=0
  estadoId: number=0
  cidade: CidadeModel=new CidadeModel
  estado: EstadoModel=new EstadoModel



  public toString = () : string => {
    return ` (${this.estado.nomeEstado + ' ' + this.cidade.nomeCidade + ' ' + this.logradouro + ' ' +this.numero + ' ' +this.cep})`;
  }


}
