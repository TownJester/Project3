using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public float DamageDone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision){
        Health Health = collision.GetComponent<Health>();
        if (Health != null){
            Health.Ouch(DamageDone);
            Destroy(gameObject);
        }
    }
}
