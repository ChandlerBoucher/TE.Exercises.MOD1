using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch? 
            */

            int birds = 4;
            int flownAway = 1;
            int birdsOnBranch;
            birdsOnBranch = birds - flownAway;

            /* 
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests? 
            */

            int familyBirds = 6;
            int nests = 3;
            int extraBirds = familyBirds - nests;

            /* 
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods? 
            */

            int playfulRaccoons = 3;
            int hungryRaccoons = 2;
            int raccoonsInWoods = playfulRaccoons - hungryRaccoons;

            /* 
            4. There are 5 flowers and 3 bees. How many less bees than flowers? 
            */

            int flowers = 5;
            int bees = 3;
            int beesInNeed = flowers - bees;

            /* 
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now? 
            */

            int firstPigeon = 1;
            int hungryPigeon = 1;
            int pigeonsDinnerParty = firstPigeon + hungryPigeon;

            /* 
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now? 
            */

            int originalQwls = 3;
            int joinerOwls = 2;
            int totalOwls = originalQwls + joinerOwls;

            /* 
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home? 
            */

            int beaverFamily = 2;
            int swimmingBeavers = 1;
            int beaversAtHome = beaverFamily - swimmingBeavers;

            /* 
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all? 
            */

            int firstToucans = 2;
            int newcanToucan = 1;
            int toucansOnTree = firstToucans + newcanToucan;

            /* 
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts? 
            */

            int squirrels = 4;
            int nuts = 2;
            int squirrelsWithoutNuts = squirrels - nuts;

            /* 
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find? 
            */

            double quarterFound = 1 * 0.25;
            double dimeFound = 1 * 0.10;
            double nickelsFound = 2 * 0.05;
            double moneyHiltFound = quarterFound + dimeFound + nickelsFound;

            /* 
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all? 
            */

            int briersMuffins = 18;
            int macAdamsMuffins = 20;
            int flanneryMuffins = 17;
            int allClassMuffins = briersMuffins + macAdamsMuffins + flanneryMuffins;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */

            double yoyoPrice = 0.24;
            double whistlePrice = 0.14;
            double totalSpent = yoyoPrice + whistlePrice;

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */

            int largeMarshMallows = 8;
            int miniMarshMallows = 10;
            int totalMarshMallows = largeMarshMallows + miniMarshMallows;

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */

            int hiltsSnow = 29;
            int schoolSnow = 17;
            int hiltsExtraSnow = hiltsSnow - schoolSnow;

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */

            int mHiltsCash = 10;
            int toyTruckCost = 3;
            int pencilCaseCost = 2;
            int HiltsRemainingMoney = mHiltsCash - toyTruckCost - pencilCaseCost;

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */

            int JoshsMarbles = 16;
            int JoshsMissingMarbles = 7;
            int JoshsRemainingMarbles = JoshsMarbles - JoshsMissingMarbles;

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */

            int seaShellsWanted = 25;
            int currentSeaShells = 19;
            int seaShellsNeeded = seaShellsWanted - currentSeaShells;

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */

            int allBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = allBalloons - redBalloons;

            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */

            int startingBooks = 38;
            int bookMartaAdds = 10;
            int totalBooks = startingBooks + bookMartaAdds;

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */

            int kneesPerBee = 6;
            int totalBees = 8;
            int theBeesKnees = kneesPerBee * totalBees;

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */

            int iceCreamConesPurchased = 2;
            double iceCreamCost = 0.99;
            double totalIceCreamExpense = iceCreamCost * iceCreamConesPurchased;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */

            int rocksRequired = 125;
            int rocksOwned = 64;
            int rocksRemaining = rocksRequired - rocksOwned;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */

            int hiltsMarbles = 38;
            int missingMarbles = 15;
            int marblesHiltHas = hiltsMarbles - missingMarbles;

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */

            int milesToConcert = 78;
            int milesTravelled = 32;
            int milesToGo = milesToConcert - milesTravelled;

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */

            int morningMinutesShovelling = 90;
            int afternoonMinutesShovelling = 45;
            int totalShovellingMinutes = morningMinutesShovelling + afternoonMinutesShovelling;

            /*    
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */

            int hiltHotDogs = 6;
            double hotDogCost = 0.50;
            double whatHiltPaid = hiltHotDogs * hotDogCost;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */

            int hiltsCents = 50;
            int pencilCost = 7;
            int howMuchCanSheGet = hiltsCents / pencilCost;

            /*    
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */

            int allButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = allButterflies - orangeButterflies;

            /*    
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */

            double katesCash = 1.00;
            double candyCost = 0.54;
            double katesChange = katesCash - candyCost;


            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */

            int marksTrees = 13;
            int plantedTrees = 12;
            int totalTrees = marksTrees + plantedTrees;

            /*    
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */

            int daysUntilVisit = 2;
            int hoursInDay = 24;
            int hoursUntilVisit = daysUntilVisit * hoursInDay;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */

            int kimsCousins = 4;
            int gumWantedToGive = 5;
            int gumNeeded = kimsCousins * gumWantedToGive;

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */

            double danDollars = 3.00;
            double candyBarCost = 1.00;
            double dansChange = danDollars - candyBarCost;

            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */

            int boatsInLake = 5;
            int peopleInBoat = 3;
            int peopleInLake = boatsInLake * peopleInBoat;

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */

            int startingLegos = 380;
            int legosLost = 57;
            int legosLeft = startingLegos - legosLost;

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */

            int arthursMuffins = 35;
            int muffinsNeeded = 83;
            int muffinsToBake = muffinsNeeded - arthursMuffins;

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */

            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int marginOfCrayons = willyCrayons - lucyCrayons;

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */

            int stickerPages = 22;
            int stickersPrPage = 10;
            int stickersTotal = stickerPages * stickersPrPage;

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */

            int cupcake4Kids = 96;
            int numOfKids = 8;
            int sharedKidCakes = cupcake4Kids / numOfKids;

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */

            int gingerCookies = 47;
            int jarCapacity = 6;
            int cookiesLeft = gingerCookies % jarCapacity;

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */

            int croissantTotal = 59;
            int neighborTotal = 8;
            int leftoverCroissants = croissantTotal % neighborTotal;

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */

            int trayCapacity = 12;
            int concurrentCookieReq = 276;
            int traysRequired = concurrentCookieReq / trayCapacity;

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */

            int servingSize = 12;
            int pretzelsMade = 480;
            int numOfServing = pretzelsMade / servingSize;

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */

            int cupcakeTotal = 53;
            int cupcakeLeftBehind = 2;
            int cupcakePerBox = 3;
            int boxesGiven = (cupcakeTotal - cupcakeLeftBehind) / cupcakePerBox;

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */

            int carrotSticks = 74;
            int equalServing = 12;
            int leftoverCarrots = carrotSticks % equalServing;

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */

            int teddyTotal = 98;
            int shelfCapacity = 7;
            int shelvesUsed = teddyTotal / shelfCapacity;

            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */

            int pictureTotal = 480;
            int albumCapacity = 20;
            int albumsNeeded = pictureTotal / albumCapacity;

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */

            int tradeCardTotal = 94;
            int boxCapacity = 8;
            int unfilledBoxContent = tradeCardTotal % boxCapacity;

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */

            int availableShelves = 10;
            int bookTotal = 21;
            int bookSpread = bookTotal / availableShelves;

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */

            int cristinaCroissants = 17;
            int cristinaGuests = 7;
            int dividedCroissants = cristinaCroissants / cristinaGuests;

        }
    }
}
