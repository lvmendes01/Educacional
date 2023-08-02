import { Component } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { CursoModel } from 'src/app/_models/cursomodel';
import { RetornoApi } from 'src/app/_models/retornoapi';
import { AlertaService } from 'src/app/_services/alerta.servico';
import { CursoService } from 'src/app/_services/curso.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-cadastrocurso',
  templateUrl: './cadastrocurso.component.html'
})
export class CadastrocursoComponent {
  curso= new CursoModel();
  loading = false;
  ID: any = "";
  constructor(private cursoservice: CursoService,
    private alertaService : AlertaService,
    private activatedRoute : ActivatedRoute) { }

    ngOnInit(): void {
      this.ID = this.activatedRoute.snapshot.paramMap.get("id")?.toString();
      if(this.ID !== undefined){
        this.cursoservice.carregar(this.ID).subscribe((dados : RetornoApi) => { 
          this.curso = dados.resultado as CursoModel;  
        })
      }     
    }

  salvar(){
    this.loading = true;
    if(this.curso.id == 0){
      this.cursoservice.salvar(this.curso).subscribe((dados : RetornoApi) => 
      {this.alertaService.TratamentoAlerta(dados);
        this.loading = false;   
        this.curso = new CursoModel();  
        }
        );
    }else{
      this.cursoservice.atualizar(this.curso).subscribe((dados : RetornoApi) => 
      {this.alertaService.TratamentoAlerta(dados);
        this.loading = false;     
        this.curso = new CursoModel();  
        }
        );
    } 
  }
}
