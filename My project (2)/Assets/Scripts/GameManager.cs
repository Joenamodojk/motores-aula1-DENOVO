using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI Hud, msgvitoria;
    public int restantes;
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;

        Hud.text = $"Moedas Restantes: {restantes}";
    }


    public void SubtrairMoedas(int valor)
    {
        restantes = restantes - valor;
        Hud.text = $"Moedas Restantes: {restantes}";

        if(restantes <= 0){
            msgvitoria.text = "Parabéns!!!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
