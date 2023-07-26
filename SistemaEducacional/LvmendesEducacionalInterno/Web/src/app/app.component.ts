import { Component } from '@angular/core';

import { AccountService } from './_services';
import { User } from './_models';
import { map } from 'rxjs';

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
        link_name: "Category",
        link: null,
        icon: "bx bx-collection",
        sub_menu: [
          {
            link_name: "HTML & CSS",
            link: "/html-n-css",
          }, {
            link_name: "JavaScript",
            link: "/javascript",
          }, {
            link_name: "PHP & MySQL",
            link: "/php-n-mysql",
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
  