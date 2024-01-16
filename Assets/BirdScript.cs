using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScripts Logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScripts>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(birdIsAlive)
                myRigidBody.velocity = Vector2.up * flapStrength;
        }

        //track bird y position and kill bird if not in threshold

        
    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        Logic.gameOver();
        birdIsAlive = false;
        Debug.Log(collision.ToString());
    }
}
