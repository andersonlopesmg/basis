import { Injectable } from '@angular/core';
import { PaginacaoDto } from '../dtos/Paginacao.dto';


interface LazyLoadEvent {
    first: number; // Índice inicial
    rows: number; // Tamanho da página
    sortField: string; // Campo de ordenação
    sortOrder: number; // 1 (ASC) ou -1 (DESC)
    // ... outros campos (filters, globalFilter)
}

@Injectable({
  providedIn: 'root',
})
export class PaginacaoService {
  public updateRequestFromLazyLoad(event: LazyLoadEvent): PaginacaoDto {
    
    // Calcula a página atual (PrimeNG usa índice baseado em 0 no 'first')
    const novaPagina = (event.first / event.rows) + 1;
    
    // Cria um novo PaginacaoParams (ou usa o record C# para imutabilidade)
    const paginacaoAtualizada: PaginacaoDto = {
      
        pagina: novaPagina,
        tamanhoDaPagina: event.rows,
        
        colunaOrdenacao: event.sortField,
        orientacao: event.sortOrder === 1 ? 'Asc' : 'Desc'
    };
    
    return paginacaoAtualizada;
  }
}