using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_controller : MonoBehaviour
{

    public float player_movement_speed;
    public float look_speed;
    private Vector2 look_rotation = Vector2.zero;
    private float rotation_camera_vertical;
    public float rot_cam_ver_up_max = -8.0f;
    public float rot_cam_ver_down_max = 7.0f;


    void Update(){
        //WALK
        transform.Translate(0,0,Input.GetAxis("Vertical")*player_movement_speed);
        transform.Translate(Input.GetAxis("Horizontal")*player_movement_speed, 0 ,0);

        //HORIZONTAL-LOOK
        transform.Rotate(0,Input.GetAxis("Mouse X")*look_speed,0);
        
        //VERTICAL-LOOK
        look_rotation.y -= Input.GetAxis("Mouse Y");

        if (look_rotation.y > rot_cam_ver_down_max){
            look_rotation.y = rot_cam_ver_down_max;
        } else if (look_rotation.y < rot_cam_ver_up_max){
            look_rotation.y = rot_cam_ver_up_max;
        }
        rotation_camera_vertical = look_rotation.y * look_speed;
        Camera.main.transform.localEulerAngles = new Vector3(rotation_camera_vertical,0,0);
    }
}
