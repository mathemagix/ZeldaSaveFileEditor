using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MMSaveFileEditor
{
    //Zelda has their own weird ascii standard
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        byte[] hexArray = new byte[65536];
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            BinaryReader binaryReader = new BinaryReader(File.Open(openFileDialog1.FileName,FileMode.Open));
            hexArray = renumberByteArray(binaryReader.ReadBytes(65536));
            /*
            for (int i = 0x2FE0; i<0x3000; i++)
            {
                textBox1.Text += i.ToString("X4") + " : " + hexArray[i].ToString("X2") + Environment.NewLine;
            }
            */

            textBox1.Text += "File Name: " + getFileName() + Environment.NewLine;
            textBox1.Text += "Bombers Password: " + getBombersPassword() + Environment.NewLine;

            checkHeartPieces();
            /*
            for (int i=0; i<hexArray.Length; i++)
            {
                if (hexArray[i] != 0) textBox1.Text += i.ToString("X4") + " - " + hexArray[i].ToString("X4") + Environment.NewLine;
            }
            */
        }

        private byte[] renumberByteArray(byte[] byteArray)
        {
            byte[] renumberedArray = new byte[65536];
            for (int i = 0; i < byteArray.Length / 4; i++)
            {
                renumberedArray[4 * i] = byteArray[(4 * i) + 3];
                renumberedArray[(4 * i) + 1] = byteArray[(4 * i) + 2];
                renumberedArray[(4 * i) + 2] = byteArray[(4 * i) + 1];
                renumberedArray[(4 * i) + 3] = byteArray[4 * i];
            }
            return renumberedArray;
        }

        private string getZASCIILetter(int register)
        {
            //0-9 are just 0-9
            if (hexArray[register] < 10) return hexArray[register].ToString();
   
            //10-35 are A-Z (ASCII codes 65-90)
            if (hexArray[register] < 36) return (Convert.ToChar(hexArray[register] + 55)).ToString();

            //if we're out of range, just leave an empty space
            return " ";
        }

        private string getFileName()
        {
            return getZASCIILetter(0x202F) + getZASCIILetter(0x202E) + getZASCIILetter(0x202D) + getZASCIILetter(0x202C) + getZASCIILetter(0x2033) + getZASCIILetter(0x2032) + getZASCIILetter(0x2031) + getZASCIILetter(0x2030);

        }

        private string getBombersPassword()
        {
            return hexArray[0x2FF8].ToString() + hexArray[0x2FFF].ToString() + hexArray[0x2FFE].ToString() + hexArray[0x2FFD].ToString() + hexArray[0x2FFC].ToString();
        }
        private void checkHeartPieces()
        {
            //List courtesy of https://github.com/cxd4/zs-flash/blob/master/zs_data.c
            //Several of these are slightly offset - not sure why. Different rom versions? Old version of P64? Read vs. Write?
            //TO-DO - Verify rom addresses 

            //16 pieces in Clock Town
            if (hexArray[0x2D2E] == 0) textBox1.Text += "Clock Tower Piece" + Environment.NewLine;
            if (hexArray[0x2F45] == 0) textBox1.Text += "Postman's Challenge Piece" + Environment.NewLine;
            if (hexArray[0x2F41] == 0) textBox1.Text += "Hand In Toilet Piece" + Environment.NewLine;
            if (hexArray[0x2F06] == 0) textBox1.Text += "Deku Scrub Playground Piece" + Environment.NewLine;
            if (hexArray[0x2D12] == 0) textBox1.Text += "Clock Town Tree Piece" + Environment.NewLine;
            if (hexArray[0x2F37] == 0) textBox1.Text += "Swordsman's School Piece" + Environment.NewLine;
            if (hexArray[0x2F47] == 0) textBox1.Text += "Keaton Quiz Piece" + Environment.NewLine;
            if (hexArray[0x2F49] == 0) textBox1.Text += "Postbox Piece" + Environment.NewLine;
            if (hexArray[0x2F33] == 0) textBox1.Text += "Maxed Bank Piece" + Environment.NewLine;
            if (hexArray[0x2F43] == 0) textBox1.Text += "Kamaro's Dance Piece" + Environment.NewLine;
            if (hexArray[0x2F18] == 0) textBox1.Text += "Town Shooting Gallery Piece" + Environment.NewLine;
            if (hexArray[0x2F0E] == 0) textBox1.Text += "Honey And Darling Piece" + Environment.NewLine;
            if (hexArray[0x2383] == 0) textBox1.Text += "Treasure Chest Game Piece" + Environment.NewLine;
            //Fix these later - heart pieces packed into same bit
            if (hexArray[0x2F2A] == 0) textBox1.Text += "Grandma Story 1 Piece" + Environment.NewLine;
            if (hexArray[0x2F2A] == 0) textBox1.Text += "Grandma Story 2 Piece" + Environment.NewLine;
            if (hexArray[0x2F34] == 0) textBox1.Text += "Mayor's Meeting Piece" + Environment.NewLine;

            //Termina Field
            if (hexArray[0x2F52] == 0) textBox1.Text += "Gossip Stone Music Puzzle Piece" + Environment.NewLine;
            if (hexArray[0x2F2D] == 0) textBox1.Text += "Business Scrub Grotto Piece" + Environment.NewLine;
            if (hexArray[0x21CE] == 0) textBox1.Text += "Peahat Grotto Piece" + Environment.NewLine;
            if (hexArray[0x21CE] == 0) textBox1.Text += "Dodongo Grotto Piece" + Environment.NewLine;
            if (hexArray[0x21CF] == 0) textBox1.Text += "Deku Baba Grotto Piece" + Environment.NewLine;
            if (hexArray[0x280B] == 0) textBox1.Text += "Swamp Tree Piece" + Environment.NewLine;
            if (hexArray[0x2F00] == 0) textBox1.Text += "Doggy Race Piece" + Environment.NewLine;

            //Southern Swamp
            if (hexArray[0x2894] == 0) textBox1.Text += "Swamp Business Scrub Piece" + Environment.NewLine;
            if (hexArray[0x2F4F] == 0) textBox1.Text += "Pictograph Piece" + Environment.NewLine;
            if (hexArray[0x25BC] == 0) textBox1.Text += "Deku Palace Piece" + Environment.NewLine;
            if (hexArray[0x28B2] == 0) textBox1.Text += "Woodfall Area Piece" + Environment.NewLine;
            if (hexArray[0x2F33] == 0) textBox1.Text += "Swamp Shooting Gallery Piece" + Environment.NewLine;
            if (hexArray[0x2F12] == 0) textBox1.Text += "Koume Cruise Piece" + Environment.NewLine;

            //Snowhead
            if (hexArray[0x2974] == 0) textBox1.Text += "Mountain Business Scrub Piece" + Environment.NewLine;
            if (hexArray[0x2AFE] == 0) textBox1.Text += "Snowhead Scarecrow Piece" + Environment.NewLine;
            if (hexArray[0x2B37] == 0) textBox1.Text += "Snowhead Spring Pond Piece" + Environment.NewLine;
            if (hexArray[0x2F1B] == 0) textBox1.Text += "Don Gero Frog Choir Piece" + Environment.NewLine;

            //Great Bay
            if (hexArray[0x2958] == 0) textBox1.Text += "Zora Hall Business Scrub Piece" + Environment.NewLine;
            if (hexArray[0x2F1F] == 0) textBox1.Text += "Jam Session Piece" + Environment.NewLine;
            if (hexArray[0x272B] == 0) textBox1.Text += "Like Like Piece" + Environment.NewLine;
            if (hexArray[0x24DE] == 0) textBox1.Text += "Pirate Fortress Piece" + Environment.NewLine;
            if (hexArray[0x2F18] == 0) textBox1.Text += "Seahorse Piece" + Environment.NewLine;
            if (hexArray[0x2568] == 0) textBox1.Text += "Oceanside Spider House Piece" + Environment.NewLine;
            if (hexArray[0x2F30] == 0) textBox1.Text += "Fish Feeding Piece" + Environment.NewLine;
            if (hexArray[0x2F11] == 0) textBox1.Text += "Beaver Race Piece" + Environment.NewLine;
            if (hexArray[0x270F] == 0) textBox1.Text += "Great Bay Scarecrow Piece" + Environment.NewLine;
            if (hexArray[0x2F4A] == 0) textBox1.Text += "Jumping Minigame Piece" + Environment.NewLine;

            //Ikana
            if (hexArray[0x231C] == 0) textBox1.Text += "Ikana Business Scrub Piece" + Environment.NewLine;
            if (hexArray[0x2F2E] == 0) textBox1.Text += "Poe Challenge Piece" + Environment.NewLine;
            if (hexArray[0x2258] == 0) textBox1.Text += "Day 2 Grave Piece" + Environment.NewLine;
            if (hexArray[0x2436] == 0) textBox1.Text += "Ikana Castle Roof Piece" + Environment.NewLine;
            if (hexArray[0x2B8A] == 0) textBox1.Text += "Secret Shrine Piece" + Environment.NewLine;

            //Moon
            if (hexArray[0x246C] == 0) textBox1.Text += "Deku Moon Dungeon Piece" + Environment.NewLine;
            if (hexArray[0x2878] == 0) textBox1.Text += "Goron Moon Dungeon Piece" + Environment.NewLine;
            if (hexArray[0x2B6C] == 0) textBox1.Text += "Zora Moon Dungeon Piece" + Environment.NewLine;
            if (hexArray[0x26F0] == 0) textBox1.Text += "Hylian Moon Dungeon Piece" + Environment.NewLine;
        }
    }
}
