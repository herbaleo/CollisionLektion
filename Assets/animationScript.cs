using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScript : MonoBehaviour {

    public Animator anim;
    public string hej;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Boris", true);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            anim.SetBool("Boris", false);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            anim.SetTrigger("testtrigger");
        }
    }
    void cool ()
    {
        print(hej);
    }


}
