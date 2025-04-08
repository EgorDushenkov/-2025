using UnityEngine;  

public class CarController : MonoBehaviour  
{  
    public WheelCollider frontLeftWheel;  
    public WheelCollider frontRightWheel;  
    public WheelCollider rearLeftWheel;  
    public WheelCollider rearRightWheel;  

    public Transform frontLeftTransform;  
    public Transform frontRightTransform;  
    public Transform rearLeftTransform;  
    public Transform rearRightTransform;  

    public float maxMotorTorque = 1500f; 
    public float maxSteeringAngle = 30f;  
    public float brakeTorque = 3000f;

    void Update()  
{  
    float motorInput = Input.GetAxis("Vertical");  
    float steeringInput = Input.GetAxis("Horizontal");   

    float frontWheelPowerFactor = 1.2f;  
    float rearWheelPowerFactor = 0.8f;  

    rearLeftWheel.motorTorque = motorInput * maxMotorTorque * rearWheelPowerFactor;  
    rearRightWheel.motorTorque = motorInput * maxMotorTorque * rearWheelPowerFactor;  
 
    frontLeftWheel.motorTorque = motorInput * maxMotorTorque * frontWheelPowerFactor;  
    frontRightWheel.motorTorque = motorInput * maxMotorTorque * frontWheelPowerFactor;  

    float steering = steeringInput * maxSteeringAngle;  
    frontLeftWheel.steerAngle = steering;  
    frontRightWheel.steerAngle = steering;  

    if (Input.GetKey(KeyCode.Space))  
    {  
        rearLeftWheel.brakeTorque = brakeTorque;  
        rearRightWheel.brakeTorque = brakeTorque;  
    }  
    else  
    {  
        rearLeftWheel.brakeTorque = 0;  
        rearRightWheel.brakeTorque = 0;  
    }  

    UpdateWheelPoses();  
}

    void UpdateWheelPoses()  
    {  
        UpdateWheelPose(frontLeftWheel, frontLeftTransform);  
        UpdateWheelPose(frontRightWheel, frontRightTransform);  
        UpdateWheelPose(rearLeftWheel, rearLeftTransform);  
        UpdateWheelPose(rearRightWheel, rearRightTransform);  
    }  

    void UpdateWheelPose(WheelCollider collider, Transform trans)  
    {  
        Vector3 position;  
        Quaternion rotation;  
        collider.GetWorldPose(out position, out rotation);  
        trans.position = position;  
        trans.rotation = rotation;  
    }  
}