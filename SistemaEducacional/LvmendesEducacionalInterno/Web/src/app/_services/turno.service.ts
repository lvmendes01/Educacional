import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { RetornoApi } from '../_models/retornoapi';
import { environment } from '../environments/environment.prod';
import { TurnoModel } from '../_models/turnomodel';

@Injectable({ providedIn: 'root' })
export class TurnoService {
 

    constructor(
        private router: Router,
        private http: HttpClient
    ) {
       
    }

  


    salvar(objeto: TurnoModel) {
        return this.http.post(`${environment.apiUrlInterno}turno/salvar`, objeto);
    }

    listar() {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}turno/Lista`);
    }

    carregar(id: string) {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}turno/Carregar?Id=${id}`);
    }

    atualizar(params: TurnoModel) {
        return this.http.put(`${environment.apiUrlInterno}turno/Atualizar`, params);
    }

    deletar(id: string) {
        return this.http.delete(`${environment.apiUrlInterno}/users/${id}`)
            .pipe(map(x => {
               
                return x;
            }));
    }
}