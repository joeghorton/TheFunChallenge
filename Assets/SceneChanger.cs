using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    private int currScene;

	// Use this for initialization
	void Start () {
        currScene = SceneManager.GetActiveScene().buildIndex;
        if (currScene == 0) {
            StartCoroutine(Intro());
        }
	}

    IEnumerator Intro() {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }

    IEnumerator Right() {
        yield return new WaitForSeconds(0.5f);
        int next = (currScene + 1) % 4;
        if (next == 0)
        {
            ++next;
        }
        SceneManager.LoadScene(next);
    }

    IEnumerator Left()
    {
        yield return new WaitForSeconds(0.5f);
        int next = currScene - 1;
        if (next == 0)
        {
            next = 3;
        }
        SceneManager.LoadScene(next);
    }

    // Update is called once per frame
    void Update () {
        if (currScene != 0)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                StartCoroutine(Left());
            }
            else if (Input.GetKey(KeyCode.RightArrow)) {
                StartCoroutine(Right());
            }
        }
	}
}
