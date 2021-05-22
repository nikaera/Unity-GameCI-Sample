using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

public class SimpleTest
{
    [Test]
    public void SimplePasses()
    {
        Assert.AreEqual(2, 1 + 1);
    }

    [UnityTest]
    public IEnumerator EnumeratorPasses()
    {
        yield return null;
        Assert.AreEqual(2, 1 + 1);
    }
}
