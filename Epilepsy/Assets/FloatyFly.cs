using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatyFly : MonoBehaviour
{
    public int health = 3;
//Just change ts if you want like faster/slower
    public float liftForce = 5f;
    public float LRForce = 5f;
    
    public float swayAmount = 0.2f;
    public float swaySpeed = 2f;

    float velocityY;
    float targetVelocityY;
    float startX;
    float velocityX;
    float targetVelocityX;
    private Vector2 screenbounds;
    
    void Start()
    {
        startX = transform.position.x;
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Laser"))
    {
        health--;
        Debug.Log("Hit! Health = " + health);

        if (health <= 0)
        {
            Debug.Log("Player died");

            
        }
    }

    if (other.CompareTag("Bomb"))
    {
        health--;
        Debug.Log("Hit! Health = " + health);

        if (health <= 0)
        {
            Debug.Log("Player died");

        }
    }
}
    // Update is called once per frame
  void Update()
{
   if (Input.GetKey(KeyCode.UpArrow))
    {
        targetVelocityY = liftForce;
    }
    else if (Input.GetKey(KeyCode.DownArrow))
    {
        targetVelocityY = -liftForce;
    }
    else
    {
        targetVelocityY = 0f;
    }

 if (Input.GetKey(KeyCode.LeftArrow))
    {
        targetVelocityX = LRForce;
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
        targetVelocityX = -LRForce;
    }
    else
{
    targetVelocityX = 0f;
}

    velocityY = Mathf.Lerp(velocityY, targetVelocityY, 5f * Time.deltaTime);
    velocityX = Mathf.Lerp(velocityX, targetVelocityX, 5f * Time.deltaTime);

    transform.Translate(Vector2.up * velocityY * Time.deltaTime);
    transform.Translate(Vector2.left * velocityX * Time.deltaTime);

float clampedX = Mathf.Clamp(transform.position.x, -screenbounds.x, screenbounds.x);
Vector2 pos = transform.position;
pos.x = clampedX;
transform.position = pos;
 
float clampedY = Mathf.Clamp(transform.position.y, -screenbounds.y, screenbounds.y);
Vector2 pos2 = transform.position;
pos2.y = clampedY;
transform.position = pos2;

}
}
