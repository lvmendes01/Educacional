import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { InstituicaoModel } from 'src/app/_models/Instituicaomodel';
import { RetornoApi } from 'src/app/_models/retornoapi';
import { InstituicaoService } from 'src/app/_services/instituicao.service';

@Component({
  selector: 'app-listaInstituicoes',
  templateUrl: './listainstituicoes.component.html'
})
export class ListaInstituicoesComponent {
  searchText = "";
  Instituicoes: Array<InstituicaoModel> | undefined;
  InstituicosOrigem: Array<InstituicaoModel> | undefined;

  constructor(
    private router: Router,
    private perfilService: InstituicaoService,) { }

  ngOnInit(): void {   
    this.perfilService.listar()
    .subscribe((dados : RetornoApi) => {
      if(dados.resultado){
        this.Instituicoes = dados.resultado as InstituicaoModel[] ;
        this.InstituicosOrigem = dados.resultado as InstituicaoModel[] ;
      }    
    });
  }

  Search(){
    // alert(this.searchText)
     if(this.searchText!== ""){
       let searchValue = this.searchText.toLocaleLowerCase();      
       this.Instituicoes = this.InstituicosOrigem?.filter((Instituico:InstituicaoModel) =>{
         return Instituico.nome.toLocaleLowerCase().match(searchValue );       
             });             
           }else{
            this.Instituicoes = this.InstituicosOrigem
           }
       }


}

