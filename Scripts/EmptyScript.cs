using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount == 0)
        {
            //Debug.Log("destroy");
            Destroy(gameObject);
        }
    }
}
