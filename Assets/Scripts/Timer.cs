using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float valeurTemps = 900;
    public Text chronometre;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(valeurTemps > 0)
        {
            valeurTemps -= Time.deltaTime;
        }
        else
        {
            valeurTemps = 0;
        }
        AfficherTemps(valeurTemps);

        if(valeurTemps == 0)
        {
            GestionChangementScenes.Defaite();
        }
    }

    void AfficherTemps(float tempsAffiche)
    {
        if(tempsAffiche < 0)
        {
            tempsAffiche = 0;
        }

        float minutes = Mathf.FloorToInt(tempsAffiche / 60);
        float secondes = Mathf.FloorToInt(tempsAffiche % 60);

        chronometre.text = string.Format("{0:00}:{1:00}", minutes, secondes);
    }
}
