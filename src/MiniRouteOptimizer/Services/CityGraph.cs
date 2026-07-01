using MiniRouteOptimizer.Models;

namespace MiniRouteOptimizer.Services;

public sealed class CityGraph
{
    private readonly Dictionary<string, List<Edge>> _adjacency = new();

    public void AddConnection(string from, string to, int cost)
    {
        if (cost < 0) throw new ArgumentOutOfRangeException(nameof(cost));
        if (!_adjacency.ContainsKey(from)) _adjacency[from] = new();
        if (!_adjacency.ContainsKey(to)) _adjacency[to] = new();
        _adjacency[from].Add(new Edge(from,to,cost));
    }

    public IReadOnlyCollection<string> GetVertices() => _adjacency.Keys.ToList();

    public IReadOnlyCollection<Edge> GetEdges() => _adjacency.Values.SelectMany(x=>x).ToList();

    public IReadOnlyCollection<Edge> GetNeighbors(string vertex) =>
        _adjacency.TryGetValue(vertex, out var neighbors) ? neighbors : new List<Edge>();
}
