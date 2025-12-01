export const ValidationMessages: Record<string, (error: any) => string> = {
  required: () => 'Campo obrigatório',
  minlength: ({ requiredLength }) => `Mínimo permitido é ${requiredLength} caracteres.`,
  maxlength: ({ requiredLength }) => `Máximo permitido é ${requiredLength} caracteres.`,
  min: ({ min }) => `O valor mínimo permitido é ${min}.`,
  max: ({ max }) => `O valor máximo permitido é ${max}.`,
  pattern: ({ message }) => message || 'Formato inválido'
};  