import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class QueryBuiderService {

  public buildParams(request: any): HttpParams {
    let params = new HttpParams();

    // Itera sobre as propriedades do objeto principal (Paginacao, Filtro)
    for (const key in request) {
      if (request.hasOwnProperty(key)) {
        const value = request[key];

        // Se a propriedade for um objeto aninhado (Paginacao ou Filtro)
        if (value && typeof value === 'object') {
          // Itera sobre as propriedades aninhadas
          for (const subKey in value) {
            if (value.hasOwnProperty(subKey) && value[subKey] !== undefined && value[subKey] !== null && value[subKey] !== '') {
              // Constrói o nome da chave: Paginacao.Pagina, Filtro.Titulo
              const paramKey = `${key}.${subKey}`;
              params = params.set(paramKey, value[subKey].toString());
            }
          }
        } 
      }
    }
    return params;
  }
}
