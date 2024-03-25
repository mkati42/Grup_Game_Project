using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Karakterin temel hareket hızı

    private Rigidbody2D rb;
    private Vector2 movement;
    public PlayerStatManager playerStat;
    public GameObject   playerMusic;

    void Start()
    {
        playerStat = GetComponent<PlayerStatManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Kullanıcının girişini al
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Hareket vektörünü oluştur
        movement = new Vector2(moveX, moveY).normalized;
        moveSpeed = playerStat._speed;
        // BURADA ENERGY SİSTEMİ VAR HIZLI KOŞUYORKEN ENERJİNİN DOLMAMASI İÇİN
        if (Input.GetKey(KeyCode.LeftShift) && playerStat._energy > 0)
        {
            if (playerStat.energyFlag == true)
                playerStat._speed += 2.0f;
            playerStat.energyFlag = false;
            playerStat._energy -= (Time.fixedDeltaTime * 8);
        }
        else
        {
            if (playerStat.energyFlag == false)
                playerStat._speed -= 2.0f;
            playerStat.energyFlag = true;
        }
    }

    void FixedUpdate()
    {
        // Hareket etme kontrolü
        if (movement.magnitude > 0) // Karakter hareket ediyorsa
        {
            // Karakteri hareket ettir
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "speed")
            playerStat.speedChange();
        else if (other.gameObject.name == "hearth")
            playerStat.healthChange(20f);
        else if (other.gameObject.name == "damage_plus")
            playerStat.damageChange();
    }
}
