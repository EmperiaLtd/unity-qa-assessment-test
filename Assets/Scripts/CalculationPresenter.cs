using System.Globalization;
using TMPro;
using UnityEngine;

public sealed class CalculationPresenter : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TextMeshProUGUI text;

    public void OnButtonClick()
    {
        var answer = FactorialCalculator.CalculateFactorial(int.Parse(inputField.text));
        text.SetText(answer.ToString(CultureInfo.InvariantCulture));
    }
}