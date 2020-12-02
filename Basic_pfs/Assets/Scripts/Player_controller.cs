using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{

    public float player_movement_speed;
    public float player_rotation_speed;
    private Rigidbody player_rb;


    void Start()
    {
        player_rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float input_horizontal = Input.GetAxis("Horizontal");
        float input_vertical = Input.GetAxis("Vertical");

        Vector3 player_movement_vector = new Vector3 (input_horizontal, 0.0f, input_vertical);
        //player_rb.AddForce(player_movement_vector*player_movement_speed);
    }

    void Update(){
        float input_horizontal = Input.GetAxis("Horizontal");
        float input_vertical = Input.GetAxis("Vertical");

        transform.Translate(0,0,input_vertical*player_movement_speed);
        transform.Rotate(0,input_horizontal*player_rotation_speed,0);
    }
}
