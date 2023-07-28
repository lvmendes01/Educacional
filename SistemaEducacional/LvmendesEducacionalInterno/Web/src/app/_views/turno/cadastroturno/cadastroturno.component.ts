import { Component } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { TurnoModel } from 'src/app/_models/turnomodel';
import { RetornoApi } from 'src/app/_models/retornoapi';
import { AlertaService } from 'src/app/_services/alerta.servico';
import { TurnoService } from 'src/app/_services/turno.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-cadastroturno',
  templateUrl: './cadastroturno.component.html'
})
export class CadastroturnoComponent {
  turno= new TurnoModel();
  loading = false;
  ID: any = "";
  constructor(private turnoservice: TurnoService,
    private alertaService : AlertaService,
    private activatedRoute : ActivatedRoute) { }

    ngOnInit(): void {
      this.ID = this.activatedRoute.snapshot.paramMap.get("id")?.toString();
      if(this.ID !== undefined){
        this.turnoservice.carregar(this.ID).subscribe((dados : RetornoApi) => { 
          this.turno = dados.resultado as TurnoModel;  
        })
      }     
    }

  salvar(){
    this.loading = true;
    if(this.turno.id == 0){
      this.turnoservice.salvar(this.turno).subscribe((dados : RetornoApi) => 
      {this.alertaService.TratamentoAlerta(dados);
        this.loading = false; 
        this.turno = new TurnoModel();    
        }
        );
    }else{
      this.turnoservice.atualizar(this.turno).subscribe((dados : RetornoApi) => 
      {this.alertaService.TratamentoAlerta(dados);
        this.loading = false;     
        }
        );
    } 
  }
}
