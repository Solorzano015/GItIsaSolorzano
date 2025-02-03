using UnityEngine;

public class Bullet : MonoBehaviour
{    

    public float velocidad;
    public float damage = 10;

    void Update()
    {
        transform.position += transform.forward * velocidad * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Health health = collision.collider.gameObject.GetComponent<Health>();
        if (health)
        {

            health.Damage(damage);

        }

    }
}
