using UnityEngine;
using System.Collections;

public class Giroscopio : MonoBehaviour {

    public GameObject VRCamaras;

    private float PosicionInicialY;
    private float PosicionGiroscopioY;
    private float CalibrarPosicionY;

    bool InicioJuego;

    void Start()
    {
        Input.gyro.enabled = true;
        PosicionGiroscopioY = VRCamaras.transform.eulerAngles.y;
    }

    void Update () {
        AplicarRotacionGiroscopio();
        AplicaCalibracion();
        if (InicioJuego == true)
        {
            Invoke("CalibrarEnY", 3f);
            InicioJuego = false;
        }
	}

    void AplicarRotacionGiroscopio()
    {
        VRCamaras.transform.rotation = Input.gyro.attitude;
        VRCamaras.transform.Rotate(0f, 0f, 180f, Space.Self);
        VRCamaras.transform.Rotate(90f, 180f, 0f, Space.World);
        PosicionGiroscopioY = VRCamaras.transform.eulerAngles.y;
    }

    void CalibraEnY()
    {
        CalibrarPosicionY = PosicionGiroscopioY - PosicionInicialY;
    }

    void AplicaCalibracion()
    {
        VRCamaras.transform.Rotate(0f, -CalibrarPosicionY, 0f, Space.World);
    }
}
