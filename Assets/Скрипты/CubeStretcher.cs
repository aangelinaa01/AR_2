using UnityEngine;
using UnityEngine.UI;

public class CubeStretcher : MonoBehaviour
{
    public Button turnOnPlusButton; 
    public Button turnOffButton;   
    public Button turnOnMinusButton; 

    public Animator animatorP; // Аниматор для объекта P
    public Animator animatorL; // Аниматор для объекта L

    private string currentAnimationP = ""; // Текущая анимация для объекта P
    private string currentAnimationL = ""; // Текущая анимация для объекта L

    private void Start()
    {
        // Инициализация кнопок
        turnOnPlusButton.onClick.AddListener(PlayTurnOnPlusAnimation);
        turnOffButton.onClick.AddListener(StopAnimation);
        turnOnMinusButton.onClick.AddListener(PlayTurnOnMinusAnimation);
    }

    // Метод для включения анимаций P1 и L2
    public void PlayTurnOnPlusAnimation()
    {
        animatorP.enabled = true; 
        animatorL.enabled = true; 

        animatorP.Play("P1", -1, 0f); 
        animatorL.Play("L2", -1, 0f); 

        currentAnimationP = "P1"; // Запоминаем текущую анимацию для P
        currentAnimationL = "L2"; // Запоминаем текущую анимацию для L
    }

    // Метод для включения анимаций P2 и L1
    public void PlayTurnOnMinusAnimation()
    {
        animatorP.enabled = true; 
        animatorL.enabled = true; 

        animatorP.Play("P2", -1, 0f); 
        animatorL.Play("L1", -1, 0f); 

        currentAnimationP = "P2"; // Запоминаем текущую анимацию для P
        currentAnimationL = "L1"; // Запоминаем текущую анимацию для L
    }

    // Метод для выключения анимаций
    public void StopAnimation()
    {
        animatorP.enabled = true; 
        animatorL.enabled = true; 

        // Проверяем текущую анимацию для P и воспроизводим соответствующую анимацию выключения
        if (currentAnimationP == "P1")
        {
            animatorP.Play("P3", -1, 0f); // Анимация выключения для P1
        }
        else if (currentAnimationP == "P2")
        {
            animatorP.Play("P4", -1, 0f); // Анимация выключения для P2
        }

        // Проверяем текущую анимацию для L и воспроизводим соответствующую анимацию выключения
        if (currentAnimationL == "L2")
        {
            animatorL.Play("L3", -1, 0f); // Анимация выключения для L2
        }
        else if (currentAnimationL == "L1")
        {
            animatorL.Play("L4", -1, 0f); // Анимация выключения для L1
        }

        // Сбрасываем текущие анимации
        currentAnimationP = "";
        currentAnimationL = "";
    }
}