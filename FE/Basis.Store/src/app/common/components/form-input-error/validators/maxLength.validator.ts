import { ValidatorFn, AbstractControl } from '@angular/forms';

export function maxLengthValidator(max: number, message?: string): ValidatorFn {
  return (control: AbstractControl) => {
    const value: string = control.value;

    if (value == null) return null;

    if (value.length > max) {
      return {
        maxlength: {
          requiredLength: max,
          actualLength: value.length,
          message: message ?? `Máximo permitido é ${max} caracteres.`
        }
      };
    }

    return null;
  };
}
