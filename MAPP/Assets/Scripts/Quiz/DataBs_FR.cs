using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBs_FR : MonoBehaviour
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

    void dataBs()  {
        addQuest(new Answer("Gothenburg ", false, -1), new Answer("Malmö ", false, 0), new Answer("Stockholm ", true, 1), "Quelle est la capitale de Suède?");
        addQuest(new Answer("40 ", false, -1), new Answer("62 ", false, 0), new Answer("50 ", true, 1), "Combien d'etats on les Etats-Unis?");
        addQuest(new Answer("Kyoto ", false, -1), new Answer("Osaka ", false, 0), new Answer("Tokyo ", true, 1), "Quelle est la capitale du Japon?");
        addQuest(new Answer("Bergen ", false, -1), new Answer("Trondheim ", false, 0), new Answer("Oslo ", true, 1), "Quelle est la capitale de la Norvège?");
        addQuest(new Answer("Etats-Unis ", false, -1), new Answer("Australie ", false, 0), new Answer("Russie ", true, 1), "Le pays avec la plus grande surface est …?");
        addQuest(new Answer("Kilimanjaro ", false, -1), new Answer("K2 ", false, 0), new Answer("Mont Everest ", true, 1), "Quelle est la plus grande montagne?");
        addQuest(new Answer("Donau ", false, -1), new Answer("Dnepr ", false, 0), new Answer("Volga ", true, 1), "Quel est le plus long fleuve dans l’Europe?");
        addQuest(new Answer("Kilimanjaro ", false, -1), new Answer("K2 ", false, 0), new Answer("Mont Everest ", true, 1), "Quelle est la deuxième plus grande montagne?");
        addQuest(new Answer("Islande ", false, -1), new Answer("Suède ", false, 0), new Answer("Danmark", true, 1), "Groenland n’est pas un pays propre mais appartient á? ");
        addQuest(new Answer("Pôle sud ", false, -1), new Answer("L’hémisphère oriental ", false, 0), new Answer("Pôle Nord", true, 1), "L'arctique se situe sur le...? ");
        addQuest(new Answer("Pôle Nord ", false, -1), new Answer("L’hémisphère occidental", false, 0), new Answer("Pôle Sud", true, 1), "L'antarctique se situe sur le...? ");
        addQuest(new Answer("Melbourne", false, -1), new Answer(" Sydney", false, 0), new Answer("Canberra", true, 1), "Quelle est la capitale de l’Australie? ");
        addQuest(new Answer("S:t Petersburg", false, -1), new Answer(" Kazan", false, 0), new Answer("Moskva", true, 1), "Quelle est la capitale de la Russie ");
        addQuest(new Answer("72", false, -1), new Answer(" 38", false, 0), new Answer("49", true, 1), "Combien de pays y a-t-il en Europe?");
        addQuest(new Answer("5", false, -1), new Answer(" 10", false, 0), new Answer("7", true, 1), "Combien de continent y a-t-il dans le monde?");
        addQuest(new Answer("Nil", false, -1), new Answer(" Mekong", false, 0), new Answer("L’Amazone", true, 1), "Quel est le fleuve le plus long au monde?");
        addQuest(new Answer("L’Amazone", false, -1), new Answer(" Mekong", false, 0), new Answer("Nil", true, 1), "Quel est le fleuve le deuxième plus long au monde?");
        addQuest(new Answer("Monaco", false, -1), new Answer(" Malta", false, 0), new Answer("Le Vatican", true, 1), "Quel est le plus petit pays au monde?");
        addQuest(new Answer("Rio de Janeiro", false, -1), new Answer(" Sao Paulo", false, 0), new Answer("Brasília", true, 1), "Quelle est la capitale du Brésil?");
        addQuest(new Answer("Phuket", false, -1), new Answer(" Pattaya", false, 0), new Answer("Bangkok", true, 1), "Quelle est la capitale de la Thaïlande?");
        addQuest(new Answer("Atlantique", false, -1), new Answer(" Océan Indien", false, 0), new Answer("Pacifique", true, 1), "Quel est le plus grand océan");
        addQuest(new Answer("Etats-Unis", false, -1), new Answer("Russie", false, 0), new Answer("Chine", true, 1), "Quel pays a la plus grande population?");
        addQuest(new Answer("Suède", false, -1), new Answer("Norvège", false, 0), new Answer("Islande", true, 1), "Quel pays ne fait pas partie de la Scandinavie?");
        addQuest(new Answer("Russie", false, -1), new Answer("Pologne", false, 0), new Answer("Islande", true, 1), "Quel pays appartient au Nord?");
        addQuest(new Answer("Napoleon I", false, -1), new Answer("Charlemagne", false, 0), new Answer("Jules César", true, 1), "Laquelle de ces personnes était un Empereur Romain?");
        addQuest(new Answer("Khabul Khan", false, -1), new Answer("Alexandre le Grand", false, 0), new Answer("Gengis Khan", true, 1), "Qui était le dirigeant mongol qui a uni les tribus mongol?");
        addQuest(new Answer("Pologne", false, -1), new Answer("Russie", false, 0), new Answer("Norvège", true, 1), "Dans quel pays Charles XII, roi de Suède, est-il mort?");
        addQuest(new Answer("1948", false, -1), new Answer("1952", false, 0), new Answer("1944", true, 1), "Quelle année ,le politicien indien, Mahatma Gandhi c’est t-il fait assassiner?");
        addQuest(new Answer("23", false, -1), new Answer("26", false, 0), new Answer("19", true, 1), "Quel âge avait Jeanne d’arc quand elle sait fait brûler sur la bûche ?");
        addQuest(new Answer("1954", false, -1), new Answer("1949", false, 0), new Answer("1961", true, 1), "Quelle année le Mur de Berlin a t-il était construit?");
        addQuest(new Answer("1985", false, -1), new Answer("1991", false, 0), new Answer("1989", true, 1), "Quelle année le Mur de Berlin s'est t-il fait détruire?");
        addQuest(new Answer("L’empire Romain", false, -1), new Answer("Égypt", false, 0), new Answer("Macédoine", true, 1), "De quel pays Alexandre le Grand était -il le roi?");
        addQuest(new Answer("8eme Siècle", false, -1), new Answer("11eme Siècle", false, 0), new Answer("10eme Siècle", true, 1), "Pendant quelle période vivait le Roi Harald á la dent bleue?");
        addQuest(new Answer("1429", false, -1), new Answer("1398", false, 0), new Answer("1453", true, 1), "Quelle année Constantinople s'est t-elle fait abattre?");
        addQuest(new Answer("1534-1564", false, -1), new Answer("1556-1586", false, 0), new Answer("1618-1648", true, 1), "Pendant quelle année la Guerre de Trente Ans a-t-elle eu lieu?");
        addQuest(new Answer("1534-1564", false, -1), new Answer("1556-1586", false, 0), new Answer("1618-1648", true, 1), "Pendant quelle année la Guerre de Trente Ans a-t-elle eu lieu?");
        addQuest(new Answer("Allemagne", false, -1), new Answer("Angleterre", false, 0), new Answer("France", true, 1), "De quel pays Charlemagne était t-il roi de?");
        addQuest(new Answer("1521", false, -1), new Answer("1518", false, 0), new Answer("1520", true, 1), "Quelle année le Ban de sang de Stockholm a-t-elle eu lieu.");
        addQuest(new Answer("1784", false, -1), new Answer("1796", false, 0), new Answer("1792", true, 1), "Quelle année Gustave III, roi de Suède, est-il mort après qu'il s'est fait attaquer sur un bal masqué?");
        addQuest(new Answer("1516", false, -1), new Answer("1498", false, 0), new Answer("1492", true, 1), "Quelle année Christophe Colomb a-t-il atteint L'Amérique?");
        addQuest(new Answer("100 000 ", false, -1), new Answer("10 000 000 ", false, 0), new Answer("1 000 000  ", true, 1), "Combien de hertz vaut 1 mégahertz ?");
        addQuest(new Answer("1,5 kg/m3 ", false, -1), new Answer("1,0 kg/m3", false, 0), new Answer("1,0 kg/dm3 	", true, 1), "Quelle densité a l’eau ?");
        addQuest(new Answer("36 kg/dm3  ", false, -1), new Answer("16 kg/m3", false, 0), new Answer("9 kg /dm3 	", true, 1), "Une partie de cuivre pèse 18kg et a un volume de 2.Que est la densité ?");
        addQuest(new Answer("19,8m/s2   ", false, -1), new Answer("9,88m/s2", false, 0), new Answer("9,8m/s2 ", true, 1), "Quelle est la constante d’accélération sur terre ?");
        addQuest(new Answer("Vrai ", false, -1), new Answer("Peut-être", false, 0), new Answer("Faux  ", true, 1), "La sublimation est le processus dans lequel une substance va de forme solide en gaz.");
        addQuest(new Answer("Faux", false, -1), new Answer("Peut-être", false, 0), new Answer("Vrai ", true, 1), "La sublimation est le processus dans lequel une substance va de forme solide en gaz sans entrer dans un forme liquide.");
        addQuest(new Answer("Énergie Chimique", false, -1), new Answer("Énergie Thermique", false, 0), new Answer("Énergie Électrique", true, 1), "Quelle énergie est stockée dans un batterie ?");
        addQuest(new Answer("Azote", false, -1), new Answer("Dioxyde de carbone", false, 0), new Answer("Protoxyde d'azote", true, 1), "Quel est le nom de N2O");
        addQuest(new Answer("H2O", false, -1), new Answer("N2O", false, 0), new Answer("O2", true, 1), "Quel gaz n’est pas classé comme un gaz à effet de serre ?");
        addQuest(new Answer("trioxyde de soufre", false, -1), new Answer("Dioxyde de Carbone", false, 0), new Answer("monoxyde de carbone", true, 1), "Quel est le nom de CO ?");
        addQuest(new Answer("-1 °C", false, -1), new Answer("100 °C", false, 0), new Answer("0 °C", true, 1), "Quel est le point de fusion de la glace ?");
        addQuest(new Answer("0°C", false, -1), new Answer("55°C", false, 0), new Answer("100°C", true, 1), "Quel est le point d'ébullition pour l’eau?");
        addQuest(new Answer("274,15°C", false, -1), new Answer("-274,15°C", false, 0), new Answer("-273,15°C", true, 1), "Quelle température est surnommée le zéro absolu ?");
        addQuest(new Answer("2", false, -1), new Answer("1,5", false, 0), new Answer("1", true, 1), "Combien de Newton mètres est un Joule ?");
        addQuest(new Answer("voyage des vagues", false, -1), new Answer("longueur de puissance", false, 0), new Answer("Longueur d'onde ", true, 1), "Comment s’appelle la distance entre deux crêtes de vague ?");
        addQuest(new Answer("Pression  =  force * surface", false, -1), new Answer("Pression = Pression/surface", false, 0), new Answer("Pression = force/surface", true, 1), "Quelle est la vraie formule ?");
        addQuest(new Answer("2 N/m²", false, -1), new Answer("1,5 N/m²", false, 0), new Answer("1 N/m²", true, 1), "1 Pascal(Pa) est égal à ?");
        addQuest(new Answer("1 Pa ", false, -1), new Answer("1N", false, 0), new Answer("1J", true, 1), "Quelle est l’unité utilisée pour mesurer la pression ?");
        addQuest(new Answer("Ampere", false, -1), new Answer("watt", false, 0), new Answer("volt", true, 1), "Quelle est l’unité utilisée pour mesurer la tension.");
        addQuest(new Answer("Ampere", false, -1), new Answer("m/s", false, 0), new Answer("hertz", true, 1), "Quelle est l’unité utilisée pour mesurer la fréquence.");
        addQuest(new Answer("220V", false, -1), new Answer("240V ", false, 0), new Answer("230V", true, 1), "Quelle est la tension dans une prise standard.");
        addQuest(new Answer("Venus", false, -1), new Answer("Mars ", false, 0), new Answer("Mercure", true, 1), "Quelle est la planète la plus petite ?");
        addQuest(new Answer("Saturne", false, -1), new Answer("Neptune ", false, 0), new Answer("Jupiter", true, 1), "Quelle est la planète la plus grande ?");
        addQuest(new Answer("Betelgeuze ", false, -1), new Answer("Vega", false, 0), new Answer("Sirius", true, 1), "Quelle est l’étoile la plus proche qu'on peut voir(excluant le Soleil)?");
    }






    public List<Question> allQues()
    {
        dataBs();
        return questions;
    }
}
