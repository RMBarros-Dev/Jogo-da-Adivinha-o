<p align="right"><strong>Language:</strong> <a href="README.pt-BR.md">Português (Brasil)</a> · <a href="README.md">English</a></p>

<p align="center"><img src="assets/brand/banner.svg" alt="Guessing Game banner" width="100%" /></p>
<p align="center"><img src="assets/brand/logo.svg" alt="Guessing Game logo" width="76" /></p>
<h1 align="center">Guessing Game</h1>
<p align="center"><strong>Think. Compare. Discover.</strong><br/>A console game for practicing logic, input validation and object-oriented C#.</p>
<p align="center">
  <img src="https://img.shields.io/badge/C%23-.NET%2010-512BD4?logo=dotnet&logoColor=white" alt="C sharp .NET 10" />
  <img src="https://img.shields.io/badge/Platform-Console-334155" alt="Console" />
  <a href="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/ci.yml"><img src="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/ci.yml/badge.svg?branch=master" alt="CI status" /></a>
  <a href="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/codeql.yml"><img src="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/codeql.yml/badge.svg?branch=master" alt="CodeQL status" /></a>
</p>

## Contents

- [01 · Overview](#01--overview)
- [02 · Gameplay](#02--gameplay)
- [03 · Rules](#03--rules)
- [04 · Input Validation](#04--input-validation)
- [05 · Game Logic Architecture](#05--game-logic-architecture)
- [06 · Programming Concepts](#06--programming-concepts)
- [07 · Technology Stack](#07--technology-stack)
- [08 · Requirements](#08--requirements)
- [09 · Clone and Run](#09--clone-and-run)
- [10 · Automated Tests](#10--automated-tests)
- [11 · Deterministic Randomness](#11--deterministic-randomness)
- [12 · Error Handling and Game Flow](#12--error-handling-and-game-flow)
- [13 · Repository Structure](#13--repository-structure)
- [14 · Quality and Maintainability](#14--quality-and-maintainability)
- [15 · Development Methodology](#15--development-methodology)
- [16 · Known Limitations](#16--known-limitations)
- [17 · Documentation and Engineering Principles](#17--documentation-and-engineering-principles)
- [18 · License and Attribution](#18--license-and-attribution)

## 01 · Overview

A small .NET console game in which the player tries to discover a randomly selected integer. The project is an educational exercise focused on logic, input handling and class organization.

## 02 · Gameplay

The application selects an integer between 1 and 100. The player has up to five valid attempts and receives hints indicating whether a guess is higher or lower than the secret number. A new round can be started after the game ends.

## 03 · Rules

- The secret number is within the inclusive range 1–100.
- The player has five valid attempts.
- A correct guess ends the round successfully.
- Hints guide the next guess.
- A new round can be started.

## 04 · Input Validation

Values that cannot be parsed as integers or fall outside the 1–100 range are rejected without consuming an attempt. This keeps invalid input separate from a valid game guess.

## 05 · Game Logic Architecture

The round logic is organized in a dedicated `Partida` class, while the application entry point remains separate. This separation keeps game rules distinct from terminal interaction.

## 06 · Programming Concepts

- C# and .NET 10.
- Classes and encapsulation.
- Methods and separation of game logic.
- Conditional statements and loops.
- Terminal input and validation.
- Dependency injection of a random-number generator for deterministic tests.

## 07 · Technology Stack

| Layer | Technology |
|---|---|
| Language | C# |
| Runtime | .NET 10 |
| Interface | Console |
| Automated tests | Separate .NET test project |
| Testability | Injectable `Random` instance |

## 08 · Requirements

- .NET 10 SDK.
- Terminal or IDE compatible with .NET projects.
- Git for cloning the repository.

## 09 · Clone and Run

```bash
git clone https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o.git
cd Jogo-da-Adivinha-o
dotnet run --project "Jogo da Adivinhação/Jogo da Adivinhação.csproj"
```

You can also open `Jogo da Adivinhação.slnx` in a compatible .NET IDE.

## 10 · Automated Tests

The repository contains a separate test project under `Jogo da Adivinhação.Tests/`. Run the solution's tests with:

```bash
dotnet test
```

## 11 · Deterministic Randomness

The game logic can receive a `Random` instance. Tests can supply a predictable generator to validate win, loss and hint scenarios without depending on unpredictable random values.

## 12 · Error Handling and Game Flow

Invalid values are rejected before attempt accounting. Valid guesses update the round state and produce the appropriate hint or terminal result. Changes to these rules should be accompanied by tests.

## 13 · Repository Structure

```text
Jogo-da-Adivinha-o/
├── Jogo da Adivinhação/
│   ├── Jogo da Adivinhação.csproj
│   ├── Partida.cs
│   └── Program.cs
├── Jogo da Adivinhação.Tests/
│   ├── Jogo da Adivinhação.Tests.csproj
│   └── RegrasDaPartidaTests.cs
├── assets/brand/
├── Jogo da Adivinhação.slnx
└── LICENSE.txt
```

## 14 · Quality and Maintainability

Keep the rules testable and the terminal interaction separate from game state. Validate the range boundary cases, invalid input and repeat-game behavior when changing the implementation.

## 15 · Development Methodology

The exercise favors small incremental changes: preserve expected behavior, reject invalid input, isolate the game rules and add tests as the logic grows.

## 16 · Known Limitations

This is a small learning exercise. It is not an online game and does not include accounts, networking, persistence, multiplayer or production infrastructure.

## 17 · Documentation and Engineering Principles

- [Project structure](docs/project-structure.md).
- [Brand guide](docs/brand/README.md).
- [Banner](assets/brand/banner.svg) and [logo](assets/brand/logo.svg).
- [Project file](Jogo%20da%20Adivinha%C3%A7%C3%A3o/Jogo%20da%20Adivinha%C3%A7%C3%A3o.csproj).

The project prioritizes simplicity, readability, input validation and separation of game logic.

## 18 · License and Attribution

See [LICENSE.txt](LICENSE.txt) for the repository license and applicable terms.


## Engineering Metrics

<div align="center">
  <img src="https://img.shields.io/github/stars/RMBarros-Dev/Jogo-da-Adivinha-o?style=flat-square&label=stars" alt="GitHub stars" />
  <img src="https://img.shields.io/github/forks/RMBarros-Dev/Jogo-da-Adivinha-o?style=flat-square&label=forks" alt="GitHub forks" />
  <img src="https://img.shields.io/github/issues/RMBarros-Dev/Jogo-da-Adivinha-o?style=flat-square&label=open%20issues" alt="Open issues" />
  <img src="https://img.shields.io/badge/runtime-.NET%2010-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET 10" />
</div>

<!-- REPOSITORY_METRICS_START -->
### Language distribution (GitHub Linguist)

![Repository language distribution](assets/metrics/repository-languages.svg)

| Language | Source bytes | Share |
|---|---:|---:|
| C# | 7,445 | 100.00% |

_Total measured source bytes: 7,445. Refreshed: 2026-11-22 12:35 UTC._

<!-- REPOSITORY_METRICS_END -->

### Technical verification

| Dimension | Implemented evidence | Measurement boundary |
|---|---|---|
| Runtime / language | C# on .NET 10 | Confirmed by project documentation and project file reference. |
| Application architecture | Console entry point separated from Partida game rules | Small educational application; no service or persistence layer claimed. |
| Automated tests | Separate .NET test project; deterministic Random injection | Run with dotnet test; no coverage percentage published. |
| CI | [CI workflow](.github/workflows/ci.yml) | Current result is shown by the workflow badge above. |
| Static security analysis | [CodeQL workflow](.github/workflows/codeql.yml) | Workflow execution is not a security certification. |
| Persistence / deployment | No persistent storage or production deployment | Not applicable to this console exercise. |
