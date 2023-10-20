using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 1.0F;
    public float velocityRightLeft = 1.0F;
    public float speedRatio = 1.0F;

    public FixedJoystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() => transform.position -= new Vector3(
                (velocity + joystick.Direction.y * speedRatio) * Time.deltaTime, 
                0, 
                -(joystick.Direction.x * Time.deltaTime * velocityRightLeft)
            );
}
