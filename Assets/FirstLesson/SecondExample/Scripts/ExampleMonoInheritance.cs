using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMonoInheritance : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            gameObject.AddComponent<MonobehaviourClass>();
    }
}

