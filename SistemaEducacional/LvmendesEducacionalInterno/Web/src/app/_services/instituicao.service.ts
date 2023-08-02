import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { RetornoApi } from '../_models/retornoapi';
import { environment } from '../environments/environment.prod';
import { InstituicaoModel } from '../_models/Instituicaomodel';

@Injectable({ providedIn: 'root' })
export class InstituicaoService {
 

    constructor(
        private router: Router,
        private http: HttpClient
    ) {
       
    }

  


    salvar(objeto: InstituicaoModel) {
        return this.http.post(`${environment.apiUrlInterno}Instituicao/salvar`, objeto);
    }

    listar() {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}Instituicao/Lista?todos=true`);
    }
    carregar(id: string) {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}Instituicao/Carregar?Id=${id}`);
    }

    atualizar(params: InstituicaoModel) {
        return this.http.put(`${environment.apiUrlInterno}Instituicao/Atualizar`, params);
    }

    deletar(id: string) {
        return this.http.delete(`${environment.apiUrlInterno}/users/${id}`)
            .pipe(map(x => {
               
                return x;
            }));
    }
}