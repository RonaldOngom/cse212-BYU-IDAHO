using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // TEST RESULT SUMMARY:
    // Expected: Highest priority element removed
    // Actual: Test passed — "High" was removed
    // Error Found: Initially, Dequeue returned the lower priority item; fixed in PriorityQueue.Dequeue
    public void Dequeue_HighestPriorityReturned()
    {
        PriorityQueue queue = new PriorityQueue();
        queue.Enqueue("Low", 1);
        queue.Enqueue("High", 5);

        string result = queue.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // TEST RESULT SUMMARY:
    // Expected: Single enqueued item is returned by Dequeue
    // Actual: Test passed — "Only" was returned
    // Error Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Only", 1);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Only", result);
    }

    [TestMethod]
// TEST RESULT SUMMARY:
// Expected: First enqueued item with same priority removed first
// Actual: Test passed — FIFO behavior preserved
// Error Found: None
public void Dequeue_SamePriority_FollowsFIFO()
{
    PriorityQueue queue = new PriorityQueue();
    queue.Enqueue("First", 3);
    queue.Enqueue("Second", 3);

    string result = queue.Dequeue();

    Assert.AreEqual("First", result);
}

[TestMethod]
// TEST RESULT SUMMARY:
// Expected: InvalidOperationException thrown
// Actual: Test passed — exception thrown with correct message
// Error Found: None
[ExpectedException(typeof(InvalidOperationException))]
public void Dequeue_EmptyQueue_ThrowsException()
{
    PriorityQueue queue = new PriorityQueue();
    queue.Dequeue();
}
}
