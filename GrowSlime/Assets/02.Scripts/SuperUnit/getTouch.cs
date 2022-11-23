using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

[IncludeInSettings(true)]
public class getTouch : MonoBehaviour
{
    private GameObject target;
    public bool isTouched = false;
    
    public bool TouchDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
            if(target == this.gameObject)
            {
                isTouched = true;
            }
            else{
                isTouched = false;
            }
        }
        else{
            isTouched = false;
        }
        return isTouched;        
    }
    public bool TouchUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            return true;
        }
        return false;
    }
    public void Drag()
    {        
        if((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Moved))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.transform.position = pos;
        }         
    }


    void CastRay()
    {
        target = null;
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

        if(hit.collider != null)
        {
            target = hit.collider.gameObject;
        }
    }
}
