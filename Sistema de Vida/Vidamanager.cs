using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Vidamanager : MonoBehaviour
{

    public int Vida = 100;
    public int Municion = 0;
    public Text texto;
    public Font fuente;
    public int daños;
  
  

   void Update()
    {
       
        if (Vida > 0)
        {
            texto.text = Vida.ToString();
            texto.color = Color.black;
            texto.font = fuente;
        }
        else
        {

            texto.text = "Estas muerto";
            Color newColor = new Color(156, 64, 7);
            texto.color = newColor;
            texto.font = fuente;
        }
    }
        
   
  
}
    
