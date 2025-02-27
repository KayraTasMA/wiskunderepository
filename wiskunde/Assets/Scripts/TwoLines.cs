using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoLines : MonoBehaviour
{
    [SerializeField] Transform A;
    [SerializeField] Transform B;
    [SerializeField] Transform C;
    [SerializeField] Transform D;
    [SerializeField] Transform AB;
    [SerializeField] Transform CD;
    LinearFunction f = new LinearFunction(1,1);
    LinearFunction g = new LinearFunction(1,1);
    [SerializeField] Transform S;
    void Start()
    {
        
    }
}

    // Update is called once per frame

    /*
    void Update()
    {
        f.SetFunctionWithTwoPoints(A.position, B.position);
        AB.SetPosition(0, new Vector3(-10,f.getY(-10),0));
        AB.SetPosition(1, new Vector3());

        g.SetFunctionWithTwoPoints(C.position,D.position);
        CD.SetPosition(0, new Vector3(-10,f.getY(-10),0));
        CD.SetPosition(1, new Vector3());

        S.Position  
    }
}
*/