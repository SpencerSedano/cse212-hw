public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue

        // Test 1
        // Scenario:  I have 4 items. The highest priority is Homework, so my test must output Homework
        // Expected Result: Homework
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Eat", 2);
        priorityQueue.Enqueue("Workout", 1);
        priorityQueue.Enqueue("Homework", 5);
        priorityQueue.Enqueue("Sleep", 4);
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: 
        // I wasn't getting any value at the beginning, so I debug using some console.WriteLine in PriorityQueue.cs
        Console.WriteLine("---------");

        // Test 2
        // Scenario: There are 3 items with the same priority.
        // Expected Result: Workout
        Console.WriteLine("Test 2");
        var priorityQueue2 = new PriorityQueue();
        priorityQueue2.Enqueue("Eat", 2);
        priorityQueue2.Enqueue("Workout", 5);
        priorityQueue2.Enqueue("Homework", 5);
        priorityQueue2.Enqueue("Sleep", 5);
        Console.WriteLine(priorityQueue2.Dequeue());

        // Defect(s) Found: 
        //I modified this line of code to only greater than -> _queue[index].Priority > _queue[highPriorityIndex].Priority
        // This means if there is no number greater than this highest priority number, it will return the first one found, which is the highest to the front
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below


        // Test 3
        // Scenario: Empty Queue
        // Expected Result: Error Message: Unhandled exception. System.IndexOutOfRangeException: EMPTY QUEUE
        Console.WriteLine("Test 2");
        var priorityQueue3 = new PriorityQueue();
        Console.WriteLine(priorityQueue3.Dequeue());

        // Defect(s) Found: 
        // The program shows the output "The queue is empty." But it does not show an error.
        
        Console.WriteLine("---------");
    }
}