using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBs_IS : MonoBehaviour
{
    private List<Question> questions;
    private void Awake()
    {
        questions = new List<Question>();
    }
    void addQuest(Answer a1, Answer a2, Answer a3, string s)
    {
        List<Answer> answers = new List<Answer>();
        answers.Add(a1); answers.Add(a2); answers.Add(a3);
        questions.Add(new Question(s, answers));
    }

    void dataBs()
    {
        addQuest(new Answer("Gautaborg", false, -1), new Answer("Malmö", false, 0), new Answer("Stokkhólmur", true, 1), "Hver er höfuðborg Svíþjóðar?");
        addQuest(new Answer("40", false, -1), new Answer("62", false, 0), new Answer("50", true, 1), "Hver er höfuðborg Svíþjóðar?");
        addQuest(new Answer("Kyoto", false, -1), new Answer("Osaka", false, 0), new Answer("Tokyo", true, 1), "Höfuðborg Japans?");
        addQuest(new Answer("Bergen", false, -1), new Answer("Þrándheimur", false, 0), new Answer("Ósló", true, 1), "Höfuðborg Noregs?");
        addQuest(new Answer("USA", false, -1), new Answer("Ástralía", false, 0), new Answer("Rússland", true, 1), "Stærsta land heims upp á yfirborðið er ...?");
        addQuest(new Answer("K2", false, -1), new Answer("Kilimanjaro", false, 0), new Answer("Mount Everest", true, 1), "Hvað er hæsta fjall í heimi?");
        addQuest(new Answer("Dóná", false, -1), new Answer("Dnepr", false, 0), new Answer("Volga", true, 1), "Hver er lengsta fljót Evrópu?");
        addQuest(new Answer("Kilimanjaro", false, -1), new Answer("Makalu", false, 0), new Answer("K2", true, 1), "Hvert er næst hæsta fjall heims?");
        addQuest(new Answer("Ísland", false, -1), new Answer("Svíþjóð", false, 0), new Answer("Danmörk", true, 1), "Grænland er ekki eigið land heldur tilheyrir ...?");
        addQuest(new Answer("Suðurpóllinn", false, -1), new Answer("Austurhvel", false, 0), new Answer("Norðurpóllinn", true, 1), "Norðurheimskautið liggur umhverfis jörðina …?");
        addQuest(new Answer("Norðurpólinn", false, -1), new Answer("Vesturhvel jarðar", false, 0), new Answer("Suðurpólinn", true, 1), "Suðurskautslandið er staðsett umhverfis jörðina …?");
        addQuest(new Answer("Melbourne", false, -1), new Answer("Sydney", false, 0), new Answer("Canberra", true, 1), "Hver er höfuðborg Ástralíu?");
        addQuest(new Answer("Sankt Pétursborg", false, -1), new Answer("Kazan", false, 0), new Answer("Moskva", true, 1), "Hver er höfuðborg Rússlands?");
        addQuest(new Answer("72", false, -1), new Answer("38", false, 0), new Answer("49", true, 1), "Hversu mörg lönd eru í Evrópu?");
        addQuest(new Answer("5", false, -1), new Answer("10", false, 0), new Answer("7", true, 1), "Hvað eru margar heimsálfur?");
        addQuest(new Answer("Níl", false, -1), new Answer("Mekong", false, 0), new Answer("Amazon", true, 1), "Hver er lengsta á heims?");
        addQuest(new Answer("Amazon", false, -1), new Answer("Mekong", false, 0), new Answer("Nile", true, 1), "Hver er lengsta á heims?");
        addQuest(new Answer("Mónakó", false, -1), new Answer("Malta", false, 0), new Answer("Vatíkanið ", true, 1), "Hvert er minnsta land í heimi?");
        addQuest(new Answer("Rio de Janeiro", false, -1), new Answer("Sao Paulo", false, 0), new Answer("Brasília", true, 1), "Hver er höfuðborg Brasilíu?");
        addQuest(new Answer("Phuket", false, -1), new Answer("Pattaya", false, 0), new Answer("Bangkok", true, 1), "Hver er höfuðborg Tælands?");
        addQuest(new Answer("Atlantshaf", false, -1), new Answer("Miðjarðarhaf", false, 0), new Answer("Kyrrahaf", true, 1), "Hvert er stærsta heimshaf okkar?");
        addQuest(new Answer("Bandaríkin", false, -1), new Answer("Rússland", false, 0), new Answer("Kína", true, 1), "Hvaða land hefur flesta íbúa?");
        addQuest(new Answer("Svíþjóð", false, -1), new Answer("Noregur", false, 0), new Answer("Ísland", true, 1), "Hvaða land tilheyrir EKKI Skandinavíu?");
        addQuest(new Answer("Rússland", false, -1), new Answer("Pólland", false, 0), new Answer("Ísland", true, 1), "Hvaða land tilheyrir Norðurlöndunum? ");
        addQuest(new Answer("Napoleon   ", false, -1), new Answer("Jesús  ", false, 0), new Answer("Julius Caesar ", true, 1), "Hver af þessu fólki var rómverskur keisari?");
        addQuest(new Answer("Khabul Khan  ", false, -1), new Answer("Alexander Stóri ", false, 0), new Answer("Djingis Khan", true, 1), "Hver var mongólski höfðinginn sem sameinaði mongólsku ættbálkana?");
        addQuest(new Answer("Íslandi  ", false, -1), new Answer("Danmörk", false, 0), new Answer("Noregi", true, 1), "Í hvaða landi dó Karl XII árið 1718?");
        addQuest(new Answer("1948  ", false, -1), new Answer("1952", false, 0), new Answer("1944", true, 1), "Hvaða ár var indverski stjórnmálamaðurinn Mahatma Gandhi myrtur?");
        addQuest(new Answer("26  ", false, -1), new Answer("18", false, 0), new Answer("19", true, 1), "Hversu gömul var franska dýrlingurin, Jeanne d’arc, þegar hún var brennd á báli?");
        addQuest(new Answer("1949  ", false, -1), new Answer("1954", false, 0), new Answer("1961", true, 1), "Hvaða ár var Berlínarmúrinn reistur?");
        addQuest(new Answer("1985  ", false, -1), new Answer("1991", false, 0), new Answer("1989", true, 1), "Hvaða ár var Berlínarmúrinn rifinn?");
        addQuest(new Answer("Rómverska heimsveldið  ", false, -1), new Answer("Egyptaland", false, 0), new Answer("Makedónía", true, 1), "Hvaða land var Alexander mikli konungur yfir?");
        addQuest(new Answer("1200", false, -1), new Answer("1000", false, 0), new Answer("900", true, 1), "Á hvaða tímabili lifði  konungur Haraldur Blåtand?");
        addQuest(new Answer("1429", false, -1), new Answer("1398", false, 0), new Answer("1453", true, 1), "Hvaða ár féll Konstantinopel?");
        addQuest(new Answer("1534-1564", false, -1), new Answer("1556-1586", false, 0), new Answer("1618-1648", true, 1), "Á hvaða árum átti þrjátíu ára stríðið sér stað?");
        addQuest(new Answer("1508-1539", false, -1), new Answer("1531-1558", false, 0), new Answer("1523-1560", true, 1), "Hvaða ár var Gustav Vasa Svíakonungur?");
        addQuest(new Answer("Íslandi", false, -1), new Answer("1Noregs", false, 0), new Answer("Svíþjóð", true, 1), "Hvaða landi var Karl Stóri konungur í?");
        addQuest(new Answer("1518", false, -1), new Answer("1521", false, 0), new Answer("1520", true, 1), "Hvaða ár fóru fram fjöldamorð í Stokkhólmi?");
        addQuest(new Answer("1784", false, -1), new Answer("1796", false, 0), new Answer("1792", true, 1), "Hvaða ár dó Gustav III eftir árás á grímuball?");
        addQuest(new Answer("1498", false, -1), new Answer("1516", false, 0), new Answer("1492", true, 1), "Hvaða ár náði Kristófer Kólumbus Ameríku?");
        addQuest(new Answer("100 000", false, -1), new Answer(" 10 000 000", false, 0), new Answer("1 000 000 ", true, 1), "1 megaherz = ? herz");
        addQuest(new Answer("1,0 kg/m3", false, -1), new Answer("1,5 kg/m3", false, 0), new Answer("1,0 kg/dm3", true, 1), "Hvaða þéttleiki hefur vatn? ");
        addQuest(new Answer("36 kg/dm3", false, -1), new Answer("16 kg/m3", false, 0), new Answer("9 kg /dm3 ", true, 1), "Eitt stykki kopar vegur 18 kg og rúmmálið er 2 dm3. Hversu mikill verður þéttleikin?");
        addQuest(new Answer("19,8", false, -1), new Answer("9,88", false, 0), new Answer("9,8 ", true, 1), "Hlutur dettur í tómarúm og fellur frjálslega. Það fellur án núnings, sem þýðir að hröðunin er stöðug. Nálægt jörðinni er þetta kallað þyngdarhröðun og er það um það bil? m / s2?");
        addQuest(new Answer("Satt", false, -1), new Answer("Ekki viss", false, 0), new Answer(" Rangt ", true, 1), "Útsetning er aðferð þar sem efni breytist beint úr föstu í loftkenndan form.");
        addQuest(new Answer("Rangt", false, -1), new Answer("Ekki viss", false, 0), new Answer(" Satt", true, 1), "Bræðing er bein umskipti efnis úr samloðunarástandi í föstu formi, án þess að fara í millifasa vökvaform.");
        addQuest(new Answer("Efnaorka", false, -1), new Answer("Varmaorka", false, 0), new Answer(" Raforka ", true, 1), "Hvaða orka hefur rafhlaði?");
        addQuest(new Answer("Dikväveoxid", false, -1), new Answer("Koldioxid", false, 0), new Answer("Kväve", true, 1), "Vad är korrekt namn för N2O?");
        addQuest(new Answer("Koldíoxíð", false, -1), new Answer("Köfnunarefni", false, 0), new Answer(" Köfnunarefnisoxíð", true, 1), "Hvað er rétt nafn fyrir N2O? ");
        addQuest(new Answer("H2O", false, -1), new Answer("N2O", false, 0), new Answer(" O2", true, 1), "Hvað er rétt nafn fyrir N2O? ");
        addQuest(new Answer("Koltvísýringur", false, -1), new Answer("Brennisteinstvíoxíð", false, 0), new Answer(" Kolmónoxíð ", true, 1), "Hvað er rétt nafn á CO? ");
        addQuest(new Answer("-1 °C", false, -1), new Answer("100 °C ", false, 0), new Answer("0 °C ", true, 1), "Bræðslumark klaka er?");
        addQuest(new Answer("55°C", false, -1), new Answer("0°C ", false, 0), new Answer("100°C ", true, 1), "Suðumark vatns við venjulegan loftþrýsting er?");
        addQuest(new Answer("274,15°C", false, -1), new Answer("-274,15°C", false, 0), new Answer("-273,15°C ", true, 1), "Hvaða hitastig er kallað algert núllpunkt?");
        addQuest(new Answer("2", false, -1), new Answer("1,5", false, 0), new Answer("1", true, 1), "Hversu mikið newtonmeter er 1 joule (J)? ");
        addQuest(new Answer("Bylgjulengdar", false, -1), new Answer("Kraftalengd ", false, 0), new Answer("Bylgjulengd ", true, 1), "Fjarlægðin milli tveggja öldutoppa (öldudala) er kölluð ...? ");
        addQuest(new Answer("Brýstingur = kraftur * svæði", false, -1), new Answer("Kraftur = prentað / svæði", false, 0), new Answer("Þrýstingur = kraftur / svæði  ", true, 1), "Hvaða formúla er rétt?");
        addQuest(new Answer("1,5 N/m²", false, -1), new Answer("2 N/m²", false, 0), new Answer("1 N/m²", true, 1), "p1 ascal (Pa) er sama sem?");
        addQuest(new Answer("1N", false, -1), new Answer("1J", false, 0), new Answer("1 Pa", true, 1), "Grunneining þrýstings er?");
        addQuest(new Answer("Ampere", false, -1), new Answer("watt", false, 0), new Answer("volt", true, 1), "Eining fyrir spennu ");
        addQuest(new Answer("Ampere", false, -1), new Answer("m/s", false, 0), new Answer("hertz", true, 1), "Eining fyrir tíðni");
        addQuest(new Answer("240V", false, -1), new Answer("220V", false, 0), new Answer("230V", true, 1), "Spenna í venjulegri veggja innstungu");
        addQuest(new Answer("Venus", false, -1), new Answer("Mars", false, 0), new Answer("Merkurius", true, 1), "Minsta plánetan");
        addQuest(new Answer("Saturnus  ", false, -1), new Answer("Neptunus", false, 0), new Answer("Jupiter", true, 1), "Stærsta plánetan");
        addQuest(new Answer("Betelgeuze", false, -1), new Answer("Vega", false, 0), new Answer("Sirius", true, 1), "Næsta stjarna sem við sjáum, fyrir utan sólina.");
        addQuest(new Answer("nebulosa", false, -1), new Answer("Big Bang", false, 0), new Answer("Galax", true, 1), "Stjörnukerfi");
        addQuest(new Answer("Labba  ", false, -1), new Answer("Mynd ", false, 0), new Answer("Stór ", true, 1), "Hvað er dæmi um lýsingarorð ?");
        addQuest(new Answer("Hlaupa  ", false, -1), new Answer("Rautt ", false, 0), new Answer("Hestur ", true, 1), "Hvað er dæmi um nafnorð ?");
        addQuest(new Answer("Störst ", true, 1), new Answer("Storast ", false, 0), new Answer("Storar", false, -1), "Stor, större ...?");
        addQuest(new Answer("Stórast  ", false, -1), new Answer("Stór ", false, 0), new Answer("Stærst ", true, 1), "Stór, Stærri,  ");
        addQuest(new Answer("Skeraði  ", false, -1), new Answer("Skarr ", false, 0), new Answer("Skar ", true, 1), "Í gær....Ég appelsínu ");
        addQuest(new Answer("9 ", true, 1), new Answer("10 ", false, 0), new Answer("6", false, -1), "Hur många ordklasser finns det?");
        addQuest(new Answer("6 ", false, -1), new Answer("9 ", false, 0), new Answer("10 ", true, 1), "Hvað eru til margir orðatímar í sænskunni ? ");
        addQuest(new Answer("Hvar ", false, -1), new Answer("Hvernig ", false, 0), new Answer("Hver ", true, 1), "Hvað eru dæmi um fornöfn ?");
        addQuest(new Answer("Wile ", false, -1), new Answer("Wihle ", false, 0), new Answer("While ", true, 1), "Hvað er á meðan á  ensku ?");
        addQuest(new Answer("Enouf ", false, 0), new Answer("Enough ", true, 1), new Answer("Enogh", false, -1), "Hur säger du nog på engelska?");
        addQuest(new Answer("Enouf ", false, -1), new Answer("Enogh ", false, 0), new Answer("Enough ", true, 1), "Hvernig segir maður nóg á ensku ?");
        addQuest(new Answer("Bréf ", false, -1), new Answer("Skór ", false, 0), new Answer("Grautur ", true, 1), "Hvað þýðir porridge ?");
        addQuest(new Answer("Geispa ", false, -1), new Answer("Anda ", false, 0), new Answer("Mása ", true, 1), "Hvað þýðir pant ?");
        addQuest(new Answer("Ömurlegt ", false, -1), new Answer("Vont ", false, 0), new Answer("Flott ", true, 1), "Hvað er samheiti til góðs ?");
        addQuest(new Answer("Listi ", false, -1), new Answer("Ákveða ", false, 0), new Answer("Samningur ", true, 1), "Hvað er samheiti yfir samkomulag ?");
        addQuest(new Answer("Fara ", false, -1), new Answer("Hætta ", false, 0), new Answer("Koma ", true, 1), "Hvað er andstætt orð við brottför ?");
        addQuest(new Answer("Hættulegt ", false, -1), new Answer("Algeingt ", false, 0), new Answer("Venjulegt ", true, 1), "Hvað er andstætt orð við skrýtið ?");
        addQuest(new Answer("Veik ", false, -1), new Answer("Slæm ", false, 0), new Answer("Frísk ", true, 1), "Hvað er samheiti fyrir heilbrigð ?");
        addQuest(new Answer("Longist ", false, -1), new Answer("Longst ", false, 0), new Answer("Longest ", true, 1), "Hvernig segir maður það lengsta á ensku ?");
        addQuest(new Answer("Dog ", false, -1), new Answer("Kourv ", false, 0), new Answer("Sausage ", true, 1), "Hvernig segir maður pylsur á ensku ?");
        addQuest(new Answer("0 ", false, -1), new Answer("2 ", false, 0), new Answer("5  ", true, 1), "Hvað eru mörg minnihlutatungumál í Svíþjóð ?");
        addQuest(new Answer("100 ", false, -1), new Answer("400 ", false, 0), new Answer("200   ", true, 1), "Hversu mörg tungumál eru töluð í Svíþjóð ?");
        addQuest(new Answer("5908 ", false, -1), new Answer("5209 ", false, 0), new Answer("6809  ", true, 1), "Hversu mörg tungumál eru töluð í heiminum ?");
        addQuest(new Answer("Enska ", false, -1), new Answer("Hindi ", false, 0), new Answer("Kínverska  ", true, 1), "Hvað er stærsta tungumálið í heiminum ?");
        addQuest(new Answer("976 miljónir ", false, -1), new Answer("612 miljonir ", false, 0), new Answer("848 miljónir   ", true, 1), "Hversu margir tala Kínversku ?");
        addQuest(new Answer("6905", false, -1), new Answer("7340", false, 0), new Answer("7260 ", true, 1), "1443 + 5817 ");
        addQuest(new Answer("5002", false, -1), new Answer("4670", false, 0), new Answer("4748 ", true, 1), "2779 + 1969 ");
        addQuest(new Answer("5832", false, -1), new Answer("6455", false, 0), new Answer("6188 ", true, 1), "3326 + 2862");
        addQuest(new Answer("16700", false, -1), new Answer("12600", false, 0), new Answer("13081 ", true, 1), "6480 + 6601");
        addQuest(new Answer("9832", false, -1), new Answer("10666", false, 0), new Answer("10888 ", true, 1), "3918 + 6970");
        addQuest(new Answer("61.35", false, -1), new Answer(" 81.5", false, 0), new Answer("71.395 ", true, 1), "71.8 − 0.405");
        addQuest(new Answer("2.32", false, -1), new Answer(" 1.35", false, 0), new Answer("2.35 ", true, 1), "9.16 − 6.81");
        addQuest(new Answer("48", false, -1), new Answer(" 47.4", false, 0), new Answer("48.56 ", true, 1), "53.6 − 5.04");
        addQuest(new Answer("60", false, -1), new Answer("65", false, 0), new Answer("72 ", true, 1), "Umreikna 1, 2 mínútur í sekúndur");
        addQuest(new Answer("170 ", false, -1), new Answer("100", false, 0), new Answer("144 ", true, 1), "Umreikna 1008 daga í vikur");
        addQuest(new Answer("20 ", false, -1), new Answer("2,52", false, 0), new Answer("25,2 ", true, 1), "Umreikna 3, 6 vikur í daga");
        addQuest(new Answer("90 ", false, -1), new Answer("70", false, 0), new Answer("97,5", true, 1), "Hvað er  0, 975 sem hlutfall");
        addQuest(new Answer("0,8 ", false, -1), new Answer(" 0,89", false, 0), new Answer("0,875", true, 1), "Hvað er  7 / 8 sem aukastaf");
        addQuest(new Answer("7/9 ", false, -1), new Answer("7/11 ", false, 0), new Answer("7/10", true, 1), "Hvað er 70 % sem brot");
        addQuest(new Answer("15 ", false, -1), new Answer(" 11 ", false, 0), new Answer("12", true, 1), "11 = 132 / t");
        addQuest(new Answer("15 ", false, -1), new Answer(" 11 ", false, 0), new Answer("12", true, 1), "11 = 132 / t");
        addQuest(new Answer("9 ", false, -1), new Answer(" 6", false, 0), new Answer("8", true, 1), "p ^ 2 = 64");
        addQuest(new Answer("1 ", false, -1), new Answer(" 4", false, 0), new Answer("2", true, 1), "q + 6 = 8");
        addQuest(new Answer("5", false, -1), new Answer("2", false, 0), new Answer("3", true, 1), "5c = 15");
        addQuest(new Answer("31", false, -1), new Answer("29.78", false, 0), new Answer("30.704", true, 1), "4.04 × 7.6");
        addQuest(new Answer("1700", false, -1), new Answer("1640", false, 0), new Answer("1560", true, 1), "26 × 60");
        addQuest(new Answer("1.69", false, -1), new Answer("1.8", false, 0), new Answer("1.6596", true, 1), "9.22 × 0.18 ");
        addQuest(new Answer("10.41", false, -1), new Answer("8.789", false, 0), new Answer("9.898", true, 1), "1.4 × 7.07 ");
        addQuest(new Answer("141.412", false, -1), new Answer("8.789", false, 0), new Answer("212.25", true, 1), "25 × 8.49");
        addQuest(new Answer("1", false, -1), new Answer("3", false, 0), new Answer("5", true, 1), "153");
        addQuest(new Answer("1", false, -1), new Answer("0", false, 0), new Answer("2", true, 1), "2 * 1");
        addQuest(new Answer("64", false, -1), new Answer("600", false, 0), new Answer("256", true, 1), "16 ^ 2");
        addQuest(new Answer("0", false, -1), new Answer("2", false, 0), new Answer("1", true, 1), "0.2 * 5");






        // addQuest(new Answer("1518 ", false, -1), new Answer("1520 ", false, 0), new Answer("1521", true, 1), "Vilket år ägde Stockholms blodbad rum?");
        //addQuest(new Answer("1498 ", false, -1), new Answer("1516 ", false, 0), new Answer("1492", true, 1), "Vilket år nådde Christofer Columbus Amerika?");

    }
    public List<Question> allQues()
    {
        dataBs();
        return questions;
    }
}
