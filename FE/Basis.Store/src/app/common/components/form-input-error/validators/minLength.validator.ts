import { ValidatorFn, AbstractControl } from '@angular/forms';

export function minLengthValidator(min: number, message?: string): ValidatorFn {
  return (control: AbstractControl) => {
    const value: string = control.value;

    if (value == null) return null;

    if (value.length < min) {
      return {
        minlength: {
          requiredLength: min,
          actualLength: value.length,
          message: message ?? `Mínimo permitido é ${min} caracteres.`
        }
      };
    }

    return null;
  };
}
