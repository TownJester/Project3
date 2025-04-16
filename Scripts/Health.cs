using UnityEngine;

public class Health : MonoBehaviour
{
    public float CurrentHealth;
    public float MaxHealth;
    public UpdateHealth HealthTrack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ouch(float amount){
        CurrentHealth -= amount;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
        if (HealthTrack != null){
            HealthTrack.ChangeFillAmount();
        }
        if (CurrentHealth <= 0){
            Die();
        }
    }
    public void Heal (float amount){
        CurrentHealth += amount;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
                if (HealthTrack != null){
            HealthTrack.ChangeFillAmount();
        }
    }
    public void Die(){
        if (GameManager.instance != null){
            GameManager.instance.ReduceLivesOne();

        }
        Destroy(gameObject);
    }

    public void TakeDamage(float amount)
    {
        CurrentHealth = CurrentHealth - amount;

        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
    }
}
