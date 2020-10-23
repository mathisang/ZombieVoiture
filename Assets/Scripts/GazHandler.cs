using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GazHandler : MonoBehaviour
{
    public float GazRessourcesInitial = 100;
    private float GazRessources;
    public float GazRemoveDelay = 5;
    public Text GazText;

    void Start() {
                GazRessources = GazRessourcesInitial;
                GazText.text = "Gaz : " +  (int)GazRessources;
            }

    public void AddGaz() {
                GazRessources = GazRessources + GazRessourcesInitial/10;
             }

    public void RemoveGaz() {
                GazRessources = GazRessources - GazRessourcesInitial/10;
             }

       // Update is called once per frame
       void Update()
       {
       if(GazRessources > GazRessourcesInitial){
       GazRessources = GazRessourcesInitial;
       }
           GazRessources -= Time.deltaTime/GazRemoveDelay;
           GazText.text = "Gaz : " +  (int)GazRessources;

           if(GazRessources <= 0){
           SceneManager.LoadScene("Endscreen");
           }
       }
}
