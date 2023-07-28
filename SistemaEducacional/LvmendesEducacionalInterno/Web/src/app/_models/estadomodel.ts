import { CidadeModel } from "./cidademodel"

export class EstadoModel {

  id: number=0
dataCriacao?: Date
nomeEstado: string=""
sigla: string=""
cidades: CidadeModel[]=new Array<CidadeModel>()
}