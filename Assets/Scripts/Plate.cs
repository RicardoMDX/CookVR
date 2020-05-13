using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    public GameObject go_Salad, go_Tomato, go_Fish, go_Meat, go_Spaghetti;
    public bool bl_Salad = false, bl_Tomato = false, bl_Meat = false, bl_Fish = false, bl_Spaghetti=false;

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
        switch (other.tag)
        {
            case "Tomato":
                go_Tomato.SetActive(true);
                bl_Tomato = true;
                Destroy(other.gameObject);
                break;
            case "Salad":
                go_Salad.SetActive(true);
                bl_Salad = true;
                Destroy(other.gameObject);
                break;
            case "Fish":
                go_Fish.SetActive(true);
                bl_Fish = true;
                Destroy(other.gameObject);
                break;
            case "Meat":
                go_Meat.SetActive(true);
                bl_Meat = true;
                Destroy(other.gameObject);
                break;
            case "Spaghetti":
                go_Spaghetti.SetActive(true);
                bl_Spaghetti = true;
                Destroy(other.gameObject);
                break;
        }
    }
}
