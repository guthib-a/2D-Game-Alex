using UnityEngine;

public class SpawnStructures : MonoBehaviour
{
    public GameObject house;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   SpawnHouse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnHouse()
    {
        Vector2 SpawnLocation = new Vector2 (Random.Range(-40, 40), Random.Range(-40, 40));
        Instantiate(house, SpawnLocation, Quaternion.identity);
    }
}
