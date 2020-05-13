using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour
{
    public GameObject go_MeatCooked, go_FishCooked;

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
        if (other.tag == "MeatUncooked")
        {
            GameObject spawn = Instantiate(go_MeatCooked);
            spawn.transform.position = other.transform.position;
            Destroy(other.gameObject);
        }
        if (other.tag == "FishUncooked")
        {
            GameObject spawn = Instantiate(go_FishCooked);
            spawn.transform.position = other.transform.position;
            Destroy(other.gameObject);
        }
    }
}
