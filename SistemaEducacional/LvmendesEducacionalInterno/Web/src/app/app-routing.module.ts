import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


import { AuthGuard } from './_helpers';
import { HomeComponent } from './_components/home';
import { CadastrocursoComponent } from './_views/curso/cadastrocurso/cadastrocurso.component';
import { ListacursosComponent } from './_views/curso/listacursos/listacursos.component';

const accountModule = () => import('./_components/account/account.module').then(x => x.AccountModule);

const routes: Routes = [
    { path: '', component: HomeComponent, canActivate: [AuthGuard] },
    { path: 'account', loadChildren: accountModule },
    { path: 'cursoCadastro',  component: CadastrocursoComponent, canActivate: [AuthGuard] },
    { path: 'cursoCadastro/:id',  component: CadastrocursoComponent, canActivate: [AuthGuard] },  
    { path: 'cursoListar',  component: ListacursosComponent, canActivate: [AuthGuard] },
    
    // otherwise redirect to home
    { path: '**', redirectTo: '' }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }