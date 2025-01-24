using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    private Rigidbody2D _rb;
    [HideInInspector] 
    public Vector2 moveDirection;
    [HideInInspector] 
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticalVector;
    public CoinManager cm;
    public GameOver gm;

    AudioManager am;

    private void Awake()
    {
        am = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        InputManager();
        Move();
    }

    private void InputManager()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        
        moveDirection = new Vector2(horizontal, vertical);

        if (moveDirection.x != 0)
        {
            lastHorizontalVector = moveDirection.x;
        }

        if (moveDirection.y != 0)
        {
            lastVerticalVector = moveDirection.y;
        }
    }

    private void Move()
    {
        _rb.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            am.PlaySFX(am.coinSound);
            cm.coinCount++;
            Destroy(other.gameObject);

            if (cm.coinCount == 30)
            {
                gm.EndGame(cm.coinCount);
            }
        }
    }
    
}
