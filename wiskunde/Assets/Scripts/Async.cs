using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Async : MonoBehaviour
{
    [SerializeField] float beginspeed = 5;
    [SerializeField] float gravity = 10;
    enum State {run, jump};
    State myState = State.run;
    Animator animator;
    Vector3 velocity = Vector3.zero;
    Vector3 acceleration = Vector3.zero;
    float t = 0;
    float tmax;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(myState == State.run)
        {
            animator.Play("run animation");
            if(Input.GetMouseButtonUp(0))
            {
                myState = State.jump;
                t = 0;
                velocity = new Vector3(0, beginspeed,0);
                acceleration = new Vector3(0, -gravity, 0);
                tmax = 2 * beginspeed / gravity;
                animator.speed = 0.583f/ tmax;
            }
        }
        t += Time.deltaTime;
        if(myState == State.jump)
        {
            velocity += acceleration * Time.deltaTime;
            transform.position += velocity * Time.deltaTime;
            animator.Play("jump animation");
            if(t > tmax)
            {
                myState = State.run;
                velocity = Vector3.zero;
                acceleration = Vector3.zero;
            }
           
        }
    }
}
