using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderFixedRadius : MonoBehaviour {

    public float minRad;
    public float maxRad;
    float rad;

    bool selected;

    // Use this for initialization
    void Start () {
        rad = minRad;
	}
	
	// Update is called once per frame
	void Update () {

        transform.localScale = new Vector3(rad, minRad, rad);
    }

    public void GazeEnter()
    {
        rad = maxRad;
    }

    public void GazeExit()
    {
        rad = minRad;
    }
}
