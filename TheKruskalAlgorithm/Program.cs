using System.Diagnostics;
using TheKruskalAlgorithm;

Graph TakeData(int index) {
    string path = $"C:\\Users\\evsty_z2oxnoi\\source\\repos\\TheKruskalAlgorithm\\TheKruskalAlgorithm\\Data{index}.txt";
    StreamReader reader = new StreamReader(path);
    string[] line = reader.ReadLine().Split(" ");
    int V = Convert.ToInt32(line[0]);
    int E = Convert.ToInt32(line[1]);
    Graph graph = new Graph();

    for (int i = 0; i < E; i++)
    {
        string[] data = reader.ReadLine().Split(" ");
        int weight = Convert.ToInt32(data[2]);
        graph.Add(new Edge(data[0], data[1], weight));

    }

    return graph;
}
Graph graph = TakeData(1);
var time = new Stopwatch();

time.Start();
var z = graph.MST();
var iteration = z.i;
time.Stop();
Console.WriteLine($"{time.ElapsedMilliseconds}, {z.i}");