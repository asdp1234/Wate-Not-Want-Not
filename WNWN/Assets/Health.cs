using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    int health = 3;
    byte losshp = 159;
    int hashealth = 255;
    [SerializeField]
    Image[] healthbar;
    [SerializeField]
    GameObject go,shootpoint,shootpointpoint;

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            health = 2;
            hashealth = 255;
        }
        go.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 1)
        {
            healthbar[0].color = new Color32(255, 0, 0, 100);
            healthbar[1].color = new Color32(losshp, losshp, losshp, 100);
            healthbar[2].color = new Color32(losshp, losshp, losshp, 100);
        }
        else if (health == 2)
        {
            healthbar[0].color = new Color32(255, 0, 0, 100);
            healthbar[1].color = new Color32(255, 0, 0, 100);
            healthbar[2].color = new Color32(losshp, losshp, losshp, 100);
        }
        else if (health == 3)
        {
            healthbar[0].color = new Color32(255, 0, 0, 100);
            healthbar[1].color = new Color32(255, 0, 0, 100);
            healthbar[2].color = new Color32(255, 0, 0, 100);
        }
        if (health > 3)
        {
            health = 3;
        }
        else if (health <= 0)
        {
            transform.position = go.transform.position;
            shootpoint.transform.position = shootpointpoint.transform.position;
            health = 3;
        }
    }
    public void SetHealth(int hp)
    {
        health += hp;
    }
    public int Gethealth()
    {
        return health;
    }
}
