
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{   //definicion de variables al zombie y ciudadano 
    Zombie z = new Zombie();//creador del constructor de la clase zombie      
    int ramdomAges; 
    string[] matrizNames;     
    int nNames;
    string sNames;   

    void Start()     
    {   //matriz de 20 nombres asinnados al azar con edades de 15 a 100 para la clase ciudadano
        matrizNames = new string[20]{"ruby","nora","yang","ren","weiss","ospin","qrow","raven","jaune","pyrrha",
        "glinda", "kali", "neo", "penny", "salem", "zwei", "winter", "summer", "cinder", "coco"};
        z.Create();
        for (int i = 0; i < Random.Range(2,8); i++)
        {
            nNames = Random.Range(0, 19);
            sNames = matrizNames[nNames];
            ramdomAges = Random.Range(15, 100);
            Citizen c = new Citizen(ramdomAges, sNames);
        }             
    }       
}       

public class Citizen
{   //contructor de la clase Citizen "ciudadano"
    int ramdomAges;
    string names;
    //inidice de alietoriedad de nombre y edad del script a la figura asignada "cubo"     
    public Citizen(int ramdomAges, string sNames)
    {
        this.ramdomAges = ramdomAges;
        names = sNames;
        GameObject citizen = GameObject.CreatePrimitive(PrimitiveType.Cube);
        citizen.transform.position = new Vector3(Random.Range(-10, 11), 0, Random.Range(-10, 11));
        Debug.Log(soy(ramdomAges,names));
    }   //dando mensaje "Hola soy (nombre asignado)y tengo (edad asignada) años" 
    string soy(int ramdomAges, string sNames)
    {
        string mensaje;
        mensaje = "Hola soy " + sNames + " y tengo " + ramdomAges + " años";
        return mensaje;
    }   
}

public class Zombie
{   //contructor de la clase 
    GameObject[] zombie = new GameObject[6];
    public void Create()
    {
        for (int i = 0; i < zombie.Length; i++)
        {   //inidice de alietoriedad de color  del script a la figura asignada "cubo"
            zombie[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            zombie[i].transform.position = new Vector3(Random.Range(-10, 11), 0, Random.Range(-10, 11));
            zombie[i].transform.GetComponent<MeshRenderer>().material.color = RandomCol();
        }
    }
    //asignando color y mensaje "soy un zombie color"  
    public Color RandomCol()
    {
        Color col = Color.black;

        switch (Random.Range(1, 3))
        {
            case 1://mensaje "soy un zombie (color designado)"  
                col = Color.cyan;
                Debug.Log("soy un Zombie color cyan");
                break;
            case 2://mensaje "soy un zombie (color designado)"  
                col = Color.magenta;
                Debug.Log("soy un Zombie color magenta");
                break;
            case 3://mensaje "soy un zombie (color designado)"  
                col = Color.green;
                Debug.Log("soy un Zombie color verde");
                break;
        }       return col;
    }
}