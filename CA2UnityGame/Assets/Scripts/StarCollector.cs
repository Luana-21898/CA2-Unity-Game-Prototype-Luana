using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarCollector : MonoBehaviour
{
    int stars = 0;

    [SerializeField] Text starsText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == ("Star"))
        {
            Destroy(other.gameObject);
            stars++;
            starsText.text = "Stars: " + stars;
        }
    }
}
