using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    private int counter = 0;
    public int Counter => counter; // Propiedad para acceder al contador
    public TextMeshProUGUI timerText;

    private void Start() {
        // Iniciar la corrutina que maneja el contador
        StartCoroutine(IncrementCounter());
    }

    private IEnumerator IncrementCounter() {
        while (true) {
            // Primer intervalo: 1 unidad por segundo durante X segundos
            for (int i = 0; i < 10; i++) {
                yield return new WaitForSeconds(1);
                counter += 1;
                timerText.text = counter + " solicitudes";

                if (counter > 100) {
                    OnCounterReachedLimit();
                    yield break;
                }
                //Debug.Log("Counter: " + counter);
            }

            // Segundo intervalo: 3 unidades por segundo durante 7 segundos
            for (int i = 0; i < 5; i++) {
                yield return new WaitForSeconds(1);
                counter += 3;
                timerText.text = counter + " solicitudes";

                if (counter > 100) {
                    OnCounterReachedLimit();
                    yield break;
                }
                //Debug.Log("Counter: " + counter);
            }

            // Tercer intervalo: 10 unidades por segundo durante 5 segundos
            for (int i = 0; i < 5; i++) {
                yield return new WaitForSeconds(1);
                counter += 2;
                timerText.text = counter + " solicitudes";

                if (counter > 100) {
                    OnCounterReachedLimit();
                    yield break;
                }
                //Debug.Log("Counter: " + counter);
            }

            // Cuarto intervalo: 3 unidades por segundo durante 3 segundos
            for (int i = 0; i < 6; i++) {
                yield return new WaitForSeconds(1);
                counter += 5;
                timerText.text = counter + " solicitudes";

                if (counter > 100) {
                    OnCounterReachedLimit();
                    yield break;
                }
                //Debug.Log("Counter: " + counter);
            }

            for (int i = 0; i < 4; i++) {
                yield return new WaitForSeconds(1);
                counter += 4;
                timerText.text = counter + " solicitudes";

                if (counter > 100) {
                    OnCounterReachedLimit();
                    yield break;
                }
                //Debug.Log("Counter: " + counter);
            }

            for (int i = 0; i < 10; i++) {
                yield return new WaitForSeconds(1);
                counter += 3;
                timerText.text = counter + " solicitudes";

                if (counter > 100) {
                    OnCounterReachedLimit();
                    yield break;
                }
                //Debug.Log("Counter: " + counter);
            }



            // Repetir el ciclo
        }

    }
        private void OnCounterReachedLimit() {
        timerText.text = "MÁS DE 100 SOLICITUDES!!";
    }


      // fin clase




    /*
    private float timeOn;
    public float maxTime;
    private float timeModifier;

    public TextMeshProUGUI timerText;

    private void Start() {
        timeModifier = 1; // (float)ListGenerator.instance.getListGeneratedOffers().Count;
        Debug.LogWarning("eL TIME MODIFIER ES " + timeModifier);
    }

    private void Update() {
        if(timeOn < maxTime) {
            timeOn += Time.deltaTime;
            updateTimer(timeOn);
        }
    }

    private void updateTimer(float currentTime) {
        // float timeModifier = ListGenerator.instance.getListGeneratedOffers().Count / 2;

        changeModifier();


        // no va es expected
        //currentTime += valueToAdd;


        timerText.text = (currentTime) + " solicitudes";

    }

    void changeModifier() {
        if(timeOn < 10) {
            timeModifier = 2;
        } else if (timeOn >= 10 && timeOn < 15) {
            timeModifier = 10;
        }                     else {
            timeModifier = 30;
        }
    }
     */
}
