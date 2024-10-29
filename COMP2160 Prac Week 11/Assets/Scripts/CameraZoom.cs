using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class CameraZoom : MonoBehaviour
{
    private Actions input;
    private InputAction Zoom;
    
    void Awake()
    {
        input = new Actions();
        Zoom = input.camera.zoom;
        // body = GetComponent<Rigidbody>();
        // body.freezeRotation = true;
        // body.constraints = RigidbodyConstraints.FreezePositionY;
    }

    void OnEnable()
    {
        Zoom.Enable();
    }
    
    void OnDisable()
    {
        Zoom.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Zoom.ReadValue<float>()<0){
        Camera.main.fieldOfView -= 5;
        Camera.main.orthographicSize  -= 1;
        }
        
        if(Zoom.ReadValue<float>()>0){
        Camera.main.fieldOfView += 5;
        Camera.main.orthographicSize  += 1;
        }
        Debug.Log(Zoom.ReadValue<float>());
    }
}
