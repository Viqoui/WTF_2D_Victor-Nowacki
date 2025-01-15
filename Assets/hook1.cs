using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class hook1 : MonoBehaviour
{
    private bool isPressed = false;
    public float ReleaseTime = .15f;
    public Rigidbody2D rb;
    public Rigidbody2D Hook;

    public GameObject NextKosmit;
    public float MaxDistance = 2f;
    public GameObject LoseUI;

    private void Update ()
    {
        if (isPressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(Vector3.Distance(mousePos, Hook.position) > MaxDistance)
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

            Time.timeScale = 0.5f;
        yield return new WaitForSeconds(ReleaseTime);
        GetComponent<SpringJoint2D>().enabled = false;


        yield return new WaitForSeconds(2f);
        if (NextKosmit != null)
        {
        NextKosmit.SetActive(true);
        } else
        {
            yield return new WaitForSeconds(1f);
            LoseUI.SetActive(true);
        }
        
    }
}
