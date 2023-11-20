using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float velocity = 1.0F;
    public float velocityRightLeft = 1.0F;
    public float speedRatio = 1.0F;
    public int jumpForce = 300;
    private int life = 100;
    private JumpButtonScript jumpButtonScript;
    private bool isJumping = false;

    private int Life
    {
        get => life;
        set => life = value < 0 ? 0 : value > 100 ? 100 : value;
    }

    public Text lifeState;
    public FixedJoystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        print($"Start life = {Life}");
        lifeState.text = Life.ToString();
        jumpButtonScript = GameObject.Find("JumpButton").GetComponent<JumpButtonScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(
            (velocity + joystick.Direction.y * speedRatio) * Time.deltaTime,
            0,
            -(joystick.Direction.x * Time.deltaTime * velocityRightLeft)
        );

        Jump();
    }

    private void Jump()
    {
        if (jumpButtonScript.isPressed && !isJumping)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
            jumpButtonScript.isPressed = false;
            // isJumping = true;
            jumpButtonScript.gameObject.SetActive(false);
        }
    }

    public void LifeUpdate(int score)
    {
        Life += score;
        lifeState.text = Life.ToString();
        if (!IsAlive())
        {
            SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
        }
    }

    private bool IsAlive() => life > 0;
}