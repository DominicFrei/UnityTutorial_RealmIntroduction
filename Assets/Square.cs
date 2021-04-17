using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Realms;

public class Square : MonoBehaviour
{
    private ColorEntity squareColor;
    private Realm realm;

    private void Awake()
    {
        realm = Realm.GetInstance();
        squareColor = realm.Find<ColorEntity>("square");
        if (squareColor == null)
        {
            squareColor = new ColorEntity("square");
            realm.Write(() => {
                realm.Add(squareColor);
            });
        }
        SetColor();
    }

    private void OnMouseDown()
    {
        realm.Write(() => {
            squareColor.Red = Random.Range(0f, 1f);
            squareColor.Green = Random.Range(0f, 1f);
            squareColor.Blue = Random.Range(0f, 1f);
        });
        SetColor();
    }

    private void SetColor()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(squareColor.Red, squareColor.Green, squareColor.Blue);
    }
}
