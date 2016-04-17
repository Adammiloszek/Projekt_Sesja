using UnityEngine;
using System.Collections;

public class inicjacja : MonoBehaviour {

    public Transform postac;
    public Transform kat;
    public Transform brzeg;
    public Transform[] pokoj; 
    public int wyskokosc;
    public int szerokosc;

    float rozmiarObrazka = 2.8f;
    //int pomWyskokosc = wyskokosc * rozmiarObrazka;

    float pozycjaX = 0;
    float pozycjaY = 0;

    void Start()
    {
        //Random.seed = pokoj.Length;
        System.Random x = new System.Random();
        
        for (int i = 0; i < szerokosc; i++)
        {
            for (int j = 0; j < wyskokosc; j++)
            {
                if (i == 0 && j == 0)
                {
                    Transform pom = (Transform)Instantiate(kat, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    pom.transform.Rotate(Vector3.forward * 90);
                }
                else if (i == 0 && j == wyskokosc-1) 
                {
                    Transform pom = (Transform)Instantiate(kat, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    pom.transform.Rotate(Vector3.forward * 180);
                }
                else if (i == szerokosc - 1 && j == 0)
                {
                    Transform pom = (Transform)Instantiate(kat, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    //pom.transform.Rotate(Vector3.forward * 90);
                }
                else if (i == szerokosc - 1 && j == wyskokosc - 1)
                {
                    Transform pom = (Transform)Instantiate(kat, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    pom.transform.Rotate(Vector3.forward * 270);
                }
                else if (i == 0) 
                { 
                    Transform pom = (Transform)Instantiate(brzeg, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    pom.transform.Rotate(Vector3.forward * 180);
                }
                else if (j == 0)
                {
                    Transform pom = (Transform)Instantiate(brzeg, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    pom.transform.Rotate(Vector3.forward * 90);
                }
                else if (i == szerokosc - 1)
                {
                    Transform pom = (Transform)Instantiate(brzeg, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    //pom.transform.Rotate(Vector3.forward * 90);
                }
                else if (j == szerokosc - 1)
                {
                    Transform pom = (Transform)Instantiate(brzeg, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    pom.transform.Rotate(Vector3.forward * 270);
                }
                else 
                { 
                    int los = x.Next(0, pokoj.Length); 
                    Instantiate(pokoj[los], new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity); 
                }
                
                //Instantiate(kat, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                pozycjaX = pozycjaX + rozmiarObrazka;
                
            }
            pozycjaY = pozycjaY + rozmiarObrazka;
            pozycjaX = 0;
        }

        Instantiate(postac, new Vector3(0.3f, 0.3f, 0), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
