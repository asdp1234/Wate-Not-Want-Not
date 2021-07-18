using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badguy : MonoBehaviour
{
    [SerializeField]
    GameObject pointa, pointb,player,go;
    bool a = true, b;
    [SerializeField]
    bool canmove;
    [SerializeField]
    GameObject blood;
    bool hasblood = false;

    int health = 3;


    float ctime, ntime = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (canmove)
        {

        if (a)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointa.transform.position, 0.003f);
            if (Vector2.Distance(transform.position, pointa.transform.position) < 0.1f)
            {
                a = false;
                b = true;
            }
        }
        else if (b)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointb.transform.position, 0.003f);
            if (Vector2.Distance(transform.position, pointb.transform.position) < 0.1f)
            {
                a = true;
                b = false;
            }
        }

        }
        print(transform.rotation.z);
        if (transform.rotation.z > .3f || transform.rotation.z < -.3f)
        {
            if (!hasblood)
            {

                GameObject test = Instantiate(blood, transform.position, transform.rotation);
                hasblood = true;
                Destroy(test, 3);
            }

            print("fuck");
            Destroy(gameObject, .55f);
            
        }
        if (health <= 0)
        {
            Destroy(gameObject, .55f);
        }
        ctime += Time.deltaTime;
        if (Vector2.Distance(transform.position,player.transform.position) < 3.5f)
        {
            if (ctime > ntime)
            {
                ctime = 0;
                print("shoot");
                Instantiate(go, transform.position, Quaternion.identity);
            }
        }
    }

    public void Sethealth(int Hp)
    {
        health += Hp;
    }
}
