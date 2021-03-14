using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class KanaUI : MonoBehaviour
{
    public KanaGrid kanaGrid;
    public string romaji;

    [Header("ÂÞÂí×ÖÎÄ±¾")]
    public Text romajiText;
    [Header("¼ÙÃûÍ¼Æ¬")]
    public Image kanaImage;
    [Header("±ÊË³Í¼Æ¬")]
    public Image strokeImage;
    [Header("ÑÝ±äÍ¼Æ¬")]
    public Image devImage;

    [Header("a")]
    public KanaUICard a;
    public KanaUICard i;
    public KanaUICard u;
    public KanaUICard e;
    public KanaUICard o;
    [Header("ka")]
    public KanaUICard ka;
    public KanaUICard ki;
    public KanaUICard ku;
    public KanaUICard ke;
    public KanaUICard ko;
    [Header("sa")]
    public KanaUICard sa;
    public KanaUICard shi;
    public KanaUICard su;
    public KanaUICard se;
    public KanaUICard so;
    [Header("ta")]
    public KanaUICard ta;
    public KanaUICard chi;
    public KanaUICard tsu;
    public KanaUICard te;
    public KanaUICard to;
    [Header("na")]
    public KanaUICard na;
    public KanaUICard ni;
    public KanaUICard nu;
    public KanaUICard ne;
    public KanaUICard no;
    [Header("ha")]
    public KanaUICard ha;
    public KanaUICard hi;
    public KanaUICard fu;
    public KanaUICard he;
    public KanaUICard ho;
    [Header("ma")]
    public KanaUICard ma;
    public KanaUICard mi;
    public KanaUICard mu;
    public KanaUICard me;
    public KanaUICard mo;
    [Header("ya")]
    public KanaUICard ya;
    public KanaUICard yu;
    public KanaUICard yo;
    [Header("ra")]
    public KanaUICard ra;
    public KanaUICard ri;
    public KanaUICard ru;
    public KanaUICard re;
    public KanaUICard ro;
    [Header("wa")]
    public KanaUICard wa;
    public KanaUICard wo;
    [Header("n")]
    public KanaUICard n;

    /*
    [Header("Æ¬¼ÙÃû")]
    [Header("a")]
    public KanaUICard aKata;
    public KanaUICard iKata;
    public KanaUICard uKata;
    public KanaUICard eKata;
    public KanaUICard oKata;
    [Header("ka")]
    public KanaUICard kaKata;
    public KanaUICard kiKata;
    public KanaUICard kuKata;
    public KanaUICard keKata;
    public KanaUICard koKata;
    [Header("sa")]
    public KanaUICard saKata;
    public KanaUICard shiKata;
    public KanaUICard suKata;
    public KanaUICard seKata;
    public KanaUICard soKata;
    [Header("ta")]
    public KanaUICard taKata;
    public KanaUICard chiKata;
    public KanaUICard tsuKata;
    public KanaUICard teKata;
    public KanaUICard toKata;
    [Header("na")]
    public KanaUICard naKata;
    public KanaUICard niKata;
    public KanaUICard nuKata;
    public KanaUICard neKata;
    public KanaUICard noKata;
    [Header("ha")]
    public KanaUICard haKata;
    public KanaUICard hiKata;
    public KanaUICard fuKata;
    public KanaUICard heKata;
    public KanaUICard hoKata;
    [Header("ma")]
    public KanaUICard maKata;
    public KanaUICard miKata;
    public KanaUICard muKata;
    public KanaUICard meKata;
    public KanaUICard moKata;
    [Header("ya")]
    public KanaUICard yaKata;
    public KanaUICard yuKata;
    public KanaUICard yoKata;
    [Header("ra")]
    public KanaUICard raKata;
    public KanaUICard riKata;
    public KanaUICard ruKata;
    public KanaUICard reKata;
    public KanaUICard roKata;
    [Header("wa")]
    public KanaUICard waKata;
    public KanaUICard woKata;
    [Header("n")]
    public KanaUICard nKata;
    */

    /*

    [Header("µ±Ç°¼ÙÃû")]
    public string kana;
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
    */
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RenderKana();
    }

    public void RenderKana()
    {
        switch (romaji)
        {
            default:
            case "":
            ///a
            case "a":
                Set(romaji, a);
                break;
            case "i":
                Set(romaji, i);
                break;
            case "u":
                Set(romaji, u);
                break;
            case "e":
                Set(romaji, e);
                break;
            case "o":
                Set(romaji, o);
                break;
            ///ka
            case "ka":
                Set(romaji, ka);
                break;
            case "ki":
                Set(romaji, ki);
                break;
            case "ku":
                Set(romaji, ku);
                break;
            case "ke":
                Set(romaji, ke);
                break;
            case "ko":
                Set(romaji, ko);
                break;
            ///sa
            case "sa":
                Set(romaji, sa);
                break;
            case "shi/si":
            case "shi":
            case "si":
                Set(romaji, shi);
                break;
            case "su":
                Set(romaji, su);
                break;
            case "se":
                Set(romaji, se);
                break;
            case "so":
                Set(romaji, so);
                break;
            ///ta
            case "ta":
                Set(romaji, ta);
                break;
            case "chi/ti":
            case "chi":
            case "ti":
                Set(romaji, chi);
                break;
            case "tsu/tu":
            case "tsu":
            case "tu":
                Set(romaji, tsu);
                break;
            case "te":
                Set(romaji, te);
                break;
            case "to":
                Set(romaji, to);
                break;
            ///na
            case "na":
                Set(romaji, na);
                break;
            case "ni":
                Set(romaji, ni);
                break;
            case "nu":
                Set(romaji, nu);
                break;
            case "ne":
                Set(romaji, ne);
                break;
            case "no":
                Set(romaji, no);
                break;
            ///ha
            case "ha":
                Set(romaji, ha);
                break;
            case "hi":
                Set(romaji, hi);
                break;
            case "fu/hu":
            case "fu":
            case "hu":
                Set(romaji, fu);
                break;
            case "he":
                Set(romaji, he);
                break;
            case "ho":
                Set(romaji, ho);
                break;
            ///ma
            case "ma":
                Set(romaji, ma);
                break;
            case "mi":
                Set(romaji, mi);
                break;
            case "mu":
                Set(romaji, mu);
                break;
            case "me":
                Set(romaji, me);
                break;
            case "mo":
                Set(romaji, mo);
                break;
            ///ya
            case "ya":
                Set(romaji, ya);
                break;
            case "yu":
                Set(romaji, yu);
                break;
            case "yo":
                Set(romaji, yo);
                break;
            ///ra
            case "ra":
                Set(romaji, ra);
                break;
            case "ri":
                Set(romaji, ri);
                break;
            case "ru":
                Set(romaji, ru);
                break;
            case "re":
                Set(romaji, re);
                break;
            case "ro":
                Set(romaji, ro);
                break;
            ///wa
            case "wa":
                Set(romaji, wa);
                break;
            case "wo":
            case "(w)o":
                Set(romaji, wo);
                break;
            ///n
            case "n":
                Set(romaji, n);
                break;

        }
    }

    public void GotoKana(string romaji)
    {
        this.romaji = romaji;
        RenderKana();
    }

    public void SetKana(string romaji)
    {
        this.romaji = romaji;
        /*
        switch (kanaGrid.kanaType)
        {
            default:
                break;
            case KanaGrid.EKanaType.Hiragana:
                //GotoHiragana(kana);
                Set(kana,)
                break;
            case KanaGrid.EKanaType.Katakana:
                GotoKatakana(kana);
                break;
        }
        */

    }

    /*
    void GotoHiragana(string kana)
    {
        switch (kana)
        {

            default:
                break;
            ///a
            case "":
            case "a":
                Set("a", aHira);
                break;
            case "i":
                Set("i", iHira);
                break;
            case "u":
                Set("u", uHira);
                break;
            case "e":
                Set("e", eHira);
                break;
            case "o":
                Set("o", oHira);
                break;
            ///ka
            case "ka":
                Set("ka", kaHira);
                break;
            case "ki":
                Set("ki", kiHira);
                break;
            case "ku":
                Set("ku", kuHira);
                break;
            case "ke":
                Set("ke", keHira);
                break;
            case "ko":
                Set("ko", koHira);
                break;
            ///sa
            case "sa":
                Set("sa", saHira);
                break;
            case "shi":
            case "si":
                Set("shi/si", shiHira);
                break;
            case "su":
                Set("su", suHira);
                break;
            case "se":
                Set("se", seHira);
                break;
            case "so":
                Set("so", soHira);
                break;
            ///ta
            case "ta":
                Set("ta", taHira);
                break;
            case "chi":
            case "ti":
                Set("chi/ti", chiHira);
                break;
            case "tsu":
            case "tu":
                Set("tsu/tu", tsuHira);
                break;
            case "te":
                Set("te", teHira);
                break;
            case "to":
                Set("to", toHira);
                break;
            ///na
            case "na":
                Set("na", naHira);
                break;
            case "ni":
                Set("ni", niHira);
                break;
            case "nu":
                Set("nu", nuHira);
                break;
            case "ne":
                Set("ne", neHira);
                break;
            case "no":
                Set("no", noHira);
                break;
            ///ha
            case "ha":
                Set("ha", haHira);
                break;
            case "hi":
                Set("hi", hiHira);
                break;
            case "fu":
            case "hu":
                Set("hu", fuHira);
                break;
            case "he":
                Set("he", heHira);
                break;
            case "ho":
                Set("ho", hoHira);
                break;
            ///ma
            case "ma":
                Set("ma", maHira);
                break;
            case "mi":
                Set("mi", miHira);
                break;
            case "mu":
                Set("mu", muHira);
                break;
            case "me":
                Set("me", meHira);
                break;
            case "mo":
                Set("mo", moHira);
                break;
            ///ya
            case "ya":
                Set("ya", yaHira);
                break;
            case "yu":
                Set("yu", yuHira);
                break;
            case "yo":
                Set("yo", yoHira);
                break;
            ///ra
            case "ra":
                Set("ra", raHira);
                break;
            case "ri":
                Set("ri", riHira);
                break;
            case "ru":
                Set("ru", ruHira);
                break;
            case "re":
                Set("re", reHira);
                break;
            case "ro":
                Set("ro", roHira);
                break;
            ///wa
            case "wa":
                Set("wa", waHira);
                break;
            case "wo":
                Set("wo", woHira);
                break;
            ///n
            case "n":
                Set("n", nHira);
                break;
        }
    }

    */
    /*
    void GotoKatakana(string kana)
    {
        switch (kana)
        {
            case "":
            default:
                break;
            ///a
            case "a":
                Set("a", aKata);
                break;
            case "i":
                Set("i", iKata);
                break;
            case "u":
                Set("u", uKata);
                break;
            case "e":
                Set("e", eKata);
                break;
            case "o":
                Set("o", oKata);
                break;
            ///ka
            case "ka":
                Set("ka", kaKata);
                break;
            case "ki":
                Set("ki", kiKata);
                break;
            case "ku":
                Set("ku", kuKata);
                break;
            case "ke":
                Set("ke", keKata);
                break;
            case "ko":
                Set("ko", koKata);
                break;
            ///sa
            case "sa":
                Set("sa", saKata);
                break;
            case "shi":
            case "si":
                Set("shi/si", shiKata);
                break;
            case "su":
                Set("su", suKata);
                break;
            case "se":
                Set("se", seKata);
                break;
            case "so":
                Set("so", soKata);
                break;
            ///ta
            case "ta":
                Set("ta", taKata);
                break;
            case "chi":
            case "ti":
                Set("chi/ti", chiKata);
                break;
            case "tsu":
            case "tu":
                Set("tsu/tu", tsuKata);
                break;
            case "te":
                Set("te", teKata);
                break;
            case "to":
                Set("to", toKata);
                break;
            ///na
            case "na":
                Set("na", naKata);
                break;
            case "ni":
                Set("ni", niKata);
                break;
            case "nu":
                Set("nu", nuKata);
                break;
            case "ne":
                Set("ne", neKata);
                break;
            case "no":
                Set("no", noKata);
                break;
            ///ha
            case "ha":
                Set("ha", haKata);
                break;
            case "hi":
                Set("hi", hiKata);
                break;
            case "fu":
            case "hu":
                Set("hu", fuKata);
                break;
            case "he":
                Set("he", heKata);
                break;
            case "ho":
                Set("ho", hoKata);
                break;
            ///ma
            case "ma":
                Set("ma", maKata);
                break;
            case "mi":
                Set("mi", miKata);
                break;
            case "mu":
                Set("mu", muKata);
                break;
            case "me":
                Set("me", meKata);
                break;
            case "mo":
                Set("mo", moKata);
                break;
            ///ya
            case "ya":
                Set("ya", yaKata);
                break;
            case "yu":
                Set("yu", yuKata);
                break;
            case "yo":
                Set("yo", yoKata);
                break;
            ///ra
            case "ra":
                Set("ra", raKata);
                break;
            case "ri":
                Set("ri", riKata);
                break;
            case "ru":
                Set("ru", ruKata);
                break;
            case "re":
                Set("re", reKata);
                break;
            case "ro":
                Set("ro", roKata);
                break;
            ///wa
            case "wa":
                Set("wa", waKata);
                break;
            case "wo":
                Set("wo", woKata);
                break;
            ///n
            case "n":
                Set("n", nKata);
                break;
        }
    }
    */

    void Set(string romaji, Sprite kana, Sprite stroke, Sprite dev)
    {
        romajiText.text = romaji;
        kanaImage.sprite = kana;
        strokeImage.sprite = stroke;
        devImage.sprite = dev;
    }

    void Set(string romaji, KanaUICard card)
    {
        switch (kanaGrid.kanaType)
        {
            default:
            case KanaGrid.EKanaType.Hiragana:
                Set(romaji, card.hiragana, card.hiraStroke, card.hiraDev);
                break;
            case KanaGrid.EKanaType.Katakana:
                Set(romaji, card.katakana, card.kataStroke, card.kataDev);
                break;
        }
    }
}
