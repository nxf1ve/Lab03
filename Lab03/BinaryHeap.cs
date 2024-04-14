public class BinaryHeap
{
    public List<int> list = new List<int>();
    public int heapSize
    {
        get
        {
            return this.list.Count;
        }

    }
    public void Add(int value)
    {
        list.Add(value);
        int i = heapSize - 1;
        int parent = (i - 1) / 2;

        while (i > 0 && list[parent] < list[i])
        {
            int temp = list[i];
            list[i] = list[parent];
            list[parent] = temp;

            i = parent;
            parent = (i - 1) / 2;
        }

    }
    public bool Remove(int value)
    {
        int index = list.IndexOf(value);
        if (index == -1)
        {
            return false;
        }

        list[index] = list[heapSize - 1];
        list.RemoveAt(index);
        Heapify(index);

        return true;
    }
    public void Heapify(int i)
    {
        int leftChild;
        int rightChild;
        int largestChild;

        while (true)
        {
            leftChild = 2*i + 1;
            rightChild = 2*i + 2;
            largestChild = i;

            if (leftChild < heapSize && list[leftChild] > list[largestChild])
            {
                largestChild = leftChild;
            }
            if (rightChild < heapSize && list[rightChild] > list[largestChild])
            {
                largestChild = rightChild;
            }
            if (largestChild == i)
            {
                break;
            }

            int temp = list[i];
            list[i] = list[largestChild];
            list[largestChild] = temp;
            i = largestChild;
        }
    }
    public void BuildHeap(int[] sourceArray)
    {
        list = sourceArray.ToList();
        for (int i = heapSize / 2; i >= 0; i--)
        {
            Heapify(i);
        }
    }
    public int GetMax()
    {
        int result = list[0];
        list[0] = list[heapSize - 1];
        list.RemoveAt(heapSize - 1);
        Heapify(0);
        return result;
    }

    public void PrintHeap()
    {
        int level = 0;
        int levelNodes = 1;
        int nodesPrinted = 0;

        for (int i = 0; i < heapSize; i++)
        {
            if (nodesPrinted == levelNodes)
            {
                Console.WriteLine();
                level++;
                levelNodes *= 2;
                nodesPrinted = 0;
            }
            Console.Write(list[i] + " ");
            nodesPrinted++;
        }
        Console.WriteLine();
    }

}
