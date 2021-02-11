using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ValidateSampleScene
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ValidateSampleSceneSimplePasses()
        {
            // Use the Assert class to test conditions
            var go = new GameObject("MyGameObject");
            Assert.AreEqual("MyGameObject", go.name);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator ValidateSampleSceneWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
