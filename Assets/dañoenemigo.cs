using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dañoenemigo : MonoBehaviour
{
    public int vida;
    public GameObject deadbodyPrefab;
    public TextMeshProUGUI vidaenemigoUI;
    public controler gamecontroler;
    // Start is called before the first frame update
    void Start()
    {
        vidaenemigoUI.text = vida.ToString();
        gamecontroler = GameObject.FindGameObjectWithTag("GameController").GetComponent<controler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Receivedamagefrombullet(int damage)
    {
        vida -= damage;
        vidaenemigoUI.text = vida.ToString();
        if (vida <= 0)
        {
            gamecontroler.Addkill();
            Destroy(gameObject);
            GameObject deadbody = Instantiate(deadbodyPrefab, transform.position, transform.rotation);
        }
    }
}

