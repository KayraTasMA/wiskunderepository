using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER : MonoBehaviour
{
    [SerializeField] GameObject runner;
    Animator animator;
    enum State { run, jump};
    State myState = State.run;
    
    Vector3 velocity = Vector3.zero;
    Vector3 acceliration = Vector3.zero;

    float y0;
   
    void Start()
    {
        animator = runner.GetComponent<Animator>();
        y0 = runner.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == State.run)
        {
            if(Input.GetMouseButtonUp(0))
            {
                 myState = State.jump;
                 velocity = new Vector3(0, (0.75f * 10)/4 ,0);
                 acceliration = new Vector3(0,-5,0);
            }
        }
        if (myState == State.jump)
        {
            velocity += acceliration * Time.deltaTime;
            runner.transform.position += velocity * Time.deltaTime;
            animator.Play("jump animation");
            if(runner.transform.position.y < y0)
            {
                runner.transform.position = new Vector3(runner.transform.position.x, y0, 0);
                myState = State.run;
            }
        }
    }
}
