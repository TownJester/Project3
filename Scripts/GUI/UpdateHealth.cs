using UnityEngine;
using UnityEngine.UI;

public class UpdateHealth : MonoBehaviour
{
    public Image HealthDisplay;
    public Health Health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        public void ChangeFillAmount(){
        if (HealthDisplay != null && Health != null){
            float HealthRatio = Health.CurrentHealth / Health.MaxHealth;
            HealthDisplay.fillAmount = HealthRatio;
        }
    }
}
