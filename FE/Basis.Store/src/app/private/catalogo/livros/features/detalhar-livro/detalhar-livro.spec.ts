import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalharLivro } from './detalhar-livro';

describe('DetalharLivro', () => {
  let component: DetalharLivro;
  let fixture: ComponentFixture<DetalharLivro>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DetalharLivro]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetalharLivro);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
