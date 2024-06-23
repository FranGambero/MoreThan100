using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoDisplay : MonoBehaviour {
    public GameObject waitingPanel;

    public Offer selectedOffer;
    public OfferDisplay selectedOfferDisplay;

    public TextMeshProUGUI offerTitleText;
    public TextMeshProUGUI offerDescriptionText;
    public TextMeshProUGUI companyTitleText;
    public Image companyImage;

    public void LoadNewOffer(OfferDisplay newOfferDisplay) {

        waitingPanel.SetActive(false);

        selectedOfferDisplay = newOfferDisplay;
        selectedOffer = newOfferDisplay.offer;
        ShowInfo();
    }


    public void ShowInfo() {
        Debug.Log("La oferta seleccionda es " + selectedOffer.offerTitle);

        offerTitleText.text = selectedOffer.offerTitle;
        offerDescriptionText.text = selectedOffer.offerDescription;
        companyTitleText.text = selectedOffer.companyTitle;
        companyImage.sprite = selectedOffer.companyImage;
    }

    public void SendApplication() {
        if (true) {
            List<OfferDisplay> listStoredOffers = ListGenerator.instance.getListGeneratedOffers();
            Debug.Log("Ofertas antes de borrar " + listStoredOffers.Count);

            //for (int i = 0; i < listStoredOffers.Count - 1; i++) {
            //    Debug.Log("Almacenada la oferta " + listStoredOffers[i].offerTitle);
            //}

            ListGenerator.instance.removeOffer(selectedOfferDisplay);

            // waitingPanel.SetActive(true);

            Debug.Log("Ofertas después de borrar " + listStoredOffers.Count);

        }
    }
}
