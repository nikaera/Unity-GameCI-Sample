using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class SimpleTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void SimpleTestSimplePasses()
    {
        // Use the Assert class to test conditions
        Assert.AreEqual(2, 1 + 1);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator SimpleTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
        Assert.AreEqual(2, 1 + 1);
    }
}

