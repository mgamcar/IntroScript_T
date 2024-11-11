

using UnityEngine;


public class MiPrimerScript : MonoBehaviour
{      
    public GameObject destino;
    Vector3 posicionDestino;

    
    void Start(){
        posicionDestino = destino.transform.position;
    }

    void Update(){
        posicionDestino = destino.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, posicionDestino, Time.deltaTime);

        //Rotacion
        transform.Rotate(Vector3.down * Time.deltaTime * 50);
    }


    
        
    
}
