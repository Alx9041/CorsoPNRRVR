using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KunaiSpawner : MonoBehaviour
{
    // L'asset del proiettile
    [SerializeField]
    private GameObject proiettile;

    //Il punto da dove inizio a sparare
    [SerializeField]
    private Transform firePoint;

    // L'azione che l'utente fa per saparare
    [SerializeField]
    private InputActionReference shootAction;

    // Update is called once per frame
    void Update()
    {
        /*
        shootAction.action.WasPressedThisFrame() =>
            se ho premuto in questo frame da come valore vero
            altrimenti da come valore falso
        */
        if(shootAction.action.WasPressedThisFrame()){
            /*
            Instantiate => Crea
            Crea il proiettile nella posizione firePoint.position, con rotazione
            firePoint.rotation
            */
            Instantiate(proiettile, firePoint.position, firePoint.rotation);
        }
    }
}
