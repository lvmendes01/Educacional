import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Perfil } from 'src/app/_models';
import { RetornoApi } from 'src/app/_models/retornoapi';
import { PerfilService } from 'src/app/_services/perfil.service';

@Component({
  selector: 'app-lista-perfil',
  templateUrl: './lista-perfil.component.html'
})
export class ListaPerfilComponent implements OnInit {

  searchText = "";
  perfis: Array<Perfil> | undefined;
  perfisOrigem: Array<Perfil> | undefined;

  constructor(
    private router: Router,
    private perfilService: PerfilService,) { }

  ngOnInit(): void {    

    this.perfilService.listar()
    .subscribe((dados : RetornoApi) => {
      if(dados.resultado){
        this.perfis = dados.resultado as Perfil[] ;
        this.perfisOrigem = dados.resultado as Perfil[] ;
      }
    
    });

    
  }
  btnCadastro(){
    this.router.navigateByUrl('/perfilcadastro');
   }
  Search(){
    // alert(this.searchText)
     if(this.searchText!== ""){
       let searchValue = this.searchText.toLocaleLowerCase();      
       this.perfis = this.perfisOrigem?.filter((perfil:any) =>{
         return perfil.nomePerfil.toLocaleLowerCase().match(searchValue );       
             });             
           }else{
            this.perfis = this.perfisOrigem
           }
       }


}

