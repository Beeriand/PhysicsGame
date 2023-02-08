using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPhysic : MonoBehaviour
{
    public Rigidbody2D[] rBodies;

    private void OnMouseUp()
    {
        foreach (Rigidbody2D rBody in rBodies)
        {
            rBody.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
