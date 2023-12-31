import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Perfil } from '../_models';
import { environment } from '../environments/environment.prod';
import { RetornoApi } from '../_models/retornoapi';


@Injectable({ providedIn: 'root' })
export class PerfilService {
  

    constructor(
        private router: Router,
        private http: HttpClient
    ) {
      
    }
    salvarPerfil(perfil: Perfil) {
        return this.http.post(`${environment.apiUrl}perfil/salvar`, perfil);
    }

    listar() {
        return this.http.get<RetornoApi>(`${environment.apiUrl}perfil/obterPerfil`);
    }


}