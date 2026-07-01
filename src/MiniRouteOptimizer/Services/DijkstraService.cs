using MiniRouteOptimizer.Models;

namespace MiniRouteOptimizer.Services;

public sealed class DijkstraService
{
    public RouteResult FindShortestPath(CityGraph graph, string origin, string destination)
    {
        var distances = new Dictionary<string,int>();
        var previous = new Dictionary<string,string?>();
        var pq = new PriorityQueue<string,int>();

        foreach(var v in graph.GetVertices()) distances[v] = int.MaxValue;
        if(!distances.ContainsKey(origin) || !distances.ContainsKey(destination))
            return new RouteResult(Array.Empty<string>(), int.MaxValue);

        distances[origin]=0;
        pq.Enqueue(origin,0);

        while(pq.Count>0){
            var current=pq.Dequeue();
            if(current==destination) break;

            foreach(var edge in graph.GetNeighbors(current)){
                var newDist=distances[current]+edge.Cost;
                if(newDist < distances[edge.To]){
                    distances[edge.To]=newDist;
                    previous[edge.To]=current;
                    pq.Enqueue(edge.To,newDist);
                }
            }
        }

        if(distances[destination]==int.MaxValue)
            return new RouteResult(Array.Empty<string>(), int.MaxValue);

        var path=new List<string>();
        for(string? at=destination; at!=null; previous.TryGetValue(at,out at))
            path.Add(at);
        path.Reverse();
        return new RouteResult(path, distances[destination]);
    }
}
