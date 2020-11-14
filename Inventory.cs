/**
 * Raheem Hampton
 * ITCS 3112-051
 * 10/21/2020
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assignment_2
{   
    class Inventory
    {
        String facilityName;
        private int pN102;
        private int pN215;
        private int pN410;
        private int pN525;
        private int pN711;
        private static int wareNum;
        private int[] file;
        StreamReader rFile;


        public Inventory(String facilityName)
        {
            this.facilityName = facilityName;
            wareNum++;
            file = begInv(file);
            pN102 = file[0];
            pN215 = file[1];
            pN410 = file[2];
            pN525 = file[3];
            pN711 = file[4];
            rFile.Close();
        }

        public int[] begInv (int[] dataArr)
        {
            rFile = new StreamReader("../../../Inventory.txt");
            String data = "";
            file = new int[5];

            for (int i = 0; i < wareNum; i++)
            {
                data = rFile.ReadLine();
                file = Array.ConvertAll(data.Split(','), int.Parse);
            }

            return file;
        }
        public String toStringInv()
        {
            return "Warehouse " + facilityName + "\n"
                +  "Part Number 102: " + pN102 + " units" + "\n"
                +  "Part Number 215: " + pN215 + " units" + "\n"
                +  "Part Number 410: " + pN410 + " units" + "\n"
                +  "Part Number 525: " + pN525 + " units" + "\n"
                +  "Part Number 711: " + pN711 + " units" + "\n" + "\n";
        }

        public String endingInv()
        {
            String endingInv = "";

            for (int i = 0; i < file.Length; i++)
            {
                endingInv += file[i] + ", ";
            }
            endingInv = endingInv.Substring(0, endingInv.Length - 2);
            return endingInv;
        }

        public String getName()
        {
            return facilityName;
        }
        public int getPartNum102()
        {
            return file[0];
        }
        public int getPartNum215()
        {
            return file[1];
        }
        public int getPartNum410()
        {
            return file[2];
        }
        public int getPartNum525()
        {
            return file[3];
        }
        public int getPartNum711()
        {
            return file[4];
        }

        public void setPartNum102(int item1)
        {
            file[0] += item1;
        }
        public void setPartNum215(int item2)
        {
            file[1] += item2;
        }
        public void setPartNum410(int item3)
        {
            file[2] += item3;
        }
        public void setPartNum525(int item4)
        {
            file[3] += item4;
        }
        public void setPartNum711(int item5)
        {
            file[4] += item5;
        }

        public int[] setEndInventory()
        {
            return file;
        }
    }
}
