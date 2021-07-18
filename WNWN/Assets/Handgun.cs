using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Handgun : Gun
{
    
    [SerializeField]
    GameObject go;
    [SerializeField]
    GameObject emptygun;
    
    // Start is called before the first frame update
    void Start()
    {
        Setup(0,"HandGun", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
        
       
        if (Input.GetMouseButtonDown(0))
        {
            if (Setactive() && Getammo() > 0)
            {
                Shootgun();
            }
        }
    }

    void Shootgun()
    {

       GameObject bullet =  Instantiate(go,transform.position,Quaternion.identity);
       bullet.GetComponent<Rigidbody2D>().AddForce(transform.up * 10,ForceMode2D.Impulse);
       Instantiate(emptygun, transform.position, Quaternion.identity);
       Setammo(-1);
    }

    
}
