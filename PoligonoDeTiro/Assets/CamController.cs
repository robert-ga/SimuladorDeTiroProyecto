using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CamController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject centerCam;
    public Transform tar;
    public float mover = 2f;

    void Start()
    {
        seguimientorostro();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        seguimientorostro();
    }
    public void seguimientorostro()
    {
        
        string msg = File.ReadAllText(@"C:/Users/Robert Gabriel/Desktop/Simulador de Tiro/DetectorDeRostro/DatosSalida.json");
        print(msg);
        
        if (!string.IsNullOrEmpty(msg))
        {
            string[] coordenadas = msg.Split(';');
            float x = float.Parse(coordenadas[0]) / 10;
            float y = float.Parse(coordenadas[1]) / 10;
            float z = float.Parse(coordenadas[2]) / 10;
            Vector3 f = centerCam.transform.position;
            f = new Vector3(x, y , z);
            tar.position = Vector3.Lerp(tar.position, f, mover * Time.deltaTime);

            //Vector3.Lerp();
            //Smooth Camera

        }
        
    }

}
