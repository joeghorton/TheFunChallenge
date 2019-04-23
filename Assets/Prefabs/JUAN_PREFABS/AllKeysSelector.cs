using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllKeysSelector : MonoBehaviour {

    public List<Selector> keys = new List<Selector>();
    private int currentKey = 0;
    private static readonly int total = 26;

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space)) {
            keys[currentKey].selected = false;
            currentKey = (currentKey + 1) % total;
        }
        keys[currentKey].selected = true;
	}
}
