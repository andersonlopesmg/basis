import { ValidatorFn, AbstractControl } from '@angular/forms';

export function maxValidator(max: number, message?: string): ValidatorFn {
  return (control: AbstractControl) => {
    const value = Number(control.value);

    if (control.value === null || control.value === '' || isNaN(value)) {
      return null;
    }

    if (value > max) {
      return {
        max: {
          max,
          actual: value,
          message: message ?? `O valor máximo permitido é ${max}.`
        }
      };
    }
    return null;
  };
}