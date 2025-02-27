using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Ball;
    Vector3 velocity = new Vector3(2, 3,0);
    Vector2 min;
    Vector2 max;
    void Start()
    {
        min = Camera.main.ScreenToWorldPoint(Vector2.zero);
        max = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        print(min.x + ".." + min.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        Ball.transform.position += velocity * Time.deltaTime;

        if (Ball.transform.position.y > max.y - Ball.transform.localScale.y/2)
        {
            velocity = new Vector3(velocity.x, velocity.y, 0);
        }
    }
}
