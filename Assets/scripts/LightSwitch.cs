using UnityEngine;
using UnityEngine.UI;

public class LightSwitch : MonoBehaviour
{
    public Light lightSource; // —сылка на компонент света
    public GameObject Lampa;

    private void OnMouseDown()
    {
        if (lightSource.gameObject.activeSelf)
        {
            lightSource.gameObject.SetActive(false);
            Lampa.GetComponent<Renderer>().material.color = Color.grey;
        }
        else
        {
            lightSource.gameObject.SetActive(true);
            Lampa.GetComponent<Renderer>().material.color = Color.white;
        }
    }    

}
