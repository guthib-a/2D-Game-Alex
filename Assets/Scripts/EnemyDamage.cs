using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] public Weapon weapon;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void TriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Weapon"))
        {
            Debug.Log("bbb");
            if (weapon.Attacking == true)
            {
                Debug.Log("aaa");
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag.Equals("Weapon"))
        {
            Debug.Log("bbb");
            if (weapon.Attacking == true)
            {
                Debug.Log("aaa");
            }
        }
    }
}
