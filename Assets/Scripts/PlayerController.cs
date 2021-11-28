using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f; //Velocidad del player en movimiento constante
    public float turnSpeed = 20.0f; //velociad de rotacion del player
    public float verticalInput; //variable usada para conectar el axis con mi condicion
    public float zMax = 450f; //limite d la pantalla 

    void Start()
    {
        transform.position = Vector3.zero; //preestablece la posicion del player al inico del game

    }
  
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical"); //ejecuta la union d la varable con los axis

        transform.Translate(Vector3.forward * speed * Time.deltaTime); //ejecuta el movimieto con la velocidad de "speed" 

        transform.Rotate(Vector3.left * turnSpeed * Time.deltaTime * verticalInput); //ejecuta el giro con la velocidad de "turnspeed"

        //Limite de pantalla donde el jueg acaba
        if (transform.position.z >= zMax)
        {
            Debug.Log("THE END");
            Time.timeScale = 0;
        }
    }
}
