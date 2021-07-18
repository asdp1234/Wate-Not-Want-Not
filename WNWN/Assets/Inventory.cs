using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    int activeid = 0;
    [SerializeField]
    Image[] slots;
    [SerializeField]
    Handgun hg;
    Shotgun sg;
    Minigun mg;
    //Minigun mg;
    private void Start()
    {
        
        hg = hg.GetComponent<Handgun>();
        sg = hg.GetComponent<Shotgun>();
        mg = hg.GetComponent<Minigun>();
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {

        // set inv by number aswell

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (activeid == 2)
            {
                activeid = 0;
            }
            else
            activeid++;
            
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (activeid == 0)
            {
                activeid = 2;
            }
            else
            activeid--;
            
        }
        print(activeid);
        for (int i = 0; i < slots.Length; i++)
        {
            if (i == activeid)
            {
                if (i == hg.Getid())//handgun
                {
                    if (hg.Getammo() == 0)
                    {
                        slots[i].GetComponent<Image>().color = new Color32(255, 0, 0, 100);
                    }
                    else
                    {
                        slots[i].GetComponent<Image>().color = new Color32(0, 255, 0, 100);
                    }

                }
                else if(i == sg.Getid())//shotgun
                {
                    if (sg.Getammo() == 0)
                    {
                        slots[i].GetComponent<Image>().color = new Color32(255, 0, 0, 100);
                    }
                    else
                    {
                        slots[i].GetComponent<Image>().color = new Color32(0, 255, 0, 100);
                    }
                }
                else if (i == mg.Getid())//minigun
                {
                    if (mg.Getammo() == 0)
                    {
                        slots[i].GetComponent<Image>().color = new Color32(255, 0, 0, 100);
                    }
                    else
                    {
                        slots[i].GetComponent<Image>().color = new Color32(0, 255, 0, 100);
                    }
                }
            }
            else
            {
                slots[i].GetComponent<Image>().color = new Color32(255, 255, 255, 100);
            }

        }

    }
    public int Getid()
    {
        return activeid;
    }
}
