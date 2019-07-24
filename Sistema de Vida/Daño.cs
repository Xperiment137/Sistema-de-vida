using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour {
    public int daño = 0;
    public GameObject aux;
    private Vidamanager manager;


    void Awake()
    {
       aux=GameObject.FindGameObjectWithTag("Player");
        manager = aux.GetComponent<Vidamanager>();
    }
   

	void Update () {
        manager.Vida -= daño;
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            daño = 3;
        }
    }
        void OnCollisionExit(Collision col)
        {
            if (col.gameObject.tag == "Player")
            {
                daño = 0;
            }



        }


    }
