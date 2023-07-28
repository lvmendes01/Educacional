import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { SalaModel } from 'src/app/_models/salamodel';
import { RetornoApi } from 'src/app/_models/retornoapi';
import { SalaService } from 'src/app/_services/sala.service';

@Component({
  selector: 'app-listasalas',
  templateUrl: './listasalas.component.html'
})
export class ListasalasComponent {
  searchText = "";
  salas: Array<SalaModel> | undefined;
  salasOrigem: Array<SalaModel> | undefined;

  constructor(
    private router: Router,
    private perfilService: SalaService,) { }

  ngOnInit(): void {   
    this.perfilService.listar()
    .subscribe((dados : RetornoApi) => {
      if(dados.resultado){
        this.salas = dados.resultado as SalaModel[] ;
        this.salasOrigem = dados.resultado as SalaModel[] ;
      }    
    });
  }

  Search(){
    // alert(this.searchText)
     if(this.searchText!== ""){
       let searchValue = this.searchText.toLocaleLowerCase();      
       this.salas = this.salasOrigem?.filter((sala:SalaModel) =>{
         return sala.numeroSala.toLocaleLowerCase().match(searchValue );       
             });             
           }else{
            this.salas = this.salasOrigem
           }
       }


}

