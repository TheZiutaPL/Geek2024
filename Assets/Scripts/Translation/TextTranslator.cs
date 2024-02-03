using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace FlawareStudios.Translation
{
    [RequireComponent(typeof(TMP_Text))]
    public class TextTranslator : MonoBehaviour
    {
        private TMP_Text textHolder;
        [SerializeField] private string translationKey;
        [SerializeField] private bool subscribeToHandler;

        private void Awake()
        {
            textHolder = GetComponent<TMP_Text>();
        }

        private void OnEnable()
        {
            if (!subscribeToHandler)
                return;

            TranslationHandler.SubscribeTranslator(GetTranslation);
        }

        private void OnDisable()
        {
            if (!subscribeToHandler)
                return;

            TranslationHandler.UnsubscribeTranslator(GetTranslation);
        }

        private void Start()
        {
            GetTranslation();
        }

        private void GetTranslation() => textHolder.SetText(TranslationHandler.GetTextTranslation(translationKey));
    }
}
