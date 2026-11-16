# Como contribuo com o Jogo da Adivinhação

Mantenho este projeto como uma aplicação de console para praticar lógica, regras de jogo e fundamentos de C#.

## Ambiente

Utilizo o .NET 10 SDK.

## Verificações antes de enviar alterações

```bash
dotnet restore "Jogo da Adivinhação.slnx"
dotnet build "Jogo da Adivinhação.slnx" --configuration Release
dotnet test "Jogo da Adivinhação.Tests/Jogo da Adivinhação.Tests.csproj" --configuration Release
```

## Diretrizes

- Incluo testes para mudanças nas regras de comparação de palpites.
- Preservo a separação entre regras determinísticas e interação no console.
- Registro alterações de comportamento no changelog.
