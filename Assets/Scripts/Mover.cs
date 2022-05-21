using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0.01f;
    [SerializeField] float zValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // transform.Translate(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
