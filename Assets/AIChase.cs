using UnityEngine;

public class AIChase : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private float distance;
    public float distanceBetween;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // UnityEngine.Vector2 direction = player.transform.position - transform.position;
    // Update is called once per frame
    void Update()
    {
        distance = UnityEngine.Vector2.Distance(transform.position, player.transform.position);
                

        
    if(distance < distanceBetween)
    {
        transform.position = UnityEngine.Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    }
    void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        Debug.Log("Enemy narazil do hráče!");
        // Tady můžeš přidat logiku poškození nebo reakce na kolizi
    }
}
}
