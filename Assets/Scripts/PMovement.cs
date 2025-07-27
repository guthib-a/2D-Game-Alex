using System.Collections;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PMovement : MonoBehaviour 
{
    public float DashSpeed;
    Vector2 MoveDir;
    Rigidbody2D PlayerRb;
    public int MoveSpeed;
    public int Xmove;
    public int Ymove;
    private bool Dashing;
    float elapsedtime;
    public double dashCooldown;
    public int dashX;
    public int dashY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
        elapsedtime += Time.deltaTime;

    }
    public void move()
    {

      
        if (elapsedtime < 0.3)
        {
            Dashing = true;
        }
        else
        {
            Dashing = false;
            dashX = 0;
            dashY = 0;
            PlayerRb.linearVelocity = Vector2.zero;
        }

        MoveSpeed = 5;
        Xmove = 0;
        Ymove = 0;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            MoveSpeed = 7;
     
        }
        
            if (Input.GetKey(KeyCode.W))
            {
                Ymove += 1;
            }
            if (Input.GetKey(KeyCode.S))
            {
                Ymove -= 1;
            }
            if (Input.GetKey(KeyCode.A))
            {
                Xmove -= 1;
            }
            if (Input.GetKey(KeyCode.D))
            {
                Xmove += 1;
            }
            if (Input.GetKey(KeyCode.Space) && elapsedtime > dashCooldown)
            {

              elapsedtime = 0;
              Dashing = true;
              dashX = Xmove;
              dashY = Ymove;


            }



             DashSpeed = 3 - elapsedtime;
        //   if (Dashing)
        //    {

        //  PlayerRb.AddForce(MoveDir, ForceMode2D.Impulse);
        MoveDir = new Vector2(dashX, dashY).normalized;
            PlayerRb.linearVelocity = MoveDir * DashSpeed * 2;
     //   }
     //   else 
    //    {
            MoveDir = new Vector2(Xmove, Ymove).normalized;
          //  transform.position += MoveDir * Time.deltaTime * MoveSpeed;
            transform.position = (Vector2)transform.position + MoveDir * Time.deltaTime * MoveSpeed;

        //    }



    }

}
