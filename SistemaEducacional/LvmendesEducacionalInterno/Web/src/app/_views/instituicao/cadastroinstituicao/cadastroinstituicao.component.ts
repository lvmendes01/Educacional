import { Component } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { InstituicaoModel } from 'src/app/_models/Instituicaomodel';
import { CidadeModel } from 'src/app/_models/cidademodel';
import { EstadoModel } from 'src/app/_models/estadomodel';
import { RetornoApi } from 'src/app/_models/retornoapi';
import { AlertaService } from 'src/app/_services/alerta.servico';
import { CidadeService } from 'src/app/_services/cidade.service';
import { EstadoService } from 'src/app/_services/estado.service';
import { InstituicaoService } from 'src/app/_services/instituicao.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-cadastroinstituicao',
  templateUrl: './cadastroinstituicao.component.html'
})
export class CadastroinstituicaoComponent {
  instituicao= new InstituicaoModel();
  loading = false;
  ID: any = "";
  
  estados:  EstadoModel[]=new Array<EstadoModel>()
  cidades: CidadeModel[]=new Array<CidadeModel>()

  constructor(private instituicaoservice: InstituicaoService,
    private alertaService : AlertaService,
    private estadoService : EstadoService,
    private cidadeService : CidadeService,
    private activatedRoute : ActivatedRoute) { }

    ngOnInit(): void {

      this.estadoService.listar().subscribe((dados : RetornoApi) => 
      {
        this.estados = dados.resultado as Array<EstadoModel>;
  
      });


      this.ID = this.activatedRoute.snapshot.paramMap.get("id")?.toString();
      if(this.ID !== undefined){
        this.instituicaoservice.carregar(this.ID).subscribe((dados : RetornoApi) => { 
          this.instituicao = dados.resultado as InstituicaoModel;  
          
          this.instituicao.telefone = this.instituicao.telefones[0];
          this.onChangeEstado(this.instituicao.endereco.estado.id);
          this.onChangeCidade(this.instituicao.endereco.cidade.id);

        })
      }    
      
  
  }

  updatedate(event: any) {

    this.instituicao.dataCriacaoEmpresa = event.toString();
}

  salvar(){
    this.loading = true;


    if(this.instituicao.id == 0){
      this.instituicao.telefones.push(this.instituicao.telefone)
      this.instituicaoservice.salvar(this.instituicao).subscribe((dados : RetornoApi) => 
      {this.alertaService.TratamentoAlerta(dados);
        this.loading = false;     
        }
        );
    }else{
      this.instituicaoservice.atualizar(this.instituicao).subscribe((dados : RetornoApi) => 
      {this.alertaService.TratamentoAlerta(dados);
        this.loading = false;     
        }
        );
    } 
  }
  onChangeCidade(idCidade: any) {
    this.instituicao.endereco.cidadeId = idCidade;
  }
  onChangeEstado(idEstado: any) {

    if(idEstado > 0){
      this.cidadeService.listarPorEstado(idEstado).subscribe((dados : RetornoApi) => 
      {
        this.instituicao.endereco.estadoId = idEstado;
        this.cidades = dados.resultado as Array<CidadeModel>;
      });
    }
    else{
      this.cidades = new Array<CidadeModel>()
    }
    
  }
}
