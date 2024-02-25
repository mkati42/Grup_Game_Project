using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Karakterin temel hareket hızı

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Kullanıcının girişini al
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Hareket vektörünü oluştur
        movement = new Vector2(moveX, moveY).normalized;
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
}
