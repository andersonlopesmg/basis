import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormInputError } from './form-input-error';

describe('FormInputError', () => {
  let component: FormInputError;
  let fixture: ComponentFixture<FormInputError>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FormInputError]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FormInputError);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
