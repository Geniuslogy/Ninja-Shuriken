using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    Component[] sprites;

    public float speed;

    public GameObject PlayerIdle;
    public GameObject PlayerRun;
    public GameObject PlayerDead;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        sprites = GetComponentsInChildren(typeof(SpriteRenderer), true);
    }

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

        if (Input.GetMouseButton(0))
        {
            Run();

            if (Input.mousePosition.x < Screen.width / 2)
            {
                rigidbody.velocity = Vector2.left * speed;

                foreach (SpriteRenderer e in sprites)
                    e.flipX = true;
            }
            else
            {
                rigidbody.velocity = Vector2.right * speed;

                foreach (SpriteRenderer e in sprites)
                {
                    e.flipX = false;
                }
            }

        } 
        else
        {
            Idle();
        }

    }

    private void Run()
    {
        PlayerRun.SetActive(true);
        PlayerIdle.SetActive(false);
    }

    private void Idle()
    {
        PlayerRun.SetActive(false);
        PlayerIdle.SetActive(true);
    }

}
