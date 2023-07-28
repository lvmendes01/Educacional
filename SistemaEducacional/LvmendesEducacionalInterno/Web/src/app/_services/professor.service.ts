import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { RetornoApi } from '../_models/retornoapi';
import { environment } from '../environments/environment.prod';
import { ProfessorModel } from '../_models/professormodel';

@Injectable({ providedIn: 'root' })
export class ProfessorService {
 

    constructor(
        private router: Router,
        private http: HttpClient
    ) {
       
    }
    salvar(objeto: ProfessorModel) {
        return this.http.post(`${environment.apiUrlInterno}professor/salvar`, objeto);
    }

    listar() {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}professor/Lista`);
    }

    carregar(id: string) {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}professor/Carregar?Id=${id}`);
    }

    atualizar(params: ProfessorModel) {
        return this.http.put(`${environment.apiUrlInterno}professor/Atualizar`, params);
    }

    deletar(id: string) {
        return this.http.delete(`${environment.apiUrlInterno}/users/${id}`)
            .pipe(map(x => {
               
                return x;
            }));
    }
}