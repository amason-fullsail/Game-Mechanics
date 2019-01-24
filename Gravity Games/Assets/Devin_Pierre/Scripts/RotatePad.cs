using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePad : MonoBehaviour
{
    float rotate = 90f;
    [SerializeField] GameObject camera;
    [SerializeField] GameObject player;
    float lerpTimer = 1;
    Quaternion startRotationCamera, endRotationCamera;
    Quaternion startRotationPlayer, endRotationPlayer;
    [SerializeField]
    bool rotateClockwise = false;
    public RotationState rotationState;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && lerpTimer >= 1f)
        {
            camera.transform.SetParent(player.transform);
           // rotationState.Rotated = !rotationState.Rotated;
            player.GetComponent<CharacterMovement>().enabled = false;
            player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            player.transform.position = new Vector3(gameObject.transform.position.x, player.transform.position.y, gameObject.transform.position.z);
            lerpTimer = 0;
            startRotationCamera = camera.transform.rotation;
            endRotationCamera = startRotationCamera;
            //if(rotateClockwise) {
            //    endRotationCamera *= Quaternion.Euler(new Vector3(0, rotate * -1f, 0));
            //}
            //else {
            //    endRotationCamera *= Quaternion.Euler(new Vector3(0, rotate, 0));
            //}
            endRotationCamera *=  Quaternion.Euler(new Vector3(0, rotateClockwise ? rotate * -1f : rotate, 0)); //<-- TERNARY

            startRotationPlayer = player.transform.rotation;
            endRotationPlayer = startRotationPlayer;
            endRotationPlayer *= Quaternion.Euler(new Vector3(0, rotateClockwise ? rotate * -1f : rotate, 0));
        }
    }
    private void Update()
    {
        if (lerpTimer < 1)
        {
            lerpTimer += Time.deltaTime;
            //turnPoint.transform.rotation = Quaternion.Lerp(startRotationCamera, endRotationCamera, lerpTimer);
            player.transform.rotation = Quaternion.Lerp(startRotationPlayer, endRotationPlayer, lerpTimer);
            if (lerpTimer >= 1f)
            {
                player.GetComponent<CharacterMovement>().enabled = true;
                rotateClockwise = !rotateClockwise;
                camera.transform.SetParent(null);
            }

        }
    }
}
