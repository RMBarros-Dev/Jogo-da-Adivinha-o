# Organização do repositório — Jogo da Adivinhação

A solução contém uma aplicação de console .NET pequena, com lógica de partida separada do ponto de entrada.

| Caminho | Responsabilidade |
| --- | --- |
| `Jogo da Adivinhação/Program.cs` | Ponto de entrada da aplicação. |
| `Jogo da Adivinhação/Partida.cs` | Estado e fluxo de uma partida. |
| `Jogo da Adivinhação/Jogo da Adivinhação.csproj` | Configuração do projeto .NET. |
| `Jogo da Adivinhação.slnx` | Solução .NET. |
| `assets/brand/` | Logotipo, banner e marca do projeto. |

## Convenções

- Manter arquivos C# dentro do diretório do projeto.
- Evitar cópias paralelas de classes com diferença apenas de maiúsculas/minúsculas.
- Manter o ponto de entrada separado da lógica de partida.
- Acrescentar testes ao ampliar regras ou comportamentos do jogo.
