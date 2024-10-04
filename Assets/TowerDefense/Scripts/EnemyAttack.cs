using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal"))
        {
            var healTarget = collision.GetComponentInParent<UnitHealth>();
            if (healTarget != null)
            {
                healTarget.TakeDamage(damage);
                Destroy(gameObject);
            }
        }
    }
}