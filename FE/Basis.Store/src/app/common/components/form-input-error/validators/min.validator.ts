import { ValidatorFn, AbstractControl } from '@angular/forms';

export function min(min: number, message?: string): ValidatorFn {
  return (control: AbstractControl) => {
    const value = Number(control.value);

    if (control.value === null || control.value === '' || isNaN(value)) {
      return null;
    }

    if (value < min) {
      return {
        min: {
          min,
          actual: value,
          message: message ?? `O valor mínimo permitido é ${min}.`,
        },
      };
    }
    return null;
  };
}
