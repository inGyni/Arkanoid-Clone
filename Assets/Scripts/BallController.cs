using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed * Time.deltaTime;
    }

    float hitRacket(Vector2 ballPos, Vector2 racketPos, float racketWidth)
    {
        return (ballPos.x - racketPos.x) / racketWidth;
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "Racket")
        {
            float x = hitRacket(transform.position, c.transform.position, c.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed * Time.deltaTime;
        }
    }
}
