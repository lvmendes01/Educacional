import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { RetornoApi } from '../_models/retornoapi';
import { environment } from '../environments/environment.prod';
import { MateriaModel } from '../_models/materamodel';

@Injectable({ providedIn: 'root' })
export class MateriaService {
     constructor(     private router: Router,private http: HttpClient) {  }

    salvar(objeto: MateriaModel) {
        return this.http.post(`${environment.apiUrlInterno}materias/salvar`, objeto);
    }

    listar() {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}materias/Lista`);
    }
    carregar(id: string) {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}materias/Carregar?Id=${id}`);
    }
    atualizar(params: MateriaModel) {
        return this.http.put(`${environment.apiUrlInterno}materias/Atualizar`, params);
    }
    deletar(id: string) {
        return this.http.delete(`${environment.apiUrlInterno}/users/${id}`)
            .pipe(map(x => {
               
                return x;
            }));
    }
}