using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float bulletDamage = 1f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * bulletSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("hit enemy");
            var eh = collision.gameObject.GetComponent<EnemyHealth>();
            eh.EnemyTakesDamage(10);
            Destroy(gameObject);
        }
    }
}