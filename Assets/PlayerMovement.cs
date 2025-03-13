using UnityEngine;

    public class Player : MonoBehaviour
    {
        public float moveSpeed;
        private Rigidbody2D rb;

        private Vector2 moveDir;
        
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
    }
    void Move()
    {
        rb.linearVelocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }
    }