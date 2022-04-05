using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public sealed class CalculationPresenter : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI text;

    private FactorialCalculator _calculator;

    private void Start() => _calculator = new FactorialCalculator();

    public void OnButtonClick()
    {
        var answer = _calculator.CalculateFactorial(int.Parse(inputField.text));
        text.SetText(answer.ToString(CultureInfo.InvariantCulture));
    }
}