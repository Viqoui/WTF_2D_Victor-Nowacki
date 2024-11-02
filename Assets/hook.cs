using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class hook : MonoBehaviour
{
    private bool isPressed = false;
    public float ReleaseTime = .15f;
    public Rigidbody2D rb;
    public Rigidbody2D Hook;
    public float MaxDistance = 2f;

    private void Update ()
    {
        if (isPressed)
        {  
            UnityEngine.Vector2 mousePos= Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(UnityEngine.Vector3.Distance(mousePos, Hook.position) > MaxDistance)
                rb.position = Hook.position + (mousePos - Hook.position).normalized * MaxDistance;
            else
            rb.position = mousePos;
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
