using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverloadingSomeOtherClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MethodOverloadingSomeClass myClass = new MethodOverloadingSomeClass();

        myClass.Add(1, 2);
        myClass.Add("Hello", "World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
