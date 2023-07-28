import { Component } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { CidadeModel } from 'src/app/_models/cidademodel';
import { EstadoModel } from 'src/app/_models/estadomodel';
import { ProfessorModel } from 'src/app/_models/professormodel';
import { RetornoApi } from 'src/app/_models/retornoapi';
import { AlertaService } from 'src/app/_services/alerta.servico';
import { CidadeService } from 'src/app/_services/cidade.service';
import { EstadoService } from 'src/app/_services/estado.service';
import { ProfessorService } from 'src/app/_services/professor.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-cadastroprofessor',
  templateUrl: './cadastroprofessor.component.html'
})
export class CadastroprofessorComponent {
  professor= new ProfessorModel();
  loading = false;
  ID: any = "";
  
  estados:  EstadoModel[]=new Array<EstadoModel>()
  cidades: CidadeModel[]=new Array<CidadeModel>()

  constructor(private professorservice: ProfessorService,
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
        this.professorservice.carregar(this.ID).subscribe((dados : RetornoApi) => { 
          this.professor = dados.resultado as ProfessorModel;  
          
          this.professor.telefone = this.professor.telefones[0];
          this.onChangeEstado(this.professor.endereco.estado.id);
          this.onChangeCidade(this.professor.endereco.cidade.id);

        })
      }    
      
  
  }



  salvar(){
    this.loading = true;


    if(this.professor.id == 0){
      this.professor.telefones.push(this.professor.telefone)
      this.professorservice.salvar(this.professor).subscribe((dados : RetornoApi) => 
      {this.alertaService.TratamentoAlerta(dados);
        this.loading = false;     
        }
        );
    }else{
      this.professorservice.atualizar(this.professor).subscribe((dados : RetornoApi) => 
      {this.alertaService.TratamentoAlerta(dados);
        this.loading = false;     
        }
        );
    } 
  }
  onChangeCidade(idCidade: any) {
    this.professor.endereco.cidadeId = idCidade;
  }
  onChangeEstado(idEstado: any) {

    if(idEstado > 0){
      this.cidadeService.listarPorEstado(idEstado).subscribe((dados : RetornoApi) => 
      {
        this.professor.endereco.estadoId = idEstado;
        this.cidades = dados.resultado as Array<CidadeModel>;
      });
    }
    else{
      this.cidades = new Array<CidadeModel>()
    }
    
  }
}
