import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { CursoModel } from 'src/app/_models/cursomodel';
import { RetornoApi } from 'src/app/_models/retornoapi';
import { CursoService } from 'src/app/_services/curso.service';

@Component({
  selector: 'app-listacursos',
  templateUrl: './listacursos.component.html'
})
export class ListacursosComponent {
  searchText = "";
  cursos: Array<CursoModel> | undefined;
  cursosOrigem: Array<CursoModel> | undefined;

  constructor(
    private router: Router,
    private perfilService: CursoService,) { }

  ngOnInit(): void {   
    this.perfilService.listar()
    .subscribe((dados : RetornoApi) => {
      if(dados.resultado){
        this.cursos = dados.resultado as CursoModel[] ;
        this.cursosOrigem = dados.resultado as CursoModel[] ;
      }    
    });
  }

  Search(){
    // alert(this.searchText)
     if(this.searchText!== ""){
       let searchValue = this.searchText.toLocaleLowerCase();      
       this.cursos = this.cursosOrigem?.filter((curso:CursoModel) =>{
         return curso.nomeCurso.toLocaleLowerCase().match(searchValue );       
             });             
           }else{
            this.cursos = this.cursosOrigem
           }
       }


}

