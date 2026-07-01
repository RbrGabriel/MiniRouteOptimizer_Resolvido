# MiniRouteOptimizer


Este projeto faz parte da atividade prática de Códigos de Alta Performance.

O projeto-base está estruturado como Console App em .NET 8, acompanhado de testes automatizados. O objetivo é completar os trechos marcados com `TODO` para que todos os testes passem.

# Sobre

O sistema representa uma pequena cidade como um grafo. A aplicação deve calcular o menor caminho entre dois pontos e ordenar rotas candidatas por custo e critério de desempate.

A atividade conecta os conteúdos de grafos, algoritmos de caminho mínimo, filas de prioridade, Heaps e ordenação de alta performance.

O que deve funcionar

| Requisito | Resultado esperado |
|---|---|
| Grafo | Deve permitir cadastrar conexões entre pontos e consultar vizinhos. |
| Menor caminho | Deve encontrar o caminho de menor custo entre origem e destino. |
| Rota inexistente | Deve retornar caminho vazio quando não existir rota possível. |
| Ordenação | Deve ordenar rotas pelo menor custo total. |
| Desempate | Em caso de mesmo custo, deve priorizar a rota com menos paradas. |

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

