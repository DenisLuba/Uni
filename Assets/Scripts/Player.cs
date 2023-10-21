using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float velocity = 1.0F;
    public float velocityRightLeft = 1.0F;
    public float speedRatio = 1.0F;
    public int life = 100;
     
    public Text lifeState;
    public FixedJoystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        print($"Start life = {life}");
        lifeState.text = life.ToString();
    }

    // Update is called once per frame
    void Update() => transform.position -= new Vector3(
                (velocity + joystick.Direction.y * speedRatio) * Time.deltaTime, 
                0, 
                -(joystick.Direction.x * Time.deltaTime * velocityRightLeft)
            );

    public void LifeUpdate(int score)
    {
        life += score;
        lifeState.text = life.ToString();
    }
}
