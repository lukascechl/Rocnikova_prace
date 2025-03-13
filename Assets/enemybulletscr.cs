using System.Threading;
using UnityEngine;

public class enemybulletscr : MonoBehaviour
{
public GameObject player;
private Rigidbody2D rb;
public float force;
private float timer;

   void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = player.transform.position - transform.position;
        rb.linearVelocity = new Vector2(direction.x, direction.y).normalized * force; 
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 8)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Health>().TakeDamage(20);
            Destroy(gameObject);
        }
    }
}