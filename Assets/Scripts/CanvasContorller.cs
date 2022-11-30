using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasContorller : MonoBehaviour
{
    public GameObject textMonedas;
    public Button button;
    GameObject playerGO;
    JugadorController player;
    // Start is called before the first frame update
    void Start()
    {
        playerGO = GameObject.Find("Jugador");
        player = playerGO.GetComponent<JugadorController>();
    }

    // Update is called once per frame
    void Update()
    {
        textMonedas.GetComponent<TextMeshProUGUI>().text = player.getMonedas().ToString();
        if (player.getMonedas() != 10)
        {
            button.gameObject.SetActive(false);
        }
        else
        {
            button.gameObject.SetActive(true);
        }
    }
}
