using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpExp : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject healt;
    public GameObject healtInfo;
    void Start()
    {
        healt.SetActive(false);
        healtInfo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        healt.SetActive(true);
        healtInfo.SetActive(true);
    }

    void OnMouseExit()
    {
        healt.SetActive(false);
        healtInfo.SetActive(false);
    }
}
