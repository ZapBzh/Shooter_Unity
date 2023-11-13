using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public GameObject bonus;
    public Rigidbody2D RBBonus;
    public float speedBonus = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        RBBonus.velocity = Vector3.up * speedBonus;
    }

    // Update is called once per frame
    void Update()
    {

        

    }
}
