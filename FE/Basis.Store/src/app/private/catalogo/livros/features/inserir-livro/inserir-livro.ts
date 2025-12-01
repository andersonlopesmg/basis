import { Component, signal } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { LivrosService } from '../../services/livros.service';
import { Router } from '@angular/router';
import { FormInputError } from '../../../../../common/components/form-input-error/form-input-error';
import { InserirLivroForm } from './models/inserir-livro-form';
import { InserirLivroRequest } from './models/inserir-livro-request';
import { CommonModule } from '@angular/common';
import { patternValidator } from '../../../../../common/components/form-input-error/validators/pattern.validator';
import { NgxMaskDirective, NgxMaskPipe } from 'ngx-mask';

@Component({
  selector: 'app-inserir-livro',
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormInputError,
     NgxMaskDirective
  ],
  templateUrl: './inserir-livro.html',
  styleUrl: './inserir-livro.scss',
  standalone: true
})
export class InserirLivro {


  inserirLivroForm: FormGroup;
  autoresIds = signal<number[]>([]);
  assuntosIds = signal<number[]>([]);
  estaProcessando = signal(false);


  constructor(
    private formBuilder: FormBuilder,
    private livrosService: LivrosService,
    private router: Router
  ) {

    this.inserirLivroForm = this.formBuilder.nonNullable.group({
    titulo: ['', [Validators.required, Validators.maxLength(40)]],
    editora: ['', [Validators.required, Validators.maxLength(40)]],
    edicao: [1, [Validators.required, Validators.min(1)]],
    anoPublicacao: [1, [Validators.required, patternValidator(/^\d{4}$/, 'Ano deve ter exatamente 4 dígitos')]],
    precoBase: [0, [Validators.required, Validators.min(0.01)]],
    codigosAutores: [[] as number[]],
    codigosAssuntos: [[] as number[]],
  });

  }
  adicionarAutor(idInput: HTMLInputElement) {
    const id = parseInt(idInput.value);
    if (id && !this.autoresIds().includes(id)) {
      // Atualiza o signal (imutabilidade)
      this.autoresIds.update(ids => [...ids, id]);
      idInput.value = ''; // Limpa o input
    }
  }

  removerAutor(id: number) {
    this.autoresIds.update(ids => ids.filter(x => x !== id));
  }

  adicionarAssunto(idInput: HTMLInputElement) {
    const id = parseInt(idInput.value);
    if (id && !this.assuntosIds().includes(id)) {
      this.assuntosIds.update(ids => [...ids, id]);
      idInput.value = '';
    }
  }

  removerAssunto(id: number) {
    this.assuntosIds.update(ids => ids.filter(x => x !== id));
  }



  salvar() {
    debugger;
    if (this.inserirLivroForm.invalid) {
      this.inserirLivroForm.markAllAsTouched();
      return;
    }

    // Validação Manual das Listas (Regra de Negócio: Deve ter ao menos 1 autor?)
    if (this.autoresIds().length === 0) {
      alert('Adicione pelo menos um autor.'); return;
    }

    if (this.assuntosIds().length === 0) {
      alert('Adicione pelo menos um autor.'); return;
    }
  
  const request: InserirLivroRequest = this.inserirLivroForm.getRawValue();

    this.estaProcessando.set(true);

    this.livrosService.inserir(request).subscribe({
      next: (id) => {
        console.log('Livro criado com ID:', id);
        this.router.navigate(['/livros/detalhar', id]);
      },
      error: (err) => {
        console.error('Erro ao criar livro:', err);
        this.estaProcessando.set(false);
      }
    });
  }
}