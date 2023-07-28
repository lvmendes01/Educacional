import { Component } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';

import { RetornoApi } from 'src/app/_models/retornoapi';
import { SalaModel } from 'src/app/_models/salamodel';
import { AlertaService } from 'src/app/_services/alerta.servico';
import { SalaService } from 'src/app/_services/sala.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-cadastrosala',
  templateUrl: './cadastrosala.component.html'
})
export class CadastrosalaComponent {
  sala= new SalaModel();
  loading = false;
  ID: any = "";
  constructor(private salaservice: SalaService,
    private alertaService : AlertaService,
    private activatedRoute : ActivatedRoute) { }

    ngOnInit(): void {
      this.ID = this.activatedRoute.snapshot.paramMap.get("id")?.toString();
      if(this.ID !== undefined){
        this.salaservice.carregar(this.ID).subscribe((dados : RetornoApi) => { 
          this.sala = dados.resultado as SalaModel;  
        })
      }     
    }

  salvar(){
    this.loading = true;
    if(this.sala.id == 0){
      this.salaservice.salvar(this.sala).subscribe((dados : RetornoApi) => 
      {this.alertaService.TratamentoAlerta(dados);
        this.loading = false;     
        }
        );
    }else{
      this.salaservice.atualizar(this.sala).subscribe((dados : RetornoApi) => 
      {this.alertaService.TratamentoAlerta(dados);
        this.loading = false;     
        }
        );
    } 
  }
}
