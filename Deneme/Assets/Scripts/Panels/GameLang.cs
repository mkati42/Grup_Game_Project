using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLang : MonoBehaviour
{
    public int langValue;
    public TextMeshProUGUI play, options, training, quit, language, menuVoice, gameVoice, mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("language"))
            langValue = PlayerPrefs.GetInt("language");
        else
            langValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        langValue = PlayerPrefs.GetInt("language");
        if (langValue == 0)
        {
            play.text = "OYNA";
            options.text = "AYARLAR";
            training.text = "EĞİTİM";
            quit.text = "ÇIKIŞ";
            language.text = "TÜRKÇE";
            menuVoice.text = "MENÜ SESİ";
            gameVoice.text = "OYUN SESİ";
            mainMenu.text = "ANA MENÜ";
        }
        else if (langValue == 1)
        {
            play.text = "PLAY";
            options.text = "SETTINGS";
            training.text = "TRAINING";
            quit.text = "QUIT";
            language.text = "ENGLISH";
            menuVoice.text = "MENU VOICE";
            gameVoice.text = "GAME VOICE";
            mainMenu.text = "MAIN MENU";
        }
        else if (langValue == 2)
        {
            play.text = "SPİELEN";
            options.text = "EİNSTELLUNGEN";
            training.text = "TRAİNİNG";
            quit.text = "BEENDEN";
            language.text = "DEUTSCH";
            menuVoice.text = "MENÜSTİMME";
            gameVoice.text = "SPİELSTİMME";
            mainMenu.text = "HAUPTMENÜ";
        }
        else if (langValue == 3)
        {
            play.text = "JOUER";
            options.text = "PARAMETRES";
            training.text = "ENTRAİNEMENT";
            quit.text = "QUITTER";
            language.text = "FRANÇAIS";
            menuVoice.text = "VOİX DE MENU";
            gameVoice.text = "VOİX DE JEU";
            mainMenu.text = "MENU PRİNCİPAL";
        }
        else if (langValue == 4)
        {
            play.text = "JUGAR";
            options.text = "CONFİGURACİON";
            training.text = "ENTRENAMİENTO";
            quit.text = "SALİR";
            language.text = "ESPANOL";
            menuVoice.text = "VOZ DEL MENU";
            gameVoice.text = "VOZ DEL JUEGO";
            mainMenu.text = "MENU PRİNCİPAL";
        }
    }
}
