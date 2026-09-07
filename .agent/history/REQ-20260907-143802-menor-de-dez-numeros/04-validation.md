# Validacao

Validacao focada:

```text
dotnet test tests/CalculosMatematicos.Tests/CalculosMatematicos.Tests.csproj --configuration Release
```

Resultado: 6 testes aprovados e 0 falhos.

Validacao completa executada com sucesso:

- `dotnet restore`: aprovado.
- `dotnet build --configuration Release --no-restore`: aprovado.
- `dotnet test --configuration Release --no-build`: 6 aprovados e 0 falhos.
