using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ConnectFourGame
{
    // ============================================================
    //  ENUM: QuestionType
    //  Definieert de vier vraagtypen voor 6vwo geschiedenis
    // ============================================================
    public enum QuestionType
    {
        Chronologie,        // Zet gebeurtenissen in de juiste volgorde
        KenmerkendAspect,   // Koppel een kenmerkend aspect aan een tijdvak
        OorzaakGevolg       // Benoem oorzaak of gevolg van een historische gebeurtenis
    }

    // ============================================================
    //  KLASSE: Question
    //  Stelt één examenvraag voor met alle metadata
    // ============================================================
    public class Question
    {
        public string QuestionText { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }
        public QuestionType Type { get; set; }

        public Question(string questionText, string answer, string category, QuestionType type)
        {
            QuestionText = questionText;
            Answer = answer;
            Category = category;
            Type = type;
        }
    }

    // ============================================================
    //  KLASSE: QuestionBank
    //  Beheert alle vragen en geeft willekeurige vragen terug
    //  Afbeeldingen worden verwacht in: images\ (naast de .exe)
    // ============================================================
    public class QuestionBank
    {
        private List<Question> questions = new List<Question>();
        private Random random = new Random();

        public QuestionBank() { LoadQuestions(); }

        private void LoadQuestions()
        {
            // ── CHRONOLOGIE ──────────────────────────────────────────────────

            questions.Add(new Question(
                questionText:
                    "Zet de volgende gebeurtenissen in de juiste chronologische volgorde:\n\n" +
                    "A) De Kristallnacht in Duitsland\n" +
                    "B) Hitler wordt Rijkskanselier\n" +
                    "C) De Duitse inval in Polen\n" +
                    "D) De Neurenbergse rassenwetten worden aangenomen",
                answer:
                    "Juiste volgorde: B (1933) → D (1935) → A (1938) → C (1939)\n\n" +
                    "Toelichting: Hitler werd kanselier in jan. 1933, de rassenwetten volgden " +
                    "in 1935, de Kristallnacht was in nov. 1938 en de inval in Polen op 1 sept. 1939.",
                category: "Interbellum & WO2",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet de volgende gebeurtenissen uit de Koude Oorlog in de juiste volgorde:\n\n" +
                    "A) Val van de Berlijnse Muur\n" +
                    "B) Cubacrisis\n" +
                    "C) NAVO-oprichting\n" +
                    "D) Koreaanse Oorlog",
                answer:
                    "Juiste volgorde: C (1949) → D (1950–1953) → B (1962) → A (1989)\n\n" +
                    "Toelichting: NAVO 1949, Korea 1950–1953, Cubacrisis 1962, val Muur 1989.",
                category: "Koude Oorlog",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet de volgende dekolonisatie-gebeurtenissen in de juiste volgorde:\n\n" +
                    "A) Indonesische onafhankelijkheidsverklaring door Soekarno\n" +
                    "B) Eerste politionele actie door Nederland\n" +
                    "C) Soevereiniteitsoverdracht van Nederland aan Indonesië\n" +
                    "D) Capitulatie Japan (einde WO2 in Azië)",
                answer:
                    "Juiste volgorde: D (aug. 1945) → A (17 aug. 1945) → B (1947) → C (1949)\n\n" +
                    "Toelichting: Direct na de Japanse capitulatie riep Soekarno de " +
                    "onafhankelijkheid uit. Nederland erkende dit niet en voerde militaire " +
                    "acties uit, maar moest in 1949 de soevereiniteit overdragen.",
                category: "Dekolonisatie",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet de volgende gebeurtenissen rondom de Franse Revolutie in de juiste volgorde:\n\n" +
                    "A) Executie van Lodewijk XVI\n" +
                    "B) Napoleon wordt keizer van Frankrijk\n" +
                    "C) De bestorming van de Bastille\n" +
                    "D) De Terreur onder Robespierre",
                answer:
                    "Juiste volgorde: C (14 juli 1789) → A (jan. 1793) → D (1793–1794) → B (1804)\n\n" +
                    "Toelichting: De Bastille markeert het begin van de Revolutie. Daarna " +
                    "volgden de executie van de koning, de gewelddadige Terreur en uiteindelijk " +
                    "de machtsgreep van Napoleon in 1799 (gekroond in 1804).",
                category: "Franse Revolutie & Napoleon",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet de volgende gebeurtenissen uit de opbouw naar WO1 in de juiste volgorde:\n\n" +
                    "A) Aanslag op Franz Ferdinand in Sarajevo\n" +
                    "B) Duitsland verklaart de oorlog aan Rusland\n" +
                    "C) Oostenrijk-Hongarije stuurt ultimatum aan Servië\n" +
                    "D) Mobilisatie van het Russische leger",
                answer:
                    "Juiste volgorde: A (28 juni 1914) → C (23 juli) → D (30 juli) → B (1 aug. 1914)\n\n" +
                    "Toelichting: De aanslag leidde via het ultimatum, Russische mobilisatie en " +
                    "het domino-effect van het bondgenootschapssysteem in enkele weken tot WO1.",
                category: "Eerste Wereldoorlog",
                type: QuestionType.Chronologie
            ));

            // ── KENMERKEND ASPECT ─────────────────────────────────────────────

            questions.Add(new Question(
                questionText:
                    "Kenmerkend aspect 35 luidt:\n" +
                    "\"Het in praktijk brengen van de totalitaire ideologieën communisme " +
                    "en fascisme/nationaalsocialisme.\"\n\n" +
                    "a) Bij welk tijdvak hoort dit kenmerkend aspect?\n" +
                    "b) Geef voor ZOWEL het communisme ALS het nationaalsocialisme een " +
                    "concreet historisch voorbeeld waarbij dit aspect zichtbaar is.",
                answer:
                    "a) Tijdvak 9: Tijd van de wereldoorlogen (1900–1950).\n\n" +
                    "b) Communisme: De Sovjet-Unie onder Stalin – collectivisatie, " +
                    "vijfjarenplannen, Goelag (dwangarbeidskampen).\n\n" +
                    "Nationaalsocialisme: Nazi-Duitsland onder Hitler – eenpartijstaat, " +
                    "Neurenbergse rassenwetten (1935), de Holocaust.",
                category: "Tijdvak 9 – Wereldoorlogen",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Kenmerkend aspect 40 luidt:\n" +
                    "\"De verdeling van de wereld in twee ideologische blokken in de " +
                    "greep van een wapenwedloop en de angst voor een atoomoorlog.\"\n\n" +
                    "a) Noem het tijdvak waarbij dit aspect hoort.\n" +
                    "b) Leg uit waarom de Cubacrisis (1962) het meest treffende voorbeeld " +
                    "van dit kenmerkend aspect is.",
                answer:
                    "a) Tijdvak 10: Tijd van televisie en computers (1950–heden).\n\n" +
                    "b) De Cubacrisis bracht de VS en USSR het dichtst bij een directe " +
                    "nucleaire confrontatie. Sovjet-raketten op Cuba bedreigden het " +
                    "Amerikaanse grondgebied. 13 dagen lang dreigde een atoomoorlog. " +
                    "De crisis toont zowel de wapenwedloop als de blokvorming " +
                    "(VS vs. USSR, Cuba als proxy-staat).",
                category: "Tijdvak 10 – Koude Oorlog",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Kenmerkend aspect 38 luidt:\n" +
                    "\"Racisme en discriminatie die leidden tot genocide (Holocaust).\"\n\n" +
                    "Beargumenteer met minimaal DRIE concrete historische stappen hoe het " +
                    "nazi-regime van discriminatie naar genocide escaleerde.\n" +
                    "Gebruik de begrippen: uitsluiting, deportatie, Endlösung.",
                answer:
                    "Stap 1 – Uitsluiting: Neurenbergse rassenwetten (1935) ontnamen Joden " +
                    "hun burgerrechten en sloten hen uit van beroepen.\n\n" +
                    "Stap 2 – Deportatie: Na de Wannseeconferentie (jan. 1942) werden Joden " +
                    "systematisch gedeporteerd naar vernietigingskampen (o.a. Auschwitz-Birkenau).\n\n" +
                    "Stap 3 – Endlösung: De industriële massamoord in de kampen. " +
                    "Circa 6 miljoen Joden werden vermoord.",
                category: "Tijdvak 9 – Holocaust",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Kenmerkend aspect 42 luidt:\n" +
                    "\"De eenwording van Europa.\"\n\n" +
                    "a) Bij welk tijdvak hoort dit aspect?\n" +
                    "b) Beschrijf DRIE concrete stappen in het Europese integratieproces " +
                    "na WO2, in chronologische volgorde.\n" +
                    "c) Welke tegenkracht (euroscepsis) verzwakte dit proces na 2010? " +
                    "Geef één voorbeeld.",
                answer:
                    "a) Tijdvak 10: Tijd van televisie en computers (1950–heden).\n\n" +
                    "b) Drie stappen:\n" +
                    "   1) EGKS (1951) – samenwerking kolen en staal, zes landen.\n" +
                    "   2) EEG (1957, Verdrag van Rome) – gemeenschappelijke markt.\n" +
                    "   3) EU en euro (Verdrag van Maastricht 1992, euro ingevoerd 2002).\n\n" +
                    "c) Brexit (2016/2020): het Verenigd Koninkrijk stemde via referendum " +
                    "voor uittreding uit de EU, als uiting van groeiend nationalisme en " +
                    "euroscepsis.",
                category: "Tijdvak 10 – Europese integratie",
                type: QuestionType.KenmerkendAspect
            ));

            // ── OORZAAK EN GEVOLG ──────────────────────────────────────────────

            questions.Add(new Question(
                questionText:
                    "Historici onderscheiden bij het uitbreken van WO1 directe en " +
                    "indirecte oorzaken.\n\n" +
                    "a) Wat was de DIRECTE aanleiding voor het uitbreken van WO1?\n" +
                    "b) Noem DRIE structurele (indirecte) oorzaken die Europa al vóór " +
                    "1914 naar oorlog dreven.\n" +
                    "c) Leg uit waarom de aanslag in Sarajevo juist in 1914 zo grote " +
                    "gevolgen had.",
                answer:
                    "a) De aanslag op aartshertog Franz Ferdinand in Sarajevo op 28 juni 1914 " +
                    "door de Bosnisch-Servische nationalist Gavrilo Princip.\n\n" +
                    "b) Drie structurele oorzaken:\n" +
                    "   1) Imperialisme en rivaliteit om koloniën\n" +
                    "   2) Nationalisme (Pan-Slavisme, Pan-Germanisme)\n" +
                    "   3) Het bondgenootschapssysteem (Triple Alliance vs. Triple Entente)\n\n" +
                    "c) Door het bondgenootschapssysteem sloeg het lokale conflict snel " +
                    "over naar een continentale en wereldoorlog. Elke mobilisatie " +
                    "triggerde automatisch andere landen.",
                category: "Eerste Wereldoorlog – Oorzaken",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "De val van de Berlijnse Muur (1989) had verstrekkende gevolgen.\n\n" +
                    "a) Noem TWEE directe politieke gevolgen voor Duitsland.\n" +
                    "b) Noem TWEE gevolgen voor de internationale verhoudingen na 1989.\n" +
                    "c) Historicus Francis Fukuyama sprak in 1989 van het 'einde van de " +
                    "geschiedenis'. Leg uit wat hij bedoelde en geef één tegenargument.",
                answer:
                    "a) Gevolgen voor Duitsland:\n" +
                    "   1) Hereniging van Oost- en West-Duitsland (3 okt. 1990).\n" +
                    "   2) Ontbinding van de DDR en overgang naar markteconomie/democratie.\n\n" +
                    "b) Internationale gevolgen:\n" +
                    "   1) Uiteenvallen van de Sovjet-Unie (1991), 15 nieuwe staten.\n" +
                    "   2) NAVO-uitbreiding naar Oost-Europa; toenemende spanning met Rusland.\n\n" +
                    "c) Fukuyama: de liberale democratie had definitief gewonnen – het " +
                    "ideologische debat was voorbij.\n" +
                    "Tegenargument: de opkomst van autoritaire regimes (Poetin, Xi), " +
                    "islamitisch fundamentalisme en populisme na 2008 bewijzen het tegendeel.",
                category: "Koude Oorlog – Gevolgen",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "De Grote Depressie (1929–1939) had grote politieke gevolgen in Europa.\n\n" +
                    "a) Wat was de directe economische oorzaak van de Grote Depressie?\n" +
                    "b) Leg uit hoe de economische crisis in Duitsland de opkomst van Hitler " +
                    "versnelde. Gebruik de begrippen: werkloosheid, radicalisering, NSDAP.\n" +
                    "c) Welk economisch beleid gebruikten westerse democratieën als " +
                    "antwoord op de depressie? Noem de naam van de econoom die dit bepleitte.",
                answer:
                    "a) De beurscrash van Wall Street ('Zwarte Donderdag', 24 okt. 1929) " +
                    "leidde tot een kredietcrisis, bankfaillissementen en wereldwijde " +
                    "inkrimping van de handel.\n\n" +
                    "b) In Duitsland steeg de werkloosheid naar 6 miljoen (1932). " +
                    "Wanhopige kiezers radicaliseerden en stemden op extremistische partijen. " +
                    "De NSDAP groeide van een marginale partij (2,6% in 1928) naar de " +
                    "grootste partij (37,4% in juli 1932).\n\n" +
                    "c) Keynesiaans beleid: staatsinterventie via overheidsbestedingen " +
                    "om de economie te stimuleren (New Deal onder Roosevelt). " +
                    "Econoom: John Maynard Keynes.",
                category: "Interbellum – Grote Depressie",
                type: QuestionType.OorzaakGevolg
            ));

            // ── CHRONOLOGIE extra ────────────────────────────────────────

            questions.Add(new Question(
                questionText:
                    "Zet de volgende gebeurtenissen uit de Russische Revolutie in de juiste volgorde:\n\n" +
                    "A) Oktoberrevolutie – Lenin grijpt de macht\n" +
                    "B) Troonsafstand van tsaar Nicolaas II\n" +
                    "C) Begin van de Russische Burgeroorlog\n" +
                    "D) Oprichting van de Sovjet-Unie (USSR)",
                answer:
                    "Juiste volgorde: B (maart 1917) → A (okt. 1917) → C (1918) → D (1922)\n\n" +
                    "Toelichting: De februarirevolutie dwong de tsaar af te treden. " +
                    "Lenin greep daarna de macht via de Oktoberrevolutie. " +
                    "Daarna volgde een burgeroorlog tussen Roden en Witten, " +
                    "waarna de USSR in 1922 werd opgericht.",
                category: "Russische Revolutie",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet de volgende gebeurtenissen uit de geschiedenis van de VN en mensenrechten " +
                    "in de juiste volgorde:\n\n" +
                    "A) Universele Verklaring van de Rechten van de Mens\n" +
                    "B) Oprichting van de Verenigde Naties\n" +
                    "C) Neurenbergse processen tegen oorlogsmisdadigers\n" +
                    "D) Oprichting van het Internationaal Strafhof (ICC)",
                answer:
                    "Juiste volgorde: B (1945) → C (1945–1946) → A (1948) → D (2002)\n\n" +
                    "Toelichting: De VN werd opgericht na WO2, de Neurenbergse processen " +
                    "volgden direct daarna, de UVRM werd in 1948 aangenomen en het ICC " +
                    "werd pas in 2002 operationeel.",
                category: "Naoorlogs – VN & Mensenrechten",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet de volgende gebeurtenissen uit de apartheidsgeschiedenis van Zuid-Afrika " +
                    "in de juiste volgorde:\n\n" +
                    "A) Nelson Mandela wordt president van Zuid-Afrika\n" +
                    "B) Invoering van het apartheidsstelsel door de Nationale Partij\n" +
                    "C) Bloedbad van Sharpeville\n" +
                    "D) Vrijlating van Nelson Mandela na 27 jaar gevangenisstraf",
                answer:
                    "Juiste volgorde: B (1948) → C (1960) → D (1990) → A (1994)\n\n" +
                    "Toelichting: Apartheid werd ingevoerd in 1948. Bij Sharpeville " +
                    "werden in 1960 69 demonstranten doodgeschoten. " +
                    "Mandela werd in 1990 vrijgelaten en in 1994 verkozen als president.",
                category: "Dekolonisatie – Afrika",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet de volgende mijlpalen uit de Nederlandse geschiedenis in de juiste volgorde:\n\n" +
                    "A) Nederland treedt toe tot de Europese Gemeenschap (EEG)\n" +
                    "B) De watersnoodramp treft Zeeland en Zuid-Holland\n" +
                    "C) Nederland wordt bevrijd van de Duitse bezetting\n" +
                    "D) De Hongerwinter in Nederland",
                answer:
                    "Juiste volgorde: D (winter 1944–1945) → C (mei 1945) → B (1953) → A (1957)\n\n" +
                    "Toelichting: De Hongerwinter was in de laatste bezettingswinter. " +
                    "Bevrijding volgde in mei 1945. De watersnoodramp kostte 1836 mensen " +
                    "het leven in 1953. Nederland was een van de oprichters van de EEG in 1957.",
                category: "Nederlandse Geschiedenis",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet de volgende gebeurtenissen uit de geschiedenis van de Koude Oorlog " +
                    "in de juiste volgorde:\n\n" +
                    "A) De Sovjet-Unie test zijn eerste atoombom\n" +
                    "B) De Marshall-hulp van de VS aan West-Europa\n" +
                    "C) De ruimtewedloop: Spoetnik wordt gelanceerd\n" +
                    "D) De NAVO wordt opgericht",
                answer:
                    "Juiste volgorde: B (1947) → D (1949) → A (1949) → C (1957)\n\n" +
                    "Toelichting: De Marshall-hulp begon in 1947, de NAVO en de " +
                    "Sovjet-atoombom kwamen allebei in 1949, en Spoetnik markeerde " +
                    "in 1957 het begin van de ruimtewedloop.",
                category: "Koude Oorlog – Tijdlijn",
                type: QuestionType.Chronologie
            ));

            // ── KENMERKEND ASPECT extra ───────────────────────────────────

            questions.Add(new Question(
                questionText:
                    "Kenmerkend aspect 36 luidt:\n" +
                    "\"De crisis van het wereldkapitalisme.\"\n\n" +
                    "a) Bij welk tijdvak hoort dit aspect?\n" +
                    "b) Leg uit hoe de beurscrash van 1929 leidde tot een wereldwijde " +
                    "economische crisis. Gebruik de begrippen: krediet, werkloosheid, protectionisme.\n" +
                    "c) Welk gevolg had deze crisis voor de democratieën in Europa?",
                answer:
                    "a) Tijdvak 9: Tijd van de wereldoorlogen (1900–1950).\n\n" +
                    "b) Banken hadden op krediet geïnvesteerd in aandelen. Na de crash " +
                    "eisten banken hun geld terug, bedrijven gingen failliet en " +
                    "de werkloosheid steeg enorm. Landen verhoogden invoertarieven " +
                    "(protectionisme) waardoor de wereldhandel instortte.\n\n" +
                    "c) Democratieën verloren geloofwaardigheid. Burgers kozen voor " +
                    "extremistische partijen (fascisme, nationaalsocialisme) die " +
                    "eenvoudige oplossingen beloofden.",
                category: "Tijdvak 9 – Economische Crisis",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Kenmerkend aspect 29 luidt:\n" +
                    "\"De opkomst van emancipatiebewegingen.\"\n\n" +
                    "a) Noem het tijdvak waarbij dit aspect hoort.\n" +
                    "b) Beschrijf de vrouwenbeweging als voorbeeld van een " +
                    "emancipatiebeweging. Noem TWEE concrete eisen of verworvenheden.\n" +
                    "c) Leg uit welke andere emancipatiebeweging in de 20e eeuw " +
                    "grote invloed had en waarom.",
                answer:
                    "a) Tijdvak 8: Tijd van burgers en stoommachines (1800–1900), " +
                    "maar ook Tijdvak 9 en 10.\n\n" +
                    "b) De vrouwenbeweging streed voor:\n" +
                    "   1) Vrouwenkiesrecht (in Nederland verkregen in 1919).\n" +
                    "   2) Gelijke toegang tot onderwijs en beroepen.\n\n" +
                    "c) De burgerrechtenbeweging in de VS (jaren '50-'60) onder leiding " +
                    "van Martin Luther King streed tegen rassendiscriminatie. " +
                    "De Civil Rights Act (1964) verbood officiële segregatie.",
                category: "Tijdvak 8/9 – Emancipatie",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Kenmerkend aspect 33 luidt:\n" +
                    "\"Het imperialisme en de Scramble for Africa.\"\n\n" +
                    "a) Bij welk tijdvak hoort dit aspect?\n" +
                    "b) Leg uit wat wordt bedoeld met de 'Scramble for Africa' en " +
                    "welke conferentie dit formaliseerde.\n" +
                    "c) Geef TWEE redenen waarom Europese landen streefden naar " +
                    "koloniën in Afrika.",
                answer:
                    "a) Tijdvak 8: Tijd van burgers en stoommachines (1800–1900).\n\n" +
                    "b) De 'Scramble for Africa' was de snelle verdeling van Afrika " +
                    "onder Europese mogendheden. Dit werd geregeld op de " +
                    "Conferentie van Berlijn (1884–1885) waar Afrikanen zelf " +
                    "niet aanwezig waren.\n\n" +
                    "c) Twee redenen:\n" +
                    "   1) Economisch: grondstoffen (rubber, goud, diamanten) en " +
                    "afzetmarkten voor industrie.\n" +
                    "   2) Prestige en nationale trots: koloniën als statussymbool " +
                    "van een grote mogendheid.",
                category: "Tijdvak 8 – Imperialisme",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Kenmerkend aspect 41 luidt:\n" +
                    "\"De dekolonisatie die een einde maakte aan de westerse overheersing.\"\n\n" +
                    "a) Bij welk tijdvak hoort dit aspect?\n" +
                    "b) Leg uit waarom WO2 het dekolonisatieproces versnelde. " +
                    "Noem TWEE concrete oorzaken.\n" +
                    "c) Vergelijk de dekolonisatie van India met die van Indonesië: " +
                    "noem één overeenkomst en één verschil.",
                answer:
                    "a) Tijdvak 10: Tijd van televisie en computers (1950–heden).\n\n" +
                    "b) WO2 versnelde dekolonisatie omdat:\n" +
                    "   1) Europese mogendheden waren verzwakt en konden hun kolonies " +
                    "niet meer militair handhaven.\n" +
                    "   2) De VS en USSR (beide anti-koloniaal) oefenden druk uit op " +
                    "Europese koloniale mogendheden.\n\n" +
                    "c) Overeenkomst: beide landen verkregen onafhankelijkheid kort na WO2.\n" +
                    "Verschil: India kreeg onafhankelijkheid relatief vreedzaam via " +
                    "onderhandelingen (1947), terwijl Indonesië militair moest vechten " +
                    "tegen Nederland (politionele acties).",
                category: "Tijdvak 10 – Dekolonisatie",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Kenmerkend aspect 37 luidt:\n" +
                    "\"Het voeren van twee wereldoorlogen.\"\n\n" +
                    "a) Noem het tijdvak waarbij dit aspect hoort.\n" +
                    "b) Leg uit wat het begrip 'totale oorlog' betekent en geef " +
                    "TWEE voorbeelden waaruit blijkt dat WO2 een totale oorlog was.\n" +
                    "c) Wat was het belangrijkste verschil in de aard van WO1 en WO2?",
                answer:
                    "a) Tijdvak 9: Tijd van de wereldoorlogen (1900–1950).\n\n" +
                    "b) Totale oorlog: de gehele samenleving wordt ingezet voor de " +
                    "oorlogsinspanning.\n" +
                    "   1) Economie: fabrieken werden omgebouwd voor wapenproductie.\n" +
                    "   2) Burgerbevolking: bombardementen op steden (Rotterdam, Dresden, " +
                    "Hiroshima) doodden miljoenen burgers.\n\n" +
                    "c) WO1 was voornamelijk een loopgravenoorlog aan het westelijk front. " +
                    "WO2 was een bewegingsoorlog over heel Europa én de Stille Oceaan, " +
                    "met genocide als bewust onderdeel van de oorlogsstrategie.",
                category: "Tijdvak 9 – Wereldoorlogen",
                type: QuestionType.KenmerkendAspect
            ));

            // ── OORZAAK EN GEVOLG extra ───────────────────────────────────

            questions.Add(new Question(
                questionText:
                    "De atoombommen op Hiroshima en Nagasaki (1945) hadden grote gevolgen.\n\n" +
                    "a) Wat was de directe militaire reden van de VS om de atoombommen te gooien?\n" +
                    "b) Noem TWEE langetermijngevolgen van het gebruik van de atoombom voor " +
                    "de internationale verhoudingen na 1945.\n" +
                    "c) Leg uit waarom het gebruik van de atoombom tot op heden moreel " +
                    "omstreden blijft.",
                answer:
                    "a) De VS wilde een langdurige en bloedige invasie van Japan " +
                    "voorkomen. Schattingen waren dat een invasie honderdduizenden " +
                    "Amerikaanse soldaten het leven zou kosten.\n\n" +
                    "b) Twee langetermijngevolgen:\n" +
                    "   1) Begin van de nucleaire wapenwedloop: USSR ontwikkelde " +
                    "ook een atoombom (1949).\n" +
                    "   2) Nucleaire afschrikking ('mutual assured destruction') " +
                    "werd de basis van de Koude Oorlog-strategie.\n\n" +
                    "c) De bommen doodden ca. 200.000 voornamelijk burgers. " +
                    "Critici stellen dat Japan toch al zou capituleren en dat " +
                    "de bom ook bedoeld was om de USSR te imponeren.",
                category: "WO2 – Atoombom",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "De oprichting van de staat Israël in 1948 leidde tot een langdurig conflict.\n\n" +
                    "a) Noem TWEE oorzaken voor de oprichting van de staat Israël na WO2.\n" +
                    "b) Leg uit waarom de Palestijnen de oprichting van Israël als " +
                    "een catastrofe (Nakba) ervoeren.\n" +
                    "c) Welke rol speelde de VN bij de oprichting van Israël?",
                answer:
                    "a) Twee oorzaken:\n" +
                    "   1) De Holocaust versterkte de internationale steun voor een " +
                    "Joodse staat als veilige haven.\n" +
                    "   2) De zionistische beweging had al decennia gepleit voor een " +
                    "Joods thuisland in Palestina.\n\n" +
                    "b) Honderdduizenden Palestijnen werden verdreven of vluchtten " +
                    "tijdens de oorlog van 1948. Zij verloren hun huizen en land " +
                    "en mochten niet terugkeren.\n\n" +
                    "c) De VN stelde in 1947 een verdelingsplan voor (Resolutie 181) " +
                    "dat het gebied splitste in een Joodse en Arabische staat. " +
                    "De Arabische staten verwierpen dit plan.",
                category: "Naoorlogs – Midden-Oosten",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "Het Verdrag van Versailles (1919) had grote gevolgen voor Europa.\n\n" +
                    "a) Noem DRIE zware bepalingen die aan Duitsland werden opgelegd.\n" +
                    "b) Leg uit hoe het Verdrag van Versailles bijdroeg aan de " +
                    "opkomst van Hitler en het nationaalsocialisme.\n" +
                    "c) Welke Amerikaanse president pleitte voor een rechtvaardigere vrede " +
                    "en wat waren zijn uitgangspunten?",
                answer:
                    "a) Drie bepalingen:\n" +
                    "   1) Oorlogsschuld: Duitsland moest alle oorlogsschade vergoeden " +
                    "(herstelbetalingen).\n" +
                    "   2) Grondverlies: Duitsland verloor ca. 13% van zijn grondgebied.\n" +
                    "   3) Ontwapening: het leger werd beperkt tot 100.000 man.\n\n" +
                    "b) De vernederende vrede voedde het gevoel van onrecht en " +
                    "nationale vernedering (Dolkstootlegende). Hitler beloofde " +
                    "dit onrecht te herstellen, wat hem veel aanhang gaf.\n\n" +
                    "c) President Woodrow Wilson met zijn Veertien Punten: " +
                    "zelfbeschikkingsrecht van volken, open diplomatie, " +
                    "oprichting van de Volkenbond.",
                category: "Interbellum – Versailles",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "De industriële revolutie had ingrijpende sociale gevolgen.\n\n" +
                    "a) Leg uit wat wordt bedoeld met het 'sociale kwestie' in de " +
                    "19e eeuw.\n" +
                    "b) Noem TWEE oorzaken van de slechte leefomstandigheden van " +
                    "arbeiders in de vroege industrie.\n" +
                    "c) Welke TWEE politieke ideologieën ontstonden als reactie op " +
                    "deze sociale misstanden?",
                answer:
                    "a) De sociale kwestie verwijst naar de erbarmelijke leef- en " +
                    "werkomstandigheden van de industriële arbeidersklasse: " +
                    "kinderarbeid, lange werkdagen, lage lonen, ongezonde fabrieken.\n\n" +
                    "b) Twee oorzaken:\n" +
                    "   1) Ongereguleerde kapitalistische economie: fabrikanten " +
                    "maximaliseerden winst ten koste van arbeiders.\n" +
                    "   2) Massale trek naar de steden veroorzaakte overbevolkte " +
                    "sloppenwijken zonder sanitaire voorzieningen.\n\n" +
                    "c) Twee ideologieën:\n" +
                    "   1) Socialisme/communisme (Marx): collectief eigendom, " +
                    "arbeiders moeten de macht grijpen.\n" +
                    "   2) Sociaal-liberalisme: markteconomie met staatsinmenging " +
                    "ter bescherming van arbeiders.",
                category: "Tijdvak 8 – Industriële Revolutie",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "De Cubacrisis (1962) bracht de wereld aan de rand van een atoomoorlog.\n\n" +
                    "a) Wat was de directe aanleiding voor de Cubacrisis?\n" +
                    "b) Leg uit hoe de crisis werd opgelost. Noem de afspraken die " +
                    "VS en USSR maakten.\n" +
                    "c) Welk gevolg had de Cubacrisis voor de communicatie tussen " +
                    "de supermachten?",
                answer:
                    "a) De VS ontdekte via verkenningsvliegtuigen dat de USSR " +
                    "nucleaire raketten plaatste op Cuba, op 150 km van de " +
                    "Amerikaanse kust.\n\n" +
                    "b) De VS eiste verwijdering van de raketten en legde een " +
                    "zeeblokkade op. Na 13 dagen onderhandelen werd een deal gesloten:\n" +
                    "   - USSR verwijdert raketten van Cuba.\n" +
                    "   - VS belooft Cuba niet aan te vallen en verwijdert " +
                    "stiekem eigen raketten uit Turkije.\n\n" +
                    "c) De 'rode telefoon' (hotline) werd ingesteld voor directe " +
                    "communicatie tussen Washington en Moskou om " +
                    "misverstanden te voorkomen.",
                category: "Koude Oorlog – Cubacrisis",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "De Franse Revolutie (1789) had verstrekkende gevolgen voor Europa.\n\n" +
                    "a) Noem TWEE politieke ideeën die door de Franse Revolutie " +
                    "werden verspreid.\n" +
                    "b) Leg uit hoe Napoleon de idealen van de Revolutie zowel " +
                    "verspreidde als verried.\n" +
                    "c) Welk gevolg had de Revolutie voor de positie van de kerk " +
                    "in de samenleving?",
                answer:
                    "a) Twee politieke ideeën:\n" +
                    "   1) Volkssoevereiniteit: het volk, niet de koning, heeft " +
                    "de hoogste macht.\n" +
                    "   2) Gelijkheid voor de wet: afschaffing van privileges " +
                    "van adel en geestelijkheid.\n\n" +
                    "b) Napoleon verspreidde de Code Civil (gelijkheid voor de wet, " +
                    "eigendomsrecht) in heel Europa. Maar hij verried de " +
                    "Revolutie door zichzelf tot keizer te kronen en een " +
                    "nieuwe elite te vormen.\n\n" +
                    "c) De kerk verloor haar politieke macht en bezittingen. " +
                    "Dit was het begin van secularisering en scheiding van " +
                    "kerk en staat.",
                category: "Franse Revolutie – Gevolgen",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "De opkomst van het nationalisme in de 19e eeuw had grote gevolgen.\n\n" +
                    "a) Leg uit wat nationalisme inhoudt als politieke ideologie.\n" +
                    "b) Geef TWEE voorbeelden van nationale eenwording in de 19e eeuw.\n" +
                    "c) Leg uit hoe nationalisme zowel een positieve als negatieve " +
                    "kracht kon zijn in de geschiedenis.",
                answer:
                    "a) Nationalisme: het idee dat mensen met een gemeenschappelijke " +
                    "taal, cultuur en geschiedenis een eigen staat verdienen. " +
                    "De natie is de hoogste politieke eenheid.\n\n" +
                    "b) Twee voorbeelden:\n" +
                    "   1) Eenwording van Duitsland onder Bismarck (1871).\n" +
                    "   2) Eenwording van Italië onder Garibaldi en Cavour (1861).\n\n" +
                    "c) Positief: bevrijdingsbewegingen tegen buitenlandse overheersing " +
                    "(dekolonisatie). Negatief: agressief nationalisme leidde tot " +
                    "WO1 en WO2, en tot genocide (Holocaust, Joegoslavië).",
                category: "Tijdvak 8 – Nationalisme",
                type: QuestionType.OorzaakGevolg
            ));
        }

        private List<Question> remainingQuestions = null;

        public Question GetRandomQuestion()
        {
            // Als alle vragen op zijn, schud opnieuw
            if (remainingQuestions == null || remainingQuestions.Count == 0)
                remainingQuestions = new List<Question>(questions);

            int index = random.Next(remainingQuestions.Count);
            Question picked = remainingQuestions[index];
            remainingQuestions.RemoveAt(index);
            return picked;
        }

        public int TotalQuestions => questions.Count;
    }

    // ============================================================
    //  KLASSE: Player
    //  Stelt een speler voor met naam, kleur en statistieken
    // ============================================================
    public class Player
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public int CorrectAnswers { get; private set; }
        public int WrongAnswers { get; private set; }

        public Player(string name, Color color)
        {
            Name = name;
            Color = color;
        }

        public void AddCorrect() => CorrectAnswers++;
        public void AddWrong() => WrongAnswers++;
        public string Stats() => $"{Name}: {CorrectAnswers}✓ {WrongAnswers}✗";
    }

    // ============================================================
    //  KLASSE: GameBoard (spellogica – los van UI)
    // ============================================================
    public class GameBoard
    {
        public const int ROWS = 6;
        public const int COLS = 7;
        private int[,] board = new int[ROWS, COLS];

        public void Reset()
        {
            for (int r = 0; r < ROWS; r++)
                for (int c = 0; c < COLS; c++)
                    board[r, c] = 0;
        }

        public bool IsOccupied(int row, int col) => board[row, col] != 0;

        public void PlaceChip(int row, int col, int playerNr) =>
            board[row, col] = playerNr;

        public int GetCell(int row, int col) => board[row, col];

        public bool CheckWin(int row, int col)
        {
            int p = board[row, col];
            if (p == 0) return false;
            return Dir(row, col, 0, 1, p) + Dir(row, col, 0, -1, p) >= 3 ||
                   Dir(row, col, 1, 0, p) + Dir(row, col, -1, 0, p) >= 3 ||
                   Dir(row, col, 1, 1, p) + Dir(row, col, -1, -1, p) >= 3 ||
                   Dir(row, col, 1, -1, p) + Dir(row, col, -1, 1, p) >= 3;
        }

        private int Dir(int row, int col, int dr, int dc, int p)
        {
            int n = 0, r = row + dr, c = col + dc;
            while (r >= 0 && r < ROWS && c >= 0 && c < COLS && board[r, c] == p)
            { n++; r += dr; c += dc; }
            return n;
        }

        public bool IsFull()
        {
            for (int c = 0; c < COLS; c++)
                if (board[0, c] == 0) return false;
            return true;
        }
    }

    // ============================================================
    //  FORM: LoginForm
    // ============================================================
    public class LoginForm : Form
    {
        private TextBox txtUsername, txtPassword;
        private Button btnLogin;

        public LoginForm()
        {
            this.Text = "Connect Four – Geschiedenis 6vwo";
            this.Size = new Size(420, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            AddLabel("🎓 Geschiedenis – Connect Four",
                new Font("Comic Sans MS", 16, FontStyle.Bold), new Point(45, 22));
            AddLabel("Gebruikersnaam:", new Font("Comic Sans MS", 10), new Point(50, 90));
            txtUsername = AddTextBox(new Point(50, 112), 300);
            AddLabel("Wachtwoord:", new Font("Comic Sans MS", 10), new Point(50, 148));
            txtPassword = AddTextBox(new Point(50, 170), 300, true);

            btnLogin = new Button
            {
                Text = "Inloggen",
                Location = new Point(140, 215),
                Size = new Size(120, 38),
                BackColor = Color.FromArgb(74, 144, 226),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Comic Sans MS", 10, FontStyle.Bold)
            };
            btnLogin.Click += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtUsername.Text)) { Warn("Vul een gebruikersnaam in!"); return; }
                if (string.IsNullOrWhiteSpace(txtPassword.Text)) { Warn("Vul een wachtwoord in!"); return; }
                new PlayerSelectionForm(txtUsername.Text).Show();
                this.Hide();
            };
            this.Controls.Add(btnLogin);
        }

        private void AddLabel(string text, Font font, Point loc)
        {
            this.Controls.Add(new Label
            {
                Text = text,
                Font = font,
                AutoSize = true,
                Location = loc
            });
        }

        private TextBox AddTextBox(Point loc, int width, bool password = false)
        {
            var tb = new TextBox
            {
                Location = loc,
                Size = new Size(width, 25),
                Font = new Font("Comic Sans MS", 10)
            };
            if (password) tb.PasswordChar = '*';
            this.Controls.Add(tb);
            return tb;
        }

        private void Warn(string msg) =>
            MessageBox.Show(msg, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    // ============================================================
    //  FORM: PlayerSelectionForm
    // ============================================================
    public class PlayerSelectionForm : Form
    {
        public PlayerSelectionForm(string username)
        {
            this.Text = "Connect Four – Speler Selectie";
            this.Size = new Size(400, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            this.Controls.Add(new Label
            {
                Text = $"Welkom {username}!\nKies aantal spelers:",
                Font = new Font("Comic Sans MS", 15, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(70, 35)
            });

            string[] labels = { "2 Spelers", "3 Spelers", "4 Spelers" };
            for (int i = 0; i < 3; i++)
            {
                int count = i + 2;
                var btn = new Button
                {
                    Text = labels[i],
                    Location = new Point(120, 120 + i * 65),
                    Size = new Size(150, 50),
                    BackColor = Color.FromArgb(74, 144, 226),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Comic Sans MS", 12, FontStyle.Bold)
                };
                btn.Click += (s, e) => { new ColorSelectionForm(count).Show(); this.Close(); };
                this.Controls.Add(btn);
            }
        }
    }

    // ============================================================
    //  FORM: ColorSelectionForm
    // ============================================================
    public class ColorSelectionForm : Form
    {
        private int playerCount;
        private List<Color> selectedColors = new List<Color>();
        private List<Button> colorButtons = new List<Button>();
        private Label lblInstruction;
        private Button btnStart;
        private int currentPlayer = 1;

        private Color[] availableColors = {
            Color.FromArgb(255, 179, 186), Color.FromArgb(186, 225, 255),
            Color.FromArgb(255, 223, 186), Color.FromArgb(186, 255, 201),
            Color.FromArgb(229, 204, 255), Color.FromArgb(255, 255, 186),
            Color.FromArgb(255, 204, 229), Color.FromArgb(204, 255, 255)
        };

        public ColorSelectionForm(int players)
        {
            playerCount = players;
            this.Text = "Connect Four – Kleur Selectie";
            this.Size = new Size(700, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            lblInstruction = new Label
            {
                Text = $"Speler {currentPlayer}: Kies je kleur",
                Font = new Font("Comic Sans MS", 14, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(200, 30)
            };
            this.Controls.Add(lblInstruction);

            int x = 60, y = 100;
            for (int i = 0; i < availableColors.Length; i++)
            {
                var btn = new Button
                {
                    Size = new Size(70, 70),
                    Location = new Point(x, y),
                    BackColor = availableColors[i],
                    FlatStyle = FlatStyle.Flat,
                    Tag = i
                };
                btn.FlatAppearance.BorderColor = Color.Gray;
                btn.FlatAppearance.BorderSize = 2;
                btn.Click += ColorBtn_Click;
                colorButtons.Add(btn);
                this.Controls.Add(btn);
                x += 80;
                if ((i + 1) % 4 == 0) { x = 60; y += 80; }
            }

            btnStart = new Button
            {
                Text = "Start Spel",
                Location = new Point(260, 300),
                Size = new Size(150, 50),
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Comic Sans MS", 12, FontStyle.Bold),
                Enabled = false
            };
            btnStart.Click += (s, e) => {
                new GameBoardForm(playerCount, selectedColors).Show();
                this.Close();
            };
            this.Controls.Add(btnStart);
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            selectedColors.Add(availableColors[(int)btn.Tag]);
            btn.Enabled = false;
            currentPlayer++;
            if (currentPlayer <= playerCount)
                lblInstruction.Text = $"Speler {currentPlayer}: Kies je kleur";
            else
            {
                lblInstruction.Text = "Alle kleuren gekozen!";
                btnStart.Enabled = true;
            }
        }
    }

    // ============================================================
    //  FORM: QuestionForm  — toont vraag, bronnen en optioneel beeld
    // ============================================================
    public class QuestionForm : Form
    {
        private Question question;
        private QuestionBank bank;
        private TextBox txtAnswer;
        private Button btnSubmit;
        public bool IsCorrect { get; private set; }
        public bool AnswerGiven { get; private set; }

        // Kleur per vraagtype
        private static readonly Dictionary<QuestionType, Color> TypeColors =
            new Dictionary<QuestionType, Color> {
                { QuestionType.Chronologie,      Color.FromArgb(255, 235, 180) },
                { QuestionType.KenmerkendAspect, Color.FromArgb(200, 255, 200) },
                { QuestionType.OorzaakGevolg,    Color.FromArgb(255, 200, 200) }
            };

        private static readonly Dictionary<QuestionType, string> TypeLabels =
            new Dictionary<QuestionType, string> {
                { QuestionType.Chronologie,      "📅 Chronologie"        },
                { QuestionType.KenmerkendAspect, "🔑 Kenmerkend Aspect"  },
                { QuestionType.OorzaakGevolg,    "⚡ Oorzaak & Gevolg"   }
            };

        public QuestionForm(QuestionBank qbank)
        {
            bank = qbank;
            question = bank.GetRandomQuestion();
            AnswerGiven = false;
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Examenvraag – Geschiedenis 6vwo";
            this.Size = new Size(720, 680);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScroll = true;

            int y = 10;

            // ── Type-badge ────────────────────────────────────────────────
            var pnlType = new Panel
            {
                Location = new Point(10, y),
                Size = new Size(680, 35),
                BackColor = TypeColors[question.Type]
            };
            pnlType.Controls.Add(new Label
            {
                Text = TypeLabels[question.Type],
                Font = new Font("Comic Sans MS", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 7),
                BackColor = Color.Transparent
            });
            pnlType.Controls.Add(new Label
            {
                Text = $"Categorie: {question.Category}",
                Font = new Font("Comic Sans MS", 10, FontStyle.Italic),
                AutoSize = true,
                Location = new Point(440, 9),
                BackColor = Color.Transparent,
                ForeColor = Color.DimGray
            });
            this.Controls.Add(pnlType);
            y += 45;

            // ── Vraag tekst ───────────────────────────────────────────────
            y += 6;
            var rtbQ = new RichTextBox
            {
                Text = question.QuestionText,
                Font = new Font("Comic Sans MS", 11, FontStyle.Bold),
                ReadOnly = true,
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                Location = new Point(10, y),
                Size = new Size(680, 120),
                ScrollBars = RichTextBoxScrollBars.Vertical
            };
            this.Controls.Add(rtbQ);
            y += 128;

            // ── Antwoordveld ──────────────────────────────────────────────
            this.Controls.Add(new Label
            {
                Text = "Jouw antwoord:",
                Font = new Font("Comic Sans MS", 10),
                AutoSize = true,
                Location = new Point(10, y)
            });
            y += 24;

            txtAnswer = new TextBox
            {
                Location = new Point(10, y),
                Size = new Size(680, 60),
                Font = new Font("Comic Sans MS", 11),
                Multiline = true
            };
            txtAnswer.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.Enter && e.Control) Submit();
            };
            this.Controls.Add(txtAnswer);
            y += 68;

            btnSubmit = new Button
            {
                Text = "Verstuur Antwoord  →",
                Location = new Point(230, y),
                Size = new Size(250, 45),
                BackColor = Color.FromArgb(74, 144, 226),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Comic Sans MS", 11, FontStyle.Bold)
            };
            btnSubmit.Click += (s, e) => Submit();
            this.Controls.Add(btnSubmit);

            this.ClientSize = new Size(700, y + 60);
        }

        private void Submit()
        {
            if (string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                MessageBox.Show("Vul een antwoord in!", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var check = new AnswerCheckForm(txtAnswer.Text, question.Answer);
            check.ShowDialog();
            IsCorrect = check.IsCorrect;
            AnswerGiven = true;
            this.Close();
        }
    }

    // ============================================================
    //  FORM: AnswerCheckForm
    // ============================================================
    public class AnswerCheckForm : Form
    {
        public bool IsCorrect { get; private set; }

        public AnswerCheckForm(string playerAnswer, string correctAnswer)
        {
            this.Text = "Controleer je antwoord";
            this.Size = new Size(600, 480);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            int y = 15;

            AddBoldLabel("Jouw antwoord:", y); y += 26;
            AddRtb(playerAnswer, Color.FromArgb(255, 235, 235), y); y += 90;

            AddBoldLabel("Modelantwoord:", y); y += 26;
            AddRtb(correctAnswer, Color.FromArgb(230, 255, 230), y); y += 130;

            this.Controls.Add(new Label
            {
                Text = "Is jouw antwoord (grotendeels) juist?",
                Font = new Font("Comic Sans MS", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(130, y)
            });
            y += 36;

            var btnJ = new Button
            {
                Text = "✓  Juist",
                Location = new Point(80, y),
                Size = new Size(180, 52),
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Comic Sans MS", 12, FontStyle.Bold)
            };
            btnJ.Click += (s, e) => { IsCorrect = true; this.Close(); };

            var btnO = new Button
            {
                Text = "✗  Onjuist",
                Location = new Point(330, y),
                Size = new Size(180, 52),
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Comic Sans MS", 12, FontStyle.Bold)
            };
            btnO.Click += (s, e) => { IsCorrect = false; this.Close(); };

            this.Controls.AddRange(new Control[] { btnJ, btnO });
        }

        private void AddBoldLabel(string text, int y) =>
            this.Controls.Add(new Label
            {
                Text = text,
                Font = new Font("Comic Sans MS", 11, FontStyle.Bold),
                Location = new Point(20, y),
                AutoSize = true
            });

        private void AddRtb(string text, Color bg, int y) =>
            this.Controls.Add(new RichTextBox
            {
                Text = text,
                Font = new Font("Comic Sans MS", 10),
                ReadOnly = true,
                BackColor = bg,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(20, y),
                Size = new Size(550, 85),
                ScrollBars = RichTextBoxScrollBars.Vertical
            });
    }

    // ============================================================
    //  FORM: GameBoardForm  — originele grid-klik mechanic behouden
    // ============================================================
    public class GameBoardForm : Form
    {
        private GameBoard gameBoard;
        private List<Player> players;
        private QuestionBank questionBank;
        private Button[,] cells = new Button[GameBoard.ROWS, GameBoard.COLS];
        private int[,] board = new int[GameBoard.ROWS, GameBoard.COLS];
        private Label lblStatus;
        private Panel boardPanel;
        private Button btnNewGame;
        private int currentPlayer = 0;

        public GameBoardForm(int playerCount, List<Color> colors)
        {
            gameBoard = new GameBoard();
            questionBank = new QuestionBank();
            players = new List<Player>();
            for (int i = 0; i < playerCount; i++)
                players.Add(new Player($"Speler {i + 1}", colors[i]));
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Connect Four – Geschiedenis 6vwo";
            this.Size = new Size(900, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 242, 245);

            lblStatus = new Label
            {
                Text = $"Speler 1 is aan de beurt",
                Font = new Font("Comic Sans MS", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(300, 20),
                ForeColor = players[0].Color
            };

            boardPanel = new Panel
            {
                Location = new Point(50, 70),
                Size = new Size(800, 650),
                BackColor = Color.FromArgb(232, 232, 232),
                BorderStyle = BorderStyle.FixedSingle
            };

            // ── Originele grid-klik mechanic ──────────────────────────────
            for (int row = 0; row < GameBoard.ROWS; row++)
            {
                for (int col = 0; col < GameBoard.COLS; col++)
                {
                    cells[row, col] = new Button
                    {
                        Size = new Size(100, 100),
                        Location = new Point(10 + col * 110, 20 + row * 110),
                        BackColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Comic Sans MS", 10),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Tag = new Point(row, col)
                    };
                    cells[row, col].FlatAppearance.BorderColor = Color.FromArgb(187, 187, 187);
                    cells[row, col].FlatAppearance.BorderSize = 2;
                    cells[row, col].Click += Cell_Click;
                    boardPanel.Controls.Add(cells[row, col]);
                }
            }

            btnNewGame = new Button
            {
                Text = "Nieuw Spel",
                Location = new Point(360, 730),
                Size = new Size(150, 40),
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Comic Sans MS", 11, FontStyle.Bold)
            };
            btnNewGame.Click += BtnNewGame_Click;

            this.Controls.AddRange(new Control[] { lblStatus, boardPanel, btnNewGame });
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var pos = (Point)btn.Tag;
            int row = pos.X, col = pos.Y;

            if (gameBoard.IsOccupied(row, col))
            {
                MessageBox.Show("Dit vakje is al bezet!", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var qForm = new QuestionForm(questionBank);
            qForm.ShowDialog();
            if (!qForm.AnswerGiven) return;

            var p = players[currentPlayer];

            if (qForm.IsCorrect)
            {
                p.AddCorrect();
                gameBoard.PlaceChip(row, col, currentPlayer + 1);
                cells[row, col].BackColor = p.Color;
                cells[row, col].Text = p.Name;
                cells[row, col].ForeColor = Color.FromArgb(51, 51, 51);

                if (gameBoard.CheckWin(row, col))
                {
                    MessageBox.Show(
                        $"🏆 {p.Name} wint!\n\n" +
                        string.Join("\n", players.Select(pl => pl.Stats())),
                        "Winnaar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableAll();
                    return;
                }
                if (gameBoard.IsFull())
                {
                    MessageBox.Show("🤝 Gelijkspel! Het bord is vol.", "Spel Afgelopen",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                p.AddWrong();
                MessageBox.Show($"❌ Fout antwoord, {p.Name}!\nVolgende speler is aan de beurt.",
                    "Onjuist", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            currentPlayer = (currentPlayer + 1) % players.Count;
            var next = players[currentPlayer];
            lblStatus.Text = $"{next.Name} is aan de beurt";
            lblStatus.ForeColor = next.Color;
        }

        private void DisableAll()
        {
            foreach (var btn in cells) btn.Enabled = false;
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wil je een nieuw spel starten?", "Nieuw Spel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new LoginForm().Show();
                this.Close();
            }
        }
    }

    // ============================================================
    //  PROGRAM ENTRY POINT
    // ============================================================
    public class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}