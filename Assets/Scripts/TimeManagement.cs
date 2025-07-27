using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class TimeManagement : MonoBehaviour
{
    public float startingTime = 60f;
    public TextMeshProUGUI TimeText;
    float elapsedtime;
    private float timeLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        elapsedtime += Time.deltaTime;
        timeLeft = startingTime - elapsedtime;
        TimeText.text = ((int)timeLeft).ToString();

    }

}
