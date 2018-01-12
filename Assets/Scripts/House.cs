using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * House script contains all the information for a single house, image, location, price will be used for displaying in the portfolio and during an auction
 */

public class House {

    private Sprite houseImage;

    House(Sprite image) {
        houseImage = image;
    }

    public Sprite HouseImage {
        get {
            return houseImage;
        }
    }
}
