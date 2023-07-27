import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

// used to create fake backend

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ErrorInterceptor, JwtInterceptor } from './_helpers';
import { CadastrocursoComponent } from './_views/curso/cadastrocurso/cadastrocurso.component';
import { ListacursosComponent } from './_views/curso/listacursos/listacursos.component';
import { CursoService } from './_services/curso.service';


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
        CadastrocursoComponent,
        ListacursosComponent
    ],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
        CursoService


    ],
    bootstrap: [AppComponent]
})
export class AppModule { };