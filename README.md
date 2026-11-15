# Jogo da Adivinhação

<p align="center">
  <img src="assets/brand/banner.svg" alt="Jogo da Adivinhação — Guess Number Game" width="100%" />
</p>
<p align="center"><img src="assets/brand/logo.svg" alt="Jogo da Adivinhação logo" width="76"/></p>

<p align="center">
  <strong>Jogo de terminal para praticar fundamentos de programação e orientação a objetos em C#.</strong>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-.NET%2010-512BD4?logo=dotnet&logoColor=white" alt="C# .NET 10"/>
  <img src="https://img.shields.io/badge/Platform-Console-334155" alt="Console"/>
</p>

---

## Como funciona

A aplicação sorteia um número inteiro entre 1 e 100. A pessoa jogadora tenta descobrir o valor dentro de cinco tentativas válidas, recebendo indicações para orientar os palpites. Ao final, pode iniciar uma nova partida.

Entradas que não podem ser interpretadas como números inteiros são rejeitadas sem consumir uma tentativa.

## Funcionalidades

- Sorteio de um novo número a cada partida.
- Limite de cinco tentativas válidas.
- Dicas para indicar se o palpite está acima ou abaixo do número secreto.
- Validação de entradas.
- Opção de jogar novamente.

## Conceitos praticados

- C# e .NET 10.
- Classes e encapsulamento.
- Métodos e separação da lógica de partida.
- Condicionais e estruturas de repetição.
- Leitura e validação de entradas no terminal.

## Requisitos

- .NET 10 SDK.
- Terminal ou IDE compatível com projetos .NET.

## Executar

```bash
git clone https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o.git
cd Jogo-da-Adivinha-o
dotnet run --project "Jogo da Adivinhação/Jogo da Adivinhação.csproj"
```

Também é possível abrir `Jogo da Adivinhação.slnx` em uma IDE compatível com .NET.

## Estrutura do repositório

```text
Jogo-da-Adivinha-o/
├── Jogo da Adivinhação/
│   ├── Jogo da Adivinhação.csproj
│   ├── Partida.cs
│   └── Program.cs
├── assets/
│   └── brand/
│       ├── banner.svg
│       ├── logo.svg
│       └── project-mark.svg
├── Jogo da Adivinhação.slnx
└── LICENSE.txt
```

## Identidade visual

Os ativos da marca e suas regras estão documentados em [assets/brand](assets/brand/) e [docs/brand/README.md](docs/brand/README.md).

## Licença

Consulte [LICENSE.txt](LICENSE.txt).
