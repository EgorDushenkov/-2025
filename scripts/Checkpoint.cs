using UnityEngine;  

public class Checkpoint : MonoBehaviour  
{  
    public bool IsFinishLine;  
    private bool isActivated = false;
    private void OnTriggerEnter(Collider other)  
    {   
        if (isActivated==false)
        {
            if (IsFinishLine)  
            {  
                RaceManager.Instance.FinishRace();
            }
            else  
            {  
                RaceManager.Instance.CollectCheckpoint(); 
            }
            isActivated = true;
        }
           
    }  
}