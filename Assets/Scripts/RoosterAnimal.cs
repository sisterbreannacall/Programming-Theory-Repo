using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoosterAnimal : Animal
{
    private void Update() 
    {
        MoveDown();
        CheckBoundary();    
    }

    // POLYMORPHISM
    public override void MoveDown()
    {
        speed = 7.0f;

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
