using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    string targetTag = "Player";
    string hitTag = "Hit";

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == targetTag)
        {
            Debug.Log("Bumped into a obstacle");

            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material.color = Color.yellow;
            gameObject.tag = hitTag;
        }
    }
}
