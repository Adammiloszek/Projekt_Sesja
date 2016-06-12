using UnityEngine;
using System.Collections;

public class InicjacjaMapy : MonoBehaviour
{
    public Transform[] tabPokoji;
       
    // Use this for initialization
    void Start()
    {
        przygotowaniePlanszy();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DajBonuys(System.Random generator,Transform pomPokój, int procent)
    {
        int los = generator.Next(0, 100);
        Transform pomBonus = pomPokój.transform.Find("bonus").transform;
        if (los < procent) { pomBonus.gameObject.SetActive(false); }

    }

    void dajBonusyPokojom() {
        System.Random x = new System.Random();
        foreach(Transform pom in tabPokoji)
        {
            Transform pomBonus = pom.transform.Find("bonus").transform;
            pomBonus.gameObject.SetActive(true);
            DajBonuys(x,pom,50);

        }

    }

    void przygotowaniePlanszy() 
    {
        dajBonusyPokojom();
        System.Random x = new System.Random();
        int losP = x.Next(0, tabPokoji.Length);
        foreach (Transform pom in tabPokoji) 
        {
            Transform pomPortal = pom.transform.Find("Portal").transform;
            pomPortal.gameObject.SetActive(false);
            DajBonuys(x, pom, 50);
        }
        tabPokoji[losP].transform.Find("Portal").transform.gameObject.SetActive(true);
        tabPokoji[losP].transform.Find("bonus").transform.gameObject.SetActive(false);
        dajBonusyPokojom();

    }
}
