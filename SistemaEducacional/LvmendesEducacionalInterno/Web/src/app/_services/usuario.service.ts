import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { Perfil } from '../_models';
import { environment } from '../environments/environment.prod';
import { RetornoApi } from '../_models/retornoapi';
import { UsuarioModelSalvar } from '../_models/usuariomodel';

@Injectable({ providedIn: 'root' })
export class UsuarioService {
  

    constructor(
        private router: Router,
        private http: HttpClient
    ) {
      
    }
    salvarUsuario(usuario: UsuarioModelSalvar) {
        return this.http.post(`${environment.apiUrl}Usuario/AdicionarUsuario`, usuario);
    }

    listar() {
        return this.http.get<RetornoApi>(`${environment.apiUrl}Usuario/ObterUsuario`);
    }


}