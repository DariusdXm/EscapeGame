using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
            transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1.0f, transform.position.z);
            transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }
    }
}
