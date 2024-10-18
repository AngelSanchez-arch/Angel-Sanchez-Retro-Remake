using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;
    public GameObject projectile;
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) 
        {
           Instantiate(explosionPrefab, transform.position,Quaternion.identity); 
           Destroy(collision.gameObject);
           Destroy(projectile);
        }

        if (collision.gameObject.CompareTag("Boundary"))
        {
            Destroy(projectile);
        }
    }


}
