using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{


    public Transform Sol;
    public Transform Satelite1;
    public Transform Satelite2;
    public Transform CameraControl;


    public bool verLineas;
    public bool verLookAt;




    private Vector3 Centro = new Vector3(0,0,0);





    // Start is called before the first frame update
    void Start()
    {
        Sol.position = Centro + new Vector3(0,0,10);
        Satelite1.localPosition = Sol.position + new Vector3(0,0,5);
        Satelite2.localPosition = Satelite1.localPosition + new Vector3(0,0,2);
    }

    // Update is called once per frame
    void Update()
    {
        

        Sol.RotateAround(Centro, Vector3.up, 10f * Time.deltaTime );
        Satelite1.RotateAround(Sol.position,Vector3.up, 45f * Time.deltaTime);
        Satelite2.RotateAround(Satelite1.position, Vector3.right, 90f * Time.deltaTime);


        Sol.LookAt(Centro);
        Satelite1.LookAt(Sol.position);
        Satelite2.LookAt(Satelite1.position);
        CameraControl.LookAt(Sol.position);
        





        if (verLookAt)
        {
            LookAtEnable();
        }
        if (verLineas)
        {
            Verlineas();
        }

    }

    public void LookAtEnable()
    {
        Debug.DrawRay(Sol.position, Sol.forward * 2, Color.blue);
        Debug.DrawRay(Sol.position, Sol.right * 2, Color.red);
        Debug.DrawRay(Sol.position, Sol.up * 2, Color.green);

        Debug.DrawRay(Satelite1.position, Satelite1.forward, Color.blue);
        Debug.DrawRay(Satelite1.position, Satelite1.right, Color.red);
        Debug.DrawRay(Satelite1.position, Satelite1.up, Color.green);

        Debug.DrawRay(Satelite2.position, Satelite2.forward, Color.blue);
        Debug.DrawRay(Satelite2.position, Satelite2.right, Color.red);
        Debug.DrawRay(Satelite2.position, Satelite2.up, Color.green);

    }
    public void Verlineas()
    {
        Debug.DrawLine(Sol.position, Centro, Color.black);
        Debug.DrawLine(Sol.position, Satelite1.position, Color.yellow);
        Debug.DrawLine(Sol.position, Satelite2.position, Color.cyan);
        Debug.DrawLine(Satelite1.position, Satelite2.position, Color.white);
    }


}
