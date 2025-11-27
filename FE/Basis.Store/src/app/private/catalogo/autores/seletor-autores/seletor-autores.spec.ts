import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SeletorAutores } from './seletor-autores';

describe('SeletorAutores', () => {
  let component: SeletorAutores;
  let fixture: ComponentFixture<SeletorAutores>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SeletorAutores]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SeletorAutores);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
