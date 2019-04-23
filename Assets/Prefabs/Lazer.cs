using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour {

    public SpriteRenderer sp = null;
    public Selector sel = null;
    public bool ready = false;
    private static readonly Vector2 INVISIBLE = new Vector2(0, 0);
    private static readonly Vector2 SHOOT = new Vector2((float)1.185813, (float)9.14747);

    void Start()
    {
        sp.size = INVISIBLE;
    }

    // Update is called once per frame
    void Update () {
        if (ready) {
            sp.size = SHOOT;
        }
	}
}
