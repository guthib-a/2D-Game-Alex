using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Weapon : MonoBehaviour
{ 
    public float distanceFromPlayer = 0.1f;
    float angledeg;
    private float rightDistanceFromPlayer = 1;
    private float backDistanceFromPlayer = 0.3f;
    public GameObject Player;
    private Camera cam;
    public float elapsedtime;
    public bool Attacking;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Attacking = false;
        PointToMouse();
        if (Input.GetMouseButton(0) && elapsedtime > 0.3)
        {

            elapsedtime = 0;

        }
        if (elapsedtime < 0.1)
        {
             Attacking = true;
            Attack();
        }


        elapsedtime += Time.deltaTime;

    }
    public void PointToMouse()
    {
        
            transform.position = Player.transform.position;
        
 
        rotate();
        transform.position += transform.right * rightDistanceFromPlayer;
        transform.position += transform.up * (0 - backDistanceFromPlayer);

        rotate();
    }

    public void Attack()
    {


        transform.position += transform.up * distanceFromPlayer * elapsedtime * 5;
        

        
    }
    public void rotate()
    {
        Vector3 mousePos = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition);
        float angleRad = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x);
        float angleDeg = (180 / Mathf.PI) * angleRad - 90;
        transform.rotation = Quaternion.Euler(0f, 0f, angleDeg);

    }
 
}