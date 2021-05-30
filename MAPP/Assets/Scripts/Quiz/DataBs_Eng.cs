using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBs_Eng : MonoBehaviour
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
        addQuest(new Answer("Malmö   ", false, -1), new Answer("Gothenburg  ", false, 0), new Answer("Stockholm ", true, 1), "The capital in Sweden is?");
        addQuest(new Answer("40     ", false, -1), new Answer("62 ", false, 0), new Answer("50 ", true, 1), "How many states are there in the USA?");
        addQuest(new Answer("Kyoto   ", false, -1), new Answer("Osaka  ", false, 0), new Answer("Tokyo ", true, 1), "The capital in Japan is …?");
        addQuest(new Answer("Bergen   ", false, -1), new Answer("Trondheim  ", false, 0), new Answer("Oslo ", true, 1), "The capital in Norway is …?");
        addQuest(new Answer("USA   ", false, -1), new Answer("Australia  ", false, 0), new Answer("Russia ", true, 1), "Which country is the world’s largest one by area?");
        addQuest(new Answer("Kilimanjaro   ", false, -1), new Answer("K2  ", false, 0), new Answer("Mount Everest ", true, 1), "Which one is the world’s tallest mountain?");
        addQuest(new Answer("Iceland   ", false, -1), new Answer("Sweden  ", false, 0), new Answer("Denmark ", true, 1), "Greenland is not a country, but belongs to …?");
        addQuest(new Answer("Kilimanjaro   ", false, -1), new Answer("Eastern hemisphere  ", false, 0), new Answer("North pole ", true, 1), "The Arctic is located at the …?");
        addQuest(new Answer("North pole   ", false, -1), new Answer("Western hemisphere  ", false, 0), new Answer("South pole ", true, 1), "Antarctica is located at the …?");
        addQuest(new Answer("Sydney   ", false, -1), new Answer("Melbourne  ", false, 0), new Answer("Canberra", true, 1), "The capital in Australia is …?");
        addQuest(new Answer("Kazan ", false, -1), new Answer("S:t Petersburg  ", false, 0), new Answer("Moscow", true, 1), "The capital in Russia is …?");
        addQuest(new Answer("5   ", false, -1), new Answer("10  ", false, 0), new Answer("7", true, 1), "How many continents are there in the world?");
        addQuest(new Answer("The Mekong   ", false, -1), new Answer("The Nile  ", false, 0), new Answer("The Amazon river", true, 1), "Which one is the world’s longest river?");
        addQuest(new Answer("The Mekong   ", false, -1), new Answer("The Amazon river  ", false, 0), new Answer("The Nile", true, 1), "Which one is the world’s second longest river?");
        addQuest(new Answer("Monaco   ", false, -1), new Answer("Malta  ", false, 0), new Answer("Vatican city", true, 1), "Which one is the world’s smallest country by area?");
        addQuest(new Answer("Rio de Janeiro   ", false, -1), new Answer("Sao Paulo  ", false, 0), new Answer("Brasília", true, 1), "The capital in Brazil is …?");
        addQuest(new Answer("Phuket   ", false, -1), new Answer("Pattaya  ", false, 0), new Answer("Bangkok", true, 1), "The capital in Thailand is …?");
        addQuest(new Answer("Atlantic ocean   ", false, -1), new Answer("Indian ocean  ", false, 0), new Answer("Pacific ocean", true, 1), "Which one is the world’s biggest ocean?");
        addQuest(new Answer("Russia   ", false, -1), new Answer("USA ", false, 0), new Answer("China", true, 1), "Which country has the most inhabitants?");
        addQuest(new Answer("Sweden   ", false, -1), new Answer("Norway  ", false, 0), new Answer("Iceland", true, 1), "Which country does NOT belong to Scandinavia?");
        addQuest(new Answer("Russia   ", false, -1), new Answer("Polen  ", false, 0), new Answer("Iceland", true, 1), "Which country belongs to the Nordic region?");



        addQuest(new Answer("Napoleon I   ", false, -1), new Answer("Charlemagne  ", false, 0), new Answer("Julius Caesar", true, 1), "Which one of these was a Roman emperor?");
        addQuest(new Answer("Khabul Khan   ", false, -1), new Answer("Alexander the Great  ", false, 0), new Answer("Djingis Khan", true, 1), "Who was the Mongolian ruler who united the Mongolian tribes?");
        addQuest(new Answer("Poland   ", false, -1), new Answer("Russia  ", false, 0), new Answer("Norway", true, 1), "In which country did Karl XII die in 1718?");
        addQuest(new Answer("1948   ", false, -1), new Answer("1952  ", false, 0), new Answer("1944", true, 1), "Which year was the Indian politician Mahatma Gandhi murdered?");
        addQuest(new Answer("26   ", false, -1), new Answer("23  ", false, 0), new Answer("19", true, 1), "How old was the French Saint, Jeanne d’Arc, when she was burned at the stake?");
        addQuest(new Answer("1985   ", false, -1), new Answer("1991  ", false, 0), new Answer("1989", true, 1), "In which year did the Berlin Wall fall?");
        addQuest(new Answer("the Roman Empire   ", false, -1), new Answer("Egypt  ", false, 0), new Answer("Macedonia", true, 1), "In which country was Alexander the Great king?");
        addQuest(new Answer("1985   ", false, -1), new Answer("1991  ", false, 0), new Answer("1989", true, 1), "In which year did the Berlin Wall fall?");

        addQuest(new Answer("8th century   ", false, -1), new Answer("11th century  ", false, 0), new Answer("10th century", true, 1), "During which time period did the king Harald Blåtand live??");
        addQuest(new Answer("1398   ", false, -1), new Answer("1429  ", false, 0), new Answer("1453", true, 1), "In which year did Constantinople fall?");
        addQuest(new Answer("1534-1564   ", false, -1), new Answer("1556-1586  ", false, 0), new Answer("1618-1648", true, 1), "During which years did the Thirty Years' War take place?");
        addQuest(new Answer("1508-1539   ", false, -1), new Answer("1531-1558  ", false, 0), new Answer("1523-1560", true, 1), "During which years was Gustav Vasa the king of Sweden?");
        addQuest(new Answer("Germany   ", false, -1), new Answer("England  ", false, 0), new Answer("France", true, 1), "Which country was Charlemagne king of??");
        addQuest(new Answer("1521   ", false, -1), new Answer("1518  ", false, 0), new Answer("1520", true, 1), "Which year did the Stockholm Bloodbath take place?");
        addQuest(new Answer("1985   ", false, -1), new Answer("1991  ", false, 0), new Answer("1792    ", true, 1), "Which year did Gustav III die, after having been attacked on a masquerade ball?");
        addQuest(new Answer("1516   ", false, -1), new Answer("1498  ", false, 0), new Answer("1492", true, 1), "Which year did Christofer Columbus reach America?");
        addQuest(new Answer("100 000 ", false, -1), new Answer("10 000 000 ", false, 0), new Answer("1 000 000  ", true, 1), "What is 1 megahertz = ? herz");

        addQuest(new Answer("1,5 kg/m3 ", false, -1), new Answer("1,0 kg/m3", false, 0), new Answer("1,0 kg/dm3     ", true, 1), "What density does water have ?");
        addQuest(new Answer("36 kg/dm3  ", false, -1), new Answer("16 kg/m3", false, 0), new Answer("9 kg /dm3     ", true, 1), "A copper part weighs 18kg and has a volume of 2.How much is the density ?");

        addQuest(new Answer("19,8m/s2   ", false, -1), new Answer("9,88m/s2", false, 0), new Answer("9,8m/s2 ", true, 1), "An object is falling in a vacuum freely.It flies without friktion, which means the acceleration is constant.If it occurs close to earth it is called gravity acceleration, about how much have we measured this constant to ? Answer is in m / s2 ");

        addQuest(new Answer("True ", false, -1), new Answer("Perhaps", false, 0), new Answer("False  ", true, 1), "Sublimation is the process in which a substance goes from fast to solid");

        addQuest(new Answer("False", false, -1), new Answer("Perhaps", false, 0), new Answer("True ", true, 1), "Sublimation is a substance direkt going from solid form to gasform, without going into a liquid state.");

        addQuest(new Answer("Chemical Energy", false, -1), new Answer("Thermal Energy", false, 0), new Answer("Electric Energy", true, 1), "What energy is stored in a battery. ");


        addQuest(new Answer("H2O", false, -1), new Answer("N2O", false, 0), new Answer("O2", true, 1), "What is the correct name for N2O ?") ;
        addQuest(new Answer("Sulfur", false, -1), new Answer("Carbon Dioxyde", false, 0), new Answer("Carbon monoxide", true, 1), "What gas is not classified as a greenhouse gas ?");

        addQuest(new Answer("-1 °C", false, -1), new Answer("100 °C", false, 0), new Answer("0 °C", true, 1), "What is Ice's melting point? ");
        addQuest(new Answer("0°C", false, -1), new Answer("55°C", false, 0), new Answer("100°C", true, 1), "What is water's boiling point at a normal air pressure?");
        

        addQuest(new Answer("274,15°C", false, -1), new Answer("-274,15°C", false, 0), new Answer("-273,15°C", true, 1), "What temperature is called the absolute zero ?");


        addQuest(new Answer("2", false, -1), new Answer("1,5", false, 0), new Answer("1", true, 1), "How many newtonmeters is a Joule ?");

        addQuest(new Answer("wave travel", false, -1), new Answer("power length", false, 0), new Answer("Wavelength ", true, 1), "What is the distance between two wavecrest called ?");

        addQuest(new Answer("pressure  =  force * area", false, -1), new Answer("pressure = pressure/area", false, 0), new Answer("pressure = force/area", true, 1), "What formula is a real one ?");

        addQuest(new Answer("2 N/m²", false, -1), new Answer("1,5 N/m²", false, 0), new Answer("1 N/m²", true, 1), "1 Pascal(Pa) is equal to ?");

        addQuest(new Answer("1 Pa ", false, -1), new Answer("1N", false, 0), new Answer("1J", true, 1), "What is the unit used for measuring pressure ?") ;
        addQuest(new Answer("Ampere", false, -1), new Answer("watt", false, 0), new Answer("volt", true, 1), "The unit used to measure voltage");
        addQuest(new Answer("Ampere", false, -1), new Answer("m/s", false, 0), new Answer("hertz", true, 1), "The unit used to measure frequency");

        addQuest(new Answer("220V", false, -1), new Answer("240V ", false, 0), new Answer("230V", true, 1), "What is the voltage in a standard(swedish) socket");

        addQuest(new Answer("Venus", false, -1), new Answer("Mars ", false, 0), new Answer("Mercury", true, 1), "What is the smallest planet ?");

        addQuest(new Answer("Saturne", false, -1), new Answer("Neptune ", false, 0), new Answer("Jupiter", true, 1), "What is the largest planet ");

        addQuest(new Answer("v  ", false, -1), new Answer("Vega", false, 0), new Answer("Sirius", true, 1), "The closest star we can see(except the sun) is … ? ");





        addQuest(new Answer("Walk  ", false, -1), new Answer("Horse ", false, 0), new Answer("Big ", true, 1),"What is an example of an adjective ?");


        addQuest(new Answer("Run  ", false, -1), new Answer("Red ", false, 0), new Answer("horse ", true, 1), "What is an example of a noun ?");
        addQuest(new Answer("Largest", true, 1), new Answer("Largest", false, 0), new Answer("Larger", false, -1), "Large, larger ...?");
        addQuest(new Answer("Cuat", false, -1), new Answer("Skar", false, 0), new Answer("Cut", true, 1), "Yesterday .... I orange");
        addQuest(new Answer("9", true, 1), new Answer("10", false, 0), new Answer("6", false, -1), "How many word classes are there?");
        addQuest(new Answer("Where", false, -1), new Answer("How", false, 0), new Answer("Who", true, 1), "What are examples of pronouns?");
        addQuest(new Answer("Wile", false, -1), new Answer("Wihle", false, 0), new Answer("While", true, 1), "How do you spell this?");
        addQuest(new Answer("Enouf", false, 0), new Answer("Enough", true, 1), new Answer("Enogh", false, -1), "How do you spell this?");
        addQuest(new Answer("Yawn", false, -1), new Answer("Breathe", false, 0), new Answer("Pant", true, 1), "What does pant mean?");
        addQuest(new Answer("Miserable", false, -1), new Answer("Bad", false, 0), new Answer("Great", true, 1), "What is a synonym for good?");
        addQuest(new Answer("List", false, -1), new Answer("Decide", false, 0), new Answer("Accord", true, 1), "What is a synonym for agreement?");
        addQuest(new Answer("Go", false, -1), new Answer("Exit", false, 0), new Answer("arrive", true, 1), "What is the opposite word on departure?");
        addQuest(new Answer("Dangerous", false, -1), new Answer("Common", false, 0), new Answer("Normal", true, 1), "What is the opposite of the word strange?");
        addQuest(new Answer("Weak", false, -1), new Answer("Bad", false, 0), new Answer("Fresh", true, 1), "What is a synonym for healthy?");
        addQuest(new Answer("Dog hot", false, -1), new Answer("Kourv", false, 0), new Answer("Sausage", true, 1), "What is a synonym to hot dog ? ");
        addQuest(new Answer("0", false, -1), new Answer("2", false, 0), new Answer("5", true, 1), "How many minority languages are there in Sweden?");
        addQuest(new Answer("100", false, -1), new Answer("400", false, 0), new Answer("200", true, 1), "How many languages are spoken in Sweden?");
        addQuest(new Answer("5908", false, -1), new Answer("5209", false, 0), new Answer("6809", true, 1), "How many languages are spoken in the world?");


        addQuest(new Answer("6905", false, -1), new Answer("7340", false, 0), new Answer("7260 ", true, 1), "1443 + 5817 ");
        addQuest(new Answer("5002", false, -1), new Answer("4670", false, 0), new Answer("4748 ", true, 1), "2779 + 1969 ");
        addQuest(new Answer("5832", false, -1), new Answer("6455", false, 0), new Answer("6188 ", true, 1), "3326 + 2862");
        addQuest(new Answer("16700", false, -1), new Answer("12600", false, 0), new Answer("13081 ", true, 1), "6480 + 6601");
        addQuest(new Answer("9832", false, -1), new Answer("10666", false, 0), new Answer("10888 ", true, 1), "3918 + 6970");
        addQuest(new Answer("61.35", false, -1), new Answer(" 81.5", false, 0), new Answer("71.395 ", true, 1), "71.8 − 0.405");
        addQuest(new Answer("2.32", false, -1), new Answer(" 1.35", false, 0), new Answer("2.35 ", true, 1), "9.16 − 6.81");
        addQuest(new Answer("48", false, -1), new Answer(" 47.4", false, 0), new Answer("48.56 ", true, 1), "53.6 − 5.04");
        addQuest(new Answer("60", false, -1), new Answer("65", false, 0), new Answer("72", true, 1), "Convert 1.2 minutes per second");
        addQuest(new Answer("170", false, -1), new Answer("100", false, 0), new Answer("144", true, 1), "Convert 1008 days to weeks");
        addQuest(new Answer("20", false, -1), new Answer("2,52", false, 0), new Answer("25,2", true, 1), "Convert 3.6 weeks to days");
        addQuest(new Answer("90%", false, -1), new Answer("70%", false, 0), new Answer("97.5%", true, 1), "What is 0.975 as a percentage ");
        addQuest(new Answer("0.8", false, -1), new Answer("0.89", false, 0), new Answer("0.875", true, 1), "What is 7/8 as decimal point ");
        addQuest(new Answer("7/9", false, -1), new Answer("7/11", false, 0), new Answer("7/10", true, 1), "What is 70% decimal point ");
        addQuest(new Answer("15 ", false, -1), new Answer(" 11 ", false, 0), new Answer("12", true, 1), "what is T if 11 = 132 / t");
        addQuest(new Answer("9 ", false, -1), new Answer(" 6", false, 0), new Answer("8", true, 1), "What is p if p ^ 2 = 64");
        addQuest(new Answer("1 ", false, -1), new Answer(" 4", false, 0), new Answer("2", true, 1), "What is q if q + 6 = 8");
        addQuest(new Answer("5", false, -1), new Answer("2", false, 0), new Answer("3", true, 1), "what is c if 5c = 15");
        addQuest(new Answer("31", false, -1), new Answer("29.78", false, 0), new Answer("30.704", true, 1), "4.04 × 7.6");
        addQuest(new Answer("1700", false, -1), new Answer("1640", false, 0), new Answer("1560", true, 1), "26 × 60");
        addQuest(new Answer("1.69", false, -1), new Answer("1.8", false, 0), new Answer("1.6596", true, 1), "9.22 × 0.18 ");
        addQuest(new Answer("10.41", false, -1), new Answer("8.789", false, 0), new Answer("9.898", true, 1), "1.4 × 7.07 ");
        addQuest(new Answer("141.412", false, -1), new Answer("8.789", false, 0), new Answer("212.25", true, 1), "25 × 8.49 ");
        addQuest(new Answer("1", false, -1), new Answer("3", false, 0), new Answer("5", true, 1), "153");
        addQuest(new Answer("1", false, -1), new Answer("0", false, 0), new Answer("2", true, 1), "2 x 1");
        addQuest(new Answer("64", false, -1), new Answer("600", false, 0), new Answer("256", true, 1), "16 ^ 2");
        addQuest(new Answer("0", false, -1), new Answer("2", false, 0), new Answer("1", true, 1), "0.2 x 5");

    }

    public List<Question> allQues()
    {
        dataBs();
        return questions;
    }
}
