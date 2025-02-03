using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100, MaxHealth = 100;
    

    public void Damage(float damage)
    {
        health -= damage;
    }



}
