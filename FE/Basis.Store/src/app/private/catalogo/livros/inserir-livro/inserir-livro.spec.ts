import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InserirLivro } from './inserir-livro';

describe('InserirLivro', () => {
  let component: InserirLivro;
  let fixture: ComponentFixture<InserirLivro>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InserirLivro]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InserirLivro);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
