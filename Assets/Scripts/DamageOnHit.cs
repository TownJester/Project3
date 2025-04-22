using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public float DamageDone;
    private void OnCollisionEnter(Collision collision){
        GameObject OtherObject = collision.gameObject;
        PlayerPawn PlayerPawn = OtherObject.GetComponent<PlayerPawn>();
        if (PlayerPawn != null){
            Health Health = PlayerPawn.GetComponent<Health>();
            if (Health != null){
                Health.TakeDamage(DamageDone);
            }
        }
    
     }
}