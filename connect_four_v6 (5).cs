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
        public string QuestionText   { get; set; }
        public string Answer         { get; set; }
        public string Category       { get; set; }
        public QuestionType Type     { get; set; }

        public Question(string questionText, string answer, string category, QuestionType type)
        {
            QuestionText = questionText;
            Answer       = answer;
            Category     = category;
            Type         = type;
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
            // ── CHRONOLOGIE (officiële examenvragen) ─────────────────────

            questions.Add(new Question(
                questionText:
                    "Zet deze bouwwerken in de juiste chronologische volgorde, van vroeger naar later.\n" +
                    "Noteer alleen de nummers.\n\n" +
                    "1) De binnenstad van de Franse stad Provins kreeg zijn huidige vorm toen in de stad\n" +
                    "   een jaarmarkt werd gevestigd tijdens de herleving van de agrarisch-urbane samenleving.\n\n" +
                    "2) De familie De Medici liet in Toscane villa's bouwen die als typisch renaissance worden beschouwd.\n\n" +
                    "3) De grachtengordel in Amsterdam werd aangelegd tijdens de economische bloeitijd van de Republiek.\n\n" +
                    "4) De haven van Delos was een belangrijk handelscentrum tijdens de bloei van de Griekse stadstaten.\n\n" +
                    "5) De moskee van Kairouan werd gebouwd kort nadat de eerste aanhangers van de islam begonnen\n" +
                    "   met de verspreiding van hun geloof.\n\n" +
                    "6) De Valongokade in Rio de Janeiro werd gebouwd als aankomstplaats voor de slavenschepen\n" +
                    "   die uit Afrika aankwamen.",
                answer:
                    "Juiste volgorde: 4, 5, 1, 2, 3, 6",
                category: "Examen 2021-1",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet deze gebeurtenissen in de juiste chronologische volgorde, van vroeger naar later.\n" +
                    "Noteer alleen de nummers.\n\n" +
                    "1) Alfred Krupp leverde tijdens de Frans-Duitse oorlog moderne kanonnen aan de Duitse troepen.\n\n" +
                    "2) Alfred Krupp zette gevangenen uit Duitse concentratiekampen in als dwangarbeiders in zijn wapenfabrieken.\n\n" +
                    "3) Friedrich Krupp wilde de beloning binnenhalen die Napoleon uitloofde aan degene die\n" +
                    "   smeltkroesstaal kon maken.\n\n" +
                    "4) Gustav Krupp schond de voorschriften van het Verdrag van Versailles door de wapenproductie\n" +
                    "   niet volledig stop te zetten.\n\n" +
                    "5) Met het kanon 'Dikke Bertha' konden de Duitsers wel Franse forten neerhalen maar niet\n" +
                    "   de Franse loopgraven vernietigen.\n\n" +
                    "6) Na aanname van de Vlootwet nam Friedrich Alfred Krupp een werf over voor de bouw\n" +
                    "   van marineschepen.",
                answer:
                    "Juiste volgorde: 3, 1, 6, 5, 4, 2",
                category: "Examen 2021-1",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet deze beschrijvingen in de juiste chronologische volgorde, van vroeger naar later.\n" +
                    "Noteer alleen de nummers.\n\n" +
                    "1) Tot woede van paus Gregorius VII besloot keizer Hendrik IV een eigen kandidaat tot bisschop\n" +
                    "   te benoemen. Voor straf moest Hendrik IV op blote voeten in de sneeuw om vergeving smeken.\n\n" +
                    "2) Het volk van Rome was in de ban van de affaire die Julius Caesar had met Cleopatra.\n\n" +
                    "3) De Britse feministe Annie Besant werd gearresteerd vanwege haar uitgave van een Amerikaans\n" +
                    "   pamflet over anticonceptie.\n\n" +
                    "4) De fresco's die Michelangelo aanbracht in de Sixtijnse kapel wekten verontwaardiging op\n" +
                    "   vanwege spaarzaam geklede figuren uit de klassieke oudheid.\n\n" +
                    "5) Een vazal van de Karolingische koning Pepijn de Korte ontdekte na thuiskomst dat zijn\n" +
                    "   vrouw hem bedroog met een priester.\n\n" +
                    "6) In een anoniem pamflet werd Rousseau ervan beschuldigd dat hij zijn eigen kinderen\n" +
                    "   te vondeling zou hebben gelegd.",
                answer:
                    "Juiste volgorde: 2, 5, 1, 4, 6, 3",
                category: "Examen 2018-1",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet deze voorbeelden van verzet in de juiste chronologische volgorde, van vroeger naar later.\n" +
                    "Noteer alleen de nummers.\n\n" +
                    "1) De Staten-Generaal besloten tijdens een vergadering in Den Haag Filips II niet langer\n" +
                    "   te erkennen als hun landsheer.\n\n" +
                    "2) De Staten-Generaal staakten hun zoektocht naar een nieuwe landsheer.\n\n" +
                    "3) Een groep edelen verzocht aan landvoogdes Margaretha de kettervervolging te matigen.\n\n" +
                    "4) De Staten-Generaal sloten de Unie van Brussel, waarin zij de Pacificatie van Gent\n" +
                    "   onderschreven.\n\n" +
                    "5) Vertegenwoordigers van Gelderland, Holland, Zeeland, Utrecht, Friesland en enkele\n" +
                    "   Vlaamse en Brabantse steden ondertekenden de Unie van Utrecht.\n\n" +
                    "6) Vertegenwoordigers van Hollandse steden kwamen bijeen in Dordrecht en herstelden\n" +
                    "   Willem van Oranje in zijn functie als stadhouder.",
                answer:
                    "Juiste volgorde: 3, 6, 4, 5, 1, 2",
                category: "Examen 2018-1",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet deze gebeurtenissen en ontwikkelingen in de juiste chronologische volgorde,\n" +
                    "van vroeger naar later. Noteer alleen de nummers.\n\n" +
                    "1) De winnaar van de eerste Olympische Spelen, waarbij atleten uit rivaliserende\n" +
                    "   Griekse stadsstaten het tegen elkaar opnamen, was Koroibos.\n\n" +
                    "2) De Romeinse dichter Juvenalis introduceerde het gezegde 'mens sana in corpore sano'.\n\n" +
                    "3) In de eerste stedelijke gemeenschappen werden polowedstrijden georganiseerd om de\n" +
                    "   strijders te bekwamen in paardrijden en vechten tegelijkertijd.\n\n" +
                    "4) Rousseau schreef een boek waarin hij pleitte voor een opvoeding met voldoende\n" +
                    "   beweging voor kinderen.\n\n" +
                    "5) Ten tijde van de kruistochten werd schaak in Europa geïntroduceerd.\n\n" +
                    "6) Tijdens de bloeitijd van de Republiek introduceerden Nederlandse kooplieden\n" +
                    "   het balspel 'kolven' in Amerika.",
                answer:
                    "Juiste volgorde: 3, 1, 2, 5, 6, 4",
                category: "Examen 2019-2",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet deze gebeurtenissen in chronologische volgorde, van vroeger naar later.\n" +
                    "Noteer alleen de nummers.\n\n" +
                    "1) De absolute koning Lodewijk XIV verzuchtte dat nieuwe landmeetmethodes voor een\n" +
                    "   kaart van Frankrijk meer grond hadden gekost dan hij in een oorlog kon verliezen.\n\n" +
                    "2) Filips II gaf opdracht aan Jacob van Deventer om van 220 steden in de Nederlanden\n" +
                    "   plattegronden te maken.\n\n" +
                    "3) Battista Agnese maakte op verzoek van keizer Karel V een wereldkaart waarop de\n" +
                    "   eerste zeereis om de wereld was afgebeeld.\n\n" +
                    "4) De Engelse admiraliteit gaf opdracht om de Franse soldaten uit het leger van Napoleon\n" +
                    "   te verhinderen delen van Australië te verkennen.\n\n" +
                    "5) Floris Balthasars ontving honderd gulden van de Staten-Generaal voor het in kaart\n" +
                    "   brengen van het Spaanse leger tijdens het beleg van Zaltbommel.\n\n" +
                    "6) Tijdens de Tiendaagse Veldtocht werd een kaart gemaakt van de troepenbewegingen\n" +
                    "   van het Nederlandse leger en de opstandige Belgen.",
                answer:
                    "Juiste volgorde: 3, 2, 5, 1, 4, 6",
                category: "Examen 2019-2",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet deze beschrijvingen van het spelen van spelletjes in de juiste chronologische\n" +
                    "volgorde, van vroeger naar later. Noteer alleen de nummers.\n\n" +
                    "1) De jonge monniken van de eerste kloosters in Noordwest-Europa moesten bij een spel\n" +
                    "   kegels omverwerpen die de duivel voorstelden.\n\n" +
                    "2) De Spanjaard Diego Durán schreef dat bij het Azteekse balspel ullamaliztli spelers\n" +
                    "   soms gewond raakten door de drie kilo wegende bal.\n\n" +
                    "3) In Brussel verbood het stadsbestuur het kolven: de houten ballen veroorzaakten\n" +
                    "   te veel schade.\n\n" +
                    "4) In de Griekse stadsstaat Sparta werd het spel episkyros erg gewelddadig gespeeld.\n\n" +
                    "5) Nederlandse schilders beeldden in de Gouden Eeuw spelers van triktrak af als\n" +
                    "   symbool voor spilzucht en zedeloosheid.\n\n" +
                    "6) Soldaten die de grenzen van het Romeinse Rijk verdedigden, speelden graag het\n" +
                    "   ludus latrunculorum, een militair-strategisch bordspel.",
                answer:
                    "Juiste volgorde: 4, 6, 1, 3, 2, 5",
                category: "Examen 2021-2",
                type: QuestionType.Chronologie
            ));

            questions.Add(new Question(
                questionText:
                    "Zet deze studentenprotesten in de juiste volgorde, van vroeger naar later.\n" +
                    "Noteer alleen de nummers.\n\n" +
                    "1) Berlijnse studenten gooiden rotte eieren naar leden van de regering uit onvrede\n" +
                    "   over de strenge bepalingen in het Verdrag van Versailles.\n\n" +
                    "2) Chinese studenten eisten op het Plein van de Hemelse Vrede meer vrijheid\n" +
                    "   en democratie, beïnvloed door de hervormingen van Gorbatsjov.\n\n" +
                    "3) Leidse studenten gingen in staking toen hoogleraar Cleveringa werd gearresteerd\n" +
                    "   vanwege zijn protest tegen het ontslag van Joodse hoogleraren.\n\n" +
                    "4) Studenten uit heel Duitsland kwamen bijeen op kasteel Wartburg om te protesteren\n" +
                    "   tegen het opheffen van burgerrechten tijdens de Restauratie.\n\n" +
                    "5) Studenten werden beschoten door de geheime politie in Boedapest, waarna\n" +
                    "   een grote anti-Russische opstand uitbrak.\n\n" +
                    "6) Vier studenten van Kent State University werden doodgeschoten tijdens een\n" +
                    "   demonstratie tegen de Amerikaanse deelname aan de oorlog in Vietnam.",
                answer:
                    "Juiste volgorde: 4, 1, 3, 5, 6, 2",
                category: "Examen 2021-2",
                type: QuestionType.Chronologie
            ));

            // ── KENMERKEND ASPECT (officiële examenvragen) ────────────────

            questions.Add(new Question(
                questionText:
                    "Het werk van de Griekse filosoof Aristoteles past bij twee onderdelen van een\n" +
                    "kenmerkend aspect van zijn tijd. Toon dit aan.",
                answer:
                    "Het werk van Aristoteles past bij:\n\n" +
                    "1) 'De ontwikkeling van wetenschappelijk denken in de Griekse stadstaat',\n" +
                    "want hij baseerde zijn boek op onderzoek van meerdere stadstaten.\n\n" +
                    "2) 'Het denken over burgerschap en politiek in de Griekse stadstaat',\n" +
                    "want dat was het onderwerp van zijn boek Politika.",
                category: "Examen 2018-1",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Toon aan dat de volgende twee bestuurlijke veranderingen verband hielden met\n" +
                    "hetzelfde kenmerkend aspect van de late middeleeuwen:\n\n" +
                    "1) Er werd een algemene belasting ingevoerd voor heel het graafschap Gelre.\n\n" +
                    "2) Functionarissen van de graaf konden worden afgezet en waren verantwoording\n" +
                    "   verschuldigd over hun optreden.",
                answer:
                    "Beide veranderingen houden verband met 'het begin van staatsvorming en centralisatie':\n\n" +
                    "1) Een algemene belasting maakte een effectiever bestuur voor het hele graafschap mogelijk.\n\n" +
                    "2) De verantwoordingsplicht van functionarissen maakte het mogelijk incompetente\n" +
                    "of corrupte ambtenaren te ontslaan.",
                category: "Examen 2018-1",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "In het begin van de vroegmoderne tijd begon de Europese overzeese expansie.\n" +
                    "Geef bij elke factor aan waardoor deze de overzeese expansie bevorderde:\n\n" +
                    "1) Het sterker worden van het centrale gezag\n\n" +
                    "2) Het ontstaan van een nieuwe wetenschappelijke belangstelling",
                answer:
                    "1) Door het sterker worden van het centrale gezag kregen vorsten meer greep op hun rijk,\n" +
                    "waardoor ze meer mogelijkheden kregen voor een zoektocht naar macht en rijkdom overzee.\n\n" +
                    "2) Door de nieuwe wetenschappelijke belangstelling werd kennis (her)ontdekt, zoals\n" +
                    "geografische en navigatietechnische kennis die belangrijk was voor overzeese expansie.",
                category: "Examen 2018-1",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Belle van Zuylen schreef in een brief: \"Alle vermogens zijn bij man en vrouw\n" +
                    "oorspronkelijk dezelfde en als het verstandelijke vermogen bij mannen meer\n" +
                    "geperfectioneerd is, dan komt dat door studie en uitsluitend en alleen door studie.\"\n\n" +
                    "Ondersteun de beweringen met een argument van Belle van Zuylen:\n\n" +
                    "1) Belle van Zuylen paste verlicht denken toe op het terrein van sociale verhoudingen.\n" +
                    "2) Belle van Zuylen ging uit van rationeel optimisme.\n\n" +
                    "Geef daarna aan op welke politiek-maatschappelijke verandering in de negentiende\n" +
                    "eeuw Belle van Zuylen vooruitliep.",
                answer:
                    "1) Belle van Zuylen paste verlicht denken toe door te beweren dat mannen en vrouwen\n" +
                    "gelijk waren omdat ze dezelfde vermogens hadden.\n\n" +
                    "2) Belle van Zuylen ging uit van rationeel optimisme door te beweren dat mannen\n" +
                    "door studie hun verstandelijke vermogens hadden geperfectioneerd.\n\n" +
                    "Zij liep vooruit op het negentiende-eeuwse feminisme / de emancipatie van vrouwen.",
                category: "Examen 2021-1",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Leg uit dat de verbetering van de boekdrukkunst in het begin van de vroegmoderne\n" +
                    "tijd kon bijdragen aan de ontwikkeling van vorstelijk absolutisme.",
                answer:
                    "Door de verbetering van de boekdrukkunst konden vorsten sneller en meer wetten\n" +
                    "in het hele land afkondigen en meer propagandaboodschappen verspreiden,\n" +
                    "waardoor hun macht over het hele land werd verstevigd\n" +
                    "(zodat het vorstelijk absolutisme werd bevorderd).",
                category: "Examen 2019-2",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "In 1940 tekende Adolf Hitler een geheime opdracht om artsen te belasten met de\n" +
                    "verantwoordelijkheid om ongeneeslijk (geestes)zieke mensen 'de genadedood' toe\n" +
                    "te kennen.\n\n" +
                    "Leg uit dat dit bevel voortvloeide uit de nazi-ideologie.",
                answer:
                    "In de nazi-ideologie diende iedereen die niet paste in de ideale Duitse samenleving\n" +
                    "(de Volksgemeinschaft) daaruit te worden verwijderd.\n" +
                    "Geesteszieke mensen pasten volgens de nazi-ideologie niet in een superieur volk.",
                category: "Examen 2018-1",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Licht toe welk politiek kenmerk past bij de leus 'Du bist nichts, Dein Volk ist alles'\n" +
                    "en geef met een ander kenmerk van het nationaalsocialisme een ideologische verklaring\n" +
                    "voor de hernoeming van de Volkstrauertag tot Heldengedenktag (1934).",
                answer:
                    "Kenmerk bij de leus: het belang van de gemeenschap wordt boven het individu gesteld /\n" +
                    "het streven naar een Volksgemeinschaft / het nationalisme dat stelt dat het\n" +
                    "Duitse volk boven alles gaat.\n\n" +
                    "Hernoemen tot Heldengedenktag: dit moest Duitsers overtuigen dat sterven voor\n" +
                    "het vaderland een eer was, wat verklaard wordt door de verheerlijking van\n" +
                    "geweld en het nationalisme van de nationaalsocialisten.",
                category: "Examen 2019-2",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Leg uit dat het opzeggen van de Nederlands-Indonesische Unie door Indonesië\n" +
                    "in 1956 past bij een kenmerkend aspect uit de tweede helft van de twintigste eeuw.",
                answer:
                    "Het opzeggen van de Unie betekende dat Indonesië elke vorm van invloed vanuit\n" +
                    "Nederland afwees en elke bestuurlijke band met Nederland verbrak,\n" +
                    "wat past bij 'de dekolonisatie die een eind maakte aan de westerse hegemonie\n" +
                    "in de wereld'.",
                category: "Examen 2021-1",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Toon aan dat de bouw van anatomische theaters in de Republiek in de zeventiende\n" +
                    "eeuw verklaard kan worden met een kenmerkend aspect van die tijd.\n\n" +
                    "In de zeventiende eeuw werd in twaalf steden in de Republiek een anatomisch theater gebouwd.",
                answer:
                    "De bouw kan worden verklaard met (een van de volgende):\n\n" +
                    "- 'De bloei in economisch opzicht van de Nederlandse Republiek', waardoor er\n" +
                    "voldoende kapitaal was om de anatomische theaters te bouwen.\n\n" +
                    "- 'De bijzondere plaats in staatkundig opzicht van de Nederlandse Republiek',\n" +
                    "waardoor de gewesten en steden anatomische theaters lieten bouwen om hun\n" +
                    "concurrentiepositie te versterken.",
                category: "Examen 2021-2",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Het 'ontstaan van een pluriforme, multiculturele samenleving' in de tweede helft\n" +
                    "van de twintigste eeuw in West-Europa kan verklaard worden met twee andere\n" +
                    "kenmerkende aspecten van die tijd.\n\n" +
                    "Geef die verklaring met twee andere kenmerkende aspecten.",
                answer:
                    "Twee van de volgende:\n\n" +
                    "- 'De dekolonisatie' droeg ertoe bij dat inwoners van voormalige koloniën\n" +
                    "naar het moederland trokken.\n\n" +
                    "- 'De toenemende westerse welvaart' zorgde ervoor dat gastarbeiders uit het\n" +
                    "Middellandse Zeegebied naar West-Europa emigreerden.\n\n" +
                    "- 'De eenwording van Europa' maakte werken en wonen in andere Europese\n" +
                    "landen beter mogelijk.",
                category: "Examen 2018-1",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "In 1896 werd in Den Haag de Vereeniging Nationale Tentoonstelling van Vrouwenarbeid\n" +
                    "opgericht, met een bestuur waarin uitsluitend vrouwen werden toegelaten.\n\n" +
                    "Leg uit dat het bestuur met dit toelatingsbeleid een politiek-maatschappelijke\n" +
                    "ontwikkeling wilde bevorderen.",
                answer:
                    "Door alleen vrouwen toe te laten wilde het bestuur laten zien dat vrouwen\n" +
                    "zonder de hulp van mannen konden organiseren / wilde het bestuur aan vrouwen\n" +
                    "de kans geven bestuurlijke ervaring op te doen,\n" +
                    "waarmee zij de opkomst van het feminisme wilde bevorderen.",
                category: "Examen 2019-2",
                type: QuestionType.KenmerkendAspect
            ));

            questions.Add(new Question(
                questionText:
                    "Noem het kenmerkend aspect dat past bij alle drie de volgende gebeurtenissen\n" +
                    "uit het leven van Eberhard Taubert:\n\n" +
                    "1) In 1940 schreef hij het script voor de propagandadocumentaire 'De eeuwige Jood'.\n\n" +
                    "2) In 1943 zette hij in Hilversum de Deutsche Europa Sender op, die Engelstalige\n" +
                    "   programma's uitzond naar Groot-Brittannië.\n\n" +
                    "3) In 1958 schreef hij anticommunistische berichten waarvoor de Amerikaanse\n" +
                    "   regering hem betaalde.",
                answer:
                    "Het kenmerkend aspect dat past bij alle drie de gebeurtenissen is:\n" +
                    "'De rol van moderne propaganda- en communicatiemiddelen\n" +
                    "en vormen van massaorganisatie'.",
                category: "Examen 2021-2",
                type: QuestionType.KenmerkendAspect
            ));

            // ── OORZAAK EN GEVOLG (officiële examenvragen) ────────────────

            questions.Add(new Question(
                questionText:
                    "Toon aan, telkens met een verwijzing naar een passend kenmerkend aspect,\n" +
                    "een verklaring te geven voor:\n\n" +
                    "- De behoefte aan de Romeinse Peutingerkaart in de Romeinse tijd\n\n" +
                    "- De geringe interesse voor de kaart in de vroege middeleeuwen\n\n" +
                    "- De belangstelling van humanist Konrad Peutinger voor de kaart",
                answer:
                    "- 'De groei van het Romeinse Imperium' zorgde voor behoefte aan een kaart\n" +
                    "met de belangrijke handelsroutes tussen de verschillende rijksdelen.\n\n" +
                    "- 'De vrijwel volledige vervanging van de agrarisch-urbane cultuur door een\n" +
                    "zelfvoorzienende agrarische cultuur' zorgde ervoor dat wegen en plaatsen\n" +
                    "in verval raakten en handel hoofdzakelijk lokaal plaatsvond.\n\n" +
                    "- 'De hernieuwde oriëntatie op de klassieke oudheid' gaf humanist Peutinger\n" +
                    "belangstelling voor de kaart met de Romeinse oorsprong.",
                category: "Examen 2021-1",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "In de vroege middeleeuwen reisde de Duitse koning met zijn hofhouding van\n" +
                    "palts naar palts. Dit rondreizen was economisch én politiek noodzakelijk.\n\n" +
                    "Geef voor beide een verklaring.",
                answer:
                    "Economisch: De koning kon door het rondreizen de belasting in natura opeisen\n" +
                    "in de vorm van een verzorgd verblijf / een gebied zou uitgeput raken\n" +
                    "als de koning er te lang bleef (past bij de zelfvoorzienende agrarische cultuur).\n\n" +
                    "Politiek: De koning moest zijn leenmannen controleren en aansturen\n" +
                    "door ze regelmatig te bezoeken (past bij het feodale systeem).",
                category: "Examen 2021-1",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "Op 12 mei 1585 boden de Staten-Generaal aan de Engelse koningin Elizabeth\n" +
                    "de soevereiniteit over de Nederlanden aan.\n\n" +
                    "Geef aan dat dit besluit mede een gevolg was van:\n\n" +
                    "- De uitvaardiging van het Plakkaat van Verlatinge\n\n" +
                    "- De Spaanse belegering van Antwerpen",
                answer:
                    "- Na het Plakkaat van Verlatinge hadden de opstandige gewesten Filips II afgezworen\n" +
                    "en wilden zij een nieuwe vorst aanstellen.\n\n" +
                    "- Door de belegering van Antwerpen hoopten de opstandige gewesten op\n" +
                    "militaire steun van de Engelse koningin.",
                category: "Examen 2021-1",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "Leg uit welke toekomtige problemen de Nederlandse Tweede Kamer in 1862 wilde\n" +
                    "voorkomen met de wet die de afschaffing van de slavernij regelde.\n\n" +
                    "De wet bepaalde dat:\n" +
                    "- de slaven direct werden vrijgelaten\n" +
                    "- de vrijgelaten slaven verplicht waren een arbeidscontract met plantage-eigenaren\n" +
                    "  af te sluiten voor tien jaar",
                answer:
                    "Dit compromis moest voorkomen dat door het vertrek van de vrijgelaten slaven\n" +
                    "de productie van plantageproducten stil zou komen te liggen,\n" +
                    "waardoor plantage-eigenaren financieel in de problemen zouden komen\n" +
                    "en de Nederlandse economie geschaad zou worden.",
                category: "Examen 2021-1",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "Karl Marx noemde de wet Le Chapelier 'een staatsgreep van de rijke burgerij'.\n\n" +
                    "Leg uit welke redenering Marx volgde door aan te geven:\n\n" +
                    "- Waarom juist de rijke burgerij van deze wet kon profiteren\n\n" +
                    "- Dat de uitspraak aansloot bij zijn ideologie",
                answer:
                    "- Door het verbod op verenigingen en stakingen konden arbeiders zich niet\n" +
                    "verweren tegen hun werkgevers, waardoor de rijke burgerij macht over hen kreeg.\n\n" +
                    "- Marx streed tegen de overheersing door de bezittende klasse en vond dat\n" +
                    "politieke macht in handen van de arbeiders moest komen,\n" +
                    "waardoor hij een wet afwees die de arbeiders macht afnam.",
                category: "Examen 2021-1",
                type: QuestionType.OorzaakGevolg
            ));



            questions.Add(new Question(
                questionText:
                    "Licht de uitspraak toe:\n" +
                    "\"De aanhangers van het Frankfurter Parlement van 1848 zagen enerzijds de\n" +
                    "totstandkoming van het Duitse keizerrijk in 1871 als de vervulling van een ideaal,\n" +
                    "maar zagen haar anderzijds als een teleurstelling.\"\n\n" +
                    "Licht beide elementen van deze uitspraak toe.",
                answer:
                    "Vervulling van een ideaal: de nationale eenheid was (min of meer) gerealiseerd.\n\n" +
                    "Teleurstelling: het parlement en het volk hadden weinig invloed,\n" +
                    "de keizer had veel macht en er werd geen democratische / liberale staat gevormd.",
                category: "Examen 2018-1",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "Geef aan waardoor het Dawesplan voor de NSDAP een gevaar vormde.",
                answer:
                    "Doordat de Duitse economie onder invloed van het Dawesplan opleefde,\n" +
                    "werd de voedingsbodem voor radicale partijen als de NSDAP kleiner,\n" +
                    "waardoor hun aanhang verminderde.\n\n" +
                    "Of: Duitsland werd door de economische steun te afhankelijk van\n" +
                    "buitenlands kapitaal (volgens de NSDAP).",
                category: "Examen 2018-1",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "In april 1950 stemde Stalin in met het Noord-Koreaanse plan om Zuid-Korea\n" +
                    "te veroveren. Stalin noemde twee redenen:\n\n" +
                    "1) De aanzienlijke versterking van het socialistische blok in het Oosten.\n" +
                    "2) Het oneerlijke, verraderlijke en arrogante gedrag van de VS in Europa.\n\n" +
                    "Noem bij iedere reden een historische gebeurtenis tussen 1945 en 1950\n" +
                    "die Stalin hierbij bedoeld kan hebben.",
                answer:
                    "1) De communistische machtsovername in China / de stichting van de\n" +
                    "Volksrepubliek China (1949).\n\n" +
                    "2) Een van de volgende:\n" +
                    "- De munthervorming in Duitsland\n" +
                    "- De luchtbrug naar West-Berlijn tijdens de Sovjetblokkade\n" +
                    "- Het stichten van de BRD\n" +
                    "- De oprichting van de NAVO\n" +
                    "- Het Marshallplan",
                category: "Examen 2018-1",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "In de late middeleeuwen vond het begin van staatsvorming en centralisatie plaats\n" +
                    "en werden steden in toenemende mate zelfstandig. Aan deze twee ontwikkelingen\n" +
                    "lag een onderlinge afhankelijkheid van landsheren en steden ten grondslag.\n\n" +
                    "Leg deze onderlinge afhankelijkheid uit.",
                answer:
                    "De landsheer had voor zijn politiek van staatsvorming de politieke en economische\n" +
                    "steun van de steden nodig,\n" +
                    "terwijl de steden voor het krijgen van privileges en stadsrechten\n" +
                    "(die nodig waren voor hun groeiende zelfstandigheid)\n" +
                    "de medewerking van de landsheer nodig hadden.",
                category: "Examen 2019-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "In 1585 voerden de Staten van Holland een discussie over de positie van Maurits.\n" +
                    "Er werd besloten hem wel tot stadhouder te benoemen, maar niet de titel\n" +
                    "'Graaf van Holland' te verlenen.\n\n" +
                    "Licht dit besluit toe door:\n" +
                    "- aan te geven welke continuïteit de Staten wilden uitdragen\n" +
                    "- een bestuurlijke verklaring te geven om hem niet de grafelijke titel te verlenen",
                answer:
                    "- De Staten wilden uitdragen dat de Opstand doorging en de militaire aanpak\n" +
                    "niet veranderde (omdat die in handen kwam van de zoon van Willem van Oranje).\n\n" +
                    "- De titel 'Graaf van Holland' werd niet verleend om te voorkomen dat\n" +
                    "Maurits te veel soevereine macht zou krijgen / om duidelijk te maken\n" +
                    "dat Maurits in dienst was van de Staten.",
                category: "Examen 2019-2",
                type: QuestionType.OorzaakGevolg
            ));



            questions.Add(new Question(
                questionText:
                    "Toon aan dat de bouw van stadsmuren van Maastricht in beide fasen noodzakelijk\n" +
                    "was door de 'opkomst van handel en ambacht':\n\n" +
                    "1) In 1229 werd begonnen met de bouw van de eerste stenen ommuring.\n" +
                    "2) Rond 1375 werden nieuwe stadsmuren gebouwd, waarmee de oppervlakte\n" +
                    "   van de stad verviervoudigde.",
                answer:
                    "1) Door de opkomst van handel en ambacht was het noodzakelijk muren te bouwen\n" +
                    "om de ontstane markten en toegestroomde handelaren en ambachtslieden te beschermen.\n\n" +
                    "2) Met nieuwe muren moest de stad uitgebreid worden omdat door de groeiende\n" +
                    "handel de stad aantrekkelijker werd als vestigingsplaats en\n" +
                    "het aantal winkels en werkplaatsen steeg.",
                category: "Examen 2021-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "In 1581 werd in de Nederlanden een pamflet uitgegeven ter ondersteuning van\n" +
                    "de inhuldiging van de hertog van Anjou als nieuwe landsheer.\n\n" +
                    "Licht de uitgave van het pamflet toe door:\n" +
                    "- aan te geven welke gebeurtenis uit 1581 de inhuldiging van Anjou mogelijk maakte\n" +
                    "- uit te leggen dat dit pamflet de keuze voor Anjou als soeverein vorst ondersteunt",
                answer:
                    "- In 1581 zegden de gewesten hun gehoorzaamheid aan Filips II op /\n" +
                    "tekenden de gewesten het Plakkaat van Verlatinge,\n" +
                    "zodat er een nieuwe landsheer kon worden ingehuldigd.\n\n" +
                    "- Het pamflet ondersteunt de keuze voor Anjou door aan te tonen dat\n" +
                    "de Spanjaarden opdracht gaven voor de aanslag op Willem van Oranje,\n" +
                    "om te laten zien dat Franse steun tegen Spanje wenselijk is.",
                category: "Examen 2021-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "Leg beide beweringen over Siebenpfeiffer uit:\n\n" +
                    "1) Siebenpfeiffer geeft kritiek op maatregelen van het Congres van Wenen.\n" +
                    "2) Siebenpfeiffer loopt vooruit op ideeën van het Frankfurter Parlement.",
                answer:
                    "1) Het Congres van Wenen herstelde Duitse vorstendommen, terwijl Siebenpfeiffer\n" +
                    "zich afzet tegen deze grenzen / tegen de onderdrukking van het volk.\n\n" +
                    "2) Siebenpfeiffer wil dat de Duitse vorsten burgers worden / wil een einde maken\n" +
                    "aan de absolutistische vorstenhuizen / wil een verenigd Duitsland,\n" +
                    "waarmee hij vooruitloopt op de liberale ideeën van het Frankfurter Parlement.",
                category: "Examen 2021-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "In twee volkspetities uit 1878 werd koning Willem III opgeroepen om een\n" +
                    "nieuwe onderwijswet niet te ondertekenen.\n\n" +
                    "Leg uit:\n" +
                    "- Door welke politiek-maatschappelijke stroming het initiatief voor deze\n" +
                    "  petitie werd genomen\n" +
                    "- Tegen de opkomst van welke politieke stroming de petitie zich richtte",
                answer:
                    "- Het initiatief werd genomen door de confessionelen, want de petitie richtte\n" +
                    "zich op het behoud van de 'School met den Bijbel' / christelijk onderwijs.\n\n" +
                    "- De petitie richtte zich tegen de opkomst van de socialisten /\n" +
                    "sociaaldemocraten, want ze keerden zich tegen figuren die oproepen tot opstand\n" +
                    "en de armen ontevreden maken.",
                category: "Examen 2021-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "Geef aan welk belang Stalin had bij het tweede front en leg uit waardoor\n" +
                    "het uitblijven hiervan tot juni 1944 bijdroeg aan het ontstaan van de Koude Oorlog.",
                answer:
                    "Stalin wilde een tweede front om het Russische leger te ontlasten /\n" +
                    "om de Duitsers definitief terug te dringen.\n\n" +
                    "Het uitblijven van het tweede front:\n" +
                    "- werd door Stalin gezien als een poging van de westerse landen om de Russische\n" +
                    "troepen uit te putten, wat bijdroeg aan het wantrouwen tussen beide blokken.\n" +
                    "- gaf de Sovjet-Unie de kans grote delen van Oost-Europa te bevrijden,\n" +
                    "die daardoor in de communistische invloedssfeer terechtkwamen.",
                category: "Examen 2021-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "In februari 1972 bracht president Nixon een bezoek aan China.\n" +
                    "In april 1972 begon het Noord-Vietnamese leger aan een grote aanval op Zuid-Vietnam.\n" +
                    "Historici zien de aanval als een reactie op het bezoek van Nixon.\n\n" +
                    "Leg de redenering uit door:\n" +
                    "- te noemen wat Nixon tijdens zijn bezoek wilde bereiken\n" +
                    "- uit te leggen wat de Noord-Vietnamezen met hun aanval wilden bereiken",
                answer:
                    "- Nixon wilde China overhalen zijn steun aan Noord-Vietnam in te trekken\n" +
                    "om zo de oorlog te kunnen beëindigen.\n\n" +
                    "- Door de aanval wilden de Noord-Vietnamezen de oorlog in hun voordeel\n" +
                    "beslissen voordat China zich zou terugtrekken als bondgenoot.\n" +
                    "Of: laten zien dat de oorlog in hun voordeel kon worden beslist,\n" +
                    "zodat China zijn steun niet zou intrekken.",
                category: "Examen 2021-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "In de troonrede van 1990 stond: \"In Europa beleven wij historische tijden.\n" +
                    "De deling van Europa loopt ten einde. Het beleid is erop gericht de democratische\n" +
                    "en economische ontwikkelingen in Oost-Europa te steunen en aan te moedigen.\"\n\n" +
                    "Leg uit: uit de troonrede is op te maken dat het einde van de Koude Oorlog\n" +
                    "een andere politieke ontwikkeling uit de tweede helft van de twintigste\n" +
                    "eeuw bevorderde.",
                answer:
                    "Uit de troonrede is op te maken dat door het einde van de Koude Oorlog\n" +
                    "de eenwording van Europa werd bevorderd,\n" +
                    "omdat de Oost-Europese landen politiek en economisch betrokken zouden worden\n" +
                    "bij West-Europa.",
                category: "Examen 2021-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "De hippies droegen in de jaren 1960-1970 bij aan sociaal-culturele\n" +
                    "veranderingsprocessen door zich af te zetten tegen economische veranderingen\n" +
                    "in die tijd.\n\n" +
                    "Leg dit uit.",
                answer:
                    "De hippies droegen bij aan het veranderen van traditionele levenswijzen\n" +
                    "door privébezit en consumptie te willen inperken /\n" +
                    "door een levenswijze in communeverband na te streven,\n" +
                    "waarmee zij zich afzetten tegen de groei van de consumptiemaatschappij /\n" +
                    "de toenemende welvaart vanaf de jaren 1960.",
                category: "Examen 2019-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "Kies twee gegevens uit het leven van Joseph Luns en geef telkens aan bij welk\n" +
                    "kenmerkend aspect van de tweede helft van de twintigste eeuw dit gegeven past:\n\n" +
                    "1) In 1957 ondertekende Luns het Verdrag van Rome over het vrije verkeer\n" +
                    "   van goederen in West-Europa.\n\n" +
                    "2) In 1962 vertelde Luns dat Nederland marineschepen had gestuurd naar Nieuw-Guinea\n" +
                    "   om te voorkomen dat Indonesië dat gebied zou inlijven.\n\n" +
                    "3) In 1979 pleitte Luns voor de modernisering van het kernwapenarsenaal van de NAVO.",
                answer:
                    "Twee van de volgende:\n\n" +
                    "- Bij 1: Past bij 'De eenwording van Europa'.\n\n" +
                    "- Bij 2: Past bij 'De dekolonisatie die een eind maakte aan de westerse\n" +
                    "hegemonie in de wereld'.\n\n" +
                    "- Bij 3: Past bij 'De verdeling van de wereld in twee ideologische blokken' /\n" +
                    "'Een wapenwedloop en de dreiging van een atoomoorlog'.",
                category: "Examen 2019-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "In 1820 schonk koning Willem I aan Gent een schilderij waarop te zien was hoe\n" +
                    "Willem van Oranje pleitte voor vrijlating van katholieken bij het bestuur\n" +
                    "van de Gentse calvinistische republiek.\n\n" +
                    "Ondersteun de interpretatie dat Willem I met deze schenking een politiek\n" +
                    "doel wilde bereiken door:\n" +
                    "- aan te geven welk politiek doel hij wilde bereiken\n" +
                    "- uit te leggen waardoor de voorstelling op het schilderij hiertoe kon bijdragen",
                answer:
                    "- Willem I wilde Gent en de Zuidelijke Nederlanden aan zich binden /\n" +
                    "wilde eenheid creëren in het recent opgerichte Koninkrijk der Nederlanden.\n\n" +
                    "- Willem I kon duidelijk maken dat hij net als zijn voorvader een goede vorst\n" +
                    "zou zijn, omdat het schilderij liet zien dat zijn voorvader verdraagzaamheid\n" +
                    "tussen katholieken en protestanten bepleitte.",
                category: "Examen 2019-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "Leg uit waarom de stedelijke samenleving in Babylonië rond 1800 voor Christus\n" +
                    "een vroeg-stedelijke samenleving was.\n\n" +
                    "Archeologen vonden een stenen gewicht in de vorm van een kikker met de tekst:\n" +
                    "\"Kikker van tien minas, een wettig gewicht van de god Sjamasj\".\n" +
                    "De mina werd gebruikt om graankorrels af te wegen.\n\n" +
                    "Leg uit welke voorwaarde voor het ontstaan van een vroeg-stedelijke samenleving\n" +
                    "dit gewicht aantoont.",
                answer:
                    "Met de vondst van een wettig vastgesteld gewicht dat werd gebruikt voor het\n" +
                    "afwegen van graan, kun je aantonen dat er sprake was van het aanleggen van\n" +
                    "graanvoorraden / van een overschot in de graanproductie,\n" +
                    "wat een voorwaarde is voor het ontstaan van een vroeg-stedelijke samenleving.",
                category: "Examen 2021-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "In 1146 kreeg abt Bernardus van Clairvaux opdracht een preek te houden:\n" +
                    "\"Haast u om voor uw zonden te boeten door de ongelovigen te verslaan.\n" +
                    "Christelijke strijders, Jezus vraagt nu het uwe ervoor terug.\n" +
                    "Deze strijd is u waardig, de strijd waarin het glorieus is te veroveren.\"\n\n" +
                    "Leg de conclusie uit: de paus wilde met deze preek een doelstelling van de\n" +
                    "katholieke kerk in de late middeleeuwen ondersteunen.",
                answer:
                    "Door te laten zeggen dat een ridder van Christus voor zijn zonden kan boeten\n" +
                    "door ongelovigen te verslaan / dat Christus wil dat de ridders gaan strijden,\n" +
                    "wilde de paus de expansie van het christendom naar buiten toe ondersteunen /\n" +
                    "steun krijgen voor het houden van een kruistocht.",
                category: "Examen 2021-2",
                type: QuestionType.OorzaakGevolg
            ));

            questions.Add(new Question(
                questionText:
                    "Toon aan dat de vlagkeuzes van 1871 en 1949 een politieke boodschap uitdroegen:\n\n" +
                    "1871: Het Duitse keizerrijk koos voor een vlag met zwart-wit-rood\n" +
                    "(zwart-wit van de Pruisische vlag).\n\n" +
                    "1949: De DDR koos de vlag met zwart-rood-geel\n" +
                    "(dezelfde vlag als het Frankfurter Parlement van 1848).",
                answer:
                    "1871: Door te kiezen voor de kleuren van Pruisen droeg het keizerrijk uit\n" +
                    "dat Pruisen de machtigste staat was en een belangrijke rol had gespeeld\n" +
                    "bij de Duitse eenwording.\n\n" +
                    "1949: Door te kiezen voor de vlag van het Frankfurter Parlement /\n" +
                    "de Weimarrepubliek droeg de DDR uit dat het land een volksdemocratie was /\n" +
                    "zich distantieerde van het Derde Rijk.",
                category: "Examen 2019-2",
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
        public string Name           { get; set; }
        public Color  Color          { get; set; }
        public int    CorrectAnswers { get; private set; }
        public int    WrongAnswers   { get; private set; }

        public Player(string name, Color color)
        {
            Name  = name;
            Color = color;
        }

        public void AddCorrect() => CorrectAnswers++;
        public void AddWrong()   => WrongAnswers++;
        public string Stats()    => $"{Name}: {CorrectAnswers}✓ {WrongAnswers}✗";
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
            return Dir(row, col, 0, 1, p)  + Dir(row, col, 0, -1, p)  >= 3 ||
                   Dir(row, col, 1, 0, p)  + Dir(row, col, -1, 0, p)  >= 3 ||
                   Dir(row, col, 1, 1, p)  + Dir(row, col, -1, -1, p) >= 3 ||
                   Dir(row, col, 1, -1, p) + Dir(row, col, -1, 1, p)  >= 3;
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
        private Button  btnLogin;

        public LoginForm()
        {
            this.Text            = "Geschiedenis Connect Four – 6vwo";
            this.Size            = new Size(440, 340);
            this.StartPosition   = FormStartPosition.CenterScreen;
            this.BackColor       = Color.FromArgb(245, 230, 190);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;

            // Titel — gecentreerd
            var lblTitle = new Label {
                Text      = "📜 Geschiedenis Connect Four",
                Font      = new Font("Georgia", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 40, 10),
                AutoSize  = false,
                Size      = new Size(400, 35),
                Location  = new Point(20, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblTitle);

            AddLabel("Gebruikersnaam:", new Font("Georgia", 10), new Point(50, 75));
            txtUsername = AddTextBox(new Point(50, 98), 320);
            AddLabel("Wachtwoord:", new Font("Georgia", 10), new Point(50, 138));
            txtPassword = AddTextBox(new Point(50, 161), 320, true);

            btnLogin = new Button {
                Text      = "Inloggen",
                Location  = new Point(155, 215),
                Size      = new Size(120, 38),
                BackColor = Color.FromArgb(139, 90, 43),
                ForeColor = Color.FromArgb(245, 230, 190),
                FlatStyle = FlatStyle.Flat,
                Font      = new Font("Georgia", 10, FontStyle.Bold)
            };
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(80, 40, 10);
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
            this.Controls.Add(new Label {
                Text = text, Font = font, AutoSize = true, Location = loc,
                ForeColor = Color.FromArgb(80, 40, 10)
            });
        }

        private TextBox AddTextBox(Point loc, int width, bool password = false)
        {
            var tb = new TextBox {
                Location       = loc, Size = new Size(width, 25),
                Font           = new Font("Georgia", 10),
                BackColor      = Color.FromArgb(250, 240, 210),
                ForeColor      = Color.FromArgb(60, 30, 5),
                RightToLeft    = RightToLeft.No
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
            this.Text            = "Speler Selectie";
            this.Size            = new Size(400, 350);
            this.StartPosition   = FormStartPosition.CenterScreen;
            this.BackColor       = Color.FromArgb(245, 230, 190);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;

            this.Controls.Add(new Label {
                Text      = $"Welkom {username}!\nKies aantal spelers:",
                Font      = new Font("Georgia", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 40, 10),
                AutoSize  = false,
                Size      = new Size(350, 60),
                Location  = new Point(25, 30),
                TextAlign = ContentAlignment.MiddleCenter
            });

            string[] labels = { "2 Spelers", "3 Spelers", "4 Spelers" };
            for (int i = 0; i < 3; i++) {
                int count = i + 2;
                var btn = new Button {
                    Text      = labels[i],
                    Location  = new Point(120, 115 + i * 65),
                    Size      = new Size(150, 50),
                    BackColor = Color.FromArgb(139, 90, 43),
                    ForeColor = Color.FromArgb(245, 230, 190),
                    FlatStyle = FlatStyle.Flat,
                    Font      = new Font("Georgia", 12, FontStyle.Bold)
                };
                btn.FlatAppearance.BorderColor = Color.FromArgb(80, 40, 10);
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
        private List<Button> colorButtons  = new List<Button>();
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
            playerCount          = players;
            this.Text            = "Kleur Selectie";
            this.Size            = new Size(700, 400);
            this.StartPosition   = FormStartPosition.CenterScreen;
            this.BackColor       = Color.FromArgb(245, 230, 190);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;

            lblInstruction = new Label {
                Text      = $"Speler {currentPlayer}: Kies je kleur",
                Font      = new Font("Georgia", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 40, 10),
                AutoSize  = true,
                Location  = new Point(195, 28)
            };
            this.Controls.Add(lblInstruction);

            int x = 60, y = 100;
            for (int i = 0; i < availableColors.Length; i++) {
                var btn = new Button {
                    Size = new Size(70, 70), Location = new Point(x, y),
                    BackColor = availableColors[i], FlatStyle = FlatStyle.Flat, Tag = i
                };
                btn.FlatAppearance.BorderColor = Color.Gray;
                btn.FlatAppearance.BorderSize  = 2;
                btn.Click += ColorBtn_Click;
                colorButtons.Add(btn);
                this.Controls.Add(btn);
                x += 80;
                if ((i + 1) % 4 == 0) { x = 60; y += 80; }
            }

            btnStart = new Button {
                Text      = "Start Spel ▶",
                Location  = new Point(255, 305),
                Size      = new Size(160, 48),
                BackColor = Color.FromArgb(100, 60, 15),
                ForeColor = Color.FromArgb(245, 230, 190),
                FlatStyle = FlatStyle.Flat,
                Font      = new Font("Georgia", 12, FontStyle.Bold),
                Enabled   = false
            };
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(60, 30, 5);
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
            else {
                lblInstruction.Text = "Alle kleuren gekozen!";
                btnStart.Enabled    = true;
            }
        }
    }

    // ============================================================
    //  FORM: QuestionForm  — toont vraag, bronnen en optioneel beeld
    // ============================================================
    public class QuestionForm : Form
    {
        private Question       question;
        private QuestionBank   bank;
        private TextBox        txtAnswer;
        private Button         btnSubmit;
        public  bool           IsCorrect   { get; private set; }
        public  bool           AnswerGiven { get; private set; }

        // Kleur per vraagtype
        private static readonly Dictionary<QuestionType, Color> TypeColors =
            new Dictionary<QuestionType, Color> {
                { QuestionType.Chronologie,      Color.FromArgb(255, 200, 0)   },  // Fel geel
                { QuestionType.KenmerkendAspect, Color.FromArgb(0, 200, 80)    },  // Fel groen
                { QuestionType.OorzaakGevolg,    Color.FromArgb(220, 50, 50)   }   // Fel rood
            };

        private static readonly Dictionary<QuestionType, string> TypeLabels =
            new Dictionary<QuestionType, string> {
                { QuestionType.Chronologie,      "📅 Chronologie"        },
                { QuestionType.KenmerkendAspect, "🔑 Kenmerkend Aspect"  },
                { QuestionType.OorzaakGevolg,    "⚡ Oorzaak & Gevolg"   }
            };

        public QuestionForm(QuestionBank qbank)
        {
            bank        = qbank;
            question    = bank.GetRandomQuestion();
            AnswerGiven = false;
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text            = "Examenvraag – Geschiedenis 6vwo";
            this.Size            = new Size(720, 680);
            this.StartPosition   = FormStartPosition.CenterScreen;
            this.BackColor       = Color.FromArgb(245, 230, 190);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.AutoScroll      = true;

            int y = 10;

            // ── Type-badge ────────────────────────────────────────────────
            var pnlType = new Panel {
                Location  = new Point(10, y),
                Size      = new Size(680, 35),
                BackColor = TypeColors[question.Type]
            };
            pnlType.Controls.Add(new Label {
                Text      = TypeLabels[question.Type],
                Font      = new Font("Comic Sans MS", 13, FontStyle.Bold),
                AutoSize  = true,
                Location  = new Point(10, 7),
                BackColor = Color.Transparent,
                ForeColor = Color.White
            });
            this.Controls.Add(pnlType);
            y += 45;

            // ── Vraag tekst ───────────────────────────────────────────────
            y += 6;
            var rtbQ = new RichTextBox {
                Text        = question.QuestionText,
                Font        = new Font("Georgia", 11, FontStyle.Bold),
                ReadOnly    = true,
                BackColor   = Color.FromArgb(245, 230, 190),
                ForeColor   = Color.FromArgb(60, 30, 5),
                BorderStyle = BorderStyle.None,
                Location    = new Point(10, y),
                Size        = new Size(680, 120),
                ScrollBars  = RichTextBoxScrollBars.Vertical,
                SelectionAlignment = HorizontalAlignment.Left
            };
            this.Controls.Add(rtbQ);
            y += 128;

            // ── Antwoordveld ──────────────────────────────────────────────
            this.Controls.Add(new Label {
                Text      = "Jouw antwoord:",
                Font      = new Font("Georgia", 10),
                ForeColor = Color.FromArgb(80, 40, 10),
                AutoSize  = true,
                Location  = new Point(10, y)
            });
            y += 24;

            txtAnswer = new TextBox {
                Location  = new Point(10, y),
                Size      = new Size(680, 60),
                Font      = new Font("Georgia", 11),
                Multiline = true,
                BackColor = Color.FromArgb(250, 240, 210),
                ForeColor = Color.FromArgb(60, 30, 5)
            };
            txtAnswer.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.Enter && e.Control) Submit();
            };
            this.Controls.Add(txtAnswer);
            y += 68;

            btnSubmit = new Button {
                Text      = "Verstuur Antwoord  →",
                Location  = new Point(220, y),
                Size      = new Size(260, 45),
                BackColor = Color.FromArgb(139, 90, 43),
                ForeColor = Color.FromArgb(245, 230, 190),
                FlatStyle = FlatStyle.Flat,
                Font      = new Font("Georgia", 11, FontStyle.Bold)
            };
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(80, 40, 10);
            btnSubmit.Click += (s, e) => Submit();
            this.Controls.Add(btnSubmit);

            this.ClientSize = new Size(700, y + 60);
        }

        private void Submit()
        {
            if (string.IsNullOrWhiteSpace(txtAnswer.Text)) {
                MessageBox.Show("Vul een antwoord in!", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var check = new AnswerCheckForm(txtAnswer.Text, question.Answer);
            check.ShowDialog();
            IsCorrect   = check.IsCorrect;
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
            this.Text            = "Controleer je antwoord";
            this.Size            = new Size(600, 480);
            this.StartPosition   = FormStartPosition.CenterScreen;
            this.BackColor       = Color.FromArgb(245, 230, 190);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;

            int y = 15;

            AddBoldLabel("Jouw antwoord:", y); y += 26;
            AddRtb(playerAnswer, Color.FromArgb(230, 200, 160), y); y += 90;

            AddBoldLabel("Modelantwoord:", y); y += 26;
            AddRtb(correctAnswer, Color.FromArgb(210, 180, 130), y); y += 130;

            this.Controls.Add(new Label {
                Text      = "Is jouw antwoord (grotendeels) juist?",
                Font      = new Font("Georgia", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 40, 10),
                AutoSize  = true,
                Location  = new Point(110, y)
            });
            y += 36;

            var btnJ = new Button {
                Text      = "✓  Juist",
                Location  = new Point(80, y),
                Size      = new Size(180, 52),
                BackColor = Color.FromArgb(60, 120, 40),
                ForeColor = Color.FromArgb(245, 230, 190),
                FlatStyle = FlatStyle.Flat,
                Font      = new Font("Georgia", 12, FontStyle.Bold)
            };
            btnJ.FlatAppearance.BorderColor = Color.FromArgb(30, 80, 10);
            btnJ.Click += (s, e) => { IsCorrect = true; this.Close(); };

            var btnO = new Button {
                Text      = "✗  Onjuist",
                Location  = new Point(330, y),
                Size      = new Size(180, 52),
                BackColor = Color.FromArgb(160, 50, 30),
                ForeColor = Color.FromArgb(245, 230, 190),
                FlatStyle = FlatStyle.Flat,
                Font      = new Font("Georgia", 12, FontStyle.Bold)
            };
            btnO.FlatAppearance.BorderColor = Color.FromArgb(100, 20, 10);
            btnO.Click += (s, e) => { IsCorrect = false; this.Close(); };

            this.Controls.AddRange(new Control[] { btnJ, btnO });
        }

        private void AddBoldLabel(string text, int y) =>
            this.Controls.Add(new Label {
                Text      = text,
                Font      = new Font("Georgia", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 40, 10),
                Location  = new Point(20, y),
                AutoSize  = true
            });

        private void AddRtb(string text, Color bg, int y) =>
            this.Controls.Add(new RichTextBox {
                Text        = text,
                Font        = new Font("Georgia", 10),
                ReadOnly    = true,
                BackColor   = bg,
                ForeColor   = Color.FromArgb(60, 30, 5),
                BorderStyle = BorderStyle.FixedSingle,
                Location    = new Point(20, y),
                Size        = new Size(550, 85),
                ScrollBars  = RichTextBoxScrollBars.Vertical
            });
    }

    // ============================================================
    //  FORM: GameBoardForm  — originele grid-klik mechanic behouden
    // ============================================================
    public class GameBoardForm : Form
    {
        private GameBoard    gameBoard;
        private List<Player> players;
        private QuestionBank questionBank;
        private Button[,]    cells     = new Button[GameBoard.ROWS, GameBoard.COLS];
        private int[,]       board     = new int[GameBoard.ROWS, GameBoard.COLS];
        private Label        lblStatus;
        private Panel        boardPanel;
        private Button       btnNewGame;
        private int          currentPlayer = 0;

        public GameBoardForm(int playerCount, List<Color> colors)
        {
            gameBoard    = new GameBoard();
            questionBank = new QuestionBank();
            players      = new List<Player>();
            for (int i = 0; i < playerCount; i++)
                players.Add(new Player($"Speler {i + 1}", colors[i]));
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text          = "Geschiedenis Connect Four – 6vwo";
            this.Size          = new Size(800, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor     = Color.FromArgb(245, 230, 190);

            lblStatus = new Label {
                Text      = $"Speler 1 is aan de beurt",
                Font      = new Font("Georgia", 15, FontStyle.Bold),
                AutoSize  = false,
                Size      = new Size(860, 35),
                Location  = new Point(20, 20),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(80, 40, 10)
            };

            boardPanel = new Panel {
                Location    = new Point(15, 65),
                Size        = new Size(756, 576),
                BackColor   = Color.FromArgb(180, 130, 70),
                BorderStyle = BorderStyle.FixedSingle
            };

            // ── Originele grid-klik mechanic ──────────────────────────────
            for (int row = 0; row < GameBoard.ROWS; row++) {
                for (int col = 0; col < GameBoard.COLS; col++) {
                    cells[row, col] = new Button {
                        Size      = new Size(104, 90),
                        Location  = new Point(6 + col * 107, 6 + row * 94),
                        BackColor = Color.FromArgb(250, 240, 210),
                        FlatStyle = FlatStyle.Flat,
                        Font      = new Font("Georgia", 7, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Tag       = new Point(row, col),
                        ForeColor = Color.FromArgb(60, 30, 5)
                    };
                    cells[row, col].FlatAppearance.BorderColor = Color.FromArgb(139, 90, 43);
                    cells[row, col].FlatAppearance.BorderSize  = 2;
                    cells[row, col].Click += Cell_Click;
                    boardPanel.Controls.Add(cells[row, col]);
                }
            }

            btnNewGame = new Button {
                Text      = "Nieuw Spel",
                Location  = new Point(310, 650),
                Size      = new Size(150, 38),
                BackColor = Color.FromArgb(139, 90, 43),
                ForeColor = Color.FromArgb(245, 230, 190),
                FlatStyle = FlatStyle.Flat,
                Font      = new Font("Georgia", 11, FontStyle.Bold)
            };
            btnNewGame.FlatAppearance.BorderColor = Color.FromArgb(80, 40, 10);
            btnNewGame.Click += BtnNewGame_Click;

            this.Controls.AddRange(new Control[] { lblStatus, boardPanel, btnNewGame });
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var pos = (Point)btn.Tag;
            int row = pos.X, col = pos.Y;

            if (gameBoard.IsOccupied(row, col)) {
                MessageBox.Show("Dit vakje is al bezet!", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var qForm = new QuestionForm(questionBank);
            qForm.ShowDialog();
            if (!qForm.AnswerGiven) return;

            var p = players[currentPlayer];

            if (qForm.IsCorrect) {
                p.AddCorrect();
                gameBoard.PlaceChip(row, col, currentPlayer + 1);
                cells[row, col].BackColor = p.Color;
                cells[row, col].Text      = p.Name;
                cells[row, col].ForeColor = Color.FromArgb(51, 51, 51);

                if (gameBoard.CheckWin(row, col)) {
                    MessageBox.Show(
                        $"🏆 {p.Name} wint!\n\n" +
                        string.Join("\n", players.Select(pl => pl.Stats())),
                        "Winnaar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableAll();
                    return;
                }
                if (gameBoard.IsFull()) {
                    MessageBox.Show("🤝 Gelijkspel! Het bord is vol.", "Spel Afgelopen",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else {
                p.AddWrong();
                MessageBox.Show($"❌ Fout antwoord, {p.Name}!\nVolgende speler is aan de beurt.",
                    "Onjuist", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            currentPlayer = (currentPlayer + 1) % players.Count;
            var next = players[currentPlayer];
            lblStatus.Text      = $"{next.Name} is aan de beurt";
            lblStatus.ForeColor = Color.FromArgb(80, 40, 10);
        }

        private void DisableAll()
        {
            foreach (var btn in cells) btn.Enabled = false;
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wil je een nieuw spel starten?", "Nieuw Spel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
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
