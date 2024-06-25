using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OfferDisplay : MonoBehaviour
{

    public Offer offer;

    public TextMeshProUGUI offerTitleText;
    public TextMeshProUGUI companyTitleText;
    public Image companyImage;

    public InfoDisplay selectedOfferPanel;


    // Start is called before the first frame update
    void Start()
    {
        offerTitleText.text = offer.offerTitle;
        companyTitleText.text = offer.companyTitle;
        companyImage.sprite = offer.companyImage;
    }

    public void setOffer(Offer newOffer) {
        offer = newOffer;
    }

    public void setInfoDisplay(InfoDisplay selectedOfferPanel) {
        this.selectedOfferPanel = selectedOfferPanel;
    }

    public void loadOffer() {
        selectedOfferPanel.LoadNewOffer(this);
        // Debug.Log("La oferta a utilizar es " + offerTitleText.text);
    }

    public void deleteOfferInside() {
        ListGenerator.instance.removeOffer(this);
    }

}
