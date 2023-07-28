import { Component } from '@angular/core';

import { AccountService } from './_services';
import { map } from 'rxjs';
import { User } from './_models';

@Component({ selector: 'app-root', templateUrl: 'app.component.html',
styleUrls: [ './app.component.css' ] })
export class AppComponent {
 

    openSidebar: boolean = true;

    menuSidebar = [
      {
        link_name: "Home",
        link: "/dashboard",
        icon: "bx bx-grid-alt",
        sub_menu: []
      }, {
        link_name: "Curso",
        link: null,
        icon: "bx bx-collection",
        sub_menu: [
          {
            link_name: "Cadastro",
            link: "/cursoCadastro",
          }, {
            link_name: "Lista",
            link: "/cursoListar",
          }
        ]
      }, {
        link_name: "Sala",
        link: null,
        icon: "bx bx-collection",
        sub_menu: [
          {
            link_name: "Cadastro",
            link: "/salaCadastro",
          }, {
            link_name: "Lista",
            link: "/salaListar",
          }
        ]
      }, {
        link_name: "Turno",
        link: null,
        icon: "bx bx-collection",
        sub_menu: [
          {
            link_name: "Cadastro",
            link: "/turnoCadastro",
          }, {
            link_name: "Lista",
            link: "/turnoListar",
          }
        ]
      },  {
        link_name: "Professor",
        link: null,
        icon: "bx bx-collection",
        sub_menu: [
          {
            link_name: "Cadastro",
            link: "/professorCadastro",
          }, {
            link_name: "Lista",
            link: "/professorListar",
          }
        ]
      }, 
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
  