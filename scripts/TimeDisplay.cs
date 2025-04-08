using UnityEngine;  
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour  
{  
    public Text timeText; 
    private RaceManager raceManager;  

    private void Start()  
    {   
        raceManager = FindObjectOfType<RaceManager>();  
    }  

    private void Update()  
    {  
        if (raceManager != null)  
        {  
            timeText.text = $"Время: {raceManager.RaceTime:F2} секунд";
        }  
    }  
}