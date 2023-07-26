import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

// used to create fake backend

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CadastroPerfilComponent } from './_components/perfil';
import { CadastroPermissaoComponent } from './_components/permissao';
import { ListaPermissaoComponent } from './_components/permissao/lista-permissao/lista-permissao.component';
import { ListaPerfilComponent } from './_components/perfil/lista-perfil/lista-perfil.component';
import { UsuarioComponent } from './_components/usuario/usuario.component';
import { ListaUsuarioComponent } from './_components/usuario/lista-usuario/lista-usuario.component';
import { ErrorInterceptor, JwtInterceptor } from './_helpers';


@NgModule({
    imports: [
        FormsModule,
        BrowserModule,
        ReactiveFormsModule,
        HttpClientModule,
        AppRoutingModule
    ],
    declarations: [
        AppComponent,
        CadastroPerfilComponent,
        CadastroPermissaoComponent,
        ListaPermissaoComponent,
        ListaPerfilComponent,
        UsuarioComponent,
        ListaUsuarioComponent
    ],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },


    ],
    bootstrap: [AppComponent]
})
export class AppModule { };