using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move with WASD");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float xValue = moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float zValue = moveSpeed * Input.GetAxis("Vertical")  * Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
    }
}
