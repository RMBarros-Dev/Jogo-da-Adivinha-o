# ADR-0001 — Isolar regras determinísticas da interação com o console

- **Status:** Registrado (arquitetura atual, documentada retrospectivamente)
- **Data do registro:** 2026-11-15

## Contexto

A primeira implementação concentrava comparação de palpites e mensagens de console na classe `Partida`, dificultando testes determinísticos da regra.

## Decisão atual

Extraí a comparação para `RegrasDaPartida`, que recebe o número secreto e o palpite e retorna um resultado tipado. Mantenho leitura, mensagens e fluxo de tentativas na classe `Partida`.

## Consequências

- Testo as regras sem simular entrada e saída do terminal.
- A classe `Partida` continua responsável pela geração aleatória e pela interação.
- Mudanças nas regras podem ser verificadas isoladamente.
- A suíte não substitui testes de interação com o console.

## Nota histórica

Este ADR registra a refatoração e o estado atual. Não o apresento como decisão original do projeto.
