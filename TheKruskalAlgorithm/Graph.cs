using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKruskalAlgorithm
{
    public class Edge : IComparable<Edge>
    {
        public int EdgeWeight { get; set; }
        public string VertexA { get; set; }
        public string VertexB { get; set; }

        public Edge(string vertexA, string vertexB, int weight)
        {
            VertexA = vertexA;
            VertexB = vertexB;
            EdgeWeight = weight;
        }

        public int CompareTo(Edge other)
        {
            if (other == null) return 1;
            return EdgeWeight.CompareTo(other.EdgeWeight);
        }
    }
    public class Graph : IEnumerable<Edge> {
        public int i;
        private List<Edge> _graph;
        public IEnumerator<Edge> GetEnumerator()
        {
            return _graph.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _graph.GetEnumerator();
        }
        public Graph() {
            _graph = new List<Edge>();
        }
        public Graph(Edge val)
        {
            Edge[] value = new Edge[] { val };

            _graph = new List<Edge>(value);
        }

        public void Add(Graph graph)
        {
            foreach (Edge edge in graph)
            {
                i++;
                _graph.Add(edge);
            }
        }

        public void Add(Edge edge)
        {
            _graph.Add(edge);
        }

        public int GetWeight()
        {
            int weight = 0;
            foreach (Edge edge in _graph)
            {
                i++;
                weight += edge.EdgeWeight;
            }
            return weight;
        }
        public void Sort() { _graph.Sort(); }

        public Graph MST()
        {
            Sort();
            var disjointSets = new SystemOfDisjointSets();
            foreach (Edge edge in _graph)
            {
                i++;
                disjointSets.AddEdgeInSet(edge);
            }

            return disjointSets.Sets.First().SetGraph;
        }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (Edge edge in _graph)
            {
  
                result += $"{edge.VertexA} {edge.VertexB} {edge.EdgeWeight}\n";
            }

            return result;
        }
    }
    
}
