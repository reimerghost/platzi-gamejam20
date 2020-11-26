using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapSpawn : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y  < -20.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
