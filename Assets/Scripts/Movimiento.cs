
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    int contador = 4;

    public GameObject itemFinal;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward * Time.deltaTime * 10);
        }
        
        if (Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Item"){
            Destroy(other.gameObject);
            contador--;
            if (contador == 0){
                itemFinal.SetActive(true);
            }
        }

        if (other.gameObject.tag == "Finish"){
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level1");
        }

        
    }




}
