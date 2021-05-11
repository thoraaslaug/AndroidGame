using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBs_SV :MonoBehaviour
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
        addQuest(new Answer("Göteborg", false, -1), new Answer("Malmö", false, 0), new Answer("Stockholm", true, 1), "Vilken är Sveriges huvudstad?");
        addQuest(new Answer("40 ", false, -1), new Answer("62 ", false, 0), new Answer("50", true, 1), "Hur många delstater har USA?");
        addQuest(new Answer("Tokyo", true, -1), new Answer("Kyoto", false, 0), new Answer("Osaka", false, 1), "Japans huvudstad?");
        addQuest(new Answer("Oslo", true, -1), new Answer("Bergen", false, 0), new Answer("Trondheim", false, 1), "Norges huvudstad?");
        addQuest(new Answer("USA", false, -1), new Answer("Australien", false, 0), new Answer("Ryssland", true, 1), "Världens största land till ytan är ...");
        addQuest(new Answer("Danmark", true, -1), new Answer("Island", false, 0), new Answer("Sverige", false, 1), "Grönland är inget eget land utan hör till?");
        addQuest(new Answer("Brasilia", true, -1), new Answer("Rio de Janeiro", false, 0), new Answer("Sao Paulo", false, 1), "Vilken är Brasiliens huvudstad?");
        addQuest(new Answer("Sverige ", false, -1), new Answer("Island ", true, 0), new Answer("Norge", false, 1), "Vilket land tillhör INTE Skandinavien?");
        addQuest(new Answer("Napoleon I", false, -1), new Answer("Julius Caesar", true, 0), new Answer("Karl den Store", false, 1), "Vem av dessa personer var en Romersk kejsare");
        addQuest(new Answer("1952", false, -1), new Answer("1948", false, 0), new Answer("1944", true, 1), "Vilket år mördades Indiska politikern Mahatma Gandhi");
        addQuest(new Answer("1985 ", false, -1), new Answer("1989 ", true, 0), new Answer("1991", false, 1), "Vilket år revs Berlinmuren ner?");
        addQuest(new Answer("1453 ", true, -1), new Answer("1429 ", false, 0), new Answer("1398", false, 1), "Vilket år föll Konstantinopel?");
        addQuest(new Answer("1531-1558", false, -1), new Answer("1523-1560", true, 0), new Answer("1508-1539", false, 1), "Vilka år var Gustav Vasa Kung av Sverige");
        addQuest(new Answer("1792 ", true, -1), new Answer("1784 ", false, 0), new Answer("1796", false, 1), "Vilket år dog Gustav III, efter blivit attackerad på en maskeradbal");
        addQuest(new Answer("Kolmonoxid", true, -1), new Answer("Koldioxid", false, 0), new Answer("Svaveltrioxid", false, 1), "Vad är korrekt namn för CO?");
        addQuest(new Answer("Våglängd", true, -1), new Answer("Vågresa", false, 0), new Answer("kraftlängd", false, 1), "Avståndet mellan två vågtoppar (vågdalar), kallas för...?");
        addQuest(new Answer("Går ", false, -1), new Answer("Häst ", false, 0), new Answer("Stor", true, 1), "Vad är ett exempel på ett adjektiv?");
        addQuest(new Answer("Störst ", true, -1), new Answer("Storast ", false, 0), new Answer("Storar", false, 1), "Stor, större ...?");
        addQuest(new Answer("9 ", true, -1), new Answer("10 ", false, 0), new Answer("6", false, 1), "Hur många ordklasser finns det?");
        addQuest(new Answer("Enouf ", false, -1), new Answer("Enough ", true, 0), new Answer("Enogh", false, 1), "Hur säger du nog på engelska?");
        addQuest(new Answer("Mount Everest", true, -1), new Answer("Kilimanjaro", false, 0), new Answer("K2", false, 1), "Vilket är världens högsta berg?");
        addQuest(new Answer("Donau", false, -1), new Answer("Volga", true, 0), new Answer("Dnepr", false, 1), "Vilken är Europas längsta flod?");
        addQuest(new Answer("Kilimanjaro", false, -1), new Answer("Makalu", false, 0), new Answer("K2", true, 1), "Vilket är världens näst högsta berg?");
        addQuest(new Answer("Sydpol", false, -1), new Answer("Nordpol", true, 0), new Answer("Östra halvklot", false, 1), "Arktis ligger kring jordens …?");
        addQuest(new Answer("Nordpol", false, -1), new Answer("Västra halvklot", false, 0), new Answer("Sydpol", true, 1), "Antarktis ligger kring jordens…?");
        addQuest(new Answer("Melbourne", false, -1), new Answer("Canberra", true, 0), new Answer("Sydney", false, 1), "Vilken är Australiens huvudstad?");
        addQuest(new Answer("Kazan", false, -1), new Answer("S:t Petersburg", false, 0), new Answer("Moskva", true, 1), "Vilken är Rysslands huvudstad?");
        addQuest(new Answer("49", true, -1), new Answer("72", false, 0), new Answer("38", false, 1), "Hur många länder finns i Europa?");
        addQuest(new Answer("5", false, -1), new Answer("7", true, 0), new Answer("10", false, 1), "Hur många världsdelar finns det?");
        addQuest(new Answer("Nilen", false, -1), new Answer("Mekong", false, 0), new Answer("Amazonfloden", true, 1), "Vilken är världens längsta flod?");
        addQuest(new Answer("Amazonfloden", false, -1), new Answer("Nilen", true, 0), new Answer("Mekong", false, 1), "Vilken är världens näst längsta flod?");
        addQuest(new Answer("Monaco", false, -1), new Answer("Malta", false, 0), new Answer("Vatikanstaten", true, 1), "Vilket är världens minsta land?");
        addQuest(new Answer("Bangkok", true, -1), new Answer("Phuket", false, 0), new Answer("Pattaya", false, 1), "Vilken är Thailands huvudstad?");
        addQuest(new Answer("Atlanten", false, -1), new Answer("Stilla havet", true, 0), new Answer("Indiska oceanen", false, 1), "Vilket är vårt största världshav?");
        addQuest(new Answer("USA", false, -1), new Answer("Ryssland", false, 0), new Answer("Kina", true, 1), "Vilket land har flest invånare?");
        addQuest(new Answer("Island", true, -1), new Answer("Ryssland", false, 0), new Answer("Polen", false, 1), "Vilket land tillhör Norden?");
        addQuest(new Answer("Khabul Khan", false, -1), new Answer("Alexander den store", false, 0), new Answer("Djingis Khan", true, 1), "Vem var den mongoliske härskare som förenade de mongoliska stammarna?");
        addQuest(new Answer("Norge", true, -1), new Answer("Polen", false, 0), new Answer("Ryssland", false, 1), "I vilket land dog Karl XII år 1718?");
        addQuest(new Answer("26", false, -1), new Answer("19", true, 0), new Answer("23", false, 1), "Hur gammal var franska helgonet, Jeanne d’arc, när hon brändes på bål?");
        addQuest(new Answer("1949", false, -1), new Answer("1954", false, 0), new Answer("1961", true, 1), "Vilket år byggdes Berlinmuren?");
        addQuest(new Answer("Makedonien", true, -1), new Answer("Romerska riket", false, 0), new Answer("Egypten", false, 1), "Vilket land var Alexander den Store kung över?");
        addQuest(new Answer("900-talet", true, -1), new Answer("700-talet", false, 0), new Answer("1000-talet", false, 1), "Under vilken tidsperiod levde kungen Harald Blåtand?");
        addQuest(new Answer("1618-1648", true, -1), new Answer("1534-1564", false, 0), new Answer("1556-1586", false, 1), "Under vilka år ägde det trettioåriga kriget rum?");
        addQuest(new Answer("Tyskland", false, -1), new Answer("Frankrike", true, 0), new Answer("England", false, 1), "Vilket land var Karl den Store kung av?");
        addQuest(new Answer("1518", false, -1), new Answer("1520", true, 0), new Answer("1521", false, 1), "Vilket år ägde Stockholms blodbad rum?");
        addQuest(new Answer("1498", false, -1), new Answer("1516", false, 0), new Answer("1492", true, 1), "Vilket år nådde Christofer Columbus Amerika?");
        addQuest(new Answer("1 000 000", true, -1), new Answer("10 000 000 ", false, 0), new Answer("100 000", false, 1), "1 megahertz = ? hertz");
        addQuest(new Answer("1,0 kg/dm3", true, -1), new Answer("1,5 kg/m3", false, 0), new Answer("1,0 kg/m3", false, 1), "Vilken densitet har vatten ?");
        addQuest(new Answer("36 kg/dm3", false, -1), new Answer("16 kg/m3", false, 0), new Answer("9 kg /dm3", true, 1), "En kopparbit väger 18 kg och har volymen 2 dm3. Vad blir densiteten?");
        addQuest(new Answer("19,8", false, -1), new Answer("9,8", true, 0), new Answer("9,88", false, 1), "Ett föremål som faller i vakuum faller fritt. Det faller utan friktion, vilket betyder att accelerationen är konstant. I närheten av jorden kallas detta för tyngdacceleration och är ungefär ? m/s2.");
        addQuest(new Answer("Sant", false, -1), new Answer("Falskt", true, 0), new Answer("Tveksamt", false, 1), "Deposition är en process där ett ämne övergår direkt från fast form till gasform.");
        addQuest(new Answer("Sant", true, -1), new Answer("Falskt", false, 0), new Answer("Tveksamt", false, 1), "Sublimation/sublimering är ett ämnes direkta övergång från aggregationstillståndet fast form till gasform, utan att passera mellanfasen flytande form.");
        addQuest(new Answer("Kemisk energi", false, -1), new Answer("Elektrisk energi", true, 0), new Answer("Värmeenergi", false, 1), "Vilken energi har batteri?");
        addQuest(new Answer("Dikväveoxid", true, -1), new Answer("Koldioxid", false, 0), new Answer("Kväve", false, 1), "Vad är korrekt namn för N2O?");
        addQuest(new Answer("H2O", false, -1), new Answer("N2O", false, 0), new Answer("O2", true, 1), "Vilken gas är inte en växthusgas?");
        addQuest(new Answer("-1 °C", false, -1), new Answer("0 °C", true, 0), new Answer("100 °C", false, 1), "Isens smältpunkt är … ?");
        addQuest(new Answer("55°C", false, -1), new Answer("0°C", false, 0), new Answer("100°C", true, 1), "Vattnets kokpunkt vid normalt lufttryck är … ?");
        addQuest(new Answer("-273,15°C", true, -1), new Answer("274,15°C", false, 0), new Answer("-274,15°C", false, 1), "Vilken temperatur kallas för den absoluta nollpunkten?");
        addQuest(new Answer("2", false, -1), new Answer("1", true, 0), new Answer("1,5", false, 1), "Hur många newtonmeter är 1 joule (J)?");
        addQuest(new Answer("Tryck  =  kraft * area", false, -1), new Answer("Tryck = kraft/area", true, 0), new Answer("Kraft = tryck/area", false, 1), "Vilken formel är riktig?");
        addQuest(new Answer("1 N/m²", true, -1), new Answer("2 N/m²", false, 0), new Answer("1,5 N/m²", false, 1), "1 pascal (Pa) är lika med?");
        addQuest(new Answer("1 Pa", true, -1), new Answer("1N", false, 0), new Answer("1J", false, 1), "Grundenheten för tryck är … ?");
        addQuest(new Answer("Ampere ", false, -1), new Answer("Volt ", true, 0), new Answer("Watt", false, 1), "Enheten för spänning är … ?");
        addQuest(new Answer("Ampere ", false, -1), new Answer("m/s", false, 0), new Answer("Hertz", true, 1), "Enheten för frekvens är … ?");
        addQuest(new Answer("220V", false, -1), new Answer("240V", false, 0), new Answer("230V", true, 1), "Spänningen i ett vanligt vägguttag är … ?");
        addQuest(new Answer("Venus", false, -1), new Answer("Mars", false, 0), new Answer("Merkurius", true, 1), "Den minsta planeten är … ?");
        addQuest(new Answer("Saturnus", false, -1), new Answer("Jupiter", true, 0), new Answer("Neptunus", false, 1), "Den största planeten är … ?");
        addQuest(new Answer("Betelgeuze ", false, -1), new Answer("Sirius ", true, 0), new Answer("Vega", false, 1), "Den närmaste stjärna som vi kan se från oss, bortsett från solen är … ?");
        addQuest(new Answer("Galax", true, -1), new Answer("Nebulosa", false, 0), new Answer("Big Bang", false, 1), "Stjärnsystem");
        addQuest(new Answer("Spring", false, -1), new Answer("Röd", false, 0), new Answer("Häst", true, 1), "Vad är ett exempel på ett substantiv?");
        addQuest(new Answer("Skarde", false, -1), new Answer("Skärde", false, 0), new Answer("Skar", true, 1), "Igår … jag en apelsin.");
        addQuest(new Answer("Vem", true, -1), new Answer("Var", false, 0), new Answer("Hur", false, 1), "Vad är exempel på pronomen?");
        addQuest(new Answer("While", true, -1), new Answer("Wile", false, 0), new Answer("Wihle", false, 1), "Vad är \"medan\" på engelska?");
        addQuest(new Answer("Nota", false, -1), new Answer("Smutta", false, 0), new Answer("Gröt", true, 1), "Vad betyder \"porridge\"?");
        addQuest(new Answer("Pant", false, -1), new Answer("Gäspa", false, 0), new Answer("Flåsa", true, 1), "Vad betyder det engelska ordet \"pant\"?");
        addQuest(new Answer("Utmärkt", true, -1), new Answer("Skröplig", false, 0), new Answer("Usel", false, 1), "Vad är en synonym till ordet \"bra\"?");
        addQuest(new Answer("Lista", false, -1), new Answer("Förbindelse", true, 0), new Answer("Bestämma", false, 1), "Vad är en synonym till ordet \"avtal\"?");
        addQuest(new Answer("Åka", false, -1), new Answer("Ankomst", true, 0), new Answer("Anlägga", false, 1), "Vad är ett motsatsord till ordet \"avfärd\"?");
        addQuest(new Answer("Udda", false, -1), new Answer("Normal", true, 0), new Answer("Märklig", false, 1), "Vad är ett motsatsord till ordet \"konstig\"?");
        addQuest(new Answer("Sund", true, -1), new Answer("Grund", false, 0), new Answer("Sjuk", false, 1), "Vad är en synonym till ordet \"frisk\"?");
        addQuest(new Answer("Longist", false, -1), new Answer("Longest", true, 0), new Answer("Longst", false, 1), "Hur säger du ordet \"längst\" på engelska?");
        addQuest(new Answer("Dog", false, -1), new Answer("Kourv", false, 0), new Answer("Sausage", true, 1), "Hur säger du ordet \"korv\" på engelska?");
        addQuest(new Answer("0", false, -1), new Answer("2", false, 0), new Answer("5", true, 1), "Hur många minoritetsspråk finns det i Sverige?");
        addQuest(new Answer("100", false, -1), new Answer("400", false, 0), new Answer("200", true, 1), "Hur många språk talas i Sverige?");
        addQuest(new Answer("5908", false, -1), new Answer("6809", true, 0), new Answer("5209", false, 1), "Hur många språk talas i världen?");
        addQuest(new Answer("Kinesiska", true, -1), new Answer("Engelska", false, 0), new Answer("Hindi", false, 1), "Vilket är världens största språk?");
        addQuest(new Answer("976 miljoner", false, -1), new Answer("848 miljoner", true, 0), new Answer("612 miljoner", false, 1), "Hur många talar kinesiska?");
        addQuest(new Answer("6905", false, -1), new Answer("7340", false, 0), new Answer("7260 ", true, 1), "1443 + 5817");
        addQuest(new Answer("5002", false, -1), new Answer("4670", false, 0), new Answer("4748 ", true, 1), "2779 + 1969");
        addQuest(new Answer("5832", false, -1), new Answer("6455", false, 0), new Answer("6188 ", true, 1), "3326 + 2862");
        addQuest(new Answer("16700", false, -1), new Answer("12600", false, 0), new Answer("13081 ", true, 1), "6480 + 6601");
        addQuest(new Answer("9832", false, -1), new Answer("10666", false, 0), new Answer("10888 ", true, 1), "3918 + 6970");
        addQuest(new Answer("61.35", false, -1), new Answer(" 81.5", false, 0), new Answer("71.395 ", true, 1), "71.8 − 0.405");
        addQuest(new Answer("2,32", false, -1), new Answer(" 1,35", false, 0), new Answer("2,35 ", true, 1), "9.16 − 6.81");
        addQuest(new Answer("48", false, -1), new Answer(" 47.4", false, 0), new Answer("48.56 ", true, 1), "53.6 − 5.04");
        addQuest(new Answer("72", true, -1), new Answer("60", false, 0), new Answer("65", false, 1), "1, 2 minuter är … sekunder.");
        addQuest(new Answer("170", false, -1), new Answer("100", false, 0), new Answer("144", true, 1), "1008 dagar är … veckor.");
        addQuest(new Answer("20", false, -1), new Answer("25,2", true, 0), new Answer("2,52", false, 1), "3, 6 veckor är … dagar.");
        addQuest(new Answer("70%", false, -1), new Answer("90%", false, 0), new Answer("97,5%", true, 1), "0, 975 motsvarar …");
        addQuest(new Answer("0,875", true, -1), new Answer("0,8", false, 0), new Answer("0,89", false, 1), "7 / 8 = …");
        addQuest(new Answer("7/10", true, -1), new Answer("7/9", false, 0), new Answer("7/11", false, 1), "70 % motsvarar …");
        addQuest(new Answer("15", false, -1), new Answer("12", true, 0), new Answer("11", false, 1), "11 = 132 / t \nt = …");
        addQuest(new Answer("12", true, -1), new Answer("16", false, 0), new Answer("9", false, 1), "20 = b + 8 \nb = …");
        addQuest(new Answer("9", false, -1), new Answer("6", false, 0), new Answer("8", true, 1), "p ^ 2 = 64 \np = …");
        addQuest(new Answer("4", false, -1), new Answer("1", false, 0), new Answer("2", true, 1), "q + 6 = 8 \nq = …");
        addQuest(new Answer("3", true, -1), new Answer("2", false, 0), new Answer("5", false, 1), "5c = 15 \nc = …");
        addQuest(new Answer("30,704", true, -1), new Answer("31", false, 0), new Answer("29,78", false, 1), "4, 04 x 7, 6");
        addQuest(new Answer("1700", false, -1), new Answer("1640", false, 0), new Answer("1560", true, 1), "26 x 60");
        addQuest(new Answer("1,69", false, -1), new Answer("1,6596", true, 0), new Answer("1,8", false, 1), "9, 22 x 0, 18");
        addQuest(new Answer("10,41", false, -1), new Answer("9,898", true, 0), new Answer("8,789", false, 1), "1, 4 x 7, 07");
        addQuest(new Answer("141,412", false, -1), new Answer("241,412", false, 0), new Answer("212,25", true, 1), "25 x 8, 49");
        addQuest(new Answer("1", false, -1), new Answer("3", false, 0), new Answer("5", true, 1), "15 / 3");
        addQuest(new Answer("1", false, -1), new Answer("2", true, 0), new Answer("0", false, 1), "2 x 1");
        addQuest(new Answer("64", false, -1), new Answer("256", true, 0), new Answer("600", false, 1), "16 ^ 2");
        addQuest(new Answer("1", true, -1), new Answer("0", false, 0), new Answer("2", false, 1), "0, 2 x 5");
    }

    public List<Question> allQues()
    {
        dataBs();
        return questions;
    }
}
