using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoDisplay : MonoBehaviour
{
    public Offer selectedOffer;

    public TextMeshProUGUI offerTitleText;
    public TextMeshProUGUI offerDescriptionText;
    public TextMeshProUGUI companyTitleText;
    public Image companyImage;

    public void LoadNewOffer(Offer newOffer) {
        selectedOffer = newOffer;
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
            List<OfferDisplay> lista = ListGenerator.instance.getListGeneratedOffers();

            for (int i = 0; i < lista.Count - 1; i++) {
                Debug.Log("Almacenada la oferta " + lista[i].offerTitleText.text);
            }

        }
    }
}
