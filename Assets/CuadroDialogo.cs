using System.Collections;
using TMPro;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class CuadroDialogo : MonoBehaviour
{
    public TextMeshProUGUI text; 
    public Image image; 

  
    public RectTransform imageRectTransform; 
    public Transform characterTransform; 
    private Vector2 offset = new Vector2(1.0f, -1.0f); 

    private void Start()
    {
        imageRectTransform.gameObject.SetActive(false); 
    }

    void Update()
    {
        Vector2 characterPosition2D = new Vector2(characterTransform.position.x, characterTransform.position.y);

        Vector2 adjustedPosition = new Vector2(characterPosition2D.x + offset.x, characterPosition2D.y + offset.y);

        imageRectTransform.position = new Vector3(adjustedPosition.x - 0.4f, adjustedPosition.y + 1.1f, imageRectTransform.position.z);
    }

    public void mostrarCuadroDialogo(string mensaje)
    {
        text.text = mensaje;
        image.gameObject.SetActive(true);
        StartCoroutine(DesaparecerImagen());
    }

    private IEnumerator DesaparecerImagen()
    {
        yield return new WaitForSeconds(5);
        image.gameObject.SetActive(false);
    }


}
