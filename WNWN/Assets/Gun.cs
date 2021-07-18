using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    int id;
    [SerializeField]
    string gunname;
    [SerializeField]
    int power;
    bool isactive = false;
    Inventory inv;
    int ammo;

    public void Setup(int Id,string Name,int Power)
    {
        id = Id;
        gunname = Name;
        power = Power;
        
    }
    public int Getpower()
    {
        return power;
    }
    public string Getname()
    {
        return gunname;
    }
    public bool Setactive()
    {
        GameObject go = GameObject.Find("Player");
        if (go.GetComponent<Inventory>().Getid() == id)
        {
            isactive = true;
        }
        else
        {
            isactive = false;
        }
        return isactive;
    }
    
    public int Getid()
    {
        return id;
    }
    public int Getammo()
    {
        return ammo;
    }
    public int Setammo(int Ammo)
    {
        return ammo += Ammo;
    }


}
