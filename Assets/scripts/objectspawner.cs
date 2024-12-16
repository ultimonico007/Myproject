using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectspawner : MonoBehaviour
{
    public GameObject objectprefab;
    public float bulletForce;
    public Vector3 spawnPosition;
    [SerializeField] private AudioClip sonidoDisparo;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          GameObject bulletclone = Instantiate(objectprefab, transform.position, transform.rotation);

            Rigidbody bulletRigidbody = bulletclone.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = transform.forward * bulletForce;
            Destroy(bulletclone, 3f);
            if (controladorsonidos.instance != null && sonidoDisparo != null)
            {
                controladorsonidos.instance.ejecutarsonido(sonidoDisparo);
            }
        }
        
    }
}
