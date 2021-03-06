using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenController : MonoBehaviour
{
    public float rotationSpeed; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, rotationSpeed);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.GameOver();
        }
        
        if (collision.gameObject.tag == "Tile")
        {
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
        }

    }

}
