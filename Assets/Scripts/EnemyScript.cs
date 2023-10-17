using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public SpriteRenderer sr;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
        
    }
    
    public void SpawnEnemy()
    {
        rb.velocity = new Vector3(0, Random.Range(-5, -10));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
