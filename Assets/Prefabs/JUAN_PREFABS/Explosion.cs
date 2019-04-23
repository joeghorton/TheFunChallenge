using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    private const float MOVE = (float)6.7;

    public List<ParticleSystem> xplosions = new List<ParticleSystem>();
    public GameObject keyskulls = null;
    private bool ready = false;

    private void ExplodeAll() {
        foreach (ParticleSystem xplosions in xplosions) {
            xplosions.Play();
        }
    }

    public bool Ready() {
        return ready;    
    }

    public void Set() {
        ready = true;
    }

    public void Update() {
        if (ready)
        {
            ExplodeAll();
            ready = false;
        }
    }
}
