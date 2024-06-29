public class TryProgram
{
  public static void Run()
  {
    Console.WriteLine("Intersect");
    Intersect();
    Console.WriteLine("Union");
    Union();
  }

  public static void Intersect()
  {
    int[] myArray1 = new int[] { 1, 2, 3, 4, 5};
    int[] myArray2 = new int[] { 5, 6, 7, 8, 9, 10 };

    HashSet<int> myHashSet = new HashSet<int>();

    for (int i = 0; i < myArray1.Length; i++)
    {
      myHashSet.Add(myArray1[i]);
    }

    for (int i = 0; i < myArray2.Length; i++)
    {
      if(myHashSet.Contains(myArray2[i]))
      {
        Console.WriteLine(myArray2[i]);
      }
    } 

  }

  public static void Union()
  {
    int[] myArray1 = new int[] { 1, 2, 3, 4, 5 };
    int[] myArray2 = new int[] { 5, 6, 7, 8, 9, 10 };

    HashSet<int> myHashSet = new HashSet<int>();
  
    for (int i = 0; i < myArray1.Length; i++)
    {
      myHashSet.Add(myArray1[i]);
    }

    for (int i = 0; i < myArray2.Length; i++)
    {
      myHashSet.Add(myArray2[i]);
    }

    foreach (var item in myHashSet)
    {
      Console.WriteLine(item);
    }

  }

}