using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PlayModeTest1 {

	[Test]
	public void PlayModeTest1SimplePasses() {
        // Use the Assert class to test conditions.
        Debug.Log("[Test] pass test run!");
    }

    [Test]
    public void PlayModeTest1SimpleFails()
    {
        Assert.Fail("[Test] fail test run!");
    }

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator PlayModeTest1WithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        Debug.Log("[UnityTest] pass test run!");
		yield return null;
	}

    [UnityTest]
    public IEnumerator PlayModeTest1WithEnumeratorFails()
    {
        Assert.Fail("[UnityTest] fail test run!");
        yield return null;
    }
}
