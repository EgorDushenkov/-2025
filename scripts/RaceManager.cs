using UnityEngine;  
using UnityEngine.SceneManagement;  

public class RaceManager : MonoBehaviour  
{  
    public static RaceManager Instance { get; private set; }  
    public float RaceTime { get; private set; }  
    public int TotalCheckpoints = 120; 
    private int checkpointsCollected = 0;  
    private bool raceFinished = false;  

    private void Awake()  
    {  
        if (Instance == null)  
        {  
            Instance = this;  
            DontDestroyOnLoad(gameObject);  
        }  
        else  
        {  
            Destroy(gameObject);  
        }  
    }  

    private void Update()  
    {  
        if (!raceFinished)  
        {  
            RaceTime += Time.deltaTime;   
        }  
    }  

    public void CollectCheckpoint()  
    {  
        checkpointsCollected++;
        Debug.Log($"Чекпоинты собраны: {checkpointsCollected} из {TotalCheckpoints}");
    }  

    public void FinishRace()  
    {  
        if (checkpointsCollected >= TotalCheckpoints)  
        {  
            raceFinished = true;  
            TimeManager timeManager = FindObjectOfType<TimeManager>(); 
            if (timeManager != null)  
            {  
                timeManager.SaveBestTime(RaceTime);  
            }  
            Debug.Log($"Ваше время: {RaceTime:F2} секунд");  
              
        }  
        else  
        {  
            Debug.Log("Вы не собрали все чекпоинты!");  
        }  
    }  
}