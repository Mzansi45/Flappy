using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision2D : MonoBehaviour
{
    public LogicScripts logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScripts>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Is triggered");
        logic.addScore();
        /*if (collision.gameObject.layer == 3)
        {
            logic.addScore();
        }
        */
    }
}
