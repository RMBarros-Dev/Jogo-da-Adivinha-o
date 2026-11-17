<p align="right"><strong>Idioma:</strong> <a href="README.md">Português (Brasil)</a> · <a href="README.en.md">English</a></p>

<p align="center"><img src="assets/brand/banner.svg" alt="Jogo da Adivinhação — identidade visual" width="100%" /></p>
<p align="center"><img src="assets/brand/logo.svg" alt="Logotipo do Jogo da Adivinhação" width="76" /></p>
<h1 align="center">Jogo da Adivinhação</h1>
<p align="center"><strong>Jogo de terminal para praticar fundamentos de programação e orientação a objetos em C#.</strong></p>
<p align="center">
  <img src="https://img.shields.io/badge/C%23-.NET%2010-512BD4?logo=dotnet&logoColor=white" alt="C# .NET 10" />
  <img src="https://img.shields.io/badge/Platform-Console-334155" alt="Console" />
  <a href="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/ci.yml"><img src="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/ci.yml/badge.svg?branch=master" alt="Status da CI" /></a>
  <a href="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/codeql.yml"><img src="https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o/actions/workflows/codeql.yml/badge.svg?branch=master" alt="Status do CodeQL" /></a>
</p>

## Índice

- [01 · Contexto e posicionamento](#01--contexto-e-posicionamento)
- [02 · Demonstração real e referências visuais](#02--demonstracao-real-e-referencias-visuais)
- [03 · Funcionalidades e estado de implementação](#03--funcionalidades-e-estado-de-implementacao)
- [04 · Arquitetura geral](#04--arquitetura-geral)
- [05 · Stack tecnológica](#05--stack-tecnologica)
- [06 · Estrutura de diretórios](#06--estrutura-de-diretorios)
- [07 · Pré-requisitos e instalação](#07--pre-requisitos-e-instalacao)
- [08 · Configuração de ambiente e dados](#08--configuracao-de-ambiente-e-dados)
- [09 · Guia de utilização](#09--guia-de-utilizacao)
- [10 · Testes e qualidade](#10--testes-e-qualidade)
- [11 · Internacionalização e localização](#11--internacionalizacao-e-localizacao)
- [12 · Deploy e infraestrutura](#12--deploy-e-infraestrutura)
- [13 · Segurança e limitações](#13--seguranca-e-limitacoes)
- [14 · Documentação complementar](#14--documentacao-complementar)
- [15 · Contribuição, licença e créditos](#15--contribuicao-licenca-e-creditos)

## 01 · Contexto e posicionamento



### Visão geral

Aplicação de console em .NET na qual a pessoa jogadora tenta descobrir um número inteiro sorteado. O projeto é um exercício educacional voltado à lógica, ao tratamento de entradas e à organização de classes.

### Objetivo e contexto

O objetivo é praticar fundamentos de programação e orientação a objetos em C#, mantendo o escopo deliberadamente pequeno. O repositório não representa um produto de entretenimento com infraestrutura ou serviços online.

## 02 · Demonstração real e referências visuais

Este repositório não apresenta uma URL de demonstração web hospedada nem capturas da execução. A demonstração é local, por terminal, utilizando o comando do guia de utilização. O banner e o logotipo são elementos de identidade visual, não evidências da interface em execução.

## 03 · Funcionalidades e estado de implementação

O estado apresentado nesta seção corresponde ao escopo descrito no README e no material referenciado pelo repositório. Não equivale, por si só, a uma homologação operacional ou a uma validação independente.

### Como funciona

A aplicação sorteia um número inteiro entre 1 e 100. A pessoa jogadora tem até cinco tentativas válidas e recebe dicas que indicam se o palpite está acima ou abaixo do número secreto. Ao terminar, pode iniciar uma nova partida.

### Regras da partida

- O número secreto está no intervalo inclusivo de 1 a 100.
- A partida permite cinco tentativas válidas.
- Um palpite correto encerra a partida com vitória.
- As dicas orientam os palpites seguintes.
- É possível iniciar uma nova partida ao final.

### Validação de entradas

Valores que não podem ser interpretados como inteiros ou que estejam fora do intervalo de 1 a 100 são rejeitados sem consumir uma tentativa. Entradas inválidas não devem alterar o estado da partida.

## 04 · Arquitetura geral



### Arquitetura da lógica

A lógica de uma partida é organizada na classe `Partida`, enquanto o ponto de entrada permanece separado. Essa divisão mantém as regras do jogo independentes da interação com o terminal e facilita os testes.

## 05 · Stack tecnológica



### Conceitos praticados

- C# e .NET 10.
- Classes e encapsulamento.
- Métodos e separação da lógica de jogo.
- Condicionais e estruturas de repetição.
- Leitura e validação de entradas no terminal.
- Injeção de uma instância de `Random` para permitir testes determinísticos.

### Tecnologias

| Camada | Tecnologia |
|---|---|
| Linguagem | C# |
| Runtime | .NET 10 |
| Interface | Console |
| Testes | Projeto de testes .NET separado |
| Testabilidade | Instância de `Random` injetável |

## 06 · Estrutura de diretórios



### Estrutura do repositório

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
│   ├── banner.svg
│   ├── logo.svg
│   └── project-mark.svg
├── Jogo da Adivinhação.slnx
└── LICENSE.txt
```

## 07 · Pré-requisitos e instalação



### Requisitos

- SDK do .NET 10.
- Terminal ou IDE compatível com projetos .NET.
- Git para clonar o repositório.

### Instalação

Clone o repositório e acesse a pasta:

```bash
git clone https://github.com/RMBarros-Dev/Jogo-da-Adivinha-o.git
cd Jogo-da-Adivinha-o
```

## 08 · Configuração de ambiente e dados

O README atual não descreve arquivo `.env` nem variáveis de ambiente específicas. Não armazene segredos no controle de versão.

## 09 · Guia de utilização



### Execução

```bash
dotnet run --project "Jogo da Adivinhação/Jogo da Adivinhação.csproj"
```

Também é possível abrir `Jogo da Adivinhação.slnx` em uma IDE compatível com .NET.

## 10 · Testes e qualidade



### Testes automatizados

O repositório contém um projeto de testes separado em `Jogo da Adivinhação.Tests/`. Execute os testes a partir da raiz:

```bash
dotnet test
```

### Aleatoriedade determinística

A lógica do jogo pode receber uma instância de `Random`. Nos testes, é possível fornecer um gerador previsível para verificar cenários de vitória, derrota e dicas sem depender de valores aleatórios imprevisíveis.

### Qualidade e manutenção

Mantenha as regras testáveis e a interação com o terminal separada do estado da partida. Ao alterar a implementação, valide os limites do intervalo, entradas inválidas e o comportamento de reiniciar o jogo.

## 11 · Internacionalização e localização

Não há pipeline de internacionalização/localização documentado neste repositório. Não se deve inferir suporte a idiomas ou variantes regionais.

## 12 · Deploy e infraestrutura

Deploy de serviço web não se aplica à aplicação de console descrita aqui. Não há ambiente hospedado ou processo de publicação documentado.

## 13 · Segurança e limitações



### Limitações e evolução

Este é um exercício de aprendizagem. Não inclui contas, rede, persistência, multiplayer ou infraestrutura online. Melhorias futuras devem permanecer proporcionais ao objetivo didático do projeto.

## 14 · Documentação complementar



### Documentação e licença

- [Organização de arquivos](docs/project-structure.md).
- [Identidade visual](docs/brand/README.md).
- [Banner SVG](assets/brand/banner.svg) e [logotipo SVG](assets/brand/logo.svg).
- [Projeto .NET](Jogo%20da%20Adivinha%C3%A7%C3%A3o/Jogo%20da%20Adivinha%C3%A7%C3%A3o.csproj).

Consulte [LICENSE.txt](LICENSE.txt) para os termos da licença.

## 15 · Contribuição, licença e créditos

Ao propor alterações, descreva o objetivo, os arquivos afetados e a validação realizada. Prefira mudanças pequenas e revisáveis; inclua testes quando alterar comportamento e nunca envie credenciais, tokens ou dados pessoais.

### Metodologia de desenvolvimento

O exercício favorece mudanças pequenas e incrementais: preservar o comportamento esperado, rejeitar entradas inválidas, isolar as regras da partida e acrescentar testes conforme a lógica evolui.
