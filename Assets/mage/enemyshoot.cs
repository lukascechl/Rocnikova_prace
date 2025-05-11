using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPosition;
    private GameObject player;

    public float shootdistance;
    private float timer;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance < shootdistance)
        {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            timer = 0;
            shoot();
        }      
    }
    }
    void shoot()
    {
        Instantiate(bullet, bulletPosition.position, bulletPosition.rotation);
    }
    
}
