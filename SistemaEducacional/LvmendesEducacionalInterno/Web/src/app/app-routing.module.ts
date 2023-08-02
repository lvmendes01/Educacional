import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


import { AuthGuard } from './_helpers';
import { HomeComponent } from './_components/home';
import { CadastrocursoComponent } from './_views/curso/cadastrocurso/cadastrocurso.component';
import { ListacursosComponent } from './_views/curso/listacursos/listacursos.component';
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

const accountModule = () => import('./_components/account/account.module').then(x => x.AccountModule);

const routes: Routes = [
    { path: '', component: HomeComponent, canActivate: [AuthGuard] },
    { path: 'account', loadChildren: accountModule },


    { path: 'cursoCadastro',  component: CadastrocursoComponent, canActivate: [AuthGuard] },
    { path: 'cursoCadastro/:id',  component: CadastrocursoComponent, canActivate: [AuthGuard] },  
    { path: 'cursoListar',  component: ListacursosComponent, canActivate: [AuthGuard] },
        
    { path: 'salaCadastro',  component: CadastrosalaComponent, canActivate: [AuthGuard] },
    { path: 'salaCadastro/:id',  component: CadastrosalaComponent, canActivate: [AuthGuard] },  
    { path: 'salaListar',  component: ListasalasComponent, canActivate: [AuthGuard] },    
    
    { path: 'turnoCadastro',  component: CadastroturnoComponent, canActivate: [AuthGuard] },
    { path: 'turnoCadastro/:id',  component: CadastroturnoComponent, canActivate: [AuthGuard] },  
    { path: 'turnoListar',  component: ListaturnosComponent, canActivate: [AuthGuard] },

    { path: 'professorCadastro',  component: CadastroprofessorComponent, canActivate: [AuthGuard] },
    { path: 'professorCadastro/:id',  component: CadastroprofessorComponent, canActivate: [AuthGuard] },  
    { path: 'professorListar',  component: ListaprofessorsComponent, canActivate: [AuthGuard] },
    

    
    { path: 'materiaCadastro',  component: CadastromateriaComponent, canActivate: [AuthGuard] },
    { path: 'materiaCadastro/:id',  component: CadastromateriaComponent, canActivate: [AuthGuard] },  
    { path: 'materiaListar',  component: ListamateriasComponent, canActivate: [AuthGuard] },
    

    
    
    { path: 'instituicaoCadastro',  component: CadastroinstituicaoComponent, canActivate: [AuthGuard] },
    { path: 'instituicaoCadastro/:id',  component: CadastroinstituicaoComponent, canActivate: [AuthGuard] },  
    { path: 'instituicaoListar',  component: ListaInstituicoesComponent, canActivate: [AuthGuard] },

    // otherwise redirect to home
    { path: '**', redirectTo: '' }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }