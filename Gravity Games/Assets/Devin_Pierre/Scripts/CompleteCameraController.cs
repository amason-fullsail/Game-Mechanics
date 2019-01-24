using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCameraController : MonoBehaviour
{

    public GameObject Player;
    private Vector3 offset;
   
    
    private Vector3 notRotated = new Vector3(0,0,0);
    private Vector3 Rotated = new Vector3(0, -90, 0);


    // Start is called before the first frame update
    void Start()
    {
        //offset = transform.position - Player.transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.parent == null)
        {
            Vector3 relativePosition = gameObject.transform.InverseTransformPoint(Player.transform.position);
            relativePosition.z -= 20;
            relativePosition.y += 5;
            transform.localPosition = Vector3.MoveTowards(transform.position, gameObject.transform.TransformPoint(relativePosition), 5f * Time.deltaTime);
        }
        /* if (rotationState.Rotated == false)
         {
             Debug.Log("NotRotated");
             Vector3 PlayerX = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
             transform.position = PlayerX;

         }

         else//(turnpoint.transform.rotation.eulerAngles.y == -90)
         {
             Debug.Log("rotated");
             Vector3 PlayerZ = new Vector3(transform.position.x, transform.position.y, Player.transform.position.z);
             transform.position = PlayerZ;
         }*/
        //if (turnpoint.transform.rotation.eulerAngles == notRotated || turnpoint.transform.rotation.eulerAngles.y == -180)
        //{
        //    Debug.Log("NotRotated");
        //    Vector3 PlayerX = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
        //    transform.position = PlayerX;

        //}

        //else//(turnpoint.transform.rotation.eulerAngles.y == -90)
        //{
        //    Debug.Log("rotated");
        //    Vector3 PlayerZ = new Vector3(transform.position.x, transform.position.y, Player.transform.position.z);
        //    transform.position = PlayerZ;
        //}

    }
}
