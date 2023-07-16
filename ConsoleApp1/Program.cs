using System;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Bienvenue sur le generateur de faux dox fait par 1tsubasa");
            Console.WriteLine("Amusez vous bien a creer votre fake dox");
            Console.WriteLine("------------------------------------------------");
            string nomFichier = "monAutoDox.txt";
            StreamWriter writer = new StreamWriter(nomFichier);
            Console.Write("Quel est Votre Genre ? ");

            switch (Console.ReadLine())
            {
                case "H":
                    Random rnd = new Random();
                    string[] prenomG =
                    {
                        "David", "Laurent", "Jules", "Louka", "Loic", "Ryan", "Jaxon", "Arnaud", "Matéo", "Andrew", "Théo", "Zack", "Milan", "Hubert", "Jack", "Julian", "Nolan", "Nicolas", "Camille", "Élliot", "Dylan", "Xavier", "Tristan", "Louis", "Lillian", "Jayden", "James", "Antoine", "Ethan", "Gabriel", "Benjamin", "Olivier", "Samuel", "Matthew", "Victor", "Adam", "Arthur", "Alexis", "Charles", "Raphael", "Émile", "Félix", "Lucas", "Léo", "Édouard", "Jacob", "Charlie", "Nathan", "Logan", "Thomas", "William", "Liam", "Noah", "Luca"
                    };
                    string[] ageH =
                    {
                        "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"
                    };
                    string[] nomH =
                    {
                        "MARTIN",
                        "BERNARD",
"PETIT",
"THOMAS",
"MOREAU",
"DUBOIS",
"RICHARD",
"ROBERT",
"MICHEL",
"DURAND",
"SIMON",
"LAURENT",
"LEROY",
"LAMBERT",
"ROUX",
"LEFEBVRE",
"GIRARD",
"DAVID",
"BERTRAND",
"MOREL",
"FOURNIER",
"ROUSSEAU",
"BONNET",
"GARNIER",
"DUPONT",
"HENRY",
"VINCENT",
"LEFEVRE",
"MERCIER",
"BLANC",
"GUERIN",
"PERRIN",
"ANDRE",
"MATHIEU",
"MARCHAND",
"ROBIN",
"FRANCOIS",
"LEGRAND",
"CLEMENT",
"MASSON",
"CHEVALIER",
"MORIN",
"GAUTIER",
"GERARD",
"NICOLAS",
"BARBIER",
"FONTAINE",
"GIRAUD",
"ROUSSEL",
"NOEL",
"DENIS",
"FAURE",
"LEMAIRE",
"DUVAL",
"AUBERT",
"DUMONT",
"COLIN",
"RENARD",
"JOLY",
"DUFOUR",
"BRUNET",
"BLANCHARD",
"ROY",
"BOURGEOIS",
"ROGER",
"GAILLARD",
"BRUN",
"GAUTHIER",
"BOYER",
"LECLERC",
"ARNAUD",
"PICARD",
"MARIE",
"MEUNIER",
"FABRE",
"LUCAS",
"CARON",
"BAILLY",
"BOUCHER",
"CHARPENTIER"
                    };
                    string[] villeH = {
    "Paris", "Marseille", "Lyon", "Toulouse", "Nice", "Nantes", "Strasbourg", "Montpellier", "Bordeaux", "Lille",
    "Rennes", "Reims", "Le Havre", "Cergy-Pontoise", "Saint-Étienne", "Toulon", "Angers", "Grenoble", "Dijon",
    "Nîmes", "Aix-en-Provence", "Saint-Quentin-en-Yvelines", "Brest", "Le Mans", "Amiens", "Tours", "Limoges",
    "Clermont-Ferrand", "Villeurbanne", "Besançon", "Orléans", "Metz", "Rouen", "Mulhouse", "Perpignan", "Caen",
    "Boulogne-Billancourt", "Nancy", "Argenteuil", "Saint-Denis", "Roubaix", "Tourcoing", "Montreuil", "Avignon",
    "Asnières-sur-Seine", "Nanterre", "Poitiers", "Courbevoie", "Créteil", "Versailles", "Pau", "Colombes",
    "Vitry-sur-Seine", "Aulnay-sous-Bois", "Marseille 01", "Marseille 02", "Marseille 03", "Marseille 04",
    "Marseille 05", "Marseille 06", "Marseille 07", "Marseille 08", "Marseille 09", "Marseille 10", "Marseille 11",
    "Marseille 12", "Marseille 13", "Marseille 14", "Marseille 15", "Marseille 16"
};
                    int villeHindex = rnd.Next(villeH.Length);
                    int prenomHindex = rnd.Next(prenomG.Length);
                    int ageHinde = rnd.Next(ageH.Length);
                    int nomHinde = rnd.Next(nomH.Length);
                    Console.WriteLine("Prénom : {0}", prenomG[prenomHindex]);
                    Console.WriteLine("Nom : {0}", nomH[nomHinde]);
                    Console.WriteLine("Âge: {0}", ageH[ageHinde]);
                    Console.WriteLine("Ville : " + villeH[villeHindex]);
                    writer.WriteLine("                                                   ^-cZW$qqb                            ^-cZW$qqbe                                     ");
                    writer.WriteLine("                                                 '1m#hb*^WWkmX+                       !xuvzczXzzvxf?'                          ");
                    writer.WriteLine("                                               :Y#B$B@$$@$@@%bJ1.                    v8B%@B@$@@@@@@Bo_                         ");
                    writer.WriteLine("                                            . .C@@@@a-    i)zZu~..                 ;aBBBB8p];!+|Lh@B@@Y^                       ");
                    writer.WriteLine("                                              XBB$%[        .lfU@BBt`             'h%B$$c.        <q%B@m.                      ");
                    writer.WriteLine("                                             `b8@w`            1m@BBv^           .C@BBMI.           {o@$b                    ");
                    writer.WriteLine("                                           +_J%B8I.            .raZj0J.          (8@Bb^              !k@Bn                   ");
                    writer.WriteLine("                                          ^kWBB@U               <q*kdWi        .^w%@&_               .~W%m,                 ");
                    writer.WriteLine("                                          ~8@B@@r               .Y#*M@t       z {8B$p`                 UBw>I               ");
                    writer.WriteLine("                                          }%BB$%t               .1WM&Bu       v'UBB@j                  }B8M#'         ");
                    writer.WriteLine("                                          }B@@@81                [8W#@/       W`v8%B(.                 [$%Ba.        ");
                    writer.WriteLine("                                          [BB@@$f                f%%&%;       $`vWB@t                  tB$@U        ");
                    writer.WriteLine("                                          :oB$B@c               `b@&@p       \"zUh8B@x                  0B@B/      ");
                    writer.WriteLine("                                          'U%B@$w;.             (%@&8i        J*oB%@0.                >#@@#\"    ");
                    writer.WriteLine("                                           {%B@%ML;            |&%B%U         ~*8&8Bo\"               ,h@@B[   ");
                    writer.WriteLine("                                           ^q@@@%oLi.        `JBBBBh?          c@@@8@n              ;w8@@)    ");
                    writer.WriteLine("                                            >oB@%BBac-!;`.`?Q8$B@@8x           `0BB%B%c.        .-]tkBBBJ                  i/v ");
                    writer.WriteLine("                               .             \"hBB$@@@BB@@@BB%&BB@W(             '0BBBBBh[..   ,1m8$%$&BC          '\"     ^L%@q.");
                    writer.WriteLine("                          .:  \"n`              fh@@%B@@@$$@B$B@@M[                 f8BB@@@8WM#8@B%8B@h:          .uWl   <oB@J. ");
                    writer.WriteLine("                           kw: r(               .-UW%B$$@$$@@@&~                     ~Q8B$@B$$@@W%Wz`            .C@?.,C8@BM!  ");
                    writer.WriteLine("                           .|MZLh'                 .?Ub*%@@@M1                          `!tUd#%kj\"               I*@ob@@01Bz   ");
                    writer.WriteLine("                             :w8Bx                  `vpkW&az^                            '1v]            ^.      ;M@@@M_\"8#'   ");
                    writer.WriteLine("                               1MBz                  .>-~,                                              'k#\"    ;0%B@a+'bBj.   ");
                    writer.WriteLine("                               _#@BL^                                                                   'k@n.'tM8&@$%I U@b     ");
                    writer.WriteLine("                              u%aWBput),                l/.                                          'b@%&B%8w0&@B'(@B-     ");
                    writer.WriteLine("                                 ^bMfv&$@@0`            ,]wu                               ..           ]&@B@M/` [8B&-&@c      ");
                    writer.WriteLine("                                  {%k\" O@B@%Q].         0B0                               ]Ww'       lUM%@B@8^   i&B$B@d       ");
                    writer.WriteLine("                                   Y@r +&88B@@8Z|^     j%B<                l1'            Y%B\"    v8B%@%h@B@B).  ,&@B@O.       ");
                    writer.WriteLine("                                   `bW>.QWB| \"tk@$%Z1+U%@@-               \"b%)           .qB@bfLMB@$#c\" \"a@8$b   !8@$p`        ");
                    writer.WriteLine("                                    ,o&^Y&Bn    `[Co8BB@@@o>              v%@d. .      ']mB@BB@BMu;     ^hBp%@+  ~8BBY         ");
                    writer.WriteLine("                                    .>W8Z#%O       .U@W@@B@%@B%&wvur(?+->U%$BBppko&%B@$B@@@@@@@Y        loBnJ@b 'mBBBv         ");
                    writer.WriteLine("                                      <*$B@o       |88/ ^O@ak##W@$@@B@B@@B@@@@@@@8&aLx]+I0B@&&8B]       IMBrI$@Yh%@@@Z         ");
                    writer.WriteLine("                                       ^b%B8\"     f8BY   }8| .   .    ,f%@B8%B%r ..      Z%&@8&%B<      }B@x L$B$Ua@@q         ");
                    writer.WriteLine("                                        'J%@L    t&@U.   ,MC           X8@MM%@B0        !M@QdBBB@#'     ?@@{l@@$z aB@o'        ");
                    writer.WriteLine("                                         .d@%w^ 1&Bf     \"*#          !&@a'(&@%B-       1&Bi.Q%@@Bk     [@8b@B@@8;wB@@I        ");
                    writer.WriteLine("                                          fBBB@&@&]       08i        .m@&,  L@B@b      .mBM'  O@BBBY    (@B@@Q.0BuUBB@I        ");
                    writer.WriteLine("                                          lo@&8$@)        n@|        U%@(   ;#$B@v     :a@Q   IaB@B@?   L@Bh!  <&Mp$@@i        ");
                    writer.WriteLine("                                          .bBB@@B@C       nBp       n8$v     tB@BW^    [%@c    !MBB@*_n#B$u     C%&BBBl        ");
                    writer.WriteLine("                                           |%$q  Iq@&|.   <W#'     (8@d.      QB@@U    r%B~     {8B@@@@@B@t     \"a@&@B:        ");
                    writer.WriteLine("                                           u8@c    .)*%a? <&@+.   ;M@B~       i*B@%\"   m@M'      m%@$@pn$$)      +WB@h'       ");
                    writer.WriteLine("                                          <Qr{{'      \"CBBB@Bj   .Z@$t         |%@@U. ;*$U    >Z%@@BB@Qt@8l       1W@d.        ");
                    writer.WriteLine("                                                         }p%@Bdv_O8$U           C%@BI 18@v\"/o&$&v:,hB$8p@#'        }WZ.       ");
                    writer.WriteLine("                                                          .1%$B$B@$8Y[^         ,#$@hjm%@%B#L-     ;kBB@@#.         ]         ");
                    writer.WriteLine("                                                           ^*$vQ@$W*%@B@@B%8&MooWBB@BB@@o>          `dBBBb                   ");
                    writer.WriteLine("                                                            XB@B@c    .I~/xvZbbmQZ*B@BBBr            .ZB%t                  ");
                    writer.WriteLine("                                                            [8B@n                  z%B@%l             ^;.                  ");
                    writer.WriteLine("                                                            .Ub/                    Y%$*'                                  ");
                    writer.WriteLine("                                                                                    ^k$k                                   ");
                    writer.WriteLine("                                                                                    IW%B-                                 ");
                    writer.WriteLine("                                                                                     '\" .   ");




                    writer.WriteLine("                                                ╔─────────────────────────────────────╗");
                    writer.WriteLine("                                                @ 0X10 | Personal Information........ @");
                    writer.WriteLine("                                                @ 0x20 | Outro....................... @");
                    writer.WriteLine("                                                ╚─────────────────────────────────────╝");


                    writer.WriteLine("╠───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────╣");
                    writer.WriteLine("   ✗ 0x10 ➢ Personal Information");
                    writer.WriteLine("    ───────────────────────────────");
                    writer.WriteLine("      ✗ Alias");
                    writer.WriteLine("      ──────────");
                    writer.WriteLine("      ✗ Basic Information");
                    writer.WriteLine("      ──────────");
                    writer.WriteLine("    Prenom ➢ " + prenomG[prenomHindex]);
                    writer.WriteLine("    Nom ➢ " + nomH[nomHinde]);
                    writer.WriteLine("    Äge ➢ " + ageH[ageHinde]);
                    writer.WriteLine("    Ville ➢ " + villeH[villeHindex]);
                    writer.WriteLine("    Sexe ➢ " + "Homme");
                    break;
                case "F":
                    Random rdn = new Random();
                    string[] prenomF =
                    {
                        "Alisea", "Amaryllis", "Annabella", "Argi", "Aurélia", "Aela", "Alisea", "Amaryllis", "Annabella", "Argia", "Auréliane", "Aela", "Alisea", "Amaryllis", "Annabella", "Argi", "Aurélia", "Aela", "Alisea", "Amaryllis", "Annabella", "Argia", "Auréliane", "Aela", "Alisea", "Amaryllis", "Annabella", "Argi", "Aurélia", "Aela", "Alisea", "Amaryllis", "Annabella", "Argia", "Auréliane", "Aela", "Alisea", "Amaryllis", "Annabella", "Argi", "Aurélia", "Aela", "Alisea", "Amaryllis", "Annabella", "Argia", "Auréliane", "Aela", "Alisea", "Amaryllis", "Annabella", "Emma", "Olivia", "Alice", "Léa", "Sophia", "Mia", "Amélia", "Florence", "Charlotte", "Zoé", "Émily", "Élizabeth", "Simone", "Sofia", "Livia", "Béatrice", "Flavie", "Victoria", "Rosalie", "Romy", "Chloé", "Camila", "Pénélope", "Clara", "Juliette", "Rose", "Jeanne", "Mila", "Aubrey", "Hannah", "Lily", "Jade", "Camille", "Adèle", "Maéva", "Léonie", "Laurence", "Raphaëlle", "Isabella", "Stella", "Sarah", "Annabelle", "Julia", "Audrey", "Ophélie", "Élodie", "Éléonore", "Maélie" ,"Camille"
                    };
                    string[] ageF =
    {
                       "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"
                    };
                    string[] nomF =
                    {
                        "MARTIN",
                        "BERNARD",
"PETIT",
"THOMAS",
"MOREAU",
"DUBOIS",
"RICHARD",
"ROBERT",
"MICHEL",
"DURAND",
"SIMON",
"LAURENT",
"LEROY",
"LAMBERT",
"ROUX",
"LEFEBVRE",
"GIRARD",
"DAVID",
"BERTRAND",
"MOREL",
"FOURNIER",
"ROUSSEAU",
"BONNET",
"GARNIER",
"DUPONT",
"HENRY",
"VINCENT",
"LEFEVRE",
"MERCIER",
"BLANC",
"GUERIN",
"PERRIN",
"ANDRE",
"MATHIEU",
"MARCHAND",
"ROBIN",
"FRANCOIS",
"LEGRAND",
"CLEMENT",
"MASSON",
"CHEVALIER",
"MORIN",
"GAUTIER",
"GERARD",
"NICOLAS",
"BARBIER",
"FONTAINE",
"GIRAUD",
"ROUSSEL",
"NOEL",
"DENIS",
"FAURE",
"LEMAIRE",
"DUVAL",
"AUBERT",
"DUMONT",
"COLIN",
"RENARD",
"JOLY",
"DUFOUR",
"BRUNET",
"BLANCHARD",
"ROY",
"BOURGEOIS",
"ROGER",
"GAILLARD",
"BRUN",
"GAUTHIER",
"BOYER",
"LECLERC",
"ARNAUD",
"PICARD",
"MARIE",
"MEUNIER",
"FABRE",
"LUCAS",
"CARON",
"BAILLY",
"BOUCHER",
"CHARPENTIER"
                    };
                    string[] villeF = {
    "Paris", "Marseille", "Lyon", "Toulouse", "Nice", "Nantes", "Strasbourg", "Montpellier", "Bordeaux", "Lille",
    "Rennes", "Reims", "Le Havre", "Cergy-Pontoise", "Saint-Étienne", "Toulon", "Angers", "Grenoble", "Dijon",
    "Nîmes", "Aix-en-Provence", "Saint-Quentin-en-Yvelines", "Brest", "Le Mans", "Amiens", "Tours", "Limoges",
    "Clermont-Ferrand", "Villeurbanne", "Besançon", "Orléans", "Metz", "Rouen", "Mulhouse", "Perpignan", "Caen",
    "Boulogne-Billancourt", "Nancy", "Argenteuil", "Saint-Denis", "Roubaix", "Tourcoing", "Montreuil", "Avignon",
    "Asnières-sur-Seine", "Nanterre", "Poitiers", "Courbevoie", "Créteil", "Versailles", "Pau", "Colombes",
    "Vitry-sur-Seine", "Aulnay-sous-Bois", "Marseille 01", "Marseille 02", "Marseille 03", "Marseille 04",
    "Marseille 05", "Marseille 06", "Marseille 07", "Marseille 08", "Marseille 09", "Marseille 10", "Marseille 11",
    "Marseille 12", "Marseille 13", "Marseille 14", "Marseille 15", "Marseille 16"
};
                    int villeFindex = rdn.Next(villeF.Length);
                    int prenomFindex = rdn.Next(prenomF.Length);
                    int ageFinde = rdn.Next(ageF.Length);
                    int nomFinde = rdn.Next(nomF.Length);
                    Console.WriteLine("Prénom : {0}", prenomF[prenomFindex]);
                    Console.WriteLine("Nom : {0}", nomF[nomFinde]);
                    Console.WriteLine("Âge: {0}", ageF[ageFinde]);
                    Console.WriteLine("Ville : " + villeF[villeFindex]);
                    writer.WriteLine("                                                   ^-cZW$qqb                            ^-cZW$qqbe                                     ");
                    writer.WriteLine("                                                 '1m#hb*^WWkmX+                       !xuvzczXzzvxf?'                          ");
                    writer.WriteLine("                                               :Y#B$B@$$@$@@%bJ1.                    v8B%@B@$@@@@@@Bo_                         ");
                    writer.WriteLine("                                            . .C@@@@a-    i)zZu~..                 ;aBBBB8p];!+|Lh@B@@Y^                       ");
                    writer.WriteLine("                                              XBB$%[        .lfU@BBt`             'h%B$$c.        <q%B@m.                      ");
                    writer.WriteLine("                                             `b8@w`            1m@BBv^           .C@BBMI.           {o@$b                    ");
                    writer.WriteLine("                                           +_J%B8I.            .raZj0J.          (8@Bb^              !k@Bn                   ");
                    writer.WriteLine("                                          ^kWBB@U               <q*kdWi        .^w%@&_               .~W%m,                 ");
                    writer.WriteLine("                                          ~8@B@@r               .Y#*M@t       z {8B$p`                 UBw>I               ");
                    writer.WriteLine("                                          }%BB$%t               .1WM&Bu       v'UBB@j                  }B8M#'         ");
                    writer.WriteLine("                                          }B@@@81                [8W#@/       W`v8%B(.                 [$%Ba.        ");
                    writer.WriteLine("                                          [BB@@$f                f%%&%;       $`vWB@t                  tB$@U        ");
                    writer.WriteLine("                                          :oB$B@c               `b@&@p       \"zUh8B@x                  0B@B/      ");
                    writer.WriteLine("                                          'U%B@$w;.             (%@&8i        J*oB%@0.                >#@@#\"    ");
                    writer.WriteLine("                                           {%B@%ML;            |&%B%U         ~*8&8Bo\"               ,h@@B[   ");
                    writer.WriteLine("                                           ^q@@@%oLi.        `JBBBBh?          c@@@8@n              ;w8@@)    ");
                    writer.WriteLine("                                            >oB@%BBac-!;`.`?Q8$B@@8x           `0BB%B%c.        .-]tkBBBJ                  i/v ");
                    writer.WriteLine("                               .             \"hBB$@@@BB@@@BB%&BB@W(             '0BBBBBh[..   ,1m8$%$&BC          '\"     ^L%@q.");
                    writer.WriteLine("                          .:  \"n`              fh@@%B@@@$$@B$B@@M[                 f8BB@@@8WM#8@B%8B@h:          .uWl   <oB@J. ");
                    writer.WriteLine("                           kw: r(               .-UW%B$$@$$@@@&~                     ~Q8B$@B$$@@W%Wz`            .C@?.,C8@BM!  ");
                    writer.WriteLine("                           .|MZLh'                 .?Ub*%@@@M1                          `!tUd#%kj\"               I*@ob@@01Bz   ");
                    writer.WriteLine("                             :w8Bx                  `vpkW&az^                            '1v]            ^.      ;M@@@M_\"8#'   ");
                    writer.WriteLine("                               1MBz                  .>-~,                                              'k#\"    ;0%B@a+'bBj.   ");
                    writer.WriteLine("                               _#@BL^                                                                   'k@n.'tM8&@$%I U@b     ");
                    writer.WriteLine("                              u%aWBput),                l/.                                          'b@%&B%8w0&@B'(@B-     ");
                    writer.WriteLine("                                 ^bMfv&$@@0`            ,]wu                               ..           ]&@B@M/` [8B&-&@c      ");
                    writer.WriteLine("                                  {%k\" O@B@%Q].         0B0                               ]Ww'       lUM%@B@8^   i&B$B@d       ");
                    writer.WriteLine("                                   Y@r +&88B@@8Z|^     j%B<                l1'            Y%B\"    v8B%@%h@B@B).  ,&@B@O.       ");
                    writer.WriteLine("                                   `bW>.QWB| \"tk@$%Z1+U%@@-               \"b%)           .qB@bfLMB@$#c\" \"a@8$b   !8@$p`        ");
                    writer.WriteLine("                                    ,o&^Y&Bn    `[Co8BB@@@o>              v%@d. .      ']mB@BB@BMu;     ^hBp%@+  ~8BBY         ");
                    writer.WriteLine("                                    .>W8Z#%O       .U@W@@B@%@B%&wvur(?+->U%$BBppko&%B@$B@@@@@@@Y        loBnJ@b 'mBBBv         ");
                    writer.WriteLine("                                      <*$B@o       |88/ ^O@ak##W@$@@B@B@@B@@@@@@@8&aLx]+I0B@&&8B]       IMBrI$@Yh%@@@Z         ");
                    writer.WriteLine("                                       ^b%B8\"     f8BY   }8| .   .    ,f%@B8%B%r ..      Z%&@8&%B<      }B@x L$B$Ua@@q         ");
                    writer.WriteLine("                                        'J%@L    t&@U.   ,MC           X8@MM%@B0        !M@QdBBB@#'     ?@@{l@@$z aB@o'        ");
                    writer.WriteLine("                                         .d@%w^ 1&Bf     \"*#          !&@a'(&@%B-       1&Bi.Q%@@Bk     [@8b@B@@8;wB@@I        ");
                    writer.WriteLine("                                          fBBB@&@&]       08i        .m@&,  L@B@b      .mBM'  O@BBBY    (@B@@Q.0BuUBB@I        ");
                    writer.WriteLine("                                          lo@&8$@)        n@|        U%@(   ;#$B@v     :a@Q   IaB@B@?   L@Bh!  <&Mp$@@i        ");
                    writer.WriteLine("                                          .bBB@@B@C       nBp       n8$v     tB@BW^    [%@c    !MBB@*_n#B$u     C%&BBBl        ");
                    writer.WriteLine("                                           |%$q  Iq@&|.   <W#'     (8@d.      QB@@U    r%B~     {8B@@@@@B@t     \"a@&@B:        ");
                    writer.WriteLine("                                           u8@c    .)*%a? <&@+.   ;M@B~       i*B@%\"   m@M'      m%@$@pn$$)      +WB@h'       ");
                    writer.WriteLine("                                          <Qr{{'      \"CBBB@Bj   .Z@$t         |%@@U. ;*$U    >Z%@@BB@Qt@8l       1W@d.        ");
                    writer.WriteLine("                                                         }p%@Bdv_O8$U           C%@BI 18@v\"/o&$&v:,hB$8p@#'        }WZ.       ");
                    writer.WriteLine("                                                          .1%$B$B@$8Y[^         ,#$@hjm%@%B#L-     ;kBB@@#.         ]         ");
                    writer.WriteLine("                                                           ^*$vQ@$W*%@B@@B%8&MooWBB@BB@@o>          `dBBBb                   ");
                    writer.WriteLine("                                                            XB@B@c    .I~/xvZbbmQZ*B@BBBr            .ZB%t                  ");
                    writer.WriteLine("                                                            [8B@n                  z%B@%l             ^;.                  ");
                    writer.WriteLine("                                                            .Ub/                    Y%$*'                                  ");
                    writer.WriteLine("                                                                                    ^k$k                                   ");
                    writer.WriteLine("                                                                                    IW%B-                                 ");
                    writer.WriteLine("                                                                                     '\" .   ");




                    writer.WriteLine("                                                ╔─────────────────────────────────────╗");
                    writer.WriteLine("                                                @ 0X10 | Personal Information........ @");
                    writer.WriteLine("                                                @ 0x20 | Outro....................... @");
                    writer.WriteLine("                                                ╚─────────────────────────────────────╝");


                    writer.WriteLine("╠───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────╣");
                    writer.WriteLine("   ✗ 0x10 ➢ Personal Information");
                    writer.WriteLine("    ───────────────────────────────");
                    writer.WriteLine("      ✗ Alias");
                    writer.WriteLine("      ──────────");
                    writer.WriteLine("      ✗ Basic Information");
                    writer.WriteLine("      ──────────");
                    writer.WriteLine("    Prenom ➢ " + prenomF[prenomFindex]);
                    writer.WriteLine("    Nom ➢ " + nomF[nomFinde]);
                    writer.WriteLine("    Äge ➢ " + ageF[ageFinde]);
                    writer.WriteLine("    Ville ➢ " + villeF[villeFindex]);
                    writer.WriteLine("    Sexe ➢ " + "Femme");
                    break;
                case "f":
                    Random rdnn = new Random();
                    string[] prenomf =
                    {
                        "Alisea", "Amaryllis", "Annabella", "Argi", "Aurélia", "Aela", "Alisea", "Amaryllis", "Annabella", "Argia", "Auréliane", "Aela", "Alisea", "Amaryllis", "Annabella", "Argi", "Aurélia", "Aela", "Alisea", "Amaryllis", "Annabella", "Argia", "Auréliane", "Aela", "Alisea", "Amaryllis", "Annabella", "Argi", "Aurélia", "Aela", "Alisea", "Amaryllis", "Annabella", "Argia", "Auréliane", "Aela", "Alisea", "Amaryllis", "Annabella", "Argi", "Aurélia", "Aela", "Alisea", "Amaryllis", "Annabella", "Argia", "Auréliane", "Aela", "Alisea", "Amaryllis", "Annabella", "Emma", "Olivia", "Alice", "Léa", "Sophia", "Mia", "Amélia", "Florence", "Charlotte", "Zoé", "Émily", "Élizabeth", "Simone", "Sofia", "Livia", "Béatrice", "Flavie", "Victoria", "Rosalie", "Romy", "Chloé", "Camila", "Pénélope", "Clara", "Juliette", "Rose", "Jeanne", "Mila", "Aubrey", "Hannah", "Lily", "Jade", "Camille", "Adèle", "Maéva", "Léonie", "Laurence", "Raphaëlle", "Isabella", "Stella", "Sarah", "Annabelle", "Julia", "Audrey", "Ophélie", "Élodie", "Éléonore", "Maélie" ,"Camille"
                    };
                    string[] agef =
    {
                       "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"
                    };
                    string[] nomf =
                    {
                        "MARTIN",
                        "BERNARD",
"PETIT",
"THOMAS",
"MOREAU",
"DUBOIS",
"RICHARD",
"ROBERT",
"MICHEL",
"DURAND",
"SIMON",
"LAURENT",
"LEROY",
"LAMBERT",
"ROUX",
"LEFEBVRE",
"GIRARD",
"DAVID",
"BERTRAND",
"MOREL",
"FOURNIER",
"ROUSSEAU",
"BONNET",
"GARNIER",
"DUPONT",
"HENRY",
"VINCENT",
"LEFEVRE",
"MERCIER",
"BLANC",
"GUERIN",
"PERRIN",
"ANDRE",
"MATHIEU",
"MARCHAND",
"ROBIN",
"FRANCOIS",
"LEGRAND",
"CLEMENT",
"MASSON",
"CHEVALIER",
"MORIN",
"GAUTIER",
"GERARD",
"NICOLAS",
"BARBIER",
"FONTAINE",
"GIRAUD",
"ROUSSEL",
"NOEL",
"DENIS",
"FAURE",
"LEMAIRE",
"DUVAL",
"AUBERT",
"DUMONT",
"COLIN",
"RENARD",
"JOLY",
"DUFOUR",
"BRUNET",
"BLANCHARD",
"ROY",
"BOURGEOIS",
"ROGER",
"GAILLARD",
"BRUN",
"GAUTHIER",
"BOYER",
"LECLERC",
"ARNAUD",
"PICARD",
"MARIE",
"MEUNIER",
"FABRE",
"LUCAS",
"CARON",
"BAILLY",
"BOUCHER",
"CHARPENTIER"
                    };
                    string[] villef = {
    "Paris", "Marseille", "Lyon", "Toulouse", "Nice", "Nantes", "Strasbourg", "Montpellier", "Bordeaux", "Lille",
    "Rennes", "Reims", "Le Havre", "Cergy-Pontoise", "Saint-Étienne", "Toulon", "Angers", "Grenoble", "Dijon",
    "Nîmes", "Aix-en-Provence", "Saint-Quentin-en-Yvelines", "Brest", "Le Mans", "Amiens", "Tours", "Limoges",
    "Clermont-Ferrand", "Villeurbanne", "Besançon", "Orléans", "Metz", "Rouen", "Mulhouse", "Perpignan", "Caen",
    "Boulogne-Billancourt", "Nancy", "Argenteuil", "Saint-Denis", "Roubaix", "Tourcoing", "Montreuil", "Avignon",
    "Asnières-sur-Seine", "Nanterre", "Poitiers", "Courbevoie", "Créteil", "Versailles", "Pau", "Colombes",
    "Vitry-sur-Seine", "Aulnay-sous-Bois", "Marseille 01", "Marseille 02", "Marseille 03", "Marseille 04",
    "Marseille 05", "Marseille 06", "Marseille 07", "Marseille 08", "Marseille 09", "Marseille 10", "Marseille 11",
    "Marseille 12", "Marseille 13", "Marseille 14", "Marseille 15", "Marseille 16"
};
                    int villefindex = rdnn.Next(villef.Length);
                    int prenomfindex = rdnn.Next(prenomf.Length);
                    int agefinde = rdnn.Next(agef.Length);
                    int nomfinde = rdnn.Next(nomf.Length);
                    Console.WriteLine("Prénom : {0}", prenomf[prenomfindex]);
                    Console.WriteLine("Nom : {0}", nomf[nomfinde]);
                    Console.WriteLine("Âge: {0}", agef[agefinde]);
                    Console.WriteLine("Ville : " + villef[villefindex]);
                    writer.WriteLine("                                                   ^-cZW$qqb                            ^-cZW$qqbe                                     ");
                    writer.WriteLine("                                                 '1m#hb*^WWkmX+                       !xuvzczXzzvxf?'                          ");
                    writer.WriteLine("                                               :Y#B$B@$$@$@@%bJ1.                    v8B%@B@$@@@@@@Bo_                         ");
                    writer.WriteLine("                                            . .C@@@@a-    i)zZu~..                 ;aBBBB8p];!+|Lh@B@@Y^                       ");
                    writer.WriteLine("                                              XBB$%[        .lfU@BBt`             'h%B$$c.        <q%B@m.                      ");
                    writer.WriteLine("                                             `b8@w`            1m@BBv^           .C@BBMI.           {o@$b                    ");
                    writer.WriteLine("                                           +_J%B8I.            .raZj0J.          (8@Bb^              !k@Bn                   ");
                    writer.WriteLine("                                          ^kWBB@U               <q*kdWi        .^w%@&_               .~W%m,                 ");
                    writer.WriteLine("                                          ~8@B@@r               .Y#*M@t       z {8B$p`                 UBw>I               ");
                    writer.WriteLine("                                          }%BB$%t               .1WM&Bu       v'UBB@j                  }B8M#'         ");
                    writer.WriteLine("                                          }B@@@81                [8W#@/       W`v8%B(.                 [$%Ba.        ");
                    writer.WriteLine("                                          [BB@@$f                f%%&%;       $`vWB@t                  tB$@U        ");
                    writer.WriteLine("                                          :oB$B@c               `b@&@p       \"zUh8B@x                  0B@B/      ");
                    writer.WriteLine("                                          'U%B@$w;.             (%@&8i        J*oB%@0.                >#@@#\"    ");
                    writer.WriteLine("                                           {%B@%ML;            |&%B%U         ~*8&8Bo\"               ,h@@B[   ");
                    writer.WriteLine("                                           ^q@@@%oLi.        `JBBBBh?          c@@@8@n              ;w8@@)    ");
                    writer.WriteLine("                                            >oB@%BBac-!;`.`?Q8$B@@8x           `0BB%B%c.        .-]tkBBBJ                  i/v ");
                    writer.WriteLine("                               .             \"hBB$@@@BB@@@BB%&BB@W(             '0BBBBBh[..   ,1m8$%$&BC          '\"     ^L%@q.");
                    writer.WriteLine("                          .:  \"n`              fh@@%B@@@$$@B$B@@M[                 f8BB@@@8WM#8@B%8B@h:          .uWl   <oB@J. ");
                    writer.WriteLine("                           kw: r(               .-UW%B$$@$$@@@&~                     ~Q8B$@B$$@@W%Wz`            .C@?.,C8@BM!  ");
                    writer.WriteLine("                           .|MZLh'                 .?Ub*%@@@M1                          `!tUd#%kj\"               I*@ob@@01Bz   ");
                    writer.WriteLine("                             :w8Bx                  `vpkW&az^                            '1v]            ^.      ;M@@@M_\"8#'   ");
                    writer.WriteLine("                               1MBz                  .>-~,                                              'k#\"    ;0%B@a+'bBj.   ");
                    writer.WriteLine("                               _#@BL^                                                                   'k@n.'tM8&@$%I U@b     ");
                    writer.WriteLine("                              u%aWBput),                l/.                                          'b@%&B%8w0&@B'(@B-     ");
                    writer.WriteLine("                                 ^bMfv&$@@0`            ,]wu                               ..           ]&@B@M/` [8B&-&@c      ");
                    writer.WriteLine("                                  {%k\" O@B@%Q].         0B0                               ]Ww'       lUM%@B@8^   i&B$B@d       ");
                    writer.WriteLine("                                   Y@r +&88B@@8Z|^     j%B<                l1'            Y%B\"    v8B%@%h@B@B).  ,&@B@O.       ");
                    writer.WriteLine("                                   `bW>.QWB| \"tk@$%Z1+U%@@-               \"b%)           .qB@bfLMB@$#c\" \"a@8$b   !8@$p`        ");
                    writer.WriteLine("                                    ,o&^Y&Bn    `[Co8BB@@@o>              v%@d. .      ']mB@BB@BMu;     ^hBp%@+  ~8BBY         ");
                    writer.WriteLine("                                    .>W8Z#%O       .U@W@@B@%@B%&wvur(?+->U%$BBppko&%B@$B@@@@@@@Y        loBnJ@b 'mBBBv         ");
                    writer.WriteLine("                                      <*$B@o       |88/ ^O@ak##W@$@@B@B@@B@@@@@@@8&aLx]+I0B@&&8B]       IMBrI$@Yh%@@@Z         ");
                    writer.WriteLine("                                       ^b%B8\"     f8BY   }8| .   .    ,f%@B8%B%r ..      Z%&@8&%B<      }B@x L$B$Ua@@q         ");
                    writer.WriteLine("                                        'J%@L    t&@U.   ,MC           X8@MM%@B0        !M@QdBBB@#'     ?@@{l@@$z aB@o'        ");
                    writer.WriteLine("                                         .d@%w^ 1&Bf     \"*#          !&@a'(&@%B-       1&Bi.Q%@@Bk     [@8b@B@@8;wB@@I        ");
                    writer.WriteLine("                                          fBBB@&@&]       08i        .m@&,  L@B@b      .mBM'  O@BBBY    (@B@@Q.0BuUBB@I        ");
                    writer.WriteLine("                                          lo@&8$@)        n@|        U%@(   ;#$B@v     :a@Q   IaB@B@?   L@Bh!  <&Mp$@@i        ");
                    writer.WriteLine("                                          .bBB@@B@C       nBp       n8$v     tB@BW^    [%@c    !MBB@*_n#B$u     C%&BBBl        ");
                    writer.WriteLine("                                           |%$q  Iq@&|.   <W#'     (8@d.      QB@@U    r%B~     {8B@@@@@B@t     \"a@&@B:        ");
                    writer.WriteLine("                                           u8@c    .)*%a? <&@+.   ;M@B~       i*B@%\"   m@M'      m%@$@pn$$)      +WB@h'       ");
                    writer.WriteLine("                                          <Qr{{'      \"CBBB@Bj   .Z@$t         |%@@U. ;*$U    >Z%@@BB@Qt@8l       1W@d.        ");
                    writer.WriteLine("                                                         }p%@Bdv_O8$U           C%@BI 18@v\"/o&$&v:,hB$8p@#'        }WZ.       ");
                    writer.WriteLine("                                                          .1%$B$B@$8Y[^         ,#$@hjm%@%B#L-     ;kBB@@#.         ]         ");
                    writer.WriteLine("                                                           ^*$vQ@$W*%@B@@B%8&MooWBB@BB@@o>          `dBBBb                   ");
                    writer.WriteLine("                                                            XB@B@c    .I~/xvZbbmQZ*B@BBBr            .ZB%t                  ");
                    writer.WriteLine("                                                            [8B@n                  z%B@%l             ^;.                  ");
                    writer.WriteLine("                                                            .Ub/                    Y%$*'                                  ");
                    writer.WriteLine("                                                                                    ^k$k                                   ");
                    writer.WriteLine("                                                                                    IW%B-                                 ");
                    writer.WriteLine("                                                                                     '\" .   ");




                    writer.WriteLine("                                                ╔─────────────────────────────────────╗");
                    writer.WriteLine("                                                @ 0X10 | Personal Information........ @");
                    writer.WriteLine("                                                @ 0x20 | Outro....................... @");
                    writer.WriteLine("                                                ╚─────────────────────────────────────╝");


                    writer.WriteLine("╠───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────╣");
                    writer.WriteLine("   ✗ 0x10 ➢ Personal Information");
                    writer.WriteLine("    ───────────────────────────────");
                    writer.WriteLine("      ✗ Alias");
                    writer.WriteLine("      ──────────");
                    writer.WriteLine("      ✗ Basic Information");
                    writer.WriteLine("      ──────────");
                    writer.WriteLine("    Prenom ➢ " + prenomf[prenomfindex]);
                    writer.WriteLine("    Nom ➢ " + nomf[nomfinde]);
                    writer.WriteLine("    Äge ➢ " + agef[agefinde]);
                    writer.WriteLine("    Ville ➢ " + villef[villefindex]);
                    writer.WriteLine("    Sexe ➢ " + "Femme");
                    break;
                case "h":
                    Random rnddd = new Random();
                    string[] prenomg =
                    {
                        "David", "Laurent", "Jules", "Louka", "Loic", "Ryan", "Jaxon", "Arnaud", "Matéo", "Andrew", "Théo", "Zack", "Milan", "Hubert", "Jack", "Julian", "Nolan", "Nicolas", "Camille", "Élliot", "Dylan", "Xavier", "Tristan", "Louis", "Lillian", "Jayden", "James", "Antoine", "Ethan", "Gabriel", "Benjamin", "Olivier", "Samuel", "Matthew", "Victor", "Adam", "Arthur", "Alexis", "Charles", "Raphael", "Émile", "Félix", "Lucas", "Léo", "Édouard", "Jacob", "Charlie", "Nathan", "Logan", "Thomas", "William", "Liam", "Noah", "Luca"
                    };
                    string[] ageh =
                    {
                        "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"
                    };
                    string[] nomh =
                    {
                        "MARTIN",
                        "BERNARD",
"PETIT",
"THOMAS",
"MOREAU",
"DUBOIS",
"RICHARD",
"ROBERT",
"MICHEL",
"DURAND",
"SIMON",
"LAURENT",
"LEROY",
"LAMBERT",
"ROUX",
"LEFEBVRE",
"GIRARD",
"DAVID",
"BERTRAND",
"MOREL",
"FOURNIER",
"ROUSSEAU",
"BONNET",
"GARNIER",
"DUPONT",
"HENRY",
"VINCENT",
"LEFEVRE",
"MERCIER",
"BLANC",
"GUERIN",
"PERRIN",
"ANDRE",
"MATHIEU",
"MARCHAND",
"ROBIN",
"FRANCOIS",
"LEGRAND",
"CLEMENT",
"MASSON",
"CHEVALIER",
"MORIN",
"GAUTIER",
"GERARD",
"NICOLAS",
"BARBIER",
"FONTAINE",
"GIRAUD",
"ROUSSEL",
"NOEL",
"DENIS",
"FAURE",
"LEMAIRE",
"DUVAL",
"AUBERT",
"DUMONT",
"COLIN",
"RENARD",
"JOLY",
"DUFOUR",
"BRUNET",
"BLANCHARD",
"ROY",
"BOURGEOIS",
"ROGER",
"GAILLARD",
"BRUN",
"GAUTHIER",
"BOYER",
"LECLERC",
"ARNAUD",
"PICARD",
"MARIE",
"MEUNIER",
"FABRE",
"LUCAS",
"CARON",
"BAILLY",
"BOUCHER",
"CHARPENTIER"
                    };
                    string[] villeh = {
    "Paris", "Marseille", "Lyon", "Toulouse", "Nice", "Nantes", "Strasbourg", "Montpellier", "Bordeaux", "Lille",
    "Rennes", "Reims", "Le Havre", "Cergy-Pontoise", "Saint-Étienne", "Toulon", "Angers", "Grenoble", "Dijon",
    "Nîmes", "Aix-en-Provence", "Saint-Quentin-en-Yvelines", "Brest", "Le Mans", "Amiens", "Tours", "Limoges",
    "Clermont-Ferrand", "Villeurbanne", "Besançon", "Orléans", "Metz", "Rouen", "Mulhouse", "Perpignan", "Caen",
    "Boulogne-Billancourt", "Nancy", "Argenteuil", "Saint-Denis", "Roubaix", "Tourcoing", "Montreuil", "Avignon",
    "Asnières-sur-Seine", "Nanterre", "Poitiers", "Courbevoie", "Créteil", "Versailles", "Pau", "Colombes",
    "Vitry-sur-Seine", "Aulnay-sous-Bois", "Marseille 01", "Marseille 02", "Marseille 03", "Marseille 04",
    "Marseille 05", "Marseille 06", "Marseille 07", "Marseille 08", "Marseille 09", "Marseille 10", "Marseille 11",
    "Marseille 12", "Marseille 13", "Marseille 14", "Marseille 15", "Marseille 16"
};
                    int villehindex = rnddd.Next(villeh.Length);
                    int prenomhindex = rnddd.Next(prenomg.Length);
                    int agehinde = rnddd.Next(ageh.Length);
                    int nomhinde = rnddd.Next(nomh.Length);
                    Console.WriteLine("Prénom : {0}", prenomg[prenomhindex]);
                    Console.WriteLine("Nom : {0}", nomh[nomhinde]);
                    Console.WriteLine("Âge: {0}", ageh[agehinde]);
                    Console.WriteLine("Ville : " + villeh[villehindex]);
                    writer.WriteLine("                                                   ^-cZW$qqb                            ^-cZW$qqbe                                     ");
                    writer.WriteLine("                                                 '1m#hb*^WWkmX+                       !xuvzczXzzvxf?'                          ");
                    writer.WriteLine("                                               :Y#B$B@$$@$@@%bJ1.                    v8B%@B@$@@@@@@Bo_                         ");
                    writer.WriteLine("                                            . .C@@@@a-    i)zZu~..                 ;aBBBB8p];!+|Lh@B@@Y^                       ");
                    writer.WriteLine("                                              XBB$%[        .lfU@BBt`             'h%B$$c.        <q%B@m.                      ");
                    writer.WriteLine("                                             `b8@w`            1m@BBv^           .C@BBMI.           {o@$b                    ");
                    writer.WriteLine("                                           +_J%B8I.            .raZj0J.          (8@Bb^              !k@Bn                   ");
                    writer.WriteLine("                                          ^kWBB@U               <q*kdWi        .^w%@&_               .~W%m,                 ");
                    writer.WriteLine("                                          ~8@B@@r               .Y#*M@t       z {8B$p`                 UBw>I               ");
                    writer.WriteLine("                                          }%BB$%t               .1WM&Bu       v'UBB@j                  }B8M#'         ");
                    writer.WriteLine("                                          }B@@@81                [8W#@/       W`v8%B(.                 [$%Ba.        ");
                    writer.WriteLine("                                          [BB@@$f                f%%&%;       $`vWB@t                  tB$@U        ");
                    writer.WriteLine("                                          :oB$B@c               `b@&@p       \"zUh8B@x                  0B@B/      ");
                    writer.WriteLine("                                          'U%B@$w;.             (%@&8i        J*oB%@0.                >#@@#\"    ");
                    writer.WriteLine("                                           {%B@%ML;            |&%B%U         ~*8&8Bo\"               ,h@@B[   ");
                    writer.WriteLine("                                           ^q@@@%oLi.        `JBBBBh?          c@@@8@n              ;w8@@)    ");
                    writer.WriteLine("                                            >oB@%BBac-!;`.`?Q8$B@@8x           `0BB%B%c.        .-]tkBBBJ                  i/v ");
                    writer.WriteLine("                               .             \"hBB$@@@BB@@@BB%&BB@W(             '0BBBBBh[..   ,1m8$%$&BC          '\"     ^L%@q.");
                    writer.WriteLine("                          .:  \"n`              fh@@%B@@@$$@B$B@@M[                 f8BB@@@8WM#8@B%8B@h:          .uWl   <oB@J. ");
                    writer.WriteLine("                           kw: r(               .-UW%B$$@$$@@@&~                     ~Q8B$@B$$@@W%Wz`            .C@?.,C8@BM!  ");
                    writer.WriteLine("                           .|MZLh'                 .?Ub*%@@@M1                          `!tUd#%kj\"               I*@ob@@01Bz   ");
                    writer.WriteLine("                             :w8Bx                  `vpkW&az^                            '1v]            ^.      ;M@@@M_\"8#'   ");
                    writer.WriteLine("                               1MBz                  .>-~,                                              'k#\"    ;0%B@a+'bBj.   ");
                    writer.WriteLine("                               _#@BL^                                                                   'k@n.'tM8&@$%I U@b     ");
                    writer.WriteLine("                              u%aWBput),                l/.                                          'b@%&B%8w0&@B'(@B-     ");
                    writer.WriteLine("                                 ^bMfv&$@@0`            ,]wu                               ..           ]&@B@M/` [8B&-&@c      ");
                    writer.WriteLine("                                  {%k\" O@B@%Q].         0B0                               ]Ww'       lUM%@B@8^   i&B$B@d       ");
                    writer.WriteLine("                                   Y@r +&88B@@8Z|^     j%B<                l1'            Y%B\"    v8B%@%h@B@B).  ,&@B@O.       ");
                    writer.WriteLine("                                   `bW>.QWB| \"tk@$%Z1+U%@@-               \"b%)           .qB@bfLMB@$#c\" \"a@8$b   !8@$p`        ");
                    writer.WriteLine("                                    ,o&^Y&Bn    `[Co8BB@@@o>              v%@d. .      ']mB@BB@BMu;     ^hBp%@+  ~8BBY         ");
                    writer.WriteLine("                                    .>W8Z#%O       .U@W@@B@%@B%&wvur(?+->U%$BBppko&%B@$B@@@@@@@Y        loBnJ@b 'mBBBv         ");
                    writer.WriteLine("                                      <*$B@o       |88/ ^O@ak##W@$@@B@B@@B@@@@@@@8&aLx]+I0B@&&8B]       IMBrI$@Yh%@@@Z         ");
                    writer.WriteLine("                                       ^b%B8\"     f8BY   }8| .   .    ,f%@B8%B%r ..      Z%&@8&%B<      }B@x L$B$Ua@@q         ");
                    writer.WriteLine("                                        'J%@L    t&@U.   ,MC           X8@MM%@B0        !M@QdBBB@#'     ?@@{l@@$z aB@o'        ");
                    writer.WriteLine("                                         .d@%w^ 1&Bf     \"*#          !&@a'(&@%B-       1&Bi.Q%@@Bk     [@8b@B@@8;wB@@I        ");
                    writer.WriteLine("                                          fBBB@&@&]       08i        .m@&,  L@B@b      .mBM'  O@BBBY    (@B@@Q.0BuUBB@I        ");
                    writer.WriteLine("                                          lo@&8$@)        n@|        U%@(   ;#$B@v     :a@Q   IaB@B@?   L@Bh!  <&Mp$@@i        ");
                    writer.WriteLine("                                          .bBB@@B@C       nBp       n8$v     tB@BW^    [%@c    !MBB@*_n#B$u     C%&BBBl        ");
                    writer.WriteLine("                                           |%$q  Iq@&|.   <W#'     (8@d.      QB@@U    r%B~     {8B@@@@@B@t     \"a@&@B:        ");
                    writer.WriteLine("                                           u8@c    .)*%a? <&@+.   ;M@B~       i*B@%\"   m@M'      m%@$@pn$$)      +WB@h'       ");
                    writer.WriteLine("                                          <Qr{{'      \"CBBB@Bj   .Z@$t         |%@@U. ;*$U    >Z%@@BB@Qt@8l       1W@d.        ");
                    writer.WriteLine("                                                         }p%@Bdv_O8$U           C%@BI 18@v\"/o&$&v:,hB$8p@#'        }WZ.       ");
                    writer.WriteLine("                                                          .1%$B$B@$8Y[^         ,#$@hjm%@%B#L-     ;kBB@@#.         ]         ");
                    writer.WriteLine("                                                           ^*$vQ@$W*%@B@@B%8&MooWBB@BB@@o>          `dBBBb                   ");
                    writer.WriteLine("                                                            XB@B@c    .I~/xvZbbmQZ*B@BBBr            .ZB%t                  ");
                    writer.WriteLine("                                                            [8B@n                  z%B@%l             ^;.                  ");
                    writer.WriteLine("                                                            .Ub/                    Y%$*'                                  ");
                    writer.WriteLine("                                                                                    ^k$k                                   ");
                    writer.WriteLine("                                                                                    IW%B-                                 ");
                    writer.WriteLine("                                                                                     '\" .   ");




                    writer.WriteLine("                                                ╔─────────────────────────────────────╗");
                    writer.WriteLine("                                                @ 0X10 | Personal Information........ @");
                    writer.WriteLine("                                                @ 0x20 | Outro....................... @");
                    writer.WriteLine("                                                ╚─────────────────────────────────────╝");


                    writer.WriteLine("╠───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────╣");
                    writer.WriteLine("   ✗ 0x10 ➢ Personal Information");
                    writer.WriteLine("    ───────────────────────────────");
                    writer.WriteLine("      ✗ Alias");
                    writer.WriteLine("      ──────────");
                    writer.WriteLine("      ✗ Basic Information");
                    writer.WriteLine("      ──────────");
                    writer.WriteLine("    Prenom ➢ " + prenomg[prenomhindex]);
                    writer.WriteLine("    Nom ➢ " + nomh[nomhinde]);
                    writer.WriteLine("    Äge ➢ " + ageh[agehinde]);
                    writer.WriteLine("    Ville ➢ " + villeh[villehindex]);
                    writer.WriteLine("    Sexe ➢ " + "Homme");
                    break;
            };
            
            Console.Write("Quel est votre pseudo?");
            string user = Console.ReadLine();
            Random ue = new Random();
            string[] email =
            {
                "gmail.com", "proton.me", "protonmail.com", "outlook.fr"
            };
            int mail = ue.Next(email.Length);
            string emailString = user + "@" + email[mail];
            Console.WriteLine("Email : {0}", emailString);
            Random tel = new Random();
            string codePays = "+33";

            string numtel = "";

            for (int i =  0; i < 9; i++)
            {
                int mobile = tel.Next(10);
                numtel += mobile.ToString();
            }

            string numEntier = codePays + numtel;
            Console.WriteLine("Numéro de téléphone : {0}", numEntier);
            writer.WriteLine("    Pseudo ➢ " + user);
            writer.WriteLine("    Email ➢ " + emailString);
            writer.WriteLine("    Num ➢ " + numEntier);
            writer.WriteLine("╠───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────╣");
            writer.WriteLine("    ✗ 0x20 -> Outro");
            writer.WriteLine("    Credits ➢ 1Tsubasa & Son Fake Dox Gen");
            writer.WriteLine("__________  __________  __________  __________  __________  __________  __________  __________  __________  __________  \r\n");
            writer.WriteLine("                                             ,---------,");
            writer.WriteLine("        ,-----------------------,          ,\"        ,\"|");
            writer.WriteLine("      ,\"                      ,\"|        ,\"        ,\"  |");
            writer.WriteLine("     +-----------------------+  |      ,\"        ,\"    |");
            writer.WriteLine("     |  .-----------------.  |  |     +---------+      |");
            writer.WriteLine("     |  |                 |  |  |     | -==----'|      |");
            writer.WriteLine("     |  |                 |  |  |     |         |      |  ");
            writer.WriteLine("     |  |  Bad command or |  |  |/----|`---=    |      |  ");
            writer.WriteLine("     |  |  C:\\>_          |  |  |   ,/|==== ooo |      ;");
            writer.WriteLine("     |  |                 |  |  |  // |(((( [33]|    ,\"");
            writer.WriteLine("     |  `-----------------'  |,\" .;'| |((((     |  ,\"");
            writer.WriteLine("     +-----------------------+  ;;  | |         |,\"  ");
            writer.WriteLine("        /_)______________(_/  //'   | +---------+");
            writer.WriteLine("   ___________________________/___  `,");
            writer.WriteLine("  /  oooooooooooooooo  .o.  oooo /,   \\,\"-----------");
            writer.WriteLine(" / ==ooooooooooooooo==.o.  ooo= //   ,`\\--{)B     ,\"");
            writer.WriteLine("/_==__==========__==_ooo__ooo=_/'   /___________,\"");
            writer.Close();

            Console.WriteLine("Ton Fake Auto Dox a été générer avec succès");

        }
    }
}