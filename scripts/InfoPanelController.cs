using UnityEngine;  
using UnityEngine.UI;  

public class InfoPanelController : MonoBehaviour  
{  
    public GameObject infoText;
    public Image background; 
    private bool isInfoVisible = false;  

    void Start()  
    {   
        infoText.SetActive(false);  
        background.gameObject.SetActive(false);  
    }  
 
    public void ToggleInfo()  
    {  
        isInfoVisible = !isInfoVisible;  
        infoText.SetActive(isInfoVisible);  
        background.gameObject.SetActive(isInfoVisible);  
    }  
}