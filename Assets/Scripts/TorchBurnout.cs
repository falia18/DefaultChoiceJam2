using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchBurnout : MonoBehaviour {

    public float lifetime;
    private float lifeTime;

    private void Start()
    {
        lifeTime = lifetime;
    }

    // Update is called once per frame
    void Update () {
        // Check if torch is lit (verifie si la lampe est allumee)
        if (GameObject.FindGameObjectWithTag("Torch").GetComponent<TorchIsLit>().torchLight.activeSelf == true)
        {
            // lifetime - seconds
            lifeTime -= Time.deltaTime;

            // check if lifetime is less than/equal to 0 (verifie si le lifetime est moins que/egal que zero)
            if (lifeTime <= 0)
            {
                // reset lifetime (remettre la duree)
                lifeTime = lifetime;
                // make torchlight inactive (fait le torchlight inactif)
                GameObject.FindGameObjectWithTag("Torch").GetComponent<TorchIsLit>().torchLight.SetActive(false);
            }
        }
	}
}
