using UnityEngine;

public class Health : MonoBehaviour
{
    public float CurrentHealth;
    public float MaxHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Heal (float amount){
        CurrentHealth += amount;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);

    }
    public void Die(){
        Destroy(gameObject);
    }

    public void TakeDamage(float amount)
    {
        CurrentHealth = CurrentHealth - amount;

        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
                if (CurrentHealth <= 0){
            Die();
        }
    }
}
