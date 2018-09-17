using System;

namespace hero_melvyn_r
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEBUT

            // Variable
            int choix = 0;

            Console.WriteLine("Vous vous reveillez avec une irrésistible envie de manger un met asiatique. Si irrésistible que vous vous rendez en quelques minutes a l'aéroport. Vous avez deux idées en tête. De bon sushi fraichement fait par un Japonais ou un bon bibimbap tout droit de la Corée du sud.");
            Console.WriteLine();
            Console.WriteLine("Taper 1 pour aller au japon");
            Console.WriteLine("Taper 2 pour aller en corée du subway");

            choix = Convert.ToInt32(Console.ReadLine());

            if (choix == 1) // je suis au Japon 
            {
                Console.WriteLine("Vous prenez le premier avion en direction du Japon, l'eau a la bouche en pensant a vos merveilleux sushi :3 . Après plusieurs heures d'attente vous êtes enfin arrivé");
                Console.WriteLine();
                Console.WriteLine("Une fois sortie de l'aéroport, vous vous mettez a la rechecher d'un restaurant de sushi. Vous hésitez entre la ville de Tokyo ou Osaka");
                Console.WriteLine();
                Console.WriteLine("Taper 1 pour se rendre a Tokyo");
                Console.WriteLine("Taper 2 pour se rendre a Osaka");

                choix = Convert.ToInt32(Console.ReadLine());
                if (choix == 1) // je suis a tokyo
                {
                    Console.WriteLine("Vous prenez le taxi pour vous rendre à Tokyo. Une fois que arrivez, vous remarquez que plusieurs personnes vous regardent intensément.. Vous vous dites qu'ils doivent avoir remarquer que vous n'êtes pas du coin et vous entrez dans le sushi shop. Vous avez le choix entre le plat du jour ou la suprise du chef");
                    Console.WriteLine();
                    Console.WriteLine("Taper 1 pour le plat du jour");
                    Console.WriteLine("Taper 2 pour la surprise du chef");

                    choix = Convert.ToInt32(Console.ReadLine());
                    if (choix == 1) // choisir le plate du jour
                    {
                        Console.WriteLine("Vous avez choisi le plat du jour, le serveur avec votre plat et l'odeur suffit a vous faire bavez. Vous dévorez votre repas en quelques minutes. Vous avez le choix entre en rester la et repartir chez vs ou boire du sake, un achool typiquement japonais et ca se prononce saké");
                        Console.WriteLine();
                        Console.WriteLine("Taper 1 pour rentrer chez nous");
                        Console.WriteLine("Taper 2 pour boire du sake");

                        choix = Convert.ToInt32(Console.ReadLine());
                        if (choix == 1)// rentrer chez nous
                        {
                            Random al = new Random();
                            int chanceMourir = al.Next(1, 101);

                            if (chanceMourir < 20)
                            {
                                Console.WriteLine("L'avion que vous avez pris pour retourner chez vous c'est écrasé dans l'océan... aucun passagers n'a survécu...");
                                Console.WriteLine();
                                Console.WriteLine("GAME OVER");
                            }
                            Console.WriteLine("Vous avez choisi de rentrer chez vous le ventre plein et heureux comme un pape");
                            Console.WriteLine();
                            Console.WriteLine("THE END");
                            Console.WriteLine();

                        }
                        else // boir du sake
                        {
                            Console.WriteLine("Vous avez décidé de boire du sake. Quelques minutes apres avoir ingéré la boisson alcoolisée, vous sentez l'effet de l'alcool. Le premier sake frappe toujours plus et vous tombez sans connaissance... Vous vous reveillez en plein millieu de la jungle, confus et désemparer   ");
                            Console.WriteLine();
                            Console.WriteLine("THE END");
                            Console.WriteLine();
                        }

                    }
                    else // choisir la suprise du chef
                    {
                        Console.WriteLine("Vous avez choisi la surprise du chef, le chef s'installe devant vous et commence a cuisine directement sur votre table. Cela vous amuse, vous vous sentez immergé dans la culture culinaire du Japon. Pendant son spectacle gastronomique, le cuisinier échappe, sans le vouloir, un de ses couteaux en plein sur votre jambe droite. La lame s'enfonce dans profondément dans votre cuisse... Vous avez deux choix à faire se rendre a l'hopital le plus proche ou faire confiance au cuisinier pour recoudre votre blessure, car selon lui a deja recousu des blessures plus grave sans probleme. ");
                        Console.WriteLine();
                        Console.WriteLine("Taper 1 pour se rendre a l'hopital");
                        Console.WriteLine("Taper 2 faire confiance au cuisiner");
                        choix = Convert.ToInt32(Console.ReadLine());

                        if (choix == 1)// se rendre a l'hopital
                        {
                            Console.WriteLine("Vous vous rendez a l'hopital le plus proche en ambiance, vous souffrez mais vous savez que votre vie n'est pas en danger. Vous entrez dans le bloc opératoire et vous vous endormez sous les sedatifs... vous vous reveillez un peu endoulorie et reparter chez vous avec au moins une drôle histoire à raconter");
                            Console.WriteLine();
                            Console.WriteLine("THE END");

                        }
                        else// faire confiance au cuisiner
                        {
                            Console.WriteLine("Vous avez pris la decision de faire confiance au cuinier et bien c'est une mauvaise idée car vous repartez chez vous sans votre foie ! LOL");
                            Console.WriteLine();
                            Console.WriteLine("GAME OVER");
                        }



                    }

                }


                else //je suis a Osaka
                {
                    Console.WriteLine("Vous prenez le taxi pour vous rendre à Osaka. Une fois que arrivez, vous remarquez que plusieurs personnes vous regardent intensément.. Vous vous dites qu'ils doivent avoir remarquer que vous n'êtes pas du coin et vous entrez dans le sushi a volonté. Vous avez le choix entre les sushis a volonté ou un plateau de votre choix");
                    Console.WriteLine();
                    Console.WriteLine("Taper 1 pour le sushi a volonté");
                    Console.WriteLine("Taper 2 pour choisir un plateau");


                    choix = Convert.ToInt32(Console.ReadLine());
                    if (choix == 1) // Sushi a volonté
                    {
                        Console.WriteLine("Vous avez choisi le sushi a volonté, vous vous empressez devant le buffet et vous prenez tous les sushis qui passent la. Vous avez terminé de manger, votre ventre n'a jamais été aussi remplit de bonnes choses. Vous hésitez entre deux options pour digérer tout ca. Aller prendre un café dans un café a chats(un café ou les chats sont en liberté dans le café ou prendre une soupe miso dans le restaurant ou vous etes)");
                        Console.WriteLine();
                        Console.WriteLine("Taper 1 pour aller au café a chats");
                        Console.WriteLine("Taper 2 pour la soupe miso");
                        choix = Convert.ToInt32(Console.ReadLine());

                        if (choix == 1)// aller café chat 
                        {
                            Console.WriteLine("Vous vous rendez au café a chats. Vous prenez place dans le café et commencez a boire votre breuvage. Apres quelques minutes vous avez de la difficulté a respirer... Vous etes mort... vous etiez allergique au chat... WP  ");
                            Console.WriteLine();
                            Console.WriteLine("GAME OVER");
                            Console.WriteLine();

                        }
                        else // prendre une soupe miso
                        {
                            Console.WriteLine("Vous avez choisi de prendre la soupe miso, votre commande arrive. Vous goutez pour la premiere fois a une soupe miso et vous trouvez ca vraiment horrible. Vous decidez de retourner chez vous");
                            Console.WriteLine();
                            Console.WriteLine("THE END");
                            Console.WriteLine();
                        }
                    }
                    else // choisir le plateau 
                    {
                        Console.WriteLine("Vous avez choisi le plateau de sushi que vous avez prealablement choisi. Le repas arrive et vous le dévorer presque aussitot arrivé sur votre table. Une fois le repas terminé vous hesitez entre aller faire du kayak ou aller dans une parc a chien");
                        Console.WriteLine();
                        Console.WriteLine("Taper 1 pour aller faire du kayak ");
                        Console.WriteLine("Taper 2 pour aller au parc a chien");
                        choix = Convert.ToInt32(Console.ReadLine());

                        if (choix == 1)// taper 1 du choix plateau
                        {
                            Console.WriteLine("Vous partez en taxi au lac je plus proche pour faire du kayak. Une fois sur le lac, vous remarquez un oiseau en détresse dans l'eau. Vous vous pressez vers lui. En essayant de le sauvé, vous tombez a l'eau... vous vous faites aspiré sous l'eau. Et vous en n'etes jamais sortie. ");
                            Console.WriteLine();
                            Console.WriteLine("GAME OVER");
                            Console.WriteLine();

                        }
                        else // taper 2 du choix plateau
                        {
                            Console.WriteLine("Vous vous rendez en vélo au parc a chien le plus proche. Une fois sur les lieux, vous admirez les magnifique chiens. Soudainement, plusieurs chiens s'approche de vous... Vous sentez la bouffe quoi... ils vous sautent tous dessus. vous finissez mal, mais ca va allez.");
                            Console.WriteLine();
                            Console.WriteLine("");
                            Console.WriteLine();
                        }





                    }

                }
            }
            else // Je suis en corée 
            {
                Console.WriteLine("Vous prenez le premier avion en direction de la corée du sud, l'eau a la bouche en pensant a votre bon bibimbap. Après plusieurs heures d'attente vous êtes enfin arrivé");
                Console.WriteLine();
                Console.WriteLine("Une fois sortie de l'aéroport, vous vous mettez a la rechecher d'un restaurant coréen. Vous hésitez entre la ville, Séoul ou Pusan");
                Console.WriteLine();
                Console.WriteLine("Taper 1 pour la ville de Séoul");
                Console.WriteLine("Taper 2 Pour la ville de Pusan");
                choix = Convert.ToInt32(Console.ReadLine());




                if (choix == 1) // je suis a Séoul
                {
                    Console.WriteLine("Vous prenez le taxi pour vous rendre à Séoul. Une fois que arrivez, vous remarquez que plusieurs personnes vous regardent intensément.. Vous vous dites qu'ils doivent avoir remarquer que vous n'êtes pas du coin et vous entrez dans le restaurant. Vous avez le bibimbap au boeuf ou le bibimbap supride du chef");
                    Console.WriteLine();
                    Console.WriteLine("Taper 1 pour le bibimbap au boeuf");
                    Console.WriteLine("Taper 2 pour le bibimbap surprise du chef");

                    choix = Convert.ToInt32(Console.ReadLine());
                    if (choix == 1) // Choisi le bibimbap au boeuf
                    {
                        Console.WriteLine("Vous avez choisi le bibimbap au boeuf, le serveur avec votre plat et l'odeur suffit a vous faire bavez. Vous dévorez votre repas en quelques minutes. Vous avez le choix entre en rester la et repartir chez vs ou boire une boisson alcoolisée locale");
                        Console.WriteLine();
                        Console.WriteLine("Taper 1 pour rentrer chez nous");
                        Console.WriteLine("Taper 2 pour la boisson alcoolisée");

                        choix = Convert.ToInt32(Console.ReadLine());
                        if (choix == 1)// rentrer chez nous
                        {
                            Console.WriteLine("Vous avez choisi de rentrer chez vous le ventre plein et heureux comme un pape");
                            Console.WriteLine();
                            Console.WriteLine("THE END");
                            Console.WriteLine();

                        }
                        else // Boire la boisson alcoolisée
                        {
                            Console.WriteLine("Vous avez décidé de boire la boisson. Quelques minutes apres avoir ingéré l'alcool, vous sentez l'effet de l'alcool. Ca frappe fort quand vous n'etes pas habitué et vous tombez sans connaissance... Vous vous reveillez au sommet d'une montagne, confus et désemparé");
                            Console.WriteLine();
                            Console.WriteLine("THE END");
                            Console.WriteLine();
                        }

                    }
                    else // choisi le bibimbap suprise du chef
                    {
                        Console.WriteLine("Vous avez choisi la surprise du chef, le chef s'installe devant vous et commence a cuisine directement sur votre table. Cela vous amuse, vous vous sentez immergé dans la culture culinaire du coréen. Pendant son spectacle gastronomique, le cuisinier échappe, sans le vouloir, un de ses couteaux en plein sur votre bras droite. La lame s'enfonceprofondément dans votre bras... Vous avez deux choix à faire se rendre a l'hopital le plus proche ou faire confiance au cuisinier pour recoudre votre blessure, car selon lui a deja recousu des blessures plus grave sans probleme. ");
                        Console.WriteLine();
                        Console.WriteLine("Taper 1 pour se rendre a l'hopital");
                        Console.WriteLine("Taper 2 faire confiance au cuisiner");
                        choix = Convert.ToInt32(Console.ReadLine());

                        if (choix == 1)// se rendre a l'hopital
                        {
                            Console.WriteLine("Vous vous rendez a l'hopital le plus proche en ambiance, vous souffrez mais vous savez que votre vie n'est pas en danger. Vous entrez dans le bloc opératoire et vous vous endormez sous les sedatifs... vous vous reveillez un peu endoulorie et reparter chez vous avec au moins une drôle histoire à raconter");
                            Console.WriteLine();
                            Console.WriteLine("THE END");

                        }
                        else// faire confiance au cuisiner
                        {
                            Console.WriteLine("Vous avez pris la decision de faire confiance au cuinier, il vous donne un cédatif... vous vous endormez.. vous etes encore conscient, mais vous ne pouvez pas bouger ou memem parler. Des hommes s'approche de vous et vous les entendez parler et vous ne reconnaissez pas la langue dans la quel ils communiquent... vous vous reveillez dans une piece qui n'as aucunement l'air d'appartenir a des terriens...");
                            Console.WriteLine();
                            Console.WriteLine("GAME OVER");
                        }
                    }
                }
                else //je suis a Pusan
                {
                    Console.WriteLine("Vous prenez le taxi pour vous rendre à Pusan. Une fois que arrivez, vous remarquez que plusieurs personnes vous regardent intensément.. Vous vous dites qu'ils doivent avoir remarquer que vous n'êtes pas du coin et vous entrez dans le restaurant coréen. Vous avez le choix entre le buffet a volonté ou un plateau de votre choix");
                    Console.WriteLine();
                    Console.WriteLine("Taper 1 pour le buffet a volonté");
                    Console.WriteLine("Taper 2 pour choisir un plateau");


                    choix = Convert.ToInt32(Console.ReadLine());
                    if (choix == 1) // buffet a volonté
                    {
                        Console.WriteLine("Vous avez choisi le buffet a volonté, vous vous empressez devant le buffet et que personne d'autre que vous n'est dans le restaurent... vous trouvez ca étrange mais vous continuez a vous servir de la nourriture. Pendant le repas, vous remarquez par la fenetre des dixaines de personnes courir dans les rues. Vous arretez tout de suite de manger et sortez du reataurant. Vous comprenez qu'une guerre entre la corée du sud et la corée du nord a éclaté. Votre seul option et de vous battre pour votre survie! Deux option s'offre a vous. La premiere est de prendre une voiture et partir de la ville en écrasant tous les personnes sur votre chemin. La deuxieme option est de  vous aliez avec un groupe de militant civil et de prendre les armes");
                        Console.WriteLine();
                        Console.WriteLine("Taper 1 pour prendre la voiture");
                        Console.WriteLine("Taper 2 pour joindre le groupe de civil");
                        choix = Convert.ToInt32(Console.ReadLine());

                        if (choix == 1)//  Prendre la voiture
                        {
                            Console.WriteLine("Vous avez decidé de prendre la voiture et de partir de la ville. Vous prenez la voiture, vous commencez a rouler dans les rues et rapidement les gens mettent bouchées les rues.. vous essayez de passe de coter mais rien n'a faire.. vous prenez une grande respiration et vous appuyez sur la pédale d'acceleration. Vous ecrasez tous les gens sur votre passages. Enfin sorti de la ville, vous vous cachez dans une petit forêt et esperez que l'armé prendra le controle de la situation rapidement... ce qui est le cas, vous rentrez chez vous avec un petit tromatisme");
                            Console.WriteLine();
                            Console.WriteLine("THE END");
                            Console.WriteLine();

                        }
                        else // Joindre le groupe civil
                        {
                            Console.WriteLine("Vous decidez de rejoindre le groupe de civil, ils vous donnent une arme et vous partez tous pour la guerre.. Vous vous battez de toute vos forces. Vous etes l'un des seul groupes a avoir survie a cette guerre civil... Vous vous faites excorté jusqu'a chez vous en avion de chasse..");
                            Console.WriteLine();
                            Console.WriteLine("THE END");
                            Console.WriteLine();
                        }
                    }
                    else // choisi le plateau
                    {
                        Console.WriteLine("Vous avez choisi le plateau, vous avez pris le bibimbap et des rouleaux de printemps. Votre plateau arrive, vous commencez aussitot a le dévorer. Apres avoir manger, vous avez de choix. Aller prendre une marche pour digérer tout ca ou simplement rentrer chez vous");
                        Console.WriteLine();
                        Console.WriteLine("Taper 1 pour prendre une marche ");
                        Console.WriteLine("Taper 2 pour rentrer chez vous ");
                        choix = Convert.ToInt32(Console.ReadLine());

                        if (choix == 1)// prendre une marche 
                        {
                            Console.WriteLine("Vous avez decidez de prendre une marche pour digérer votre repas. Vous ne connaissez pas la région et decidez de vous rendre a l'endroit touristique le plus proche. Elle se trouve a 15 minutes de marche d'ou vous vous trouvez. Une fois arrivé sur le lieu, vous remarquez que l'endroit est désert.. vous regardez bien autours de vous, mais toujours aucun signe de vie.. Un peu paniqué, vous courez partout a la recherche de vie.. Vous courrez pendant plusieurs minutes et puis plusieurs heures sans aucune réponse.......");
                            Console.WriteLine();
                            Console.WriteLine("GAME OVER");
                            Console.WriteLine();

                        }
                        else // rentrer chez vous
                        {
                            Console.WriteLine("Vous rentrez chez vous avec le ventre remplit et le coeur remplit de joie");
                            Console.WriteLine();
                            Console.WriteLine("THE END");
                            Console.WriteLine();

                        }

                    }

                }
            }
            Console.ReadKey();
        }
    }
}
