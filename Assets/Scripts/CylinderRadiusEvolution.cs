using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRadiusEvolution : MonoBehaviour {

    public float speed;
    public float minRad;
    public float maxRad;
    float rad;

    bool grow;
    bool selected;

	// Use this for initialization
	void Start () {
        grow = true;
        selected = false;
        rad = minRad;
	}
	
	// Update is called once per frame
	void Update () {

        if (!selected)
        {
            transform.localScale = new Vector3(rad, minRad, rad);

            if (grow) rad += speed * Time.deltaTime;
            if (!grow) rad -= speed * Time.deltaTime;
            if (rad > maxRad) grow = false;
            if (rad < minRad) grow = true;
        }
        else
        {
            transform.localScale = new Vector3(minRad, minRad, minRad);
        }
	}

    public void GazeEnter()
    {
        selected = true;
    }

    public void GazeExit()
    {
        selected = false;
    }
}
