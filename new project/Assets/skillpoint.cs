using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // This is so that it should find the Text component
using UnityEngine.Events; // This is so that you can extend the pointer handlers
using UnityEngine.EventSystems; // This is so that you can extend the pointer handlers

public class skillpoint : MonoBehaviour
{
    // Start is called before the first frame update
    int skillpoints = 10;
    int healthpoint = 200;
    int stamina = 100;
    public Text TotalSkillPoint;
    public Text hpText;
    public Text staText;
    public GameObject reverseHP;
    public GameObject reverseSTA;
    public GameObject currentHP;
    public GameObject currentSTA;
    public int chosenStat;

    void Start()
    {

        reverseHP.SetActive(false);
        reverseSTA.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

        TotalSkillPoint.text = skillpoints.ToString();
        hpText.text = healthpoint.ToString();
        staText.text = stamina.ToString();

    }

    public void resetSkillPoint()
    {

    }

    public void spendSkillPoint(GameObject stat)
    {
        
        if (skillpoints > 0)
        {
            skillpoints -= 1;
            if (stat == currentHP)
            {               
                healthpoint += 10;
                reverseHP.SetActive(true);
            }
            else if(stat == currentSTA)
            {                
                stamina += 10;
                reverseSTA.SetActive(true);
            }
        }
        else if(skillpoints == 10)
        {
            reverseSTA.SetActive(false);
            reverseHP.SetActive(false);
        }
       
    }

    public void reversePoint(GameObject stat)
    {
        if (skillpoints < 10)
        {
            
            if (stat == currentHP)
            {
                if (healthpoint > 200)
                {
                    healthpoint -= 10;
                    skillpoints += 1;
                }
                if(healthpoint == 200)
                {
                    reverseHP.SetActive(false);
                }
            }
            else if (stat == currentSTA)
            {
                if (stamina > 100)
                {
                    stamina -= 10;
                    skillpoints += 1;
                }
                if (stamina == 100)
                {
                    reverseSTA.SetActive(false);
                }
            }


        }
    }

    /*public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<Text>().color = Color.gray; // Changes the colour of the text
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<Text>().color = Color.black; // Changes the colour of the text
    }*/
}
