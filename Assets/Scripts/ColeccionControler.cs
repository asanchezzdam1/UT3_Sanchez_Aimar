using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColeccionControler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PickUp(other);
    }
    void PickUp(Collider player)
    {
        JugadorController jugador = player.GetComponent<JugadorController>();
        jugador.monedas++;
        Destroy(gameObject);
    }
}
