import { PaginacaoService } from './../../../../../common/services/paginacao-service';
import { LivrosService } from './../../services/livros.service';
import { TableModule } from 'primeng/table';
import { Component, OnInit } from '@angular/core';
import { ResultadoPaginado } from '../../../../../common/dtos/ResultadoPaginado.dto';
import { ListarLivrosPaginadoResponse } from './dtos/ListarLivrosPaginadoResponse';
import { ListarLivrosPaginadoRequest } from './dtos/ListarLivrosPaginadoRequest';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-listar-livros',
  imports: [
    CommonModule,
    TableModule],
  templateUrl: './listar-livros.html',
  styleUrl: './listar-livros.scss',
})
export class ListarLivros implements OnInit {

  gerandoRelatorio = false;

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
    private livrosService: LivrosService,
    private router: Router) {
  }

  ngOnInit(): void {
    this.carregarLivros();
  }

  carregarLivros() {
    this.livrosService.listarPaginado(this.request).subscribe({
      next: (response) => {
        this.livros = response;
      },
      error: (err) => {
        console.error('Erro ao carregar livros:', err);
      }
    });
  }

  onLazyLoad(event: any) {
    this.request.Paginacao = this.paginacaoService.updateRequestFromLazyLoad(event);
    this.carregarLivros();
  }
  
  adicionarLivro() {
   this.router.navigate(['/app/livros/inserir']);
}


  baixarRelatorio() {
    this.gerandoRelatorio = true;

    this.livrosService.baixarRelatorioLivrosPorAutor().subscribe({
      next: (blob: Blob) => {
        this.downloadFile(blob, 'RelatorioLivrosPorAutor.pdf');
        this.gerandoRelatorio = false;
      },
      error: (err) => {
        console.error('Erro ao baixar relatório', err);
        this.gerandoRelatorio = false;
      }
    });
  }

  // Método auxiliar para forçar o download no browser
  private downloadFile(data: Blob, fileName: string) {
    const url = window.URL.createObjectURL(data);
    const a = document.createElement('a');
    a.href = url;
    a.download = fileName;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
    window.URL.revokeObjectURL(url);
  }
}
