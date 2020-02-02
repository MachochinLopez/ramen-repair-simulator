using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    //Score
    public Text scoreText;
    //Time
    public Text timerText;
    public float roundTimer;
    public int roundTimerInt;
    //Stress
    public int stressLevel;
    //Audio
    AudioClip[] bruhSounds;
    AudioClip[] panaSounds;
    public AudioClip shootClip;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = roundTimer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (roundTimer > 0f)
        {
            roundTimer = roundTimer - Time.deltaTime;
        }
        roundTimerInt = (int)roundTimer;
        timerText.text = roundTimerInt.ToString();
    }

    /*
     * - Reproducir sonido al interactuar (Remplazar objeto)
     * AudioSource = audio = objeto.gameObject.GetComponent<AudioSource>();
     * audio.Play();
     * 
     */

    
    public int getTime()
    {
        return roundTimerInt; //Devuelve el tiempo restante al terminar la partida (roundTimerInt = 600 seg - tiempo transcurrido)
    }

    public int getStress()
    {
        return stressLevel; //Devuelve el nivel actual de estres (Rango 0-10)
    }

    public void addStress(int amount)
    {
        stressLevel = stressLevel + amount;
    }

    public void reduceStress(int amount)
    {
        stressLevel = stressLevel - amount;
    }

    public AudioClip getBruhSound()
    {
        int randomClip = Random.Range(0, bruhSounds.Length);
        shootClip = bruhSounds[randomClip];
        return shootClip;
    }

    public AudioClip getPanaSound()
    {
        int randomClip = Random.Range(0, panaSounds.Length);
        shootClip = panaSounds[randomClip];
        return shootClip;
    }
}
