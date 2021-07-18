using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shotgun : Gun
{
    
    [SerializeField]
    GameObject go;
    [SerializeField]
    GameObject emptygun;

    Vector3 a = new Vector3(0, 30, 0);

    // Start is called before the first frame update
    void Start()
    {
        Setup(1,"ShotGun", 1);

        

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
        
       GameObject bullet = Instantiate(go,transform.position, transform.rotation);
       bullet.GetComponent<Rigidbody2D>().AddForce(transform.up * 15,ForceMode2D.Impulse);// add to up for pew pew
       Instantiate(emptygun, transform.position, Quaternion.identity);

    }
}
