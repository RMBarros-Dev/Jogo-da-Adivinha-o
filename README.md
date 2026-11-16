<p align="right"><strong>Idioma:</strong> <a href="README.md">Português (Brasil)</a> · <a href="README.en.md">English</a></p>

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


<p align="center">
  <a href="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/ci.yml"><img src="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/ci.yml/badge.svg?branch=master" alt="CI status" /></a>
  <a href="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/codeql.yml"><img src="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/codeql.yml/badge.svg?branch=master" alt="CodeQL status" /></a>
</p>

---

## Índice

- [Como funciona](#como-funciona)
- [Área de aplicação e funcionalidades](#funcionalidades)
- [Conceitos e técnicas](#conceitos-praticados)
- [Metodologia](#metodologia-de-desenvolvimento)
- [Requisitos e execução](#requisitos)
- [Estrutura de arquivos](#estrutura-do-repositório)
- [Documentação e princípios](#documentação-e-princípios-de-engenharia)
- [Licença](#licença)

## Como funciona

A aplicação sorteia um número inteiro entre 1 e 100. A pessoa jogadora tenta descobrir o valor dentro de cinco tentativas válidas, recebendo indicações para orientar os palpites. Ao final, pode iniciar uma nova partida.

Entradas que não podem ser interpretadas como números inteiros ou que estejam fora do intervalo de 1 a 100 são rejeitadas sem consumir uma tentativa. A geração do número pode receber uma instância de `Random`, permitindo cenários determinísticos em testes.

## Área de aplicação

Exercício de programação para terminal, destinado à prática de lógica, controle de fluxo, leitura de entradas e organização básica de classes em C#.

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

## Metodologia de desenvolvimento

O exercício organiza o fluxo de uma partida em uma classe própria, mantendo o ponto de entrada separado. A evolução recomendada é incremental: preservar o comportamento esperado, validar entradas inválidas e acrescentar testes quando a lógica for ampliada.

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
├── Jogo da Adivinhação.Tests/
│   ├── Jogo da Adivinhação.Tests.csproj
│   └── RegrasDaPartidaTests.cs
├── assets/
│   └── brand/
│       ├── banner.svg
│       ├── logo.svg
│       └── project-mark.svg
├── Jogo da Adivinhação.slnx
└── LICENSE.txt
```

## Documentação e princípios de engenharia

- [Organização de arquivos](docs/project-structure.md).
- [Identidade visual](docs/brand/README.md).
- [Banner SVG](assets/brand/banner.svg) e [logotipo SVG](assets/brand/logo.svg).
- [Projeto .NET](Jogo%20da%20Adivinha%C3%A7%C3%A3o/Jogo%20da%20Adivinha%C3%A7%C3%A3o.csproj).

O projeto prioriza simplicidade, legibilidade, validação das entradas e separação da lógica de jogo. Trata-se de um exercício de aprendizagem, não de um produto de entretenimento com infraestrutura ou serviços online.

## Licença

Consulte [LICENSE.txt](LICENSE.txt).
