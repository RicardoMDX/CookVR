﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plate" && other.GetComponent<Plate>().bl_Tomato == true && other.GetComponent<Plate>().bl_Spaghetti == true)
        {
            SceneManager.LoadScene(2);
        }
    }
}
