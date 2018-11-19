using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManagement : MonoBehaviour {

    bool show = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (show)
        {
            this.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            this.gameObject.GetComponent<Image>().enabled = false;
        }
	}

    public void GazeEnter()
    {
        show = true;
    }

    public void GazeExit()
    {
        show = false;
    }

}
