using System;
using System.Collections;
using UnityEngine;

using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;
public class VoiceRecognition : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("forward", () =>
        {
            // action to be performed when this keyword is spoken
            transform.Translate(1,0,0);
        });
       
        keywords.Add("up", () =>
        {
            transform.Translate(0,1,0);
        });
       
       
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        // if the keyword recognized is in our dictionary, call that Action.
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }

    // private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    // {
    //     Debug.Log(speech.text);
    //     action[speech.text].Invoke();
    // }


}
