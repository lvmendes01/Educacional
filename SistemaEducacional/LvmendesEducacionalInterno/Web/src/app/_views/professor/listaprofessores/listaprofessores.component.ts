import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ProfessorModel } from 'src/app/_models/professormodel';
import { RetornoApi } from 'src/app/_models/retornoapi';
import { ProfessorService } from 'src/app/_services/professor.service';

@Component({
  selector: 'app-listaprofessores',
  templateUrl: './listaprofessores.component.html'
})
export class ListaprofessorsComponent {
  searchText = "";
  professores: Array<ProfessorModel> | undefined;
  professorsOrigem: Array<ProfessorModel> | undefined;

  constructor(
    private router: Router,
    private perfilService: ProfessorService,) { }

  ngOnInit(): void {   
    this.perfilService.listar()
    .subscribe((dados : RetornoApi) => {
      if(dados.resultado){
        this.professores = dados.resultado as ProfessorModel[] ;
        this.professorsOrigem = dados.resultado as ProfessorModel[] ;
      }    
    });
  }

  Search(){
    // alert(this.searchText)
     if(this.searchText!== ""){
       let searchValue = this.searchText.toLocaleLowerCase();      
       this.professores = this.professorsOrigem?.filter((professor:ProfessorModel) =>{
         return professor.nome.toLocaleLowerCase().match(searchValue );       
             });             
           }else{
            this.professores = this.professorsOrigem
           }
       }


}

