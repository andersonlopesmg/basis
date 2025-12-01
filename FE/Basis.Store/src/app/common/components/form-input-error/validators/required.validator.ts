import { ValidatorFn } from '@angular/forms';

export function requiredWithMessage(message = 'Campo obrigatório'): ValidatorFn {
  return (control) => {
    const value = control.value;
    if (value === null || value === undefined || value === '') {
      return {
        required: { message }
      };
    }
    return null;
  };
}
