using System;

namespace Kiosk
{
    class Program
    {
        static void Main(string[] args)
        {
            const string mainMenuChoice = "1";
            const string purchaseMenuChoice = "2";
            const string maintenanceMenuChoice = "3";
            const string kioskResultsChoice = "4";
            const string purchaseItemChoice = "5";
            const string detailedBillChoice = "6";
            const string addKioskItemChoice = "7";
            const string addKioskRawMatl = "8";
            const string clearKioskChoice = "9";
            const string updateKioskRawMatlQty = "10";
            const string quitApplication = "999";

            int inventoryItemCount = 0;
            int rawMaterialCount = 0;
            int itemPurchaseCount = 0;
            double totalPurchaseCost = 0;

            string itemName1 = string.Empty;
            double itemCost1 = 0;
            string itemName2 = string.Empty;
            double itemCost2 = 0;
            string itemName3 = string.Empty;
            double itemCost3 = 0;
            string itemName4 = string.Empty;
            double itemCost4 = 0;
            string itemName5 = string.Empty;
            double itemCost5 = 0;

            string colorName1 = string.Empty;
            int itemQuantity1 = 0;
            string colorName2 = string.Empty;
            int itemQuantity2 = 0;
            string colorName3 = string.Empty;
            int itemQuantity3 = 0;

            string itemNamePurch1 = string.Empty;
            double itemCostPurch1 = 0;
            int itemQuantityPurch1 = 0;
            string itemColorPurch1 = string.Empty;

            string itemNamePurch2 = string.Empty;
            double itemCostPurch2 = 0;
            int itemQuantityPurch2 = 0;
            string itemColorPurch2 = string.Empty;

            string itemNamePurch3 = string.Empty;
            double itemCostPurch3 = 0;
            int itemQuantityPurch3 = 0;
            string itemColorPurch3 = string.Empty;

            string itemNamePurch4 = string.Empty;
            double itemCostPurch4 = 0;
            int itemQuantityPurch4 = 0;
            string itemColorPurch4 = string.Empty;

            string itemNamePurch5 = string.Empty;
            double itemCostPurch5 = 0;
            int itemQuantityPurch5 = 0;
            string itemColorPurch5 = string.Empty;

            string menuChoice = mainMenuChoice;
            while (menuChoice != quitApplication)
            {
                Console.Clear();
                if (menuChoice == mainMenuChoice)
                {
                    Console.WriteLine("MAIN MENU");
                    Console.WriteLine("==========");
                    Console.WriteLine("1. Purchase");
                    Console.WriteLine("2. Maintenance");
                    Console.WriteLine("3. Kiosk Results");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "1") menuChoice = purchaseMenuChoice;
                    else if (choice == "2") menuChoice = maintenanceMenuChoice;
                    else if (choice == "3") menuChoice = quitApplication;
                    else if (choice == "Q" || choice == "q") menuChoice = quitApplication;
                }
                else if (menuChoice == purchaseMenuChoice)
                {
                    Console.WriteLine("PURCHASE");
                    Console.WriteLine("==========");
                    Console.WriteLine("1. Purchase Item");
                    Console.WriteLine("2. Detailed Bill");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "1") menuChoice = purchaseItemChoice;
                    else if (choice == "2") menuChoice = detailedBillChoice;
                    else if (choice == "3") menuChoice = quitApplication;
                    else if (choice == "Q" || choice == "q") menuChoice = mainMenuChoice;
                }
                else if (menuChoice == purchaseItemChoice)
                {
                    Console.WriteLine("PURCHASE ITEM");
                    Console.WriteLine("==========");
                    if (inventoryItemCount > 0) Console.WriteLine($"1. {itemName1}");
                    if (inventoryItemCount > 1) Console.WriteLine($"2. {itemName2}");
                    if (inventoryItemCount > 2) Console.WriteLine($"3. {itemName3}");
                    if (inventoryItemCount > 3) Console.WriteLine($"4. {itemName4}");
                    if (inventoryItemCount > 4) Console.WriteLine($"5. {itemName5}");


                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "Q" || choice == "q") menuChoice = purchaseMenuChoice;
                    else
                    {
                        Console.Write("How many would you like?");
                        var count = Console.ReadLine();
                        Console.WriteLine("Pick a color: ");
                        if (rawMaterialCount > 0) Console.WriteLine($"1. {colorName1}");
                        if (rawMaterialCount > 1) Console.WriteLine($"2. {colorName2}");
                        if (rawMaterialCount > 2) Console.WriteLine($"3. {colorName3}");
                        var colorItem = Console.ReadLine();
                        int countNum = 0;
                        if(!int.TryParse(count,out countNum))
                        {
                            Console.WriteLine("You must enter a number for the count.");
                            menuChoice = purchaseItemChoice;
                        }
                        else
                        {
                            itemPurchaseCount++;
                            var purchItemName = string.Empty;
                            var purchItemCost = 0.0;
                            var purchItemCount = 0;
                            var purchItemColor = string.Empty;
                            if (colorItem == "1") purchItemColor = colorName1;
                            if (colorItem == "2") purchItemColor = colorName2;
                            if (colorItem == "3") purchItemColor = colorName3;

                            if (choice == "1")
                            {
                                purchItemName = itemName1;
                                purchItemCost = itemCost1;
                                purchItemCount = countNum;
                            }
                            if (choice == "2")
                            {
                                purchItemName = itemName2;
                                purchItemCost = itemCost2;
                                purchItemCount = countNum;
                            }
                            if (choice == "3")
                            {
                                purchItemName = itemName3;
                                purchItemCost = itemCost3;
                                purchItemCount = countNum;
                            }
                            if (choice == "4")
                            {
                                purchItemName = itemName4;
                                purchItemCost = itemCost4;
                                purchItemCount = countNum;
                            }
                            if (choice == "5")
                            {
                                purchItemName = itemName5;
                                purchItemCost = itemCost5;
                                purchItemCount = countNum;
                            }
                            totalPurchaseCost += purchItemCost * purchItemCount;
                            if(itemPurchaseCount==1)
                            {
                                itemNamePurch1 = purchItemName;
                                itemColorPurch1 = purchItemColor;
                                itemCostPurch1 = purchItemCost;
                                itemQuantityPurch1 = purchItemCount;
                            }
                            if (itemPurchaseCount == 2)
                            {
                                itemNamePurch2 = purchItemName;
                                itemColorPurch2 = purchItemColor;
                                itemCostPurch2 = purchItemCost;
                                itemQuantityPurch2 = purchItemCount;
                            }
                            if (itemPurchaseCount == 3)
                            {
                                itemNamePurch3 = purchItemName;
                                itemColorPurch3 = purchItemColor;
                                itemCostPurch3 = purchItemCost;
                                itemQuantityPurch3 = purchItemCount;
                            }
                            if (itemPurchaseCount == 4)
                            {
                                itemNamePurch4 = purchItemName;
                                itemColorPurch4 = purchItemColor;
                                itemCostPurch4 = purchItemCost;
                                itemQuantityPurch4 = purchItemCount;
                            }
                            if (itemPurchaseCount == 5)
                            {
                                itemNamePurch5 = purchItemName;
                                itemColorPurch5 = purchItemColor;
                                itemCostPurch5 = purchItemCost;
                                itemQuantityPurch5 = purchItemCount;
                            }
                        }
                    }

                }
                else if (menuChoice == detailedBillChoice)
                {
                    Console.WriteLine("DETAILED BILL");
                    Console.WriteLine("==========");
                    if (itemPurchaseCount >= 1) Console.WriteLine($"{itemNamePurch1} - {itemColorPurch1} - {itemQuantityPurch1} - ${itemCost1}");
                    if (itemPurchaseCount >= 2) Console.WriteLine($"{itemNamePurch2} - {itemColorPurch2} - {itemQuantityPurch2} - ${itemCost2}");
                    if (itemPurchaseCount >= 3) Console.WriteLine($"{itemNamePurch3} - {itemColorPurch3} - {itemQuantityPurch3} - ${itemCost3}");
                    if (itemPurchaseCount >= 4) Console.WriteLine($"{itemNamePurch4} - {itemColorPurch4} - {itemQuantityPurch4} - ${itemCost4}");
                    if (itemPurchaseCount >= 5) Console.WriteLine($"{itemNamePurch5} - {itemColorPurch5} - {itemQuantityPurch5} - ${itemCost5}");
                    Console.WriteLine($"Total: ${totalPurchaseCost}");
                    Console.ReadLine();
                    totalPurchaseCost = 0.0;
                    itemPurchaseCount = 0;
                    menuChoice = purchaseItemChoice;
                }
                else if (menuChoice == maintenanceMenuChoice)
                {
                    Console.WriteLine("MAINTENANCE");
                    Console.WriteLine("============");
                    Console.WriteLine($"1. Add item to kiosk ({inventoryItemCount})");
                    Console.WriteLine($"2. Add raw material to kiosk ({rawMaterialCount})");
                    Console.WriteLine("3. Clear kiosk");
                    Console.WriteLine("4. Update raw material quantity");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "1") menuChoice = addKioskItemChoice;
                    else if (choice == "2") menuChoice = addKioskRawMatl;
                    else if (choice == "3") menuChoice = clearKioskChoice;
                    else if (choice == "4") menuChoice = updateKioskRawMatlQty;
                    else if (choice == "Q" || choice == "q") menuChoice = mainMenuChoice;
                }
                else if (menuChoice == addKioskItemChoice)
                {
                    Console.WriteLine("ADD KIOSK ITEM");
                    Console.WriteLine("==========");

                    if (inventoryItemCount >= 5)
                    {
                        Console.WriteLine("Inventory count exceeded.");
                        menuChoice = maintenanceMenuChoice;
                    }
                    else
                    {
                        Console.Write("Enter item name: ");
                        var itemName = Console.ReadLine();
                        Console.Write("Enter item cost: ");
                        var cost = Console.ReadLine();
                        double costNumeric = 0;
                        if (!double.TryParse(cost, out costNumeric))
                        {
                            Console.WriteLine("Cost must be a number.");
                            menuChoice = maintenanceMenuChoice;
                        }
                        else
                        {
                            inventoryItemCount++;
                            if (inventoryItemCount == 1)
                            {
                                itemName1 = itemName;
                                itemCost1 = costNumeric;
                            }
                            else if (inventoryItemCount == 2)
                            {
                                itemName2 = itemName;
                                itemCost2 = costNumeric;
                            }
                            else if (inventoryItemCount == 3)
                            {
                                itemName3 = itemName;
                                itemCost3 = costNumeric;
                            }
                            else if (inventoryItemCount == 4)
                            {
                                itemName4 = itemName;
                                itemCost4 = costNumeric;
                            }
                            else if (inventoryItemCount == 5)
                            {
                                itemName5 = itemName;
                                itemCost5 = costNumeric;
                            }
                            menuChoice = maintenanceMenuChoice;
                        }
                    }
                }

                else if (menuChoice == addKioskRawMatl)
                {
                    Console.WriteLine("ADD RAW MATERIAL");
                    Console.WriteLine("==========");
                    if (rawMaterialCount >= 3)
                    {
                        Console.WriteLine("Raw material count exceeded.");
                        menuChoice = maintenanceMenuChoice;
                    }
                    else
                    {
                        Console.Write("Enter color: ");
                        var colorName = Console.ReadLine();
                        Console.Write("Enter quantity: ");
                        var quantity = Console.ReadLine();
                        int qtyNumeric = 0;
                        if (!int.TryParse(quantity, out qtyNumeric))
                        {
                            Console.WriteLine("Quantity must be a number.");
                            menuChoice = maintenanceMenuChoice;
                        }
                        else
                        {
                            rawMaterialCount++;
                            if (rawMaterialCount == 1)
                            {
                                colorName1 = colorName;
                                itemQuantity1 = qtyNumeric;
                            }
                            else if (rawMaterialCount == 2)
                            {
                                colorName2 = colorName;
                                itemQuantity2 = qtyNumeric;
                            }
                            else if (rawMaterialCount == 3)
                            {
                                colorName3 = colorName;
                                itemQuantity3 = qtyNumeric;
                            }
                            menuChoice = maintenanceMenuChoice;
                        }
                    }
                }


                else if (menuChoice == clearKioskChoice)
                {
                    Console.WriteLine("CLEAR KIOSK");
                    Console.WriteLine("==========");
                    Console.Write("Are you sure? This will clear all kiosk data.");
                    var choice = Console.ReadLine();
                    if (choice == "Y" || choice == "y")
                    {
                        inventoryItemCount = 0;
                        rawMaterialCount = 0;
                    }
                    menuChoice = maintenanceMenuChoice;
                }
                else if (menuChoice == updateKioskRawMatlQty)
                {
                    Console.WriteLine("UPDATE RAW MATERIALS");
                    Console.WriteLine("==========");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "Q" || choice == "q") menuChoice = maintenanceMenuChoice;
                }
            }
        }
    }
}
      

