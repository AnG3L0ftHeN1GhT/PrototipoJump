using TMPro;
using UnityEngine;

public class HudManager : MonoBehaviour
{
    [SerializeField] TMP_Text textLife;
    public void updateLifes(int value)
    {
        textLife.text = value.ToString();
    }

}
