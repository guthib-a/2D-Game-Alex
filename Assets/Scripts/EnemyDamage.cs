using UnityEngine;

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
        Debug.Log(weapon.Attacking);
    }

    private void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag.Equals("Weapon"))
        {
            if (weapon.Attacking == true)
            {
                Debug.Log("aaa");
            }
        }
    }
}
