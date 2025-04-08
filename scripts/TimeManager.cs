using UnityEngine;  

public class TimeManager : MonoBehaviour  
{  
    private const string saveKey = "BestTime";  

    public void SaveBestTime(float newTime)  
    {  
        float bestTime = PlayerPrefs.GetFloat(saveKey, float.MaxValue);  
        if (newTime < bestTime)  
        {  
            PlayerPrefs.SetFloat(saveKey, newTime);  
            PlayerPrefs.Save();  
        }  
    }  

    public float LoadBestTime()  
    {  
        return PlayerPrefs.GetFloat(saveKey, float.MaxValue);  
    }  
}