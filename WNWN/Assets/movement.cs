using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Vector3 move;
    [SerializeField]
    float speed = 4;
    [SerializeField]
    int jumph = 0;
    [SerializeField]
    float jumpspeed = 6;
    bool isgrounded = true;
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    bool isplayer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector3(Input.GetAxis("Horizontal"), jumph, 0);

        if (Input.GetKeyDown(KeyCode.Space) && isgrounded && isplayer)
        {
            rb.velocity = Vector2.up * jumpspeed;
            isgrounded = false;
        }
        else
            jumph = 0;

        transform.position += move * speed * Time.deltaTime;

        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Ground"))
        {
            isgrounded = true;
        }
    }
}
