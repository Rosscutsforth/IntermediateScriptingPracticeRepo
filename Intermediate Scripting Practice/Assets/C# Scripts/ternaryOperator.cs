using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ternaryOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 10;
        string message;

        message = health > 0 ? "Player is Alive" : "Player is Dead";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
