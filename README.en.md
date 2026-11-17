<p align="right"><strong>Language:</strong> <a href="README.md">Português (Brasil)</a> · <a href="README.en.md">English</a></p>

<p align="center"><img src="assets/brand/banner.svg" alt="Guessing Game banner" width="100%" /></p>
<p align="center"><img src="assets/brand/logo.svg" alt="Guessing Game logo" width="76" /></p>
<h1 align="center">Guessing Game</h1>
<p align="center"><strong>Console game for practicing programming fundamentals and object-oriented C#.</strong></p>
<p align="center">
  <img src="https://img.shields.io/badge/C%23-.NET%2010-512BD4?logo=dotnet&logoColor=white" alt="C sharp .NET 10" />
  <img src="https://img.shields.io/badge/Platform-Console-334155" alt="Console" />
  <a href="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/ci.yml"><img src="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/ci.yml/badge.svg?branch=master" alt="CI status" /></a>
  <a href="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/codeql.yml"><img src="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/codeql.yml/badge.svg?branch=master" alt="CodeQL status" /></a>
</p>

## Contents

- [01 · Context and project positioning](#01--context-and-project-positioning)
- [02 · Live demonstration and visual references](#02--live-demonstration-and-visual-references)
- [03 · Features and implementation status](#03--features-and-implementation-status)
- [04 · System architecture](#04--system-architecture)
- [05 · Technology stack](#05--technology-stack)
- [06 · Directory structure](#06--directory-structure)
- [07 · Prerequisites and installation](#07--prerequisites-and-installation)
- [08 · Environment and data configuration](#08--environment-and-data-configuration)
- [09 · User guide](#09--user-guide)
- [10 · Testing and quality](#10--testing-and-quality)
- [11 · Internationalization and localization](#11--internationalization-and-localization)
- [12 · Deployment and infrastructure](#12--deployment-and-infrastructure)
- [13 · Security and limitations](#13--security-and-limitations)
- [14 · Additional documentation](#14--additional-documentation)
- [15 · Contribution, license and credits](#15--contribution-license-and-credits)

## 01 · Context and project positioning



### Overview

A small .NET console game in which the player tries to discover a randomly selected integer. The project is an educational exercise focused on logic, input handling and class organization.

## 02 · Live demonstration and visual references

This repository does not provide a hosted web demo URL or runtime screenshots. The demonstration is local and terminal-based, using the command in the user guide. The banner and logo are brand assets, not evidence of the running interface.

## 03 · Features and implementation status

The status presented here reflects the scope described in the README and the material referenced by the repository. It is not, by itself, operational sign-off or independent validation.

### Gameplay

The application selects an integer between 1 and 100. The player has up to five valid attempts and receives hints indicating whether a guess is higher or lower than the secret number. A new round can be started after the game ends.

### Rules

- The secret number is within the inclusive range 1–100.
- The player has five valid attempts.
- A correct guess ends the round successfully.
- Hints guide the next guess.
- A new round can be started.

### Input Validation

Values that cannot be parsed as integers or fall outside the 1–100 range are rejected without consuming an attempt. This keeps invalid input separate from a valid game guess.

## 04 · System architecture



### Game Logic Architecture

The round logic is organized in a dedicated `Partida` class, while the application entry point remains separate. This separation keeps game rules distinct from terminal interaction.

## 05 · Technology stack



### Programming Concepts

- C# and .NET 10.
- Classes and encapsulation.
- Methods and separation of game logic.
- Conditional statements and loops.
- Terminal input and validation.
- Dependency injection of a random-number generator for deterministic tests.

### Technology Stack

| Layer | Technology |
|---|---|
| Language | C# |
| Runtime | .NET 10 |
| Interface | Console |
| Automated tests | Separate .NET test project |
| Testability | Injectable `Random` instance |

## 06 · Directory structure



### Repository Structure

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

## 07 · Prerequisites and installation



### Requirements

- .NET 10 SDK.
- Terminal or IDE compatible with .NET projects.
- Git for cloning the repository.

### Clone and Run

```bash
git clone https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o.git
cd Jogo-da-Adivinha-o
dotnet run --project "Jogo da Adivinhação/Jogo da Adivinhação.csproj"
```

You can also open `Jogo da Adivinhação.slnx` in a compatible .NET IDE.

## 08 · Environment and data configuration

The current README does not describe an `.env` file or application-specific environment variables. Do not store secrets in version control.

## 09 · User guide



### Error Handling and Game Flow

Invalid values are rejected before attempt accounting. Valid guesses update the round state and produce the appropriate hint or terminal result. Changes to these rules should be accompanied by tests.

## 10 · Testing and quality



### Automated Tests

The repository contains a separate test project under `Jogo da Adivinhação.Tests/`. Run the solution's tests with:

```bash
dotnet test
```

### Deterministic Randomness

The game logic can receive a `Random` instance. Tests can supply a predictable generator to validate win, loss and hint scenarios without depending on unpredictable random values.

### Quality and Maintainability

Keep the rules testable and the terminal interaction separate from game state. Validate the range boundary cases, invalid input and repeat-game behavior when changing the implementation.

## 11 · Internationalization and localization

No internationalization/localization pipeline is documented in this repository. Support for languages or regional variants must not be inferred.

## 12 · Deployment and infrastructure

Web-service deployment does not apply to the console application described here. No hosted environment or publishing process is documented.

## 13 · Security and limitations



### Known Limitations

This is a small learning exercise. It is not an online game and does not include accounts, networking, persistence, multiplayer or production infrastructure.

## 14 · Additional documentation



### Documentation and Engineering Principles

- [Project structure](docs/project-structure.md).
- [Brand guide](docs/brand/README.md).
- [Banner](assets/brand/banner.svg) and [logo](assets/brand/logo.svg).
- [Project file](Jogo%20da%20Adivinha%C3%A7%C3%A3o/Jogo%20da%20Adivinha%C3%A7%C3%A3o.csproj).

The project prioritizes simplicity, readability, input validation and separation of game logic.

## 15 · Contribution, license and credits

When proposing changes, describe the goal, affected files and validation performed. Prefer small, reviewable changes; include tests when behavior changes and never submit credentials, tokens or personal data.

### Development Methodology

The exercise favors small incremental changes: preserve expected behavior, reject invalid input, isolate the game rules and add tests as the logic grows.

### License and Attribution

See [LICENSE.txt](LICENSE.txt) for the repository license and applicable terms.
