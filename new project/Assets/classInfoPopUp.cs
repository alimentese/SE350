using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classInfoPopUp : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 mousePosition;
    public float moveSpeed = 0.0000001f;
    public float x;
    public float y;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            x = mousePosition.x + 2.7f;
            y = mousePosition.y - 0.8f;
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
            transform.position = new Vector2(x, y);
    }
}
