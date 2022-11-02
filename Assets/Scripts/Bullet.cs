using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 30f;
    public float atk = 20;
    private Rigidbody rb;

    void Start()
    {
        // 往前飛
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    void Update()
    {
        
    }
}
