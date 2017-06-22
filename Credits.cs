using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace Credits
{
    class Credit_Lib
    {
        public static string[] Credits =
        {                                               //Credíts line by line
           "##--##--Credit File--##--##" ,
           "Author: GHXX",
           "Special thanks to 'GHXX' for some Codes!",
           "Also special thanks to: Corenality, BloodStainedAngel, Snickerbobble, Snarferman, and Anubiscorpiak for some awesome sprites!"
        };
        //             ___   ___   ___  _____                   _____
        /*  |  |\  /| |   \ /   \ |   \   |     /\      |\   |    |
         *  |  | \/ | |___| |   | |___|   |    /__\     | \  |    |     O   Put this Method into the MainModFile, into "Load()":
         *  |  |    | |     |   | | \     |   /    \    |  \ |    |     O   Credit_Lib.generateCreditFile(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\Terraria\ModLoader\Mods\" + Name + "_Credits.txt",Name,false);
         *  |  |    | |     \___/ |  \    |  /      \   |   \|    |         You should also add the following line: using Credits;
         */



        public static void generateCreditFile(string path,string modname,bool showInfoMsgBoxes = true,bool hideCriticalErrors = false,bool forceUpdateOnLoad = false)          //method to create the file, it should be straight forward
        {                                                                   //Warning forceUpdateOnLoad will cause the credit file to be generated everytime the mod gets loaded!
            try
            {
                if (File.Exists(path))
                {


                    if (File.ReadAllLines(path).Length != Credit_Lib.Credits.Length || forceUpdateOnLoad)
                    {
                        
                        File.WriteAllLines(path, Credit_Lib.Credits);
                        if (showInfoMsgBoxes) { MessageBox.Show("The Credits-File of " + modname + " has been Updated"); }
                    }
                }
                else
                {
                    File.WriteAllLines(path, Credit_Lib.Credits);
                    if (showInfoMsgBoxes) { MessageBox.Show("Thank you for installing the " + modname + " Mod. You can find the Credits in the Modfolder"); }         
                }

            }
            catch (Exception e)
            {
                if (!hideCriticalErrors) { MessageBox.Show("There was a critical Error while creating the CreditFile:\n" + e.ToString(), "Critical Error from Mod " + modname, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
