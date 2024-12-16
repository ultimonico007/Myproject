using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejecutarsonido : MonoBehaviour
{
    [SerializeField] private AudioClip intro;
    [SerializeField] private AudioClip motivacion;

    private void OnTriggerEnter2D(Collider2D other)
    {
        controladorsonidos.instance.ejecutarsonido(intro);
        StartCoroutine(ReproducirSegundoAudio());
        Destroy(gameObject);
    }
    private System.Collections.IEnumerator ReproducirSegundoAudio()
    {
        yield return new WaitForSeconds(intro.length);
        controladorsonidos.instance.ejecutarsonido(motivacion);
    }
}
