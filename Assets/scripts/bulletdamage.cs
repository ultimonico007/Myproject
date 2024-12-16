using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdamage : MonoBehaviour
{
    // Start is called before the first frame update
    public int damagebullet = 25;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("enemy"))
        {
            dañoenemigo enemy = collision.gameObject.GetComponent<dañoenemigo>();
            if(enemy != null)
            {
                enemy.Receivedamagefrombullet(damagebullet);
            }
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
