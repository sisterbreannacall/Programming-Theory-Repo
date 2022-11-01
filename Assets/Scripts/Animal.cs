using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float speed = 5.0f;
    private float boundary = -10.0f;

    public virtual void MoveDown()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void CheckBoundary()
    {
        if (transform.position.z < boundary)
        {
            Destroy(gameObject);
        }
    }
}
