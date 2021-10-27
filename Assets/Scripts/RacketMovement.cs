using UnityEngine;

public class RacketMovement : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        float i = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * i * speed * Time.deltaTime;
    }
}
