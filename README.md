# Calculos Matematicos

Biblioteca .NET 8 com operacoes matematicas comuns e testes automatizados.

## Operacoes disponiveis

- Soma, subtracao, multiplicacao e divisao com `decimal`.
- Potencia e raiz quadrada com `double`.
- Calculo de percentual com `decimal`.

## Validacao

```bash
dotnet restore
dotnet build --configuration Release --no-restore
dotnet test --configuration Release --no-build
```

## Estrutura

- `src/CalculosMatematicos`: biblioteca principal.
- `tests/CalculosMatematicos.Tests`: testes unitarios.
