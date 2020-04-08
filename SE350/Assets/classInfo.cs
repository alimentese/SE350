using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // This is so that it should find the Text component
using UnityEngine.Events; // This is so that you can extend the pointer handlers
using UnityEngine.EventSystems; // This is so that you can extend the pointer handlers
using UnityEngine.SceneManagement;

public class classInfo : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject knightInfo;
    public GameObject knightText;
    RaycastHit hit;
    Ray ray;
    void Start()
    {
        knightInfo.SetActive(false);
        knightText.SetActive(false);

    }

    void OnMouseOver()
    {
        GetComponent<Text>().color = Color.gray; // Changes the colour of the text
        knightInfo.SetActive(true);
        knightText.SetActive(true);
    }

    void OnMouseExit()
    {
        GetComponent<Text>().color = Color.black; // Changes the colour of the text
        knightInfo.SetActive(false);
        knightText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    
    public void buttonKnight()
    {
        knightInfo.SetActive(true);
        knightText.SetActive(true);
    }
    public void sureYesKnightButton(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void sureNoKnightButton()
    {
        knightInfo.SetActive(false);
        knightText.SetActive(false);
    }
}
