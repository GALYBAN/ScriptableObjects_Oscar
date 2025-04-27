using UnityEngine;

[CreateAssetMenu(fileName = "TranslationData", menuName = "ScriptableObjects/TranslationData")]
public class TranslationData : ScriptableObject
{
    [System.Serializable]
    public class Translation
    {
        public string english;
        public string spanish;
        public string french;
    }

    public Translation[] translations;
} 