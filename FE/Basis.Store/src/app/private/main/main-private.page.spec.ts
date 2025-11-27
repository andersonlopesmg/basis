import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MainPagePrivate } from '../main-private.page';
import { MainPage } from '../../public/main/main-public.page';

describe('MainPagePrivate', () => {
  let component: MainPagePrivate;
  let fixture: ComponentFixture<MainPagePrivate>;
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MainPage]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MainPagePrivate);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
