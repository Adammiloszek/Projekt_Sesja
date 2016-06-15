using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class powtorka : MonoBehaviour
{

    Text komponent;


    void Start()
    {
		

        komponent = GetComponent<Text>();
		komponent.text = "Punkty: " + countDots.currentScore.ToString();
		float proc = countDots.currentScore / countDots.allPacdotsCount;
        string ocena = "2";
		komponent.text = "Uzyskałeś " +  countDots.currentScore.ToString() + "/" + countDots.allPacdotsCount.ToString() +  " punktów z egzaminu. Twoja ocena to " + ocena + ". Na szczęście to był pierwszy termin, masz jeszcze drugi. Do boju!";
    
    }
    
    void Update()
    {


		float proc = countDots.currentScore / countDots.allPacdotsCount;
		string ocena = "2";
		komponent.text = "Uzyskałeś " +  countDots.currentScore.ToString() + "/" + countDots.allPacdotsCount.ToString() +  " punktów z egzaminu. Twoja ocena to " + ocena + ". Na szczęście to był pierwszy termin, masz jeszcze drugi. Do boju!";


    
        }
}