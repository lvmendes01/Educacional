import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { TurnoModel } from 'src/app/_models/turnomodel';
import { RetornoApi } from 'src/app/_models/retornoapi';
import { TurnoService } from 'src/app/_services/turno.service';

@Component({
  selector: 'app-listaturnos',
  templateUrl: './listaturnos.component.html'
})
export class ListaturnosComponent {
  searchText = "";
  turnos: Array<TurnoModel> | undefined;
  turnosOrigem: Array<TurnoModel> | undefined;

  constructor(
    private router: Router,
    private perfilService: TurnoService,) { }

  ngOnInit(): void {   
    this.perfilService.listar()
    .subscribe((dados : RetornoApi) => {
      if(dados.resultado){
        this.turnos = dados.resultado as TurnoModel[] ;
        this.turnosOrigem = dados.resultado as TurnoModel[] ;
      }    
    });
  }

  Search(){
    // alert(this.searchText)
     if(this.searchText!== ""){
       let searchValue = this.searchText.toLocaleLowerCase();      
       this.turnos = this.turnosOrigem?.filter((turno:TurnoModel) =>{
         return turno.nomeTurno.toLocaleLowerCase().match(searchValue );       
             });             
           }else{
            this.turnos = this.turnosOrigem
           }
       }


}

