using UnityEngine;  
using UnityEngine.UI;  

public class MapToggle : MonoBehaviour  
{  
    public Image mapImage; 
    private bool isMapVisible = false; 

    public void ToggleMap()  
    {  
        isMapVisible = !isMapVisible;  
        mapImage.gameObject.SetActive(isMapVisible);  
    }  
}