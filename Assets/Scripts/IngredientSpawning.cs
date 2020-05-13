using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientSpawning : MonoBehaviour
{
    public GameObject go_IngredientSpawning, go_IngredientPrefab;
    public float f_Timer = 3f;

    private float f_LastSpawn=0f;
    private bool bl_Spawn = true, bl_CanSpawn=true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bl_Spawn==true)
        {
            //Spawn
            GameObject spawned=Instantiate(go_IngredientPrefab);
            spawned.transform.position = go_IngredientSpawning.transform.position;
            f_Timer = 3f;
            bl_Spawn = false;
            bl_CanSpawn = false;
        }
        if (bl_CanSpawn)
        {
            f_Timer -= Time.deltaTime;
            if (f_Timer<=0)
            {
                bl_Spawn = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
            f_LastSpawn = Time.deltaTime;
            bl_CanSpawn = true;
    }
}
