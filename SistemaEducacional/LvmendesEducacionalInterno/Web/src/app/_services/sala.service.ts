import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { RetornoApi } from '../_models/retornoapi';
import { environment } from '../environments/environment.prod';
import { SalaModel } from '../_models/salamodel';

@Injectable({ providedIn: 'root' })
export class SalaService {
 

    constructor(
        private router: Router,
        private http: HttpClient
    ) {
       
    }

  


    salvar(objeto: SalaModel) {
        return this.http.post(`${environment.apiUrlInterno}Sala/salvar`, objeto);
    }

    listar() {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}Sala/Lista`);
    }

    carregar(id: string) {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}Sala/Carregar?Id=${id}`);
    }

    atualizar(params: SalaModel) {
        return this.http.put(`${environment.apiUrlInterno}Sala/Atualizar`, params);
    }

    deletar(id: string) {
        return this.http.delete(`${environment.apiUrlInterno}/users/${id}`)
            .pipe(map(x => {
               
                return x;
            }));
    }
}