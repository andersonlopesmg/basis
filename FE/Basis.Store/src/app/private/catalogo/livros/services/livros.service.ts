import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ListarLivrosPaginadoRequest } from '../features/listar-livros/dtos/ListarLivrosPaginadoRequest';
import { QueryBuiderService } from '../../../../common/services/query-buider-service';
import { ResultadoPaginado } from '../../../../common/dtos/ResultadoPaginado.dto';
import { ListarLivrosPaginadoResponse } from '../features/listar-livros/dtos/ListarLivrosPaginadoResponse';
import { environment } from '../../../../../environments/environment.development';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})

export class LivrosService {
  private apiUrl = `${environment.apiUrl}/api/livros`;

  constructor(
    private queryBuilder: QueryBuiderService,
    private http: HttpClient) { }


  listarPaginado(request: ListarLivrosPaginadoRequest){
    const params = this.queryBuilder.buildParams(request);
    return this.http.get<ResultadoPaginado<ListarLivrosPaginadoResponse>>(`${this.apiUrl}`, { params });
  }

  baixarRelatorioLivrosPorAutor(): Observable<Blob> {
    return this.http.get(`${this.apiUrl}/relatorios/livrosporautor` , {
      responseType: 'blob'
    });
  }
}
