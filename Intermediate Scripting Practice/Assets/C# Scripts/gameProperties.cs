using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;

public class gameProperties : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player myPlayer = new Player();

        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
