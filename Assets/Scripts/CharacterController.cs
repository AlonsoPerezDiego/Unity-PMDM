using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class CharacterController : MonoBehaviour {

    public float speed;
    public Text WinText, WinText2;
    private float timeMovement, angle;
    public GameObject character;

    void Start () {
        WinText.text = "";
        WinText2.text = "";
        timeMovement = 0.0f;
    }
    
    void Update()
    {
        timeMovement = timeMovement + 1 * Time.deltaTime;

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("VictoryCube"))
        {
            other.gameObject.SetActive(false);
            speed = 0;
            WinText.text = "Congratulations!\n" + timeMovement + "sec.";
            WinText2.text = "Congratulations!\n" + timeMovement + "sec.";
        }
    }

    internal void Move(Vector3 vector3)
    {
        throw new NotImplementedException();
    }
}
