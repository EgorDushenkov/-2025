using UnityEngine;  

public class CameraOrbit : MonoBehaviour  
{  
    public Transform target;  
    public float rotateSpeed = 5f;   
    public float zoomSpeed = 2f; 
    public float minDistance = 2f; 
    public float maxDistance = 10f; 
    private float currentDistance;  

    private void Start()  
    {  
        currentDistance = Vector3.Distance(transform.position, target.position); 
    }
    private void Update()  
    {  
        if (Input.GetMouseButton(1))   
        {  
            float mouseX = Input.GetAxis("Mouse X") * rotateSpeed;  
            float mouseY = Input.GetAxis("Mouse Y") * rotateSpeed;  
  
            transform.RotateAround(target.position, Vector3.up, mouseX);  
            transform.RotateAround(target.position, transform.right, -mouseY);  
        }  
        
        float scroll = Input.GetAxis("Mouse ScrollWheel");  
        if (scroll != 0)  
        {  
            currentDistance -= scroll * zoomSpeed; 
            currentDistance = Mathf.Clamp(currentDistance, minDistance, maxDistance); 
        }  

      
        Vector3 direction = (transform.position - target.position).normalized;
        transform.position = target.position + direction * currentDistance; 
    }  
}