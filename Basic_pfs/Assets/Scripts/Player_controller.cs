using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{

    public float player_movement_speed;
    public float player_rotation_speed;
    public float look_speed;
    public Camera main_camera;
    private Vector2 look_rotation = Vector2.zero;
    private float rotation_camera_vertical;
    public float rot_cam_ver_up_max = -90.0f;
    public float rot_cam_ver_down_max = 35.0f;
    void Start()
    {
        Debug.Log("Camera initial look angle: "+Camera.main.transform.localEulerAngles);
    }

    void Update(){

        transform.Translate(0,0,Input.GetAxis("Vertical")*player_movement_speed);
        transform.Translate(Input.GetAxis("Horizontal")*player_movement_speed, 0 ,0);
        transform.Rotate(0,Input.GetAxis("Mouse X")*look_speed,0);

        
        look_rotation.y -= Input.GetAxis("Mouse Y");
        rotation_camera_vertical = look_rotation.y * look_speed;
        if (rotation_camera_vertical > rot_cam_ver_down_max){
            rotation_camera_vertical = rot_cam_ver_down_max;
        } else if (rotation_camera_vertical < rot_cam_ver_up_max){
            rotation_camera_vertical = rot_cam_ver_up_max;
        }

        Camera.main.transform.localEulerAngles = new Vector3(rotation_camera_vertical,0,0);

        if (Input.GetAxis("Mouse Y") != 0){
            Debug.Log("look_rotation.y = "+look_rotation.y);
            Debug.Log("Mouse X: "+Input.GetAxis("Mouse X")+" Y: "+Input.GetAxis("Mouse Y"));
            Debug.Log("Camera look angle: "+Camera.main.transform.localEulerAngles);
        }
        
    }
}
