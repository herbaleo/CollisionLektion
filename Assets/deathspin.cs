using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathspin : MonoBehaviour {
    public SpriteRenderer spinner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       

           
    }
    private void FixedUpdate()
    {
        transform.Rotate(0, 2, 0);
        
    }

}
