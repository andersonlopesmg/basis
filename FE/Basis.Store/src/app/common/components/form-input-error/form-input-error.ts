import { AbstractControl } from '@angular/forms';
import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ValidationMessages } from './validation-messages';

@Component({
  selector: 'form-input-error',
  imports: [CommonModule],
  templateUrl: './form-input-error.html',
  styleUrl: './form-input-error.scss',
  standalone: true
})
export class FormInputError {

  @Input({ required: true }) control!: AbstractControl | null;


  get errorKeys(): string[] {
    debugger;
    return this.control?.errors ? Object.keys(this.control.errors) : [];
  }

  get errorMessages(): string[] {
    if (!this.control?.errors) {
      return [];
    }

    debugger;
    const errors = this.control.errors;

    return Object.keys(errors).map(key => {
      const errorValue = errors[key];

      const messageBuilder = ValidationMessages[key];

      if (messageBuilder) {
        return messageBuilder(errorValue);
      }

      // fallback caso não exista mensagem definida
      return key;
    });
  }
}