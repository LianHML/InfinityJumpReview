using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehavior : MonoBehaviour
{
    private GameObject[] platformCollider;

    void Start()
    {
        platformCollider = GameObject.FindGameObjectsWithTag("PlatformCollider");
    }

    public void ToggleCollider()
    {
        foreach (var collider in platformCollider)
        {
            collider.SetActive(!collider.activeSelf);
        }
    }
}
