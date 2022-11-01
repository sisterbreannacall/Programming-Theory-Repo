using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PugAnimal : Animal
{
    // INHERITANCE
    private void Update() 
    {
        MoveDown();
        CheckBoundary();
    }
}
