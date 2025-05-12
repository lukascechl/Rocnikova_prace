using UnityEngine;

public class AIChase : MonoBehaviour
{
    public GameObject player;
    Animator animator;
    public float speed;
    public float hitdamage;
    public bool _hasTarget = false;
    public bool hasTarget { get { return _hasTarget;} private set 
    {
        _hasTarget = value;
        animator.SetBool("hastarget",value);
    }
    }
    public float distanceBetween;
    public detection detection;
    [SerializeField] private Animator _animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // UnityEngine.Vector2 direction = player.transform.position - transform.position;
    // Update is called once per frame
    private void Awake()
    {
        animator = GetComponent<Animator>();    
    }
    private void Update()
    {
        Vector2 direction = player.transform.position - transform.position;
        float sqrDistance = direction.sqrMagnitude;
        hasTarget = detection.detected.Count > 0;

        if (sqrDistance < distanceBetween * distanceBetween)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);


            _animator.SetBool("run", true);

        }
        else
        {
            _animator.SetBool("run", false);
        }
    }

    

    void damage(){
        if (hasTarget = detection.detected.Count > 0)
        {
            player.GetComponent<Health>().TakeDamage(hitdamage);
        }
    }

}
