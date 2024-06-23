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

    public void ShowInfo() {
        Debug.Log("La oferta seleccionda es " + selectedOffer.offerTitle);
    }
}
