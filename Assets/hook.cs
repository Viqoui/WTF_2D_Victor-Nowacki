using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hook : MonoBehaviour
{
    private bool isPressed = false;
    public float ReleaseTime = .15f;
    public Rigidbody2D rb;

    private void Update ()
    {
        if (isPressed)
        {  
           rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void OnMouseDown ()
    {
        isPressed = true;
        rb.isKinematic = true;
    }
    void OnMouseUp ()
    {
        isPressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());
    }

    private IEnumerator Release ()
    {
        yield return new WaitForSeconds(ReleaseTime);
        GetComponent<SpringJoint2D>().enabled = false;
    }
}
