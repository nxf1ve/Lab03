namespace Lab03;
public class PrimMST
{
    private const int vertices = 5;
    int MinKey(int[] key, bool[] mstSet)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int i=0; i<vertices; i++)
        {
            if (mstSet[i] == false && key[i] < min)
            {
                min = key[i];
                minIndex = i;
            }
        }

        return minIndex;
    }

    public void PrintMST(int[] parent, int[,] graph)
    {
        Console.WriteLine("Edge \tWeight");
        for (int i=1; i<vertices; i++) 
        {
            Console.WriteLine(parent[i] + " - " + i + "\t" + graph[i, parent[i]]);
        }
    }

    public void PrimMSTAlgorithm(int[,] graph)
    {
        int[] parent = new int[vertices];
        int[] key = new int[vertices];
        bool[] mstSet = new bool[vertices]; 

        for(int i=0; i<vertices;i++)
        {
            key[i] = int.MaxValue;
            mstSet[i] = false;
        }

        key[0] = 0;
        parent[0] = -1;

        for(int count = 0; count<vertices -1; count++) 
        {
            int u = MinKey(key, mstSet);
            mstSet[u] = true;

            for(int i=0; i < vertices; i++)
            {
                if (graph[u, i] != 0 && mstSet[i] == false && graph[u, i] < key[i])
                {
                    parent[i] = u;
                    key[i] = graph[u, i];
                }
            }
        }
        PrintMST(parent, graph);
    }
}
