using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;//le hace dependiente del objeto qeu selecciones en unity
    public Vector3 offset = new Vector3(60, 3, 0); //vector d posisicion d la camara

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
