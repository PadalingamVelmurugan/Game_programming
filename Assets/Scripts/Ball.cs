using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector2 direction = Vector2.right;
    float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         float angle = 30.0f * Mathf.Deg2Rad;
         direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
    }

    // Update is called once per frame
    void Update()
    {
        // Homework: Prevent the ball from travelling off the screen by changing its direction

        // If the ball is too far right, make its x-direction negative (1% -- free)
        if (transform.position.x > 10.0f)
        {
            direction.x = -direction.x;
        }

  if (transform.position.x < 10.0f)
        {
            direction.x = -direction.x;
        }
        // If the ball is too far up, make its y-direction negative (1%)

        // If the ball is too far down, make its y-direction positive (1%)

        float dt = Time.deltaTime;
        Vector3 change = direction * speed * dt;
        transform.position += change;
    }
}
