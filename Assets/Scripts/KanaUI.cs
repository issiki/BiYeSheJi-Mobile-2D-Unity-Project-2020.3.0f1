using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class KanaUI : MonoBehaviour
{
    public KanaGrid kanaGrid;
    [Header("µ±Ç°¼ÙÃû")]
    public string kana;
    [Header("ÂÞÂí×ÖÎÄ±¾")]
    public Text romajiText;
    [Header("¼ÙÃûÍ¼Æ¬")]
    public Image kanaImage;
    [Header("±ÊË³Í¼Æ¬")]
    public Image strokeImage;
    [Header("ÑÝ±äÍ¼Æ¬")]
    public Image devImage;
    [Header("a")]
    public Sprite a;
    public Sprite i;
    public Sprite u;
    public Sprite e;
    public Sprite o;

    public Sprite aStroke;
    public Sprite iStroke;
    public Sprite uStroke;
    public Sprite eStroke;
    public Sprite oStroke;

    public Sprite aDev;
    public Sprite iDev;
    public Sprite uDev;
    public Sprite eDev;
    public Sprite oDev;
    [Header("ka")]
    public Sprite ka;
    public Sprite ki;
    public Sprite ku;
    public Sprite ke;
    public Sprite ko;

    public Sprite kaStroke;
    public Sprite kiStroke;
    public Sprite kuStroke;
    public Sprite keStroke;
    public Sprite koStroke;

    public Sprite kaDev;
    public Sprite kiDev;
    public Sprite kuDev;
    public Sprite keDev;
    public Sprite koDev;
    [Header("sa")]
    public Sprite sa;
    public Sprite shi;
    public Sprite su;
    public Sprite se;
    public Sprite so;

    public Sprite saStroke;
    public Sprite shiStroke;
    public Sprite suStroke;
    public Sprite seStroke;
    public Sprite soStroke;

    public Sprite saDev;
    public Sprite shiDev;
    public Sprite suDev;
    public Sprite seDev;
    public Sprite soDev;
    [Header("ta")]
    public Sprite ta;
    public Sprite chi;
    public Sprite tsu;
    public Sprite te;
    public Sprite to;

    public Sprite taStroke;
    public Sprite chiStroke;
    public Sprite tsuStroke;
    public Sprite teStroke;
    public Sprite toStroke;

    public Sprite taDev;
    public Sprite chiDev;
    public Sprite tsuDev;
    public Sprite teDev;
    public Sprite toDev;
    [Header("na")]
    public Sprite na;
    public Sprite ni;
    public Sprite nu;
    public Sprite ne;
    public Sprite no;

    public Sprite naStroke;
    public Sprite niStroke;
    public Sprite nuStroke;
    public Sprite neStroke;
    public Sprite noStroke;

    public Sprite naDev;
    public Sprite niDev;
    public Sprite nuDev;
    public Sprite neDev;
    public Sprite noDev;
    [Header("ha")]
    public Sprite ha;
    public Sprite hi;
    public Sprite fu;
    public Sprite he;
    public Sprite ho;

    public Sprite haStroke;
    public Sprite hiStroke;
    public Sprite fuStroke;
    public Sprite heStroke;
    public Sprite hoStroke;

    public Sprite haDev;
    public Sprite hiDev;
    public Sprite fuDev;
    public Sprite heDev;
    public Sprite hoDev;
    [Header("ma")]
    public Sprite ma;
    public Sprite mi;
    public Sprite mu;
    public Sprite me;
    public Sprite mo;

    public Sprite maStroke;
    public Sprite miStroke;
    public Sprite muStroke;
    public Sprite meStroke;
    public Sprite moStroke;

    public Sprite maDev;
    public Sprite miDev;
    public Sprite muDev;
    public Sprite meDev;
    public Sprite moDev;
    [Header("ya")]
    public Sprite ya;
    public Sprite yu;
    public Sprite yo;

    public Sprite yaStroke;
    public Sprite yuStroke;
    public Sprite yoStroke;

    public Sprite yaDev;
    public Sprite yuDev;
    public Sprite yoDev;
    [Header("ra")]
    public Sprite ra;
    public Sprite ri;
    public Sprite ru;
    public Sprite re;
    public Sprite ro;

    public Sprite raStroke;
    public Sprite riStroke;
    public Sprite ruStroke;
    public Sprite reStroke;
    public Sprite roStroke;

    public Sprite raDev;
    public Sprite riDev;
    public Sprite ruDev;
    public Sprite reDev;
    public Sprite roDev;
    [Header("wa")]
    public Sprite wa;
    public Sprite wo;

    public Sprite waStroke;
    public Sprite woStroke;

    public Sprite waDev;
    public Sprite woDev;
    [Header("n")]
    public Sprite n;

    public Sprite nStroke;

    public Sprite nDev;

    [Header("a kata")]
    public Sprite aKata;
    public Sprite iKata;
    public Sprite uKata;
    public Sprite eKata;
    public Sprite oKata;

    public Sprite aKataStroke;
    public Sprite iKataStroke;
    public Sprite uKataStroke;
    public Sprite eKataStroke;
    public Sprite oKataStroke;

    public Sprite aKataDev;
    public Sprite iKataDev;
    public Sprite uKataDev;
    public Sprite eKataDev;
    public Sprite oKataDev;
    [Header("ka kata")]
    public Sprite kaKata;
    public Sprite kiKata;
    public Sprite kuKata;
    public Sprite keKata;
    public Sprite koKata;

    public Sprite kaKataStroke;
    public Sprite kiKataStroke;
    public Sprite kuKataStroke;
    public Sprite keKataStroke;
    public Sprite koKataStroke;

    public Sprite kaKataDev;
    public Sprite kiKataDev;
    public Sprite kuKataDev;
    public Sprite keKataDev;
    public Sprite koKataDev;
    [Header("sa kata")]
    public Sprite saKata;
    public Sprite shiKata;
    public Sprite suKata;
    public Sprite seKata;
    public Sprite soKata;

    public Sprite saKataStroke;
    public Sprite shiKataStroke;
    public Sprite suKataStroke;
    public Sprite seKataStroke;
    public Sprite soKataStroke;

    public Sprite saKataDev;
    public Sprite shiKataDev;
    public Sprite suKataDev;
    public Sprite seKataDev;
    public Sprite soKataDev;
    [Header("ta kata")]
    public Sprite taKata;
    public Sprite chiKata;
    public Sprite tsuKata;
    public Sprite teKata;
    public Sprite toKata;

    public Sprite taKataStroke;
    public Sprite chiKataStroke;
    public Sprite tsuKataStroke;
    public Sprite teKataStroke;
    public Sprite toKataStroke;

    public Sprite taKataDev;
    public Sprite chiKataDev;
    public Sprite tsuKataDev;
    public Sprite teKataDev;
    public Sprite toKataDev;
    [Header("na kata")]
    public Sprite naKata;
    public Sprite niKata;
    public Sprite nuKata;
    public Sprite neKata;
    public Sprite noKata;

    public Sprite naKataStroke;
    public Sprite niKataStroke;
    public Sprite nuKataStroke;
    public Sprite neKataStroke;
    public Sprite noKataStroke;

    public Sprite naKataDev;
    public Sprite niKataDev;
    public Sprite nuKataDev;
    public Sprite neKataDev;
    public Sprite noKataDev;
    [Header("ha kata")]
    public Sprite haKata;
    public Sprite hiKata;
    public Sprite fuKata;
    public Sprite heKata;
    public Sprite hoKata;

    public Sprite haKataStroke;
    public Sprite hiKataStroke;
    public Sprite fuKataStroke;
    public Sprite heKataStroke;
    public Sprite hoKataStroke;

    public Sprite haKataDev;
    public Sprite hiKataDev;
    public Sprite fuKataDev;
    public Sprite heKataDev;
    public Sprite hoKataDev;
    [Header("ma kata")]
    public Sprite maKata;
    public Sprite miKata;
    public Sprite muKata;
    public Sprite meKata;
    public Sprite moKata;

    public Sprite maKataStroke;
    public Sprite miKataStroke;
    public Sprite muKataStroke;
    public Sprite meKataStroke;
    public Sprite moKataStroke;

    public Sprite maKataDev;
    public Sprite miKataDev;
    public Sprite muKataDev;
    public Sprite meKataDev;
    public Sprite moKataDev;
    [Header("ya kata")]
    public Sprite yaKata;
    public Sprite yuKata;
    public Sprite yoKata;

    public Sprite yaKataStroke;
    public Sprite yuKataStroke;
    public Sprite yoKataStroke;

    public Sprite yaKataDev;
    public Sprite yuKataDev;
    public Sprite yoKataDev;
    [Header("ra kata")]
    public Sprite raKata;
    public Sprite riKata;
    public Sprite ruKata;
    public Sprite reKata;
    public Sprite roKata;

    public Sprite raKataStroke;
    public Sprite riKataStroke;
    public Sprite ruKataStroke;
    public Sprite reKataStroke;
    public Sprite roKataStroke;

    public Sprite raKataDev;
    public Sprite riKataDev;
    public Sprite ruKataDev;
    public Sprite reKataDev;
    public Sprite roKataDev;
    [Header("wa kata")]
    public Sprite waKata;
    public Sprite woKata;

    public Sprite waKataStroke;
    public Sprite woKataStroke;

    public Sprite waKataDev;
    public Sprite woKataDev;
    [Header("n kata")]
    public Sprite nKata;

    public Sprite nKataStroke;

    public Sprite nKataDev;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // GotoKana(kana);
    }

    public void GotoKana(string kana)
    {
        switch (kanaGrid.kanaType)
        {
            default:
                break;
            case KanaGrid.EKanaType.Hiragana:
                GotoHiragana(kana);
                break;
            case KanaGrid.EKanaType.Katakana:
                GotoKatakana(kana);
                break;
        }
    }

    void GotoHiragana(string kana)
    {
        switch (kana)
        {

            default:
                break;
            ///a
            case "":
            case "a":
                Set("a", a, aStroke, aDev);
                break;
            case "i":
                Set("i", i, iStroke, iDev);
                break;
            case "u":
                Set("u", u, uStroke, uDev);
                break;
            case "e":
                Set("e", e, eStroke, eDev);
                break;
            case "o":
                Set("o", o, oStroke, oDev);
                break;
            ///ka
            case "ka":
                Set("ka", ka, kaStroke, kaDev);
                break;
            case "ki":
                Set("ki", ki, kiStroke, kiDev);
                break;
            case "ku":
                Set("ku", ku, kuStroke, kuDev);
                break;
            case "ke":
                Set("ke", ke, keStroke, keDev);
                break;
            case "ko":
                Set("ko", ko, koStroke, koDev);
                break;
            ///sa
            case "sa":
                Set("sa", sa, saStroke, saDev);
                break;
            case "shi":
            case "si":
                Set("shi/si", shi, shiStroke, shiDev);
                break;
            case "su":
                Set("su", su, suStroke, suDev);
                break;
            case "se":
                Set("se", se, seStroke, seDev);
                break;
            case "so":
                Set("so", so, soStroke, soDev);
                break;
            ///ta
            case "ta":
                Set("ta", ta, taStroke, taDev);
                break;
            case "chi":
            case "ti":
                Set("chi/ti", chi, chiStroke, chiDev);
                break;
            case "tsu":
            case "tu":
                Set("tsu/tu", tsu, tsuStroke, tsuDev);
                break;
            case "te":
                Set("te", te, teStroke, teDev);
                break;
            case "to":
                Set("to", to, toStroke, toDev);
                break;
            ///na
            case "na":
                Set("na", na, naStroke, naDev);
                break;
            case "ni":
                Set("ni", ni, niStroke, niDev);
                break;
            case "nu":
                Set("nu", nu, nuStroke, nuDev);
                break;
            case "ne":
                Set("ne", ne, neStroke, neDev);
                break;
            case "no":
                Set("no", no, noStroke, noDev);
                break;
            ///ha
            case "ha":
                Set("ha", ha, haStroke, haDev);
                break;
            case "hi":
                Set("hi", hi, hiStroke, hiDev);
                break;
            case "fu":
            case "hu":
                Set("hu", fu, fuStroke, fuDev);
                break;
            case "he":
                Set("he", he, heStroke, heDev);
                break;
            case "ho":
                Set("ho", ho, hoStroke, hoDev);
                break;
            ///ma
            case "ma":
                Set("ma", ma, maStroke, maDev);
                break;
            case "mi":
                Set("mi", mi, miStroke, miDev);
                break;
            case "mu":
                Set("mu", mu, muStroke, muDev);
                break;
            case "me":
                Set("me", me, meStroke, meDev);
                break;
            case "mo":
                Set("mo", mo, moStroke, moDev);
                break;
            ///ya
            case "ya":
                Set("ya", ya, yaStroke, yaDev);
                break;
            case "yu":
                Set("yu", yu, yuStroke, yuDev);
                break;
            case "yo":
                Set("yo", yo, yoStroke, yoDev);
                break;
            ///ra
            case "ra":
                Set("ra", ra, raStroke, raDev);
                break;
            case "ri":
                Set("ri", ri, riStroke, riDev);
                break;
            case "ru":
                Set("ru", ru, ruStroke, ruDev);
                break;
            case "re":
                Set("re", re, reStroke, reDev);
                break;
            case "ro":
                Set("ro", ro, roStroke, roDev);
                break;
            ///wa
            case "wa":
                Set("wa", wa, waStroke, waDev);
                break;
            case "wo":
                Set("wo", wo, woStroke, woDev);
                break;
            ///n
            case "n":
                Set("n", n, nStroke, nDev);
                break;
        }
    }

    void GotoKatakana(string kana)
    {
        switch (kana)
        {
            case "":
            default:
                break;
            ///a
            case "a":
                Set("a", aKata, aKataStroke, aKataDev);
                break;
            case "i":
                Set("i", iKata, iKataStroke, iKataDev);
                break;
            case "u":
                Set("u", uKata, uKataStroke, uKataDev);
                break;
            case "e":
                Set("e", eKata, eKataStroke, eKataDev);
                break;
            case "o":
                Set("o", oKata, oKataStroke, oKataDev);
                break;
            ///ka
            case "ka":
                Set("ka", kaKata, kaKataStroke, kaKataDev);
                break;
            case "ki":
                Set("ki", kiKata, kiKataStroke, kiKataDev);
                break;
            case "ku":
                Set("ku", kuKata, kuKataStroke, kuKataDev);
                break;
            case "ke":
                Set("ke", keKata, keKataStroke, keKataDev);
                break;
            case "ko":
                Set("ko", koKata, koKataStroke, koKataDev);
                break;
            ///sa
            case "sa":
                Set("sa", saKata, saKataStroke, saKataDev);
                break;
            case "shi":
            case "si":
                Set("shi/si", shiKata, shiKataStroke, shiKataDev);
                break;
            case "su":
                Set("su", suKata, suKataStroke, suKataDev);
                break;
            case "se":
                Set("se", seKata, seKataStroke, seKataDev);
                break;
            case "so":
                Set("so", soKata, soKataStroke, soKataDev);
                break;
            ///ta
            case "ta":
                Set("ta", taKata, taKataStroke, taKataDev);
                break;
            case "chi":
            case "ti":
                Set("chi/ti", chiKata, chiKataStroke, chiKataDev);
                break;
            case "tsu":
            case "tu":
                Set("tsu/tu", tsuKata, tsuKataStroke, tsuKataDev);
                break;
            case "te":
                Set("te", teKata, teKataStroke, teKataDev);
                break;
            case "to":
                Set("to", toKata, toKataStroke, toKataDev);
                break;
            ///na
            case "na":
                Set("na", naKata, naKataStroke, naKataDev);
                break;
            case "ni":
                Set("ni", niKata, niKataStroke, niKataDev);
                break;
            case "nu":
                Set("nu", nuKata, nuKataStroke, nuKataDev);
                break;
            case "ne":
                Set("ne", neKata, neKataStroke, neKataDev);
                break;
            case "no":
                Set("no", noKata, noKataStroke, noKataDev);
                break;
            ///ha
            case "ha":
                Set("ha", haKata, haKataStroke, haKataDev);
                break;
            case "hi":
                Set("hi", hiKata, hiKataStroke, hiKataDev);
                break;
            case "fu":
            case "hu":
                Set("hu", fuKata, fuKataStroke, fuKataDev);
                break;
            case "he":
                Set("he", heKata, heKataStroke, heKataDev);
                break;
            case "ho":
                Set("ho", hoKata, hoKataStroke, hoKataDev);
                break;
            ///ma
            case "ma":
                Set("ma", maKata, maKataStroke, maKataDev);
                break;
            case "mi":
                Set("mi", miKata, miKataStroke, miKataDev);
                break;
            case "mu":
                Set("mu", muKata, muKataStroke, muKataDev);
                break;
            case "me":
                Set("me", meKata, meKataStroke, meKataDev);
                break;
            case "mo":
                Set("mo", moKata, moKataStroke, moKataDev);
                break;
            ///ya
            case "ya":
                Set("ya", yaKata, yaKataStroke, yaKataDev);
                break;
            case "yu":
                Set("yu", yuKata, yuKataStroke, yuKataDev);
                break;
            case "yo":
                Set("yo", yoKata, yoKataStroke, yoKataDev);
                break;
            ///ra
            case "ra":
                Set("ra", raKata, raKataStroke, raKataDev);
                break;
            case "ri":
                Set("ri", riKata, riKataStroke, riKataDev);
                break;
            case "ru":
                Set("ru", ruKata, ruKataStroke, ruKataDev);
                break;
            case "re":
                Set("re", reKata, reKataStroke, reKataDev);
                break;
            case "ro":
                Set("ro", roKata, roKataStroke, roKataDev);
                break;
            ///wa
            case "wa":
                Set("wa", waKata, waKataStroke, waKataDev);
                break;
            case "wo":
                Set("wo", woKata, woKataStroke, woKataDev);
                break;
            ///n
            case "n":
                Set("n", nKata, nKataStroke, nKataDev);
                break;
        }
    }

    void Set(string romaji, Sprite kana, Sprite stroke, Sprite dev)
    {
        romajiText.text = romaji;
        kanaImage.sprite = kana;
        strokeImage.sprite = stroke;
        devImage.sprite = dev;
    }
}
