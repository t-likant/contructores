using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{ // Declaracion de mouse X,y
    float mouseX; 
    float mouseY; 
    public bool InvertedMouse;// Condiciona la camara invertida

    void Start()
    {// Establece la rotacion de la camara en los angulos 30 0 0
        transform.eulerAngles = new Vector3(45, 0, 0); 
    }

    void Update()
    { 
        Vector3 mousePosition = Input.mousePosition;// Nos permite analizar la posicion del mouse en pantalla
        mouseX += Input.GetAxis("Mouse X"); // La actualizacion es mas agradable y sin temblor

        if (mouseY <= 40 && mouseY >= -45)// Condicional para que el cuerpo no se de la vuelta y ponga el mundo de cabeza
        {
            if (InvertedMouse) // Si InvertedMouse es verdadero se invierte la camara en Y
            {// Arriba es Abajo y viceversa
                mouseY += Input.GetAxis("Mouse Y"); 
            }
            else
            {// Arriba es arriba y abajo es abajo en la camara
                mouseY -= Input.GetAxis("Mouse Y");
            }
        }// Establece a mouseY en el limite positivo
        else if (mouseY > 45)
        {
            mouseY = 45; 
        }
        else 
        {
            mouseY = -45; 
        }
        //Debug.Log(mouseX);// Nos muestra la rotacion en X
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0); // Rotacion en X y Y
    }
}
