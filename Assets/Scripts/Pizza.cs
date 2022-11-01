using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    private float speed = 20.0f;
    private float boundary = 6.2f;

    private void Update() 
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.z > boundary)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        GameManager.Instance.IncrementScore();
    }
}
