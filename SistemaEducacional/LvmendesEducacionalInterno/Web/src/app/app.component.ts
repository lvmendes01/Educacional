import { Component } from '@angular/core';

import { AccountService } from './_services';
import { map } from 'rxjs';
import { User } from './_models';

@Component({ selector: 'app-root',
 templateUrl: 'app.component.html',
styleUrls: [ './app.component.css' ] })
export class AppComponent {
 

    openSidebar: boolean = true;

    menuSidebar = [
      {
        link_name: "Home",
        link: "/dashboard",
        icon: "fa  fa-home",
        sub_menu: []
      }, {
        link_name: "Cadastros Base",
        link: null,
        icon: "fa fa-clipboard",
        sub_menu: [
          {
            link_name: "Curso",
            link: "/cursoListar",
          }, {
            link_name: "Sala",
            link: "/salaListar",
          }, {
            link_name: "Turnos",
            link: "/turnoListar",
          },{
            link_name: "Disciplinas",
            link: "/salaListar",
          },
        ]
      }, {
        link_name: "Instituição",
        link: null,
        icon: "fa fa-university",
        sub_menu: [
          {
            link_name: "Cadastro",
            link: "/instituicaoCadastro",
          }, {
            link_name: "Consulta",
            link: "/instituicaoListar",
          }
        ]
      },  {
        link_name: "Professor",
        link: null,
        icon: "fa fa-id-card",
        sub_menu: [
          {
            link_name: "Cadastro",
            link: "/professorCadastro",
          }, {
            link_name: "Consulta",
            link: "/professorListar",
          }
        ]
      }
    ]
    user?: User | null;

    constructor(private accountService: AccountService) {

        this.accountService.user.subscribe(x => this.user = x);
    }

    logout() {
        this.accountService.logout();



    }
    ngOnInit() {
  
    }
  
    showSubmenu(itemEl: HTMLElement) {
      itemEl.classList.toggle("showMenu");
    }
  }
  