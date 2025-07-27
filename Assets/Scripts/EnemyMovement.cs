using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float stoppingDistance;
    public float maxDistance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance && Vector2.Distance(transform.position, target.position) < maxDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
