using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LanguageManager : MonoBehaviour
{
    public TranslationData translationData;
    public TextMeshProUGUI[] uiTexts;
    
    private enum Language { English, Spanish, French }
    private Language currentLanguage = Language.English;

    public void SwitchToEnglish()
    {
        currentLanguage = Language.English;
        UpdateTexts();
    }

    public void SwitchToSpanish()
    {
        currentLanguage = Language.Spanish;
        UpdateTexts();
    }

    public void SwitchToFrench()
    {
        currentLanguage = Language.French;
        UpdateTexts();
    }

    private void UpdateTexts()
    {
        for (int i = 0; i < uiTexts.Length && i < translationData.translations.Length; i++)
        {
            switch (currentLanguage)
            {
                case Language.English:
                    uiTexts[i].text = translationData.translations[i].english;
                    break;
                case Language.Spanish:
                    uiTexts[i].text = translationData.translations[i].spanish;
                    break;
                case Language.French:
                    uiTexts[i].text = translationData.translations[i].french;
                    break;
            }
        }
    }
} 