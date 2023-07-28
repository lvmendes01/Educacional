
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { RetornoApi } from '../_models/retornoapi';
import { environment } from '../environments/environment.prod';


@Injectable({ providedIn: 'root' })
export class CidadeService {


    constructor(
        private router: Router,
        private http: HttpClient
    ) {
    }


    listarPorEstado(id: string) {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}cidade/ObterCidadePeloEstado?EstadoId=${id}`);
    }

    carregar(id: string) {
        return this.http.get<RetornoApi>(`${environment.apiUrlInterno}cidade/Carregar?Id=${id}`);
    }



}
