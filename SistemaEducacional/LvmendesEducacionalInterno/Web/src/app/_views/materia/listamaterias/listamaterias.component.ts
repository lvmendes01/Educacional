import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { MateriaModel } from 'src/app/_models/materamodel';
import { RetornoApi } from 'src/app/_models/retornoapi';
import { MateriaService } from 'src/app/_services/material.service';

@Component({
  selector: 'app-listamaterias',
  templateUrl: './listamaterias.component.html'
})
export class ListamateriasComponent {
  searchText = "";
  materias: Array<MateriaModel> | undefined;
  materiasOrigem: Array<MateriaModel> | undefined;

  constructor(
    private router: Router,
    private perfilService: MateriaService,) { }

  ngOnInit(): void {   
    this.perfilService.listar()
    .subscribe((dados : RetornoApi) => {
      if(dados.resultado){
        this.materias = dados.resultado as MateriaModel[] ;
        this.materiasOrigem = dados.resultado as MateriaModel[] ;
      }    
    });
  }

  Search(){
    // alert(this.searchText)
     if(this.searchText!== ""){
       let searchValue = this.searchText.toLocaleLowerCase();      
       this.materias = this.materiasOrigem?.filter((materia:MateriaModel) =>{
         return materia.nome.toLocaleLowerCase().match(searchValue );       
             });             
           }else{
            this.materias = this.materiasOrigem
           }
       }


}

