using UnityEngine;  

public class HeadlightsController : MonoBehaviour  
{  
    public Light[] headlights;
    private bool areHeadlightsOn = false;  
 
    public void ToggleHeadlights()  
    {  
        areHeadlightsOn = !areHeadlightsOn;  
        foreach (Light headlight in headlights)  
        {  
            headlight.enabled = areHeadlightsOn;  
        }  
    }  
}