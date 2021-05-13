using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    Animator animatr;
    // Start is called before the first frame update
    void Start()
    {
        animatr = transform.parent.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "DoorHandle")
                {
                    Debug.Log("touched handle");
                    animatr.SetBool("DoorSwing", true);
                }
            }
        }
    }
}
