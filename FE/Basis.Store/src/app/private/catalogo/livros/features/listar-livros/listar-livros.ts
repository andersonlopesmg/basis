import { PaginacaoService } from './../../../../../common/services/paginacao-service';
import { LivrosService } from './../../services/livros.service';
import { TableModule } from 'primeng/table';
import { Component, OnInit } from '@angular/core';
import { ResultadoPaginado } from '../../../../../common/dtos/ResultadoPaginado.dto';
import { ListarLivrosPaginadoResponse } from './dtos/ListarLivrosPaginadoResponse';
import { ListarLivrosPaginadoRequest } from './dtos/ListarLivrosPaginadoRequest';

@Component({
  selector: 'app-listar-livros',
  imports: [TableModule],
  templateUrl: './listar-livros.html',
  styleUrl: './listar-livros.scss',
})
export class ListarLivros implements OnInit {
  
  livros: ResultadoPaginado<ListarLivrosPaginadoResponse> = { 
    itens: [], 
    totalDeItens: 0, 
    paginaAtual: 1, 
    tamanhoDaPagina: 10, 
    totalDePaginas: 0 
  };

  request: ListarLivrosPaginadoRequest = {
    Paginacao: { 
      pagina: 1, 
      tamanhoDaPagina: 10, 
      colunaOrdenacao: 'Titulo',
      orientacao: 'Asc' 
    }, 
    Filtro: {}
  };
  
  
  constructor(
    private paginacaoService: PaginacaoService,
    private livrosService: LivrosService) { 
  }

  ngOnInit(): void {
    this.carregarLivros();
  }

  carregarLivros() {
    this.livrosService.listarPaginado(this.request).subscribe({
      next: (response) => {
        this.livros = response;
      },
      error: (err) =>{
        console.error('Erro ao carregar livros:', err);
      }
    });
  }

  onLazyLoad(event: any) {
    this.request.Paginacao = this.paginacaoService.updateRequestFromLazyLoad(event);
    this.carregarLivros();
  }
}
