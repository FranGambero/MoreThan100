using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListGenerator : MonoBehaviour {
    public GameObject listItemPrefab; // Prefab del elemento de la lista
    public Transform contentPanel;    // Panel de contenido del Scroll View

    public List<Offer> list;

    void Start() {
        PopulateList(2);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)){
            PopulateList(3);
        }
    }

    void PopulateList(int num) {
        for (int i = 0; i < num; i++) // Número de elementos en la lista
        {
            GameObject newItem = Instantiate(listItemPrefab, contentPanel);
            newItem.GetComponent<OfferDisplay>().offer = list[i];
            // newItem.GetComponentInChildren<Text>().text = "Item " + i; // Asignar texto al elemento
        }
    }
}
