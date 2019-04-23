using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selector : MonoBehaviour {

    public SpriteRenderer sp = null;
    public bool selected = false;
    private Color BASE = Color.black;
    public ObjectShooter shooter = null;
    private bool changed = false;

    // Use this for initialization
    void Start () {
        BASE = sp.color;
	}
	
	// Update is called once per frame
	void Update () {
        if (selected)
        {
            sp.color = Color.white;
            shooter.ready = true;
            changed = true;
        } else {
            if (changed) {
                shooter.ready = false;
                changed = false;
            }
            sp.color = BASE;
        }
	}
}
