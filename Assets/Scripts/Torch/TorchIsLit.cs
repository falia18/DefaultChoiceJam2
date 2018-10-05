using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchIsLit : MonoBehaviour {

    public GameObject player;
    public GameObject light;
    private bool isLighting;

    // Get the light variable from the player (prende la lumiere variables de le joueur)
    void getLight()
    {
        isLighting = player.GetComponent<PlayerLighter>().isLighting;
    }

    void Update () {
        getLight();
	}

    private void OnCollisionStay(Collision collision)
    {
        // Check if player is touching the torch & lighting it (Verifie si le joueur est touchante la lampe et faire jour ce)
        if(collision.gameObject.CompareTag("Player"))
        {
            if(isLighting == true)
            {
                // Make the light of the torch appear (fais la lumiere de la lampe apparaitre)
                light.SetActive(true);
            }
        }
    }
}
