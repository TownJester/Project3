using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameObjectDestroy : MonoBehaviour
{
    public float Damage;
    public int Lives = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
        Health Health = collision.gameObject.GetComponent<Health>();
        if(Health != null){
            Health.TakeDamage(Damage);
        }
        // Destroys itself
        Destroy(gameObject);
    }
    }

