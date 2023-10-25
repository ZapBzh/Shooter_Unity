using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacementEnnemies : MonoBehaviour
{

    public Rigidbody2D monRigidBody;
    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        monRigidBody.velocity = Vector3.down * speed;
    }
}
