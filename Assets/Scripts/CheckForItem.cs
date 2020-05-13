using UnityEngine;
using UnityEngine.UI;

public class CheckForItem : MonoBehaviour
{
    public GameObject go_ItemHolder;
    public Text txt_PickUpText, txt_CutText;

    private int layerMask = 1 << 9;
    private bool b_HoldingItem=false;
    private new Camera camera;
    private GameObject lastObject=null;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (!b_HoldingItem)
        {
            if (Physics.Raycast(ray, out hit, 2f, layerMask))
            {
                txt_PickUpText.enabled = true;
                lastObject = hit.transform.gameObject;
                if (Input.GetMouseButtonDown(0))
                {
                    lastObject.transform.position = go_ItemHolder.transform.position;
                    lastObject.GetComponent<Rigidbody>().useGravity = false;
                    lastObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    lastObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                    lastObject.transform.parent = go_ItemHolder.transform;
                    b_HoldingItem = true;
                    txt_PickUpText.enabled = false;
                }
                if (hit.transform.gameObject.GetComponent<IngredientRaw>())
                {
                    if (hit.transform.gameObject.GetComponent<IngredientRaw>().bl_Cuttable == true)
                    {
                        txt_CutText.enabled = true;
                        if (Input.GetKeyDown(KeyCode.F))
                        {
                            hit.transform.SendMessage("Cut");
                            txt_CutText.enabled = false;
                        }
                    }
                    else
                    {
                        txt_CutText.enabled = false;
                    }
                }
            }
            else if (lastObject != null)
            {
                txt_PickUpText.enabled = false;
                txt_CutText.enabled = false;
            }
            else
            {
                txt_PickUpText.enabled = false;
                txt_CutText.enabled = false;
            }
        }
        else
        {
            if (lastObject != null)
            {
                txt_PickUpText.enabled = false;
                txt_CutText.enabled = false;
                if (Input.GetMouseButtonDown(0))
                {
                    lastObject.transform.parent = null;
                    lastObject.GetComponent<Rigidbody>().useGravity = true;
                    b_HoldingItem = false;
                }
            }
            else
            {
                b_HoldingItem = false;
            }
        }
    }
}
