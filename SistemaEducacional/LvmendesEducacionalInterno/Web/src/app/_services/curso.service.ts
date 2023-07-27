import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { RetornoApi } from '../_models/retornoapi';
import { CursoModel } from '../_models/cursomodel';
import { environment } from '../environments/environment.prod';

@Injectable({ providedIn: 'root' })
export class CursoService {
 

    constructor(
        private router: Router,
        private http: HttpClient
    ) {
       
    }

  


    salvar(objeto: CursoModel) {
        return this.http.post(`${environment.apiUrlInterno}curso/salvar`, objeto);
    }

    listar() {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}curso/Lista`);
    }

    carregar(id: string) {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}curso/Carregar?Id=${id}`);
    }

    atualizar(params: CursoModel) {
        return this.http.put(`${environment.apiUrlInterno}Curso/Atualizar`, params);
    }

    deletar(id: string) {
        return this.http.delete(`${environment.apiUrlInterno}/users/${id}`)
            .pipe(map(x => {
               
                return x;
            }));
    }
}