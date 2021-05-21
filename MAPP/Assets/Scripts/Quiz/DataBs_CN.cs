using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBs_CN : MonoBehaviour
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
        addQuest(new Answer("哥德堡", false, -1), new Answer("马尔默", false, 0), new Answer("斯德哥尔摩", true, 1), "瑞典的首都是？");

        addQuest(new Answer("40", false, -1), new Answer("62", false, 0), new Answer("50", true, 1), "美国有多少个自治州?");

        addQuest(new Answer("东京", true, -1), new Answer("京东", false, 0), new Answer("大版", false, 1), "日本的首都是");

        addQuest(new Answer("奥斯陆", true, -1), new Answer("卑尔根", false, 0), new Answer("特隆赫姆", false, 1), "挪威的首都是");

        addQuest(new Answer("俄罗斯", true, -1), new Answer("美国", false, 0), new Answer("澳大利亚", false, 1), "世界上土地面积最大的国家是?");

        addQuest(new Answer("珠穆朗玛峰 ", true, -1), new Answer("乞力马扎罗山", false, 0), new Answer("乔戈里峰", false, 1), "世界上最高的山是？");

        addQuest(new Answer("杜尔加河", true, -1), new Answer("多瑙河", false, 0), new Answer("第聂伯河", false, 1), "欧洲最长的河流是？");


        addQuest(new Answer("乞力马扎罗山", false, -1), new Answer("乔戈里峰", true, 0), new Answer("马卡鲁峰", false, 1), "世界上第二高的山是？");


        addQuest(new Answer("丹麦", false, -1), new Answer("冰岛", true, 0), new Answer("瑞典", false, 1), "格林兰岛属于哪个国家？");

        addQuest(new Answer("南极", false, -1), new Answer("北极", true, 0), new Answer("东半球", false, 1), "北冰洋位于哪里？");

        addQuest(new Answer("北极", false, -1), new Answer("西半球", false, 0), new Answer("南极", true, 1), "南极洲位于地球的哪里？");

        addQuest(new Answer("墨尔本", false, -1), new Answer("堪培拉", true, 0), new Answer("悉尼", false, 1), "澳大利亚的首都是？");


        addQuest(new Answer("莫斯科", true, -1), new Answer("圣彼得堡", false, 0), new Answer("喀山", false, 1), "俄罗斯的首都是哪里？");

        addQuest(new Answer("49", true, -1), new Answer("72", false, 0), new Answer("38", false, 1), "欧洲有多少国家？");

        addQuest(new Answer("5", false, -1), new Answer("7", true, 0), new Answer("10", false, 1), "地球有几个大洲？");

        addQuest(new Answer("亚马逊河", true, -1), new Answer("尼罗河", false, 0), new Answer("湄公河", false, 1), "地球最长的河流是？");

        addQuest(new Answer("亚马逊河", false, -1), new Answer("湄公河", false, 0), new Answer("尼罗河", true, 1), "第二长的河流是？");

        addQuest(new Answer("摩洛哥", false, -1), new Answer("马耳他", false, 0), new Answer("梵蒂冈", true, 1), "地球上最小的国家是？");

        addQuest(new Answer("巴西", true, -1), new Answer("里约热内卢", false, 0), new Answer("圣保罗", false, 1), "巴西利亚的首都是？");

        addQuest(new Answer("曼谷", true, -1), new Answer("普吉", false, 0), new Answer("芭提雅", false, 1), "泰国的首都是？");

        addQuest(new Answer("大西洋", false, -1), new Answer("太平洋地区", true, 0), new Answer("印度洋", false, 1), "世界最大的海洋是？");

        addQuest(new Answer("美国", false, -1), new Answer("俄罗斯", false, 0), new Answer("中国", true, 1), "下列哪个国家人口最多？");

        addQuest(new Answer("冰岛", true, -1), new Answer("瑞典", false, 0), new Answer("挪威", true, 1), "以下哪个国家不属于斯堪的纳维亚");

        addQuest(new Answer("冰岛", true, -1), new Answer("俄罗斯", false, 0), new Answer("波兰", false, 1), "以下哪个国家属于北欧国家？");

        //以上是地理问题24题

        addQuest(new Answer("拿破仑一世", false, -1), new Answer("凯撒大帝", true, 0), new Answer("查理曼大帝", false, 1), "以下谁是罗马皇帝？");

        addQuest(new Answer("成吉思汗", true, -1), new Answer("哈布尔汗", false, 0), new Answer("亚历山大帝", false, 1), "谁是团结蒙古部落的蒙古统治者？");

        addQuest(new Answer("挪威", true, -1), new Answer("波兰", false, 0), new Answer("俄罗斯", false, 1), "卡尔十二世死于哪个国家（1718年）");

        addQuest(new Answer("1944", true, -1), new Answer("1948", false, 0), new Answer("1952", false, 1), "印度政客甘地于哪一年遇害？");

        addQuest(new Answer("26", false, -1), new Answer("19", true, 0), new Answer("23", false, 1), "法国圣女珍妮达尔克被烧死在火刑柱上的时候多少岁？");

        addQuest(new Answer("1949", false, -1), new Answer("1954", false, 0), new Answer("1961", true, 1), "柏林墙于几几年建成？");

        addQuest(new Answer("1985", false, -1), new Answer("1991", false, 0), new Answer("1989", true, 1), "柏林墙是哪一年拆的？");

        addQuest(new Answer("马其顿", true, -1), new Answer("罗马帝国", false, 0), new Answer("埃及", false, 1), "亚历山大大帝曾统治过哪个国家？");

        addQuest(new Answer("900年代", true, -1), new Answer("700年代", false, 0), new Answer("1000年代", false, 1), "蓝牙哈拉尔是哪个时期的皇帝？");

        addQuest(new Answer("1429", false, -1), new Answer("1398", false, 0), new Answer("1453", true, 1), "君士坦丁堡是哪一年沦陷？");

        addQuest(new Answer("1618-1648", true, -1), new Answer("1534-1564", false, 0), new Answer("1556-1586", false, 1), "三十年战争发生在哪几年？");

        addQuest(new Answer("1523-1560", true, -1), new Answer("1508-1539", false, 0), new Answer("1531-1558", false, 1), "以下哪个是瑞典国王古斯塔夫瓦萨的在位时间？");

        addQuest(new Answer("德国", false, -1), new Answer("法国", true, 0), new Answer("英国", false, 1), "查理曼大帝是哪个国家的？");

        addQuest(new Answer("1518", false, -1), new Answer("1520", true, 0), new Answer("1521", false, 1), "斯德哥尔摩大屠杀发生在哪一个？");

        addQuest(new Answer("1792", true, -1), new Answer("1784", false, 0), new Answer("1796", false, 1), "古斯塔夫三世在化妆舞会被刺后身亡是哪一年？");

        addQuest(new Answer("1498", false, -1), new Answer("1516", false, 0), new Answer("1492", true, 1), "克里斯托弗哥伦布哪一个到达的美国？");

        //常识类16题

        addQuest(new Answer("1 000 000", true, -1), new Answer("10 000 000", false, 0), new Answer("100 000", false, 1), "一兆赫兹等于多少赫兹？");

        addQuest(new Answer("1,0 kg/dm3", true, -1), new Answer(" 1,5 kg/m3 ", false, 0), new Answer("1,0 kg/m3", false, 1), "水的密度是多少？");

        addQuest(new Answer("36 kg/dm3  ", false, -1), new Answer("9 kg /dm3 ", true, 0), new Answer("16 kg/m3  ", false, 1), "一块铜重18公斤，体积为2 dm的三次方，密度是多少？");


        addQuest(new Answer("19.8", false, -1), new Answer("9.8", true, 0), new Answer("9.88", false, 1), "处于真空中的物体会自由下落。 它无摩擦地下落，这意味着加速度是恒定的。 在地球附近，这称为重力加速度，大约是多少？ m / s2？");

        addQuest(new Answer("对", false, -1), new Answer("不对", true, 0), new Answer("可能对", false, 1), "沉积是一种过程，其中物质直接从固体形式变为气体形式。");

        addQuest(new Answer("对", true, -1), new Answer("不对", false, 0), new Answer("可能对", false, 1), "升华是物质从团聚状态直接转变为固体形式，而没有通过中间相液体形式。");

        addQuest(new Answer("化学能源", false, -1), new Answer("电能", true, 0), new Answer("热能", false, 1), "电池有什么能量？");

        addQuest(new Answer("一氧化氮", true, -1), new Answer("二氧化碳", false, 0), new Answer("二氧化氮", false, 1), "N2O的正确名称是？");

        addQuest(new Answer("H2O", false, -1), new Answer("N2O", false, 0), new Answer("O2", true, 1), "以下哪种气体不是温室气体？");

        addQuest(new Answer("一氧化碳", true, -1), new Answer("二氧化碳", false, 0), new Answer("三氧化硫", false, 1), "CO的正确名称是？");

        addQuest(new Answer("-1度", false, -1), new Answer("0度", true, 0), new Answer("100度", false, 1), "冰的熔点是？");

        addQuest(new Answer("55度", false, -1), new Answer("0度", false, 0), new Answer("100度", true, 1), "水的沸点是？");

        addQuest(new Answer("", false, -1), new Answer("", true, 0), new Answer("", false, 1), "哪个温度称为绝对零点？");

        addQuest(new Answer("-273.15度", true, -1), new Answer("274.15度", false, 0), new Answer("-274.15度", false, 1), "");

        addQuest(new Answer("2", false, -1), new Answer("1", true, 0), new Answer("1.5", false, 1), "一焦耳是多少牛顿米？");

        addQuest(new Answer("波长", true, -1), new Answer("波距", false, 0), new Answer("力长", false, 1), "两个波峰之间的距离称为？");

        addQuest(new Answer("压强等于力乘以面积", false, -1), new Answer("压强等与力除以面积", true, 0), new Answer("力等于压强除以面积", false, 1), "以下哪个公式是正确的？");

        addQuest(new Answer("1 N/m2", true, -1), new Answer("2 N/m2", false, 0), new Answer("1.5 N/m2", false, 1), "一帕斯卡等于？");

        addQuest(new Answer("1 Pa", true, -1), new Answer("1 N", false, 0), new Answer("1 J", false, 1), "压强的基本单位是？");

        addQuest(new Answer("安培", false, -1), new Answer("伏特", true, 0), new Answer("瓦特", false, 1), "电压单位");

        addQuest(new Answer("安培", false, -1), new Answer("m/s", false, 0), new Answer("赫兹", true, 1), "频率的单位是？");

        addQuest(new Answer("220V", false, -1), new Answer("240V", false, 0), new Answer("230V", true, 1), "普通家里的插座电压是？");

        addQuest(new Answer("金星", false, -1), new Answer("火星", false, 0), new Answer("水星", true, 1), "最小的行星");

        addQuest(new Answer("土星", false, -1), new Answer("木星", true, 0), new Answer("海王星", false, 1), "最大的行星？");

        addQuest(new Answer("参宿四", false, -1), new Answer("天狼星", true, 0), new Answer("织女星", false, 1), "除了太阳，我们可以从我们看到的最近的恒星?");

        addQuest(new Answer("星系", false, -1), new Answer("星云", true, 0), new Answer("宇宙大爆炸", false, 1), "星型系统");


        // 物理化学26题


        addQuest(new Answer("大", true, -1), new Answer("去", false, 0), new Answer("马", false, 1), "以下哪一个是形容词？");

        addQuest(new Answer("跑", false, -1), new Answer("红", false, 0), new Answer("马", true, 1), "以下哪一个是名词？");

        addQuest(new Answer("最大的", true, -1), new Answer("大的", false, 0), new Answer("很大的", false, 1), "Stor的最高级是什么？");

        addQuest(new Answer("削", true, -1), new Answer("销", false, 0), new Answer("消", true, 1), "选词填空我昨天--一个橙子");

        addQuest(new Answer("6", false, -1), new Answer("10", false, 0), new Answer("9", true, 1), "普通来说，瑞典语有多少个词类");

        addQuest(new Answer("谁", true, -1), new Answer("哪", false, 0), new Answer("如何", false, 1), "以下哪个例子是代词？");

        addQuest(new Answer("While", true, -1), new Answer("Wile", false, 0), new Answer("Wihle", false, 1), "尽管，然后，却的英文是什么？");

        addQuest(new Answer("Enouf", false, -1), new Answer("Enough", true, 0), new Answer("Enogh", false, 1), "英语足够怎么说？");

        addQuest(new Answer("麦片", false, -1), new Answer("粥", true, 0), new Answer("谷物", false, 1), "餬(糊)又可以叫做什么？");

        addQuest(new Answer("喘气", true, -1), new Answer("叹气", false, 0), new Answer("打哈欠", false, 1), "英语pant是什么意思");

        addQuest(new Answer("优秀的", true, -1), new Answer("女性内衣", false, 0), new Answer("糟糕", false, 1), "瑞典语中的bra是什么意思？");

        addQuest(new Answer("列举", false, -1), new Answer("连接", true, 0), new Answer("决定", false, 1), "瑞典语中，以下哪一个是avtal的同义词？");

        addQuest(new Answer("出去", false, -1), new Answer("到达", true, 0), new Answer("建造", false, 1), "瑞典语中，avfärd的反义词是什么？");

        addQuest(new Answer("奇怪的", false, -1), new Answer("引人注目的", false, 0), new Answer("普通的", true, 1), "瑞典语中，konstig的反义词是哪一个？");

        addQuest(new Answer("康健", true, -1), new Answer("衰弱", false, 0), new Answer("虚弱", false, 1), "瑞典语中，以下哪一个是frisk的同义词？");

        addQuest(new Answer("Longist", false, -1), new Answer("Longest", true, 0), new Answer("Longst", false, 1), "英语最长的怎么说？");

        addQuest(new Answer("Dog", false, -1), new Answer("Kourv", false, 0), new Answer("Sausage", true, 1), "英语香肠怎么说？");

        addQuest(new Answer("0", false, -1), new Answer("2", false, 0), new Answer("5", true, 1), "瑞典有多少个少数名族语言？");

        addQuest(new Answer("100", false, -1), new Answer("200", true, 0), new Answer("400", false, 1), "瑞典居住人口中一共有多少语言？");

        addQuest(new Answer("5908", false, -1), new Answer("5209", false, 0), new Answer("6809", true, 1), "全世界有多少语言？");

        addQuest(new Answer("中文", true, -1), new Answer("英文", false, 0), new Answer("印度语", false, 1), "世界最大的语言是什么？");

        addQuest(new Answer("九亿七千万", false, -1), new Answer("八亿四千万", true, 0), new Answer("六亿一千万", false, 1), "世界上又大约多少人说中文？");

        //22 english and swedish quz

        addQuest(new Answer("6905", false, -1), new Answer("7340", false, 0), new Answer("7260 ", true, 1), "1443 + 5817 ");
        addQuest(new Answer("5002", false, -1), new Answer("4670", false, 0), new Answer("4748 ", true, 1), "2779 + 1969 ");
        addQuest(new Answer("5832", false, -1), new Answer("6455", false, 0), new Answer("6188 ", true, 1), "3326 + 2862");
        addQuest(new Answer("16700", false, -1), new Answer("12600", false, 0), new Answer("13081 ", true, 1), "6480 + 6601");
        addQuest(new Answer("9832", false, -1), new Answer("10666", false, 0), new Answer("10888 ", true, 1), "3918 + 6970");
        addQuest(new Answer("61.35", false, -1), new Answer(" 81.5", false, 0), new Answer("71.395 ", true, 1), "71.8 − 0.405");
        addQuest(new Answer("2.32", false, -1), new Answer(" 1.35", false, 0), new Answer("2.35 ", true, 1), "9.16 − 6.81");
        addQuest(new Answer("48", false, -1), new Answer(" 47.4", false, 0), new Answer("48.56 ", true, 1), "53.6 − 5.04");
        addQuest(new Answer("60", false, -1), new Answer("65", false, 0), new Answer("72 ", true, 1), "1.2分钟有多少秒");
        addQuest(new Answer("170 ", false, -1), new Answer("100", false, 0), new Answer("144 ", true, 1), "1008天大概是多少周？");
        addQuest(new Answer("20 ", false, -1), new Answer("2,52", false, 0), new Answer("25,2 ", true, 1), "3.6周大概是多少天");
        addQuest(new Answer("90% ", false, -1), new Answer("70%", false, 0), new Answer("97,5%", true, 1), "0.975的百分比格式是");
        addQuest(new Answer("0,8 ", false, -1), new Answer(" 0,89", false, 0), new Answer("0,875", true, 1), "7 / 8大概是多少");
        addQuest(new Answer("7/9 ", false, -1), new Answer("7/11 ", false, 0), new Answer("7/10", true, 1), "百分之七十大概是多少");
        addQuest(new Answer("15 ", false, -1), new Answer(" 11 ", false, 0), new Answer("12", true, 1), "11 = 132 / t，t是多少");
        addQuest(new Answer("9 ", false, -1), new Answer(" 6", false, 0), new Answer("8", true, 1), "p ^ 2 = 64，p是多少");
        addQuest(new Answer("1 ", false, -1), new Answer(" 4", false, 0), new Answer("2", true, 1), "q + 6 = 8，q是多少");
        addQuest(new Answer("5", false, -1), new Answer("2", false, 0), new Answer("3", true, 1), "5c = 15，c是多少");
        addQuest(new Answer("31", false, -1), new Answer("29.78", false, 0), new Answer("30.704", true, 1), "4.04 × 7.6");
        addQuest(new Answer("1700", false, -1), new Answer("1640", false, 0), new Answer("1560", true, 1), "26 × 60");
        addQuest(new Answer("1.69", false, -1), new Answer("1.8", false, 0), new Answer("1.6596", true, 1), "9.22 × 0.18");
        addQuest(new Answer("10.41", false, -1), new Answer("8.789", false, 0), new Answer("9.898", true, 1), "1.4 × 7.07");
        addQuest(new Answer("141.412", false, -1), new Answer("8.789", false, 0), new Answer("212.25", true, 1), "25 × 8.49");
        addQuest(new Answer("1", false, -1), new Answer("3", false, 0), new Answer("5", true, 1), "15 / 3");
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
