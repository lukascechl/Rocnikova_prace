using UnityEngine;

    public class Player : MonoBehaviour
    {
        public float moveSpeed;
        private Rigidbody2D rb;

        private Vector2 moveDir;
    [SerializeField] private Animator _animator;
        
        void Update()
        {
            ProcessInputs();
        }
        void FixedUpdate()
        {
            Move();
        }
        
        void Start()
        {
            rb = this.GetComponent<Rigidbody2D>();
        }
    
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(moveX, moveY).normalized;
        if (moveDir != Vector2.zero)
        {
            _animator.SetBool("IsRunning", true);
        }
        else
        {
            _animator.SetBool("IsRunning", false);
        }

    }
    void Move()
    {
        rb.linearVelocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }
    }