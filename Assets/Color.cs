using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour {

    public Transform trans;

    public Material gray, red, blue;
    Renderer rend;

    bool showactive = true, hitactive = true;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        
        //Show
        if (showactive == true)
        {
            if (Input.GetKeyDown("w")) //show
            {
                showactive = false;

                StartCoroutine(Show());


            }
        }

            //Hit
            if (hitactive == true)
            {
                if (Input.GetKeyDown("e") && rend.sharedMaterial == red) //hit
                {
                hitactive = false;
                

                    StartCoroutine(Hit());
                }
            }

        }

    IEnumerator Show()
    {
        rend.sharedMaterial = red;

        yield return new WaitForSeconds(5);
        if (hitactive == true)
        {
            rend.sharedMaterial = gray;
        }
        

        showactive = true;

    }

    IEnumerator Hit()
    {
        rend.sharedMaterial = blue;
        yield return new WaitForSeconds(5);
        rend.sharedMaterial = gray;
        print("hit done");
       hitactive = true;
    }
}
