using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Gameplay/Timed Self-Destruct")]
public class TimedSelfDestruct : MonoBehaviour
{

    // After this time, the object will be destroyed
    public float timeToDestruction = 3;

    private void Start()
    {
            Invoke("DestroyMe", timeToDestruction);
    }


    // This function will destroy this object :(
    void DestroyMe()
	{
		Destroy(gameObject);

		// Bye bye!
	}
}
