using System.Diagnostics;

namespace Lab03;
public class Program
{
    static void Main(string[] args)
    {
        // int heapSize = 64000;
        // BinaryHeap binaryHeap = new BinaryHeap();

        // Random random = new Random();
        // int[] array = Enumerable.Range(1, heapSize).OrderBy(x => random.Next()).ToArray();
        // Stopwatch stopwatch = Stopwatch.StartNew();
        // binaryHeap.BuildHeap(array);
        // stopwatch.Stop();
        // Console.WriteLine($"Время построения кучи из {heapSize} элементов: {stopwatch.Elapsed.TotalSeconds}");

        // Console.WriteLine("\nТекущее состояние кучи:");
        // //binaryHeap.PrintHeap();
        // Console.WriteLine();
        // stopwatch.Restart();
        // binaryHeap.GetMax();
        // stopwatch.Stop();
        // Console.WriteLine($"Время извлечения максимального элемента: {stopwatch.Elapsed.TotalSeconds}");


        // Console.WriteLine("\nТекущее состояние кучи:");
        //// binaryHeap.PrintHeap();

        // stopwatch.Restart();
        // binaryHeap.Add(10);
        // stopwatch.Stop();
        // Console.WriteLine($"Время добавления элемента {10}: {stopwatch.Elapsed.TotalSeconds}");

        // Console.WriteLine("\nТекущее состояние кучи:");
        // //binaryHeap.PrintHeap();

        // stopwatch.Restart();
        // binaryHeap.Remove(10);
        // stopwatch.Stop();
        // Console.WriteLine($"Время удаления элемента со значением {10}: {stopwatch.Elapsed.TotalSeconds}");

        // Console.WriteLine("\nТекущее состояние кучи:");
        // //binaryHeap.PrintHeap();

        //Graph graph = new Graph(6);
        //graph.AddEdge(0, 1);
        //graph.AddEdge(0, 2);
        //graph.AddEdge(1, 3);
        //graph.AddEdge(2, 3);
        //graph.AddEdge(2, 4);
        //graph.AddEdge(3, 4);
        //graph.AddEdge(3, 5);
        //graph.AddEdge(4, 5);
        //graph.PrintGraph();

        //Console.WriteLine("Введите стартовую вершину с которой выполнять обход: ");
        //int startingVertex = int.Parse(Console.ReadLine());
        //Console.WriteLine($"BFS обход графа начиная с вершины {startingVertex}:");
        //graph.BFS(startingVertex);

        PrimMST t = new PrimMST();
        int[,] graph1 = new int[,] {{ 0, 2, 0, 6, 0 },
                                    { 2, 0, 3, 8, 5 },
                                    { 0, 3, 0, 0, 7 },
                                    { 6, 8, 0, 0, 9 },
                                    { 0, 5, 7, 9, 0 } };
        t.PrimMSTAlgorithm(graph1);
    }
}
