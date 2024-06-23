using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListGenerator : MonoBehaviour {
    public OfferDisplay listItemPrefab; // Prefab del elemento de la lista
    public Transform contentPanel;    // Panel de contenido del Scroll View

    public InfoDisplay infoDisplay;

    public List<Offer> originalOfferList;
    private List<Offer> shuffledList;
    private int currentIndex = 0;

    void Start() {
        mergeElements();
        PopulateList(2);

    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)){
            PopulateList(3);
        }
    }
           /*
    void PopulateList(int num) {
        for (int i = 0; i < num; i++) // N�mero de elementos en la lista
        {
            OfferDisplay newItem = Instantiate(listItemPrefab, contentPanel);
            newItem.offer = originalOfferList[i];

            newItem.setInfoDisplay(infoDisplay);

            // newItem.GetComponentInChildren<Text>().text = "Item " + i; // Asignar texto al elemento
        }
    }
           */

    void mergeElements() {
        shuffledList = originalOfferList;

          for(int i = shuffledList.Count -1; i > 0; i--) {
            int j = Random.Range(0, 1 + i);
            Offer temp = shuffledList[i];
            shuffledList[i] = shuffledList[j];
            shuffledList[j] = temp;
        }

        currentIndex = 0;
    }

    public Offer GetNextOffer() {
          if(currentIndex >= shuffledList.Count) {
            mergeElements();
        }

        Offer nextOffer = shuffledList[currentIndex];
        currentIndex++;

        return nextOffer;
    }

    void PopulateList(int numOffers) {

        while(numOffers > 0) {
            OfferDisplay newItem = Instantiate(listItemPrefab, contentPanel);
            newItem.setOffer(GetNextOffer());
            newItem.setInfoDisplay(infoDisplay);

            numOffers--;
        }


    }
}
