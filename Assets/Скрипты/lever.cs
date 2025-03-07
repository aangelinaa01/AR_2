using UnityEngine;
using UnityEngine.UI;

public class Lever : MonoBehaviour
{
    public Button turnOnPlusButton; 
    public Button turnOffButton;    
    public Button turnOnMinusButton; 

    public Animator animator;

    private string currentAnimation = "";

    private void Start()
    {
        animator.enabled = false;

        turnOnPlusButton.onClick.AddListener(PlayTurnOnAnimation);
        turnOffButton.onClick.AddListener(StopAnimation);
        turnOnMinusButton.onClick.AddListener(PlayTurnOn2Animation);
    }

    public void PlayTurnOnAnimation()
    {
        animator.enabled = true; 
        animator.Play("ON", -1, 0f); 
        currentAnimation = "ON"; // Запоминаем текущую анимацию
    }

    public void StopAnimation()
    {
        animator.enabled = true; 

        // Проверяем текущую анимацию и воспроизводим соответствующую анимацию OFF
        if (currentAnimation == "ON")
        {
            animator.Play("OFF", -1, 0f); 
        }
        else if (currentAnimation == "ON2")
        {
            animator.Play("OFF2", -1, 0f); 
        }

        currentAnimation = ""; // Сбрасываем текущую анимацию
    }
    
    public void PlayTurnOn2Animation()
    {
        animator.enabled = true; 
        animator.Play("ON2", -1, 0f); 
        currentAnimation = "ON2"; // Запоминаем текущую анимацию
    }
}