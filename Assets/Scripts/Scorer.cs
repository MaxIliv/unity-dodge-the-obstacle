using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] private int score = 0;
    string ignoreTag = "Hit";

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != ignoreTag) {
            score++;
            Debug.Log($"Bumped this many times: {score}");
        }
    }
}
