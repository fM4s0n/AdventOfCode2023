﻿namespace AdventOfCode2023.DaySolutions;

internal static class Day3
{
    private static readonly string puzzleInput = "...........................................751........501...................................890.231...............829..168......143.........\r\n......................................*.........841....*....../................+..311.......................441..........*...........202....\r\n.........332...60....537..697.......901.................609....678....261.....90................870....519...........272..449.......%.......\r\n840.........*...........*....*..968......273...440.415..................*..................&......*...*......447................883...&.....\r\n.....34....651.786...646...804.*..........*.../.....-..........=...............94......96..760.222.....637.%...&.290...55..368.....*..565...\r\n.518*..........+................717......80.............231.....610...810*942..........*...................640...*................499.......\r\n...................189......................772.........*........................550..626...676-......213......432...........790.......834..\r\n......995..=..........&..955...........391......387...825..362........481...334..*................579.*...84%.......506./...................\r\n........*.700..............*..........*.......+..*............*...170.%..........733........658..*....832............-..777..616.915........\r\n......322...........977.526............852...410.14.........28.....$.........831.....%.....@.....586.........69.....................+.......\r\n...............................30.........................*............./.....*.......505....274...........=.#....344...52.308..............\r\n.........123*504.................-...-..................15.968.....427.439...456..............*..935../..441......*.....*..*.....195.794....\r\n..729.............186...............786..476*168.653*.............*........................148...+...962...................271......*.......\r\n............23.......................................435.491*4..40...-...26.......11..133..................*758.-....215....................\r\n466...656..=............957.........463.............................372..*..............................894.....661.......903.......%283....\r\n..................421...*.................32..946...%....668.886..........30.682......108...........................292..................189\r\n....759......379.*.....380.......................-..942..=....*...891......../.......*....193.......703..946/......./...................*...\r\n.39*.........*...847............80-..........................886.*.....+.............418.@......763............432.....................873..\r\n...........916.......................335..369.....................651..624.445*809.........*695...*..267.......+....666.641.888.480.........\r\n...@38...............685..149..........&.*..........312..................................27......544....*.420.........*....*..........*750..\r\n................&.....*..*...............208...........*...361.....&.....569................*986.....295...*..751..499.............549......\r\n.....@.......626...390..761....*.............$.........319....+.289..250*................189.....947......804....*......742*................\r\n.....660....................342.582.......24..611..................................354.*............*.............997.......595....874......\r\n...................................................109.........*...108.........252.*...168.@88...973................................#...$...\r\n214.....161..............499-.......................%........497...*....419.....*...52.........................83.........*5.............739\r\n.......*...............................156..........................88........798..............204...............*.....444.......974........\r\n.108..39..................*651.395#.....*.............963.......911...............886.................532.....417...................-.......\r\n....*..........921*82..321...........597...@321..409.....*254....../........237...*.......................&......./...................=308..\r\n.954..110........................................../.................478....*.....423.........990....187.429..#...506..........614*.........\r\n........#...211.............................575.....................*....893...13.........811*................673.....85...........465......\r\n..................393...........782.............-166.........=.831...401........*.348....................477...........*.819..#261..........\r\n.....761..........*...536.....+....&.................549..427.....*...........924.@......283.50............*........795...=.................\r\n....*....-.51....617./......954...................................248...................*........776....407.................................\r\n.756..986..............326........516............387..342....336............142=.823..354....233.............$...........523........336.....\r\n..........+495...856.....*....363....*188.177.4..+..............*....=512....................*...835......458..348..........*.......=....445\r\n................*.........638.$..............*.......214.........190......293...........&.128......*............*..167......711.........*...\r\n...565.......842.................#.....................@...............=..#...........195.......984.....201#...530...................640....\r\n...*...........................289.401.......251...626..........198*..277....$..............%.......................719..........964........\r\n...397..910+............................$....*.....&.....936..............893../...........249.....#334.299.../503..........*....*..........\r\n..............................918-...420...405..............$...226.729.........910........................*.........892....76....511.......\r\n...674=...282*418......#................................................962..........=693.....760..........499.908/..../.......$........*926\r\n.......................906..../......485*..........*......9....+....564*.........132.............*..........................137.............\r\n...........................300...........960....503.572......490............608*.......*....504.979..25......230.................925...@....\r\n..673............787..............................................433*164.......961.956.596.........*...610...............340.......#...765.\r\n....*....................8*............217*805..................*..................................427..*........680*.......................\r\n....247..............699...848....................651........137.870.673............696..................660.........432...593=.........906.\r\n..........209.........*....................327............................%..........%................3.....................................\r\n.....%.../.....482...708...782............*..........520..................947....390...420.....%..............456.....667*544............732\r\n..305.......%.....*......%....%....220...419....608..*.............282............&....#........269......117-....*834.........546#..........\r\n............137...145.128...........%.............*.555.............*.......................=...............................................\r\n....988.299.....................940.......978..971........437.......79..........*.........238.497...490.912.539.........85......157-........\r\n..........*.660....335......../...%........................*..224........@...556.368.............*...*...*..*...551......................474\r\n291..217..1..................321......-...................17.....*.......810............411......573.688...273.....*....$.............../...\r\n....*.........=.......701............781...*....................761...........315........*........................895.445...................\r\n...............467.......*...............444................................/../..........925..530+....50.....-.............................\r\n........+..........545....970........./........767......543..............953........389.................$.....393......#....17....83........\r\n.668.....577...&..@............803.....931......*............829..226*.............*.......-....114................=..9.....&............298\r\n..../........239.......101...&...*..................419.....@.........922..17......598....704..*..................722...........768.........\r\n.................776..*......156.163............419...@....................*...................465..+....................206=......-.*......\r\n....506.891-.......=.499....................@......#..........992..664....270......*395..............519.......666..............37...566....\r\n....&........251.................671.=.......474......429....*..../.............776.........#.............260.&....319......410*............\r\n............*.....46...772.........#.441.........340=..-.....393.....452..../..............219......487..*........*.....697.................\r\n......993.507.............*.........................................&......515.231..#988........./..$...519.=...435.....*...........753.....\r\n..177..=.......*17.........341..62.....361...820.....647+.........................*...........939...........980.......7.145....310....*.....\r\n....*.....113.....................*17.....*..................583....585...........160..571............................*..............75.....\r\n..937.163....*857...........322.......233..436..973................*............................678..................304.....#140...........\r\n.........*............@................@.......@......412..521......917......+.............................................@..............32\r\n.........233.........5.......649.230..................*...%..................513....304.........745...85..31....799........958..............\r\n.....983........@...............*.....#......%.....340..........=....745...............*565........%..*..........*.....835.........../503...\r\n.....*.......558....71.............518......546..........148..439....*.......567......................870..846$.519.......#..../17..........\r\n....945..381.......$........671@.....................390...........870..........+..%.........*..198..................347-...............164.\r\n....................................................@.....-...............318......555....234.9................@..................134.......\r\n..............489$....=608.............................&...40.*.................................................291.274...489.690*..........\r\n.....=485...........................633.462....+......490......370...............-......740..........416*..............*....................\r\n....................................*.....*.....125./.....#656.....679.....227....455.-....*.......*.................414................552.\r\n.................227..............733.$....787.......532..............*879...-........681...148.188.426./.......547.........=.......645.....\r\n....+..21.....75...*.....797...........73...................491...12............27......................727...@...*........912..............\r\n...258...*572.....955.......*..&...585.........*.......800.*...............@...-............................357.........................+...\r\n...........................415.389.*........973.738.%..-...759.968....477..192.......553...#.......398..170......900..../..986..834$..758...\r\n.........10......816..676..........356..............78............*..%..............*.....372......./......*..........322...................\r\n.....122*..........*......%............590.............870..920..911............246..452................740...............199...............\r\n...........444.....738....505...@.498...*...=..........*...................................946...................+.*......*.................\r\n.....675.....*................180...%.957..335.295...&.222....-..........281..625....@....=.....695...........173..652......141...-.........\r\n.......*....860........842.........................453.......809.....167....*..*..308..........*......902.101..................+...894..130.\r\n.....834...............*....=138.........................224.....301...$..663.9.......58.....899.........*..................................\r\n........................948......................908............+...............#................74........384.454......69.....*724.........\r\n...............4............84........990.949...*...................480...961..230......18........#..367......*.............................\r\n......496.......*289..........*11............*..........139*129....@.........*........................*...255................532.....607.443\r\n......*................888....................812....................876..364......965....105.....446.612...*..12*............*......*......\r\n..374...833.........19*.......904.........432.......153.....78/...............267..........*..............800......285......890...618.......\r\n...*......*...479..........*.*.................648.....+.........71...........*........53..216.686............3/....@..498...............346\r\n.739......28.....*760....112.725..145......133.../.#71.....737....$..*.....407..228......=........%....................=.............407*...\r\n.....619............................=.........&.............../.....932........&.............................296.........348.+166...........\r\n.......*.............22...-917......................................................-317........................=.........#........=.....111\r\n.......263...............................$........829......=...418-...........$..............599..304.............@..........849$..442..&...\r\n..792%...........*880....499...........719....415*.......853................928...47...*59...@...*....679.......744.........................\r\n.........590..589..........*...90...................*...............#282.........*..............568..$..........................736..383.321\r\n.........../.........481....87.*.................831.674....430.............270..393....................%65......................*......*...\r\n....864.........809....*........922.979......................./....461.545.....@.....738........-.....................355.....646...........\r\n.......%......@....#....539.........$.................*122............*....992...898*.....801.497.......#...&...@.................214..862..\r\n.............393...............................964.953..........503@......*........................764..143.17..385...........525...*.......\r\n.......87.49......444#....................&............................108.....801..............*.....&................866.......$.334...626\r\n............*120.............736.971....595........715...462...=.....-........=.................754.............@.........*629..............\r\n.....331............620........*...*.........252.............987.=...846..........163..941.............-219...719...231*..........=.........\r\n....../.........468*..........734...939.........+..220..934......170........745..-.................*....................635......650........\r\n.550.......&..........................................%.*.....................*.......&.........261.346.237..................#..............\r\n...*.528..303.546..........357.....878.....571..........755...619...661.....803.358.335....67.......................496...259.........25....\r\n.938.+....................*...........+.......*649.............*..../.....................*..........................*..........961....*....\r\n...........975........-....745...........312................134...........253.98...........362.......716.............94.+...620...+.-...62..\r\n............*.......123..............429....*26.......590............836&.@...........$..............=..................485.........821.....\r\n....555......924...........287........../.............*............................837..........408.........................................\r\n........265............924*.........784......382......354.............255..280.896...............+..........537....936....524...601.........\r\n.............495........................177.....+...........148...628*......*............691.........776=..*......*......*.......&..........\r\n.....617....*....................832.....#........278*651...*...............767.......16.......66..........857.956.....145..............817.\r\n.......*...560..........906..........635..........................526*.............44*...%....@......@981......................=...624.*....\r\n....446............-.../................*....................%........798...............796.....................448..........839...*....941.\r\n.................523.......%.990..828-.537......22........771....251...........938..884........782....866..................@........776.....\r\n.808...255..............527..$..............&......709*.............*....=....*........+.......*.........*..........908..659.675............\r\n..........=.-694.................225........603........523.......617...201.....85..............430.......982...62..=..........*...+...118...\r\n.......=..........672............*.................713...................................120..........&.....................237..733........\r\n........723....77*.......765........453....296.......*...........................392.554*.......@......770.878.569..../..............757....\r\n........................./............*.......@.....518.................360*.................272...602........*....456....614/..............\r\n..............*677............593.460.51..571.................136..758.................422........+.........................................\r\n...........265.......974....../...........=..............142..................82......+.........$......591*...........$......&..............\r\n....542........44.......*297.......................=.......*.......516.......$.................113.........198.......792..244......391......\r\n......&...$........737*.............743......741.64.....688........*...........647.986..+588..................................=......&..129.\r\n...........4...........14..............$.397*................896..832...810*.........*.............656...........996..........618.......*...\r\n.......765..................887....8..................226.......%...........149......884.678..........*...358....*................915....956\r\n........*...................*...../....514.............*................995......429.......@../969...434...*......955....../..210*..........\r\n.....672....@......@.......322.........*........404#...784.............../..#884....*......................506..........984..........708....\r\n..........757..712.195...............188.....................895...................326...501.480..&524..........998./..........996.....*....\r\n..972.160...............857..293..............274....-...-...........807...%............*....................+...*...128..313.........478...\r\n...*..*...804............*...........334..110*.......974.459...........*....801........727.595..778.........699..800.........*..............\r\n.934..798.%...............37.....191.............*............@.......75...........486......*.................................323...........\r\n................................*......387....477.200......360.......................*....962...47................................179.......\r\n.....................884........985...................................67..145*.......292................191..323...213..............*.......\r\n.....................$....860.............700.147..................$..&.......334........282..267...........*.........-.93..867........525..\r\n..............492.......&...*....91.......%...*....779.......-691.93.......@.........710.*....*...=...310..........97.....*./..........*....\r\n..........568*.......708...216..............780......*....................312........*....438.....346....$..$327...=......5........756..855.\r\n.......................................261......807.261.............................42......................................................";
    private static readonly string testInput = "467..114..\r\n...*......\r\n..35..633.\r\n......#...\r\n617*......\r\n.....+.58.\r\n..592.....\r\n......755.\r\n...$.*....\r\n.664.598..";
    private static List<string> lines;

    internal static int RunDay3Pt1()
    {
        int total = 0;

        Dictionary<Point, int> partNums = [];

        lines = [..testInput.Split("\r\n")];

        //iterate through each line
        for (int lineIndex = 0; lineIndex < lines.Count; lineIndex++)
        {
            //iterate through each char in the line
            for (int charIndex = 0; charIndex < lines[lineIndex].Length; charIndex++)
            {
                char charToCheck = lines[lineIndex][charIndex];

                if ((charToCheck) == '.')
                    continue;

                Point charLoc = new(lineIndex, charIndex);

                if (char.IsSymbol(charToCheck))
                {                    
                    CheckForMatch(charLoc);
                }
            }
        }

        return total;
    }

    private static void CheckForMatch(Point charLoc)
    {
        //check top
        if (char.IsDigit(lines[charLoc.Y][charLoc.X]))
        {
            //check backwards
            for (int charIndex = charLoc.X-1; charIndex == 0; charIndex--)
            {
                if (char.IsDigit(lines[charLoc.Y][charIndex]) == false)
                {
                    //we know we have found the start
                }

            }

        }


        //check top right


        //check right


        // check bottom right


        //check bottom


        //check bottom left


        //check left


        //check top left
    }

    private static void AddPartToList(Point loc, int partNum)
    {

    }
}