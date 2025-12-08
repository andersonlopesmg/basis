import { ValidatorFn } from '@angular/forms';

export function patternValidator(
  regex: RegExp,
  message = 'Formato inválido'
): ValidatorFn {
  return (control) => {
    const value = control.value;

    // Não valida pattern se o campo estiver vazio
    // (isso permite usar Validators.required separado)
    if (value === null || value === undefined || value === '') {
      return null;
    }

    const matches = regex.test(value);

    if (!matches) {
      return {
        pattern: { message }
      };
    }

    return null;
  };
}
