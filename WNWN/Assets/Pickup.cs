using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField]
    Handgun hg;
    Shotgun sg;
    Minigun mg;
    [SerializeField]
    Health hp;
    [SerializeField]
   AudioSource ac,heals;
    //Minigun mg;
    private void Start()
    {
        hg = hg.GetComponent<Handgun>();
        sg = hg.GetComponent<Shotgun>();
        mg = hg.GetComponent<Minigun>();
        hp = hp.GetComponent<Health>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("HandGun"))
        {
            //add to correct gun
            hg.Setammo(1);
            Destroy(col.gameObject);
            ac.Play();
        }
        if (col.gameObject.tag.Equals("SGun"))
        {
            //add to correct gun
            sg.Setammo(1);
            ac.Play();
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag.Equals("MiniGun"))
        {
            //add to correct gun
            mg.Setammo(1);
            ac.Play();
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag.Equals("Health") && hp.Gethealth() < 3)
        {
            //add to correct gun
            hp.SetHealth(1);
            heals.Play();
            Destroy(col.gameObject);
        }
    }
}
