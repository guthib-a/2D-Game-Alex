using Unity.VisualScripting;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int health = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health < 1)
        {
            GameObject.Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("aaaaa");
        GameObject enemy = collision.gameObject;
        if (enemy.tag == "enemy")
        {
            health -= 1;
            Debug.Log("aaaaa");
        }
    }
}
