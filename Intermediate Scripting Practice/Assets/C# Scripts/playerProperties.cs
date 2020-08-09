using System.Collections;
using System.Collections.Generic;
using System.Media;
using UnityEngine;

public class playerProperties : MonoBehaviour
{

    public class Player
    {
        private int experience;

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }
    }

    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
