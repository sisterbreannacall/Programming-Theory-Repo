using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAnimal : Animal
{
    private void Update()
    {
        MoveDown();
        CheckBoundary();
    }

    // POLYMORPHISM
    public override void MoveDown()
    {
        speed = 6.0f;

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
