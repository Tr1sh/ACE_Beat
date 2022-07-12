using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] private int speed = 2;
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * speed;
    }
}
