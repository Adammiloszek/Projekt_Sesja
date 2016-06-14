using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class powtorka : MonoBehaviour
{

    Text komponent;


    void Start()
    {
        komponent = GetComponent<Text>();
        komponent.text = "Punkty: " + pacdot.punkty.ToString();
        float punkty = pacdot.punkty;
        float proc = punkty / 320;
        string ocena = "2";
        komponent.text = "Uzyskałeś " + punkty.ToString() + "/320 punktów z egzaminu. Twoja ocena to " + ocena + ". Na szczęście to był pierwszy termin, masz jeszcze drugi. Do boju!";
    
    }
    
    void Update()
    {
        float punkty = pacdot.punkty;
        float proc = punkty / 320;
        string ocena = "2";
        komponent.text = "Uzyskałeś " + punkty.ToString() + "/320 punktów z egzaminu. Twoja ocena to " + ocena + ". Na szczęście to był pierwszy termin, masz jeszcze drugi. Do boju!";
    
        }
}