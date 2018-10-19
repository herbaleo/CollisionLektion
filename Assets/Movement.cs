using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {
    public Rigidbody2D rbody;
	// Use this for initialization
      
	void Start () {
        //rbody.AddForce(new Vector2(0, 20f), ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
	}
    void FixedUpdate()
    {
        /*.AddForce puttar ngt. Addrelative putter höger via världen. Move positionen sätter positionen direkt till en annan 
        position, MoveRotation e samma sak fast med rotation. Velocity är hastigheten, AngularVelocity är hastigheten vid rotation.
     */
        
        if (Input.GetKey(KeyCode.D))
            {

            rbody.AddForce(new Vector2(10f, 0f));
        }
        if (Input.GetKey(KeyCode.A)){

            rbody.AddForce(new Vector2(-10f, 0f));
        }
        if (Input.GetKey(KeyCode.W))
        {

            rbody.AddForce(new Vector2(0f, 10f));
        }
        if (Input.GetKey(KeyCode.S))
        {

            rbody.AddForce(new Vector2(0f, -10f));
        }
        }   
        void OnCollisionEnter2D(Collision2D coll)
        {
        
            SceneManager.LoadScene("SampleScene");
        }
}  
