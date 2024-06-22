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


}
