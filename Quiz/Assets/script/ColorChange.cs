using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    Color myColor;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollider2DEnter(Collision2D other)
    {
        myColor=other.gameObject.GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = myColor;

    }
}
