import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

import { RetornoApi } from '../_models/retornoapi';
import { environment } from '../environments/environment.prod';

@Injectable({ providedIn: 'root' })
export class EstadoService {
 

    constructor(
        private router: Router,
        private http: HttpClient
    ) {
       
    }


    listar() {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}cidade/ObterEstados`);
    }

    carregar(id: string) {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}cidade/ObterEstado?Id=${id}`);
    }



}