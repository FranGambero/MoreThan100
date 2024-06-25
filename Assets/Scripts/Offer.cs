using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Offer", menuName = "cOffer")]
public class Offer : ScriptableObject
{
    public enum jobRole {
        gamedesign, programming, art, production
    }

    public string offerTitle;
    public string offerDescription;
    public jobRole offerJobRole;
    public string companyTitle;
    public Sprite companyImage;

}
