import { Component, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Perfil, Permiss } from 'src/app/_models';
import { PerfilService } from 'src/app/_services/perfil.service';


@Component({ 
    templateUrl: 'cadastro-permissao.component.html',
selector: 'cadastro-permissao', })
export class CadastroPermissaoComponent implements OnInit {

    @Output() permissaoinserida = new EventEmitter();

    loading = false;
    submitted = false;
    perfil = new Perfil;
    permissao = new Permiss;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private perfilService: PerfilService
    ) { }

    ngOnInit() {
        this.perfil.permissoes = new Array<Permiss>();
    }



    public AdicionarPermissao(){
        this.perfil.permissoes?.push(this.permissao);
        this.permissaoinserida.emit( this.perfil.permissoes);
        this.permissao = new Permiss;
    }
    RemoverPermissao(p : Permiss){
       
        this.perfil.permissoes = this.perfil.permissoes?.filter(s=>s.nome != p.nome && s.url != p.url);
    }
 
}