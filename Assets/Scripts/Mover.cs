using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float zValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // transform.Translate(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");

        transform.Translate(xValue, 0f, zValue);
    }
}
