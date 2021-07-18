using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    
    Vector2 worldPosition;
    [SerializeField]
    GameObject shootpoint;
    LineRenderer lr;
    Vector2 dir;
    Rigidbody2D rb;
    float angle;
    // Start is called before the first frame update

    void Start()
    {
        lr = shootpoint.GetComponent<LineRenderer>();
        rb = shootpoint.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lr.SetPosition(0, shootpoint.transform.position);
        lr.SetPosition(1, worldPosition);

        dir = worldPosition - rb.position;
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
    public Vector3 Getshootposition()
    {
        return worldPosition;
    }
   
}
