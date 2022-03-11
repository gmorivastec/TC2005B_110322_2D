using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    // agregar elementos para hacerlo singleton
    public static GUIManager Instance {
        get;
        private set;
    }

    [SerializeField]
    private Text textito;
    
    [SerializeField]
    private Slider slidercito;

    
    // Start is called before the first frame update
    void Start()
    {
        // mecanismo correctivo de número de instancias
        if(Instance != null){
            Destroy(gameObject);
        } else {
            Instance = this;
        }

        // como evitar la destrucción de un objeto
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // métodos que escuchan cambios
    public void Botonazo() {

        textito.text = "BOTON PRESIONADO!";
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene("Segunda");
    }

    public void Sliderazo() {

        textito.text = "SLIDER: " + slidercito.value;
    }

    public void CerrarAplicacion() {

        Application.Quit();
    }
}
