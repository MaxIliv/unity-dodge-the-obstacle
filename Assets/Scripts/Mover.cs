using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        // transform.Translate(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float zValue = moveSpeed * Input.GetAxis("Vertical")  * Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
    }
}
