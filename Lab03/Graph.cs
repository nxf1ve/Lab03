namespace Lab03;

public class Graph
{
    private int _vertices;
    private List<List<int>> adjacency;

    public Graph(int vertices)
    {
        _vertices = vertices;
        adjacency = new List<List<int>>(_vertices);
        for (int i = 0; i < _vertices; i++)
        {
            adjacency.Add(new List<int>());
        }
    }

    // Добавление ребра в граф
    public void AddEdge(int vertex, int weight)
    {
        adjacency[vertex].Add(weight);
    }

    // Удаление ребра из графа
    public void RemoveEdge(int vertex, int weight) 
    {
        adjacency[vertex].Remove(weight);
    }

    public void PrintGraph()
    {
        for (int i = 0; i < _vertices; i++)
        {
            Console.Write($"Вершина {i}: ");
            foreach (int vertex in adjacency[i])
            {
                Console.Write(vertex + " ");
            }
            Console.WriteLine();
        }
    }

    public void BFS(int startVertex)
    {
        // Массив для отслеживания посещенных вершин
        bool[] visited = new bool[_vertices];

        // Создаем очередь для BFS
        Queue<int> queue = new Queue<int>();

        // Помещаем начальную вершину в очередь и отмечаем её как посещенную
        queue.Enqueue(startVertex);
        visited[startVertex] = true;
        Console.WriteLine($"Начинаем обход с {startVertex} вершины");
        while (queue.Count != 0)
        {
            // Извлекаем вершину из очереди и выводим её
            int currentVertex = queue.Dequeue();
            Console.WriteLine($"Перешли к узлу {currentVertex}");

            // Получаем все смежные вершины для текущей вершины
            List<int> adjacentVertices = adjacency[currentVertex];

            // Добавляем все смежные вершины, которые еще не были посещены, в очередь
            foreach (int adjacentVertex in adjacentVertices)
            {
                if (!visited[adjacentVertex])
                {
                    queue.Enqueue(adjacentVertex);
                    visited[adjacentVertex] = true;
                    Console.WriteLine($"Добавили в очередь узел {adjacentVertex}");
                }
            }
        }
    }
}
