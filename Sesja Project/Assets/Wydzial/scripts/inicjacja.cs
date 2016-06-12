using UnityEngine;
using System.Collections;

public class inicjacja : MonoBehaviour {

    public Transform postac;
    public Transform kat;
    public Transform brzeg;
    public Transform korytarz;
    public Transform[] pokójWejścieWPrawo;
    public Transform[] pokojWejścieWLewo;
    public int wyskokosc;
    public int szerokosc;

    float rozmiarObrazka = 2.8f;

    float pozycjaX = 0;
    float pozycjaY = 0;
    int liczbaKorytarzy;
    int liczbaPojedyniczych;

    void Start()
    {
        int liczcznikPojedyniczych;
        
        if (wyskokosc < 3) { wyskokosc = 3; }
        if (szerokosc < 3) { szerokosc = 3; }
        liczbaKorytarzy = (szerokosc - 2) / 3;
        //liczbaPojedyniczych = (szerokosc - 2);

        if (szerokosc % 3 == 2) 
        { 
            liczbaPojedyniczych = 2; 
        } 
        else if (szerokosc % 3 == 0) 
        { 
            liczbaPojedyniczych = 1; 
        } 
        else 
        { 
            liczbaPojedyniczych = 0; 
        }


        //Random.seed = pokoj.Length;
        System.Random x = new System.Random();

        for (int i = 0; i < wyskokosc; i++)
        {
            liczcznikPojedyniczych=liczbaPojedyniczych;
            for (int j = 0; j < szerokosc; j++)
            {
                
                
                if (i == 0 && j == 0)
                {
                    Transform pom = (Transform)Instantiate(kat, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    pom.transform.Rotate(Vector3.forward * 90);
                    pom.gameObject.name = "Pokój: i:" + i + " j:" + j;
                    //pom.parent = plansza as Transform;
                }
                else if (i == 0 && j == szerokosc - 1) 
                {
                    Transform pom = (Transform)Instantiate(kat, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    pom.transform.Rotate(Vector3.forward * 180);
                    pom.gameObject.name = "Pokój: i:" + i + " j:" + j;
                    //pom.parent = plansza;
                }
                else if (i == wyskokosc - 1 && j == 0)
                {
                    Transform pom = (Transform)Instantiate(kat, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    //pom.transform.Rotate(Vector3.forward * 90);
                    pom.gameObject.name = "Pokój: i:" + i + " j:" + j;
                    //pom.gameObject.transform.parent = plansza;
                }
                else if (i == wyskokosc - 1 && j == szerokosc - 1)
                {
                    Transform pom = (Transform)Instantiate(kat, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    pom.transform.Rotate(Vector3.forward * 270);
                    pom.gameObject.name = "Pokój: i:" + i + " j:" + j;
                    //pom.parent = plansza;
                }
                else if (i == 0) 
                { 
                    Transform pom = (Transform)Instantiate(brzeg, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    pom.transform.Rotate(Vector3.forward * 180);
                    pom.gameObject.name = "Pokój: i:" + i + " j:" + j;
                    //pom.parent = plansza;
                }
                else if (j == 0)
                {
                    Transform pom = (Transform)Instantiate(brzeg, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    pom.transform.Rotate(Vector3.forward * 90);
                    pom.gameObject.name = "Pokój: i:" + i + " j:" + j;
                    //pom.parent = plansza;
                }
                else if (i == wyskokosc - 1)
                {
                    Transform pom = (Transform)Instantiate(brzeg, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    //pom.transform.Rotate(Vector3.forward * 90);
                    pom.gameObject.name = "Pokój: i:" + i + " j:" + j;
                    //pom.parent = plansza;
                }
                else if (j == szerokosc - 1)
                {
                    Transform pom = (Transform)Instantiate(brzeg, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                    pom.transform.Rotate(Vector3.forward * 270);
                    pom.gameObject.name = "Pokój: i:" + i + " j:" + j;
                    //pom.parent = plansza;
                }
                else 
                {



                    if (szerokosc == 3)
                    {
                        if (x.Next(1, 100) > 50)
                        {
                            
                            int los = x.Next(0, pokójWejścieWPrawo.Length);

                            Transform pomPokój = (Transform)Instantiate(pokójWejścieWPrawo[los], new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomPokój.gameObject.name = "Pokój: i:" + i + " j:" + j;
                            //pomPokój.parent = plansza;
                            Transform pomBonus = (Transform)Instantiate(pokójWejścieWPrawo[los].GetComponent<BonusDoPokoju>().bonus, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomBonus.parent = pomPokój;

                            if (x.Next(1, 100) < 50) { pomBonus.gameObject.SetActive(false); }
                        }
                        else 
                        {
                            int los = x.Next(0, pokojWejścieWLewo.Length);

                            Transform pomPokój = (Transform)Instantiate(pokojWejścieWLewo[los], new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomPokój.gameObject.name = "Pokój: i:" + i + " j:" + j;
                            //pomPokój.parent = plansza;
                            Transform pomBonus = (Transform)Instantiate(pokojWejścieWLewo[los].GetComponent<BonusDoPokoju>().bonus, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomBonus.parent = pomPokój;

                            if (x.Next(1, 100) < 50) { pomBonus.gameObject.SetActive(false); }
                        }

                    }
                    else if (szerokosc == 4)
                    {
                        if (i == 1)
                        {
                            int los = x.Next(0, pokójWejścieWPrawo.Length);
                            Transform pomPokój = (Transform)Instantiate(pokójWejścieWPrawo[los], new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomPokój.gameObject.name = "Pokój: i:" + i + " j:" + j;
                            //pomPokój.parent = plansza;
                            Transform pomBonus = (Transform)Instantiate(pokójWejścieWPrawo[los].GetComponent<BonusDoPokoju>().bonus, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomBonus.parent = pomPokój;

                            if (x.Next(1, 100) < 50) { pomBonus.gameObject.SetActive(false); }
                        }
                        else
                        {
                            int los = x.Next(0, pokojWejścieWLewo.Length);
                            Transform pomPokój = (Transform)Instantiate(pokojWejścieWLewo[los], new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomPokój.gameObject.name = "Pokój: i:" + i + " j:" + j;
                            //pomPokój.parent = plansza;
                            Transform pomBonus = (Transform)Instantiate(pokojWejścieWLewo[los].GetComponent<BonusDoPokoju>().bonus, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomBonus.parent = pomPokój;

                            if (x.Next(1, 100) < 50) { pomBonus.gameObject.SetActive(false); }
                        }
                    }
                    else 
                    {
                        if (liczcznikPojedyniczych > 0)
                        {
                            liczcznikPojedyniczych--;
                            if (x.Next(1, 100) > 50)
                            {

                                int los = x.Next(0, pokójWejścieWPrawo.Length);

                                Transform pomPokój = (Transform)Instantiate(pokójWejścieWPrawo[los], new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                                pomPokój.gameObject.name = "Pokój: i:" + i + " j:" + j;
                                //pomPokój.parent = plansza;
                                Transform pomBonus = (Transform)Instantiate(pokójWejścieWPrawo[los].GetComponent<BonusDoPokoju>().bonus, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                                pomBonus.parent = pomPokój;

                                if (x.Next(1, 100) < 50) { pomBonus.gameObject.SetActive(false); }
                            }
                            else
                            {
                                int los = x.Next(0, pokojWejścieWLewo.Length);

                                Transform pomPokój = (Transform)Instantiate(pokojWejścieWLewo[los], new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                                pomPokój.gameObject.name = "Pokój: i:" + i + " j:" + j;
                                //pomPokój.parent = plansza;
                                Transform pomBonus = (Transform)Instantiate(pokojWejścieWLewo[los].GetComponent<BonusDoPokoju>().bonus, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                                pomBonus.parent = pomPokój;

                                if (x.Next(1, 100) < 50) { pomBonus.gameObject.SetActive(false); }
                            }
                            
                            
                            
                            
                            
                            /*int los = x.Next(0, pokójWejścieWPrawo.Length);

                            Transform pomPokój = (Transform)Instantiate(pokójWejścieWPrawo[los], new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomPokój.gameObject.name = "Pokój: i:" + i + " j:" + j;
                            //pomPokój.parent = plansza;
                            Transform pomBonus = (Transform)Instantiate(pokójWejścieWPrawo[los].GetComponent<BonusDoPokoju>().bonus, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomBonus.parent = pomPokój;

                            if (x.Next(1, 100) < 50) { pomBonus.gameObject.SetActive(false); }*/

                            if (j + 1 < szerokosc-1)
                            {
                                j++;
                                pozycjaX = pozycjaX + rozmiarObrazka;
                                Transform pomKorytarz = (Transform)Instantiate(korytarz, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                                pomKorytarz.gameObject.name = "Korytarz: i:" + i + " j:" + j;
                            }


                        }
                        else 
                        {
                            int los = x.Next(0, pokojWejścieWLewo.Length);
                            Transform pomPokój2 = (Transform)Instantiate(pokojWejścieWLewo[los], new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomPokój2.gameObject.name = "Pokój: i:" + i + " j:" + j;
                            //pomPokój.parent = plansza;
                            Transform pomBonus2 = (Transform)Instantiate(pokojWejścieWLewo[los].GetComponent<BonusDoPokoju>().bonus, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomBonus2.parent = pomPokój2;

                            if (x.Next(1, 100) < 50) { pomBonus2.gameObject.SetActive(false); }

                            j++;
                            pozycjaX = pozycjaX + rozmiarObrazka;

                            los = x.Next(0, pokójWejścieWPrawo.Length);
                            Transform pomPokój = (Transform)Instantiate(pokójWejścieWPrawo[los], new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomPokój.gameObject.name = "Pokój: i:" + i + " j:" + j;
                            //pomPokój.parent = plansza;
                            Transform pomBonus = (Transform)Instantiate(pokójWejścieWPrawo[los].GetComponent<BonusDoPokoju>().bonus, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                            pomBonus.parent = pomPokój;

                            if (x.Next(1, 100) < 50) { pomBonus.gameObject.SetActive(false); }
                           
                            if (j + 1 < szerokosc-1)
                            {
                                j++;
                                pozycjaX = pozycjaX + rozmiarObrazka;
                                Transform pomKorytarz = (Transform)Instantiate(korytarz, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                                pomKorytarz.gameObject.name = "Korytarz: i:" + i + " j:" + j;
                            }

                        }
                    }


                    /*int los = x.Next(0, pokoj.Length);
                    Transform pom = pokoj[los];
                    Transform pom2 = pom.GetComponent<BonusDoPokoju>().bonus;
                    pom2.transform.parent = pom;
                    Instantiate(pom, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);

                    if (x.Next(1, 100) < 50) { Instantiate(pom2, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity); }*/

                    
                    
                    
                }
                
                //Instantiate(kat, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
                pozycjaX = pozycjaX + rozmiarObrazka;
                
            }
            pozycjaY = pozycjaY + rozmiarObrazka;
            pozycjaX = 0;
        }

        Instantiate(postac, new Vector3(0.3f, 0.3f, 0), Quaternion.identity);
    }

    /*public void dodajPokuj(Transform[] tablicaPokoji,int pozI,int pozJ) 
    {
        System.Random x = new System.Random();
        int los = x.Next(0, pokójWejścieWPrawo.Length);
        Transform pomPokój = (Transform)Instantiate(pokójWejścieWPrawo[los], new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
        pomPokój.gameObject.name = "Pokój: i:" + i + " j:" + j;
        //pomPokój.parent = plansza;
        Transform pomBonus = (Transform)Instantiate(pokójWejścieWPrawo[los].GetComponent<BonusDoPokoju>().bonus, new Vector3(pozycjaX, pozycjaY, 0), Quaternion.identity);
        pomBonus.parent = pomPokój;

        if (x.Next(1, 100) < 50) { pomBonus.gameObject.SetActive(false); }
    }*/
	
}
