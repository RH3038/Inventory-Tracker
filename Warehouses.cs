/**
 * Raheem Hampton
 * ITCS 3112-051
 * 10/21/2020
 */

using System;
using System.IO;

namespace Assignment_2
{
    class Warehouses
    {
        static void Main(string[] args)
        {
            String endDay = "N";
            String makePurchase = "N";
            String makeSale = "N";
            String invNum = "";
            StreamWriter wFile = new StreamWriter("../../../Transactions.txt");
            StreamWriter wInv;

            Inventory Atlanta = new Inventory("Atlanta");
            Inventory Baltimore = new Inventory("Baltimore");
            Inventory Chicago = new Inventory("Chicago");
            Inventory Denver = new Inventory("Denver");
            Inventory Ely = new Inventory("Ely");
            Inventory Fargo = new Inventory("Fargo");

            Console.WriteLine(Atlanta.toStringInv());
            Console.WriteLine(Baltimore.toStringInv());
            Console.WriteLine(Chicago.toStringInv());
            Console.WriteLine(Denver.toStringInv());
            Console.WriteLine(Ely.toStringInv());
            Console.WriteLine(Fargo.toStringInv());

            Inventory[] warehouses = {Atlanta, Baltimore, Chicago, Denver, Ely, Fargo};

            while (endDay == "N")
            {
                Console.WriteLine("Hello! Welcome to the inventory system." + "\n");
                Console.WriteLine("Would you like to make a purchase? Y/N" + "\n");
                makePurchase = Console.ReadLine();
                Console.WriteLine("\n");


                if (makePurchase == "Y")
                {
                    int purchaseAmount;
                    int lowNum;
                    int lowIndex = 0;

                    Console.WriteLine("What item would you like to purchse?");
                    Console.WriteLine("Please Type: 102, 215, 410, 525, or 711");
                    invNum = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.WriteLine("Please type amount desired!");
                    purchaseAmount = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    if (invNum == "102")
                    {
                        lowNum = warehouses[0].getPartNum102();

                        for (int i = 0; i < 6; i++)
                        {
                            if (lowNum > warehouses[i].getPartNum102())
                            {
                                lowNum = warehouses[i].getPartNum102();
                                lowIndex = i;
                            }
                        }
                        warehouses[lowIndex].setPartNum102(purchaseAmount);
                        lowNum = warehouses[lowIndex].getPartNum102();
                        Console.WriteLine(warehouses[lowIndex].getName() + ": " + lowNum + " units");
                        Console.WriteLine("\n");
                        wFile.WriteLine("P, " + purchaseAmount + ", " + lowNum);
                    }
                    else if (invNum == "215")
                    {
                        lowNum = warehouses[0].getPartNum215();

                        for (int i = 0; i < 6; i++)
                        {
                            if (lowNum > warehouses[i].getPartNum215())
                            {
                                lowNum = warehouses[i].getPartNum215();
                                lowIndex = i;
                            }
                        }
                        warehouses[lowIndex].setPartNum215(purchaseAmount);
                        lowNum = warehouses[lowIndex].getPartNum215();
                        Console.WriteLine(warehouses[lowIndex].getName() + ": " + lowNum + " units");
                        Console.WriteLine("\n");
                        wFile.WriteLine("P, " + purchaseAmount + ", " + lowNum);
                    }
                    else if (invNum == "410")
                    {
                        lowNum = warehouses[0].getPartNum410();

                        for (int i = 0; i < 6; i++)
                        {
                            if (lowNum > warehouses[i].getPartNum410())
                            {
                                lowNum = warehouses[i].getPartNum410();
                                lowIndex = i;
                            }
                        }
                        warehouses[lowIndex].setPartNum410(purchaseAmount);
                        lowNum = warehouses[lowIndex].getPartNum410();
                        Console.WriteLine(warehouses[lowIndex].getName() + ": " + lowNum + " units");
                        Console.WriteLine("\n");
                        wFile.WriteLine("P, " + purchaseAmount + ", " + lowNum);
                    }
                    else if (invNum == "525")
                    {
                        lowNum = warehouses[0].getPartNum525();

                        for (int i = 0; i < 6; i++)
                        {
                            if (lowNum > warehouses[i].getPartNum525())
                            {
                                lowNum = warehouses[i].getPartNum525();
                                lowIndex = i;
                            }
                        }
                        warehouses[lowIndex].setPartNum525(purchaseAmount);
                        lowNum = warehouses[lowIndex].getPartNum525();
                        Console.WriteLine(warehouses[lowIndex].getName() + ": " + lowNum + " units");
                        Console.WriteLine("\n");
                        wFile.WriteLine("P, " + purchaseAmount + ", " + lowNum);
                    }
                    else
                    {
                        lowNum = warehouses[0].getPartNum711();

                        for (int i = 0; i < 6; i++)
                        {
                            if (lowNum > warehouses[i].getPartNum711())
                            {
                                lowNum = warehouses[i].getPartNum711();
                                lowIndex = i;
                            }
                        }
                        warehouses[lowIndex].setPartNum711(purchaseAmount);
                        lowNum = warehouses[lowIndex].getPartNum711();
                        Console.WriteLine(warehouses[lowIndex].getName() + ": " + lowNum + " units");
                        Console.WriteLine("\n");
                        wFile.WriteLine("P, " + purchaseAmount + ", " + lowNum);
                    }
                }
            

                Console.WriteLine("Would you like to make a sale? Y/N" + "\n");
                makeSale = Console.ReadLine();
                Console.WriteLine("\n");

                if (makeSale == "Y")
                {
                    int saleAmount;
                    int highNum;
                    int highIndex = 0;

                    Console.WriteLine("What item would you like to sell?");
                    Console.WriteLine("Please Type: 102, 215, 410, 525, or 711");
                    invNum = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.WriteLine("Please type amount desired!");
                    saleAmount = Int32.Parse(Console.ReadLine()) * -1;
                    Console.WriteLine("\n");

                    if (invNum == "102")
                    {
                        highNum = warehouses[0].getPartNum102();

                        for (int i = 0; i < 6; i++)
                        {
                            if (highNum < warehouses[i].getPartNum102())
                            {
                                highNum = warehouses[i].getPartNum102();
                                highIndex = i;
                            }
                        }
                        warehouses[highIndex].setPartNum102(saleAmount);
                        highNum = warehouses[highIndex].getPartNum102();
                        Console.WriteLine(warehouses[highIndex].getName() + ": " + highNum + " units");
                        Console.WriteLine("\n");
                        wFile.WriteLine("S, " + saleAmount + ", " + highNum);
                    }
                    else if (invNum == "215")
                    {
                        highNum = warehouses[0].getPartNum215();

                        for (int i = 0; i < 6; i++)
                        {
                            if (highNum < warehouses[i].getPartNum215())
                            {
                                highNum = warehouses[i].getPartNum215();
                                highIndex = i;
                            }
                        }
                        warehouses[highIndex].setPartNum215(saleAmount);
                        highNum = warehouses[highIndex].getPartNum215();
                        Console.WriteLine(warehouses[highIndex].getName() + ": " + highNum + " units");
                        Console.WriteLine("\n");
                        wFile.WriteLine("S, " + saleAmount + ", " + highNum);
                    }
                    else if (invNum == "410")
                    {
                        highNum = warehouses[0].getPartNum410();

                        for (int i = 0; i < 6; i++)
                        {
                            if (highNum < warehouses[i].getPartNum410())
                            {
                                highNum = warehouses[i].getPartNum410();
                                highIndex = i;
                            }
                        }
                        warehouses[highIndex].setPartNum410(saleAmount);
                        highNum = warehouses[highIndex].getPartNum410();
                        Console.WriteLine(warehouses[highIndex].getName() + ": " + highNum + " units");
                        Console.WriteLine("\n");
                        wFile.WriteLine("S, " + saleAmount + ", " + highNum);
                    }
                    else if (invNum == "525")
                    {
                        highNum = warehouses[0].getPartNum525();

                        for (int i = 0; i < 6; i++)
                        {
                            if (highNum < warehouses[i].getPartNum525())
                            {
                                highNum = warehouses[i].getPartNum525();
                                highIndex = i;
                            }
                        }
                        warehouses[highIndex].setPartNum525(saleAmount);
                        highNum = warehouses[highIndex].getPartNum525();
                        Console.WriteLine(warehouses[highIndex].getName() + ": " + highNum + " units");
                        Console.WriteLine("\n");
                        wFile.WriteLine("S, " + saleAmount + ", " + highNum);
                    }
                    else
                    {
                        highNum = warehouses[0].getPartNum711();

                        for (int i = 0; i < 6; i++)
                        {
                            if (highNum < warehouses[i].getPartNum711())
                            {
                                highNum = warehouses[i].getPartNum711();
                                highIndex = i;
                            }
                        }
                        warehouses[highIndex].setPartNum711(saleAmount);
                        highNum = warehouses[highIndex].getPartNum711();
                        Console.WriteLine(warehouses[highIndex].getName() + ": " + highNum + " units");
                        Console.WriteLine("\n");
                        wFile.WriteLine("S, " + saleAmount + ", " + highNum);
                    }
                }

                Console.WriteLine("Would you like to end the day? Y/N");
                endDay = Console.ReadLine();

                if (endDay == "Y")
                {
                    wInv = new StreamWriter("../../../Inventory.txt");
                    int[] file;

                    Console.WriteLine("\n");
                    Console.WriteLine("Warehouse ending day Inventory");
                    Console.WriteLine("\n");

                    for (int i = 0; i < 6; i++)
                    {
                        file = warehouses[i].setEndInventory();
                        wInv.WriteLine(warehouses[i].endingInv());
                        Console.WriteLine(warehouses[i].getName() + ": " + warehouses[i].endingInv());
                    }
                    wFile.Close();
                    wInv.Close();
                }
                else
                {

                }
            }
        }
    }
}
