import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import Swal from 'sweetalert2';
import { RetornoApi } from '../_models/retornoapi';

@Injectable({ providedIn: 'root' })
export class AlertaService {


    constructor() {}



    TratamentoAlerta(dados : RetornoApi) {
        if(dados.status){
            Swal.fire({  
              position: 'top-end',  
              icon: 'success',  
              title: dados.mensagem,  
              showConfirmButton: false,  
              timer: 1500  
            })  ;
          }else{
            Swal.fire({  
              icon: 'error',  
              title: 'Oops...',  
              text: dados.mensagem,  
              showConfirmButton: false,  
              timer: 2500  
            })  
          }  
    }

}

