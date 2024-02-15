namespace LeetCodeProblems.Tests;

[TestFixture]
public class ListNodeTests
{
    [Test]
    public void ShouldTransfromToArray() {
    ListNode firstNode = new(2, new(4));
    ListNode secondNode = new(5, new(6, new(4)));
    ListNode thirdNode = new(0);

    int[] firstArray = [2, 4];
    int[] secondArray = [5, 6, 4];
    int[] thirdArray = [0];

    Assert.Multiple(() => 
    {
        Assert.That(firstArray.SequenceEqual(firstNode.ToArray()), Is.True);
        Assert.That(secondArray.SequenceEqual(secondNode.ToArray()), Is.True);
        Assert.That(thirdArray.SequenceEqual(thirdNode.ToArray()), Is.True);
    });
  }
}