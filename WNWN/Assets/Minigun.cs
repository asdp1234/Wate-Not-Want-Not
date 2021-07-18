using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minigun : Gun
{
    
    [SerializeField]
    GameObject go;
    [SerializeField]
    GameObject emptygun;
    
    // Start is called before the first frame update
    void Start()
    {
        Setup(2,"MiniGun", 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Setactive() && Getammo() > 0)
            {
                Shootgun();
                Setammo(-1);
            }
        }
    }

    void Shootgun()
    {

       GameObject bullet =  Instantiate(go,transform.position,Quaternion.identity);
       bullet.GetComponent<Rigidbody2D>().AddForce(transform.up * 20,ForceMode2D.Impulse);
       Instantiate(emptygun, transform.position, Quaternion.identity);
    }
}
