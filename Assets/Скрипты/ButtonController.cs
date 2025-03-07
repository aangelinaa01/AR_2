using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject lamp; 
    public Material lampOnMaterial; 
    public Material lampOffMaterial; 

    public Lever leverScript; // Ссылка на скрипт Lever
    public CubeStretcher cubeStretcherScript; // Ссылка на скрипт CubeStretcher

    private bool isLampOn = false;

    private void Start()
    {
        // Отключаем скрипты при старте
        leverScript.enabled = false;
        cubeStretcherScript.enabled = false;
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject) 
                {
                    ToggleLamp(); 
                    leverScript.enabled = true; // Включаем скрипт Lever
                    cubeStretcherScript.enabled = true; // Включаем скрипт CubeStretcher
                }
            }
        }
    }

    private void ToggleLamp()
    {
        isLampOn = !isLampOn; 

        MeshRenderer lampRenderer = lamp.GetComponent<MeshRenderer>();
        if (lampRenderer != null)
        {
            lampRenderer.material = isLampOn ? lampOnMaterial : lampOffMaterial;
        }
    }
}