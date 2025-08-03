using System.Collections;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] public Weapon weapon;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        weapon = FindObjectOfType<Weapon>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Weapon") && weapon.Attacking)
        {
                Destroy(gameObject);
            }
        }

    }
 