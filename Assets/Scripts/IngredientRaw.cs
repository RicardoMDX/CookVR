using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientRaw : MonoBehaviour
{
    public bool bl_Cuttable;
    public GameObject go_CutVersion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Cut()
    {
        GameObject cut = Instantiate(go_CutVersion);
        cut.transform.position = this.gameObject.transform.position;
        Destroy(this.gameObject);
    }
}
