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
import { CadastrosalaComponent } from './_views/sala/cadastrosala/cadastrosala.component';
import { ListasalasComponent } from './_views/sala/listasalas/listasalas.component';
import { ListaturnosComponent } from './_views/turno/listaturnos/listaturnos.component';
import { CadastroturnoComponent } from './_views/turno/cadastroturno/cadastroturno.component';
import { CadastroprofessorComponent } from './_views/professor/cadastroprofessor/cadastroprofessor.component';
import { ListaprofessorsComponent } from './_views/professor/listaprofessores/listaprofessores.component';
import { CadastromateriaComponent } from './_views/materia/cadastromateria/cadastromateria.component';
import { ListamateriasComponent } from './_views/materia/listamaterias/listamaterias.component';
import { CadastroinstituicaoComponent } from './_views/instituicao/cadastroinstituicao/cadastroinstituicao.component';
import { ListaInstituicoesComponent } from './_views/instituicao/listainstituicoes/listainstituicoes.component';
import { DateValueAccessorModule } from 'angular-date-value-accessor';

@NgModule({
    imports: [
        FormsModule,
        BrowserModule,
        ReactiveFormsModule,
        HttpClientModule,
        AppRoutingModule,
        DateValueAccessorModule
    ],
    declarations: [
        AppComponent,
        CadastrocursoComponent,
        ListacursosComponent,
        CadastrosalaComponent,
        ListasalasComponent,
        CadastroturnoComponent,
        ListaturnosComponent,
        CadastroprofessorComponent,
        ListaprofessorsComponent,
        CadastromateriaComponent,
        ListamateriasComponent,
        CadastroinstituicaoComponent,
        ListaInstituicoesComponent
        
    ],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
        CursoService


    ],
    bootstrap: [AppComponent]
})
export class AppModule { };