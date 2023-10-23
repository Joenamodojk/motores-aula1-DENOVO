using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI Hud, msgvitoria;
    public int restantes;
    public AudioClip clipMoeda,clipVitoria;

    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<Moeda>().Length;

        Hud.text = $"Moedas Restantes: {restantes}";
    }


    public void SubtrairMoedas(int valor)
    {
        restantes = restantes - valor;
        Hud.text = $"Moedas Restantes: {restantes}";
        source.PlayOneShot(clipMoeda);

        if(restantes <= 0){
            msgvitoria.text = "Parabéns!!!";
            source.Stop();
            source.PlayOneShot(clipVitoria);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
