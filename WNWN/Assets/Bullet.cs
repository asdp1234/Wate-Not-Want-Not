using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
   GameObject go;

    float speed = 5;
    Rigidbody2D rb;
    [SerializeField]
    movement target;
    Vector2 dir;
    [SerializeField]
    AudioSource pew;

   
    void Start()
    {
        

        if (gameObject.tag.Equals("Enemy_bullet"))
        {
            rb = GetComponent<Rigidbody2D>();
            target = GameObject.FindObjectOfType<movement>();
            dir = (target.transform.position - transform.position).normalized * speed;
            rb.velocity = dir;
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("badguy") && this.gameObject.tag.Equals("Bullet_shotgun"))//shotgun
        {
            pew.Play();
            col.gameObject.GetComponent<badguy>().Sethealth(-1);
            Instantiate(go, col.gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject, .1f);
        }
        if (col.gameObject.tag.Equals("badguy") && this.gameObject.tag.Equals("Bullet_handgun"))//handgun
        {
            pew.Play();
            print("ding");
            col.gameObject.GetComponent<badguy>().Sethealth(-2);
            Instantiate(go, col.gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject, .1f);
        }
        if (col.gameObject.tag.Equals("badguy") && this.gameObject.tag.Equals("Bullet_minigun"))//minigun
        {
            pew.Play();
            col.gameObject.GetComponent<badguy>().Sethealth(-2);
            Instantiate(go, col.gameObject.transform.position, Quaternion.identity);
            print("ding");
            Destroy(gameObject, 5f);
        }
        if (col.gameObject.tag.Equals("Player") && this.gameObject.tag.Equals("Enemy_bullet"))//minigun
        {
            pew.Play();
            col.gameObject.GetComponent<Health>().SetHealth(-1);
            Instantiate(go, col.gameObject.transform.position, Quaternion.identity);  
            print("ding");
            Destroy(gameObject);
        }
    }
}
