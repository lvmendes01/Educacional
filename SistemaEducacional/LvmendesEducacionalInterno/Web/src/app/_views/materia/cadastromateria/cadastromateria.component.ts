import { Component } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { MateriaModel } from 'src/app/_models/materamodel';
import { RetornoApi } from 'src/app/_models/retornoapi';
import { AlertaService } from 'src/app/_services/alerta.servico';
import { MateriaService } from 'src/app/_services/material.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-cadastromateria',
  templateUrl: './cadastromateria.component.html'
})
export class CadastromateriaComponent {
  materia= new MateriaModel();
  loading = false;
  ID: any = "";
  constructor(private materiaservice: MateriaService,
    private alertaService : AlertaService,
    private activatedRoute : ActivatedRoute) { }

    ngOnInit(): void {
      this.ID = this.activatedRoute.snapshot.paramMap.get("id")?.toString();
      if(this.ID !== undefined){
        this.materiaservice.carregar(this.ID).subscribe((dados : RetornoApi) => { 
          this.materia = dados.resultado as MateriaModel;  
        })
      }     
    }

  salvar(){
    this.loading = true;
    if(this.materia.id == 0){
      this.materiaservice.salvar(this.materia).subscribe((dados : RetornoApi) => 
      {this.alertaService.TratamentoAlerta(dados);
        this.loading = false; 
        this.materia = new MateriaModel();    
        }
        );
    }else{
      this.materiaservice.atualizar(this.materia).subscribe((dados : RetornoApi) => 
      {this.alertaService.TratamentoAlerta(dados);
        this.loading = false;     
        }
        );
    } 
  }
}
