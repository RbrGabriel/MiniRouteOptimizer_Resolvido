# MiniRouteOptimizer

## Atividade 02 — 2º Bimestre

Este projeto faz parte da atividade prática de **Códigos de Alta Performance**. A atividade é **individual**, vale **3,0 pontos** e deve ser entregue até **30/06, às 23h50**, por meio de **link do repositório GitHub** postado no portal.

O projeto-base está estruturado como **Console App em .NET 8**, acompanhado de testes automatizados. O objetivo é completar os trechos marcados com `TODO` para que todos os testes passem.

## Contexto

O sistema representa uma pequena cidade como um **grafo**. A aplicação deve calcular o **menor caminho** entre dois pontos e ordenar rotas candidatas por custo e critério de desempate.

A atividade conecta os conteúdos de **grafos**, **algoritmos de caminho mínimo**, **filas de prioridade**, **Heaps** e **ordenação de alta performance**.

## O que deve funcionar

| Requisito | Resultado esperado |
|---|---|
| Grafo | Deve permitir cadastrar conexões entre pontos e consultar vizinhos. |
| Menor caminho | Deve encontrar o caminho de menor custo entre origem e destino. |
| Rota inexistente | Deve retornar caminho vazio quando não existir rota possível. |
| Ordenação | Deve ordenar rotas pelo menor custo total. |
| Desempate | Em caso de mesmo custo, deve priorizar a rota com menos paradas. |

## Regras da atividade

O projeto não exige banco de dados, Docker ou interface gráfica. O foco é completar a lógica do projeto e demonstrar entendimento dos conceitos estudados.

A solução deve ser feita principalmente nos arquivos da pasta `src/MiniRouteOptimizer/Services`. Os testes não devem ser alterados, pois representam o comportamento esperado da aplicação.

Caso o aluno adapte o projeto para uma API em **.NET 8**, a lógica principal deve continuar organizada, testável e compatível com os requisitos da atividade.

## Como executar os testes

Na raiz do projeto, execute:

```bash
dotnet restore
dotnet test
```

## Como executar o Console App

```bash
dotnet run --project src/MiniRouteOptimizer/MiniRouteOptimizer.csproj
```

## Entrega

A entrega deve ser feita no portal com **somente o link do repositório GitHub**. Não é necessário enviar o `.zip`, prints ou arquivos separados.

O repositório deve conter o projeto completo, o README com instruções simples de execução e a solução funcionando.

## Materiais de apoio no portal

| Aula | Tema |
|---|---|
| **Aula 16 — Ordenação de Alta Performance** | Ordenação, comparação, desempenho e critérios de desempate. |
| **Aula 17 — Algoritmos de Caminho Mínimo** | Grafos, caminhos mínimos, Dijkstra e uso de filas de prioridade. |
