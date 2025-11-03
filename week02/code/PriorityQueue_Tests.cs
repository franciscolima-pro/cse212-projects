using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Tasks with different priorities in sequence.
    // Expected Result: [task1 (Pri:1), task2 (Pri:2)]
    // Defect(s) Found: Was not removing the item from the queue after Dequeue because it was missing the function call for that. Also was not returning the correct value because the loop did not traverse the entire queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("task1", 1);
        priorityQueue.Enqueue("task2", 2);
        priorityQueue.Enqueue("task3", 3);
        
         Assert.AreEqual("task3", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Tasks with equal priorities to verify if the one closest to the beginning of the queue is removed first.
    // Expected Result: [taska (Pri:3), taskc (Pri:4), taskd (Pri:4), taske (Pri:4)]
    // Defect(s) Found: Does not identify values with the same priority correctly. Nor does it remove the item closest to the beginning of the queue.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("taska", 3);
        priorityQueue.Enqueue("taskb", 4);
        priorityQueue.Enqueue("taskc", 4);
        priorityQueue.Enqueue("taskd", 4);
        priorityQueue.Enqueue("taske", 4);

        Assert.AreEqual("taskb", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}