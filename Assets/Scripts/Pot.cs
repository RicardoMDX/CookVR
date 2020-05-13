using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{
    public GameObject go_SpaghettiCooked;

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
        if(other.tag=="SpaghettiUncooked")
        {
            GameObject spawn = Instantiate(go_SpaghettiCooked);
            spawn.transform.position = other.transform.position;
            Destroy(other.gameObject);
        }
    }
}
