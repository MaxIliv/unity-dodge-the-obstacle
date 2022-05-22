using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] private int score = 0;

    private void OnCollisionEnter(Collision other) {
        score++;
        Debug.Log($"Bumped this many times: {score}");
    }
}
