using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class controler : MonoBehaviour
{
    // Start is called before the first frame update
    public int kills;
    public int totalenemies;
    private bool isPaused = false;
    private float defeatTimer = 15f;
    public TMPro.TextMeshProUGUI timeText;
    [SerializeField] private TextMeshProUGUI killstext;
    [SerializeField] private TextMeshProUGUI wintext;
    [SerializeField] private TextMeshProUGUI losetext;
    void Start()
    {

        wintext.enabled = false;
        losetext.enabled = false;
        totalenemies = GameObject.FindGameObjectsWithTag("enemy").Length;
        UpdateUI();
        timeText.text = defeatTimer.ToString("F1");
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = defeatTimer.ToString("F1");
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                Time.timeScale = 1; 
                isPaused = false;
                
            }
            else
            {
                Time.timeScale = 0; 
                isPaused = true;
                
            }
        }
        if (defeatTimer > 0)
        {
            defeatTimer -= Time.deltaTime;
        }
        else
        {
            Gameover();
        }

    }
    public void Addkill()
    {
        kills++;
        UpdateUI();
        if (kills >= totalenemies)
        {
            Time.timeScale = 0;
            wintext.enabled = true;
        }

    }
    public void Gameover()
    {
        losetext.enabled = true;
        Time.timeScale = 0;
    }
    public void UpdateUI()
    {
        killstext.text = kills.ToString() + "/" + totalenemies.ToString();
    }
}
