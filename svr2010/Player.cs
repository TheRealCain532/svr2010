using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svr2010 //this is older, check Wrestler.cs for an updated version.
{
    public class Player //struct is apx 260 | 0x104
    {
        private uint p;
        private fEdit fs;
        public byte Strength { get =>  fs.ReadByte(p); set  => fs.WriteByte(p, value); }
        public byte Submission { get =>  fs.ReadByte(p + 1); set  => fs.WriteByte(p + 1, value); }
        public byte Speed { get =>  fs.ReadByte(p + 2); set  => fs.WriteByte(p + 2, value); }
        public byte Technique { get =>  fs.ReadByte(p + 3); set  => fs.WriteByte(p + 3, value); }
        public byte Durability { get =>  fs.ReadByte(p + 4); set  => fs.WriteByte(p + 4, value); }
        public byte Charisma { get =>  fs.ReadByte(p + 5); set  => fs.WriteByte(p + 5, value); }
        public byte Stamina { get =>  fs.ReadByte(p + 6); set  => fs.WriteByte(p + 6, value); }
        public byte Hardcore { get =>  fs.ReadByte(p + 7); set  => fs.WriteByte(p + 7, value); }
        public byte[] Stats { get => new byte[] { Strength, Submission, Speed, Technique, Durability, Charisma, Stamina, Hardcore }; set => fs.WriteBytes(p, value); }
        public byte MaxStrength { get =>  fs.ReadByte(p + 8); set  => fs.WriteByte(p + 8, value); }
        public byte MaxSubmission { get =>  fs.ReadByte(p + 9); set  => fs.WriteByte(p + 9, value); }
        public byte MaxSpeed { get =>  fs.ReadByte(p + 10); set  => fs.WriteByte(p + 10, value); }
        public byte MaxTechnique { get =>  fs.ReadByte(p + 11); set  => fs.WriteByte(p + 11, value); }
        public byte MaxDurability { get => fs.ReadByte(p + 12); set => fs.WriteByte(p + 12, value); }
        public byte MaxCharisma { get => fs.ReadByte(p + 13); set => fs.WriteByte(p + 13, value); }
        public byte MaxStamina { get =>  fs.ReadByte(p + 14); set  => fs.WriteByte(p + 14, value); }
        public byte MaxHardcore { get =>  fs.ReadByte(p + 15); set  => fs.WriteByte(p + 15, value); }
        public byte[] MaxStats { get => new byte[] { MaxStrength, MaxSubmission, MaxSpeed, MaxTechnique, MaxDurability, MaxCharisma, MaxStamina, MaxHardcore }; set => fs.WriteBytes(p + 8, value); }
        public string NameText { get => fs.ReadString(p + 34); set { fs.WriteBytes(p + 34, new byte[32]); fs.WriteString(p + 34, value); } }
        public string HUDText { get => fs.ReadString(p + 102); set { fs.WriteBytes(p + 102, new byte[32]); fs.WriteString(p + 102, value); } }
        public string Nickname { get => fs.ReadString(p + 170); set { fs.WriteBytes(p + 170, new byte[32]); fs.WriteString(p + 170, value); } }
        public Player(string filename, uint start = 0xA48) { fs = new fEdit(filename); p = start; }
        private enum Stars_e : uint
        {
            Custom0 = 0x2979C,
            Custom1 = 0x2ACD8,
            Custom2 = 0x2C214,
            Custom3 = 0x2D750,
            Custom4 = 0x2EC8C,
            Custom5 = 0x301C8,
            Custom6 = 0x31704,
            Custom7 = 0x32C40,
            Custom8 = 0x3417C,
            Custom9 = 0x356B8,
            The_Rock = 0xA48,
            Stone_Cold = 0xB4C,
            Triple_H = 0xC50,
            Undertaker = 0xD54,
            Chris_Jericho = 0xE58,
            Motion_Test_01 = 0xF5C,
            Motion_Test_02 = 0x1060,
            Kane = 0x1164,
            Edge = 0x1470,
            Jeff_Hardy = 0x1574,
            Matt_Hardy = 0x1678,
            JBL = 0x1880,
            Mr_McMahon = 0x1984,
            William_Regal = 0x1B8C,
            Carlito = 0x1C90,
            Rey_Mysterio = 0x21A4,
            Big_Show = 0x23AC,
            Motion_Test_03 = 0x24B0,
            Maria = 0x25B4,
            CM_Punk = 0x29C4,
            MVP = 0x2DD4,
            Million_Dollar_Man = 0x2ED8,
            Chavo_Guerrero = 0x2FDC,
            John_Cena = 0x31E4,
            Mickie_James = 0x35F4,
            Shawn_Michaels = 0x37FC,
            Michael_Cole = 0x3D10,
            Shane_McMahon = 0x3F18,
            Jerry_Lawler = 0x401C,
            Tazz = 0x4224,
            Umaga = 0x442C,
            Finlay = 0x4530,
            Batista = 0x4738,
            Randy_Orton = 0x483C,
            Mr_Kennedy = 0x4940,
            Kelly_Kelly = 0x4B48,
            JTG = 0x4C4C,
            The_Great_Khali = 0x4D50,
            Tommy_Dreamer = 0x4F58,
            Jim_Ross = 0x5368,
            Melina = 0x5570,
            John_Morrison = 0x5674,
            Kofi_Kingston = 0x5778,
            Shad = 0x5980,
            Mark_Henry = 0x5A84,
            Michelle_McCool = 0x5D90,
            Justin_Roberts = 0x62A4,
            Tony_Chimmel = 0x63A8,
            Lilian_Garcia = 0x64AC,
            Green = 0x65B0,
            Red = 0x66B4,
            Moves_Man_02 = 0x67B8,
            Hornswoggle = 0x6AC4,
            Santino_Marella = 0x70DC,
            Cody_Rhodes = 0x74EC,
            The_Brian_Kendrick = 0x76F4,
            Shelton_Benjamin = 0x77F8,
            Dusty_Rhodes = 0x78FC,
            Jesse = 0x7D0C,
            Festus = 0x7E10,
            The_Miz = 0x8220,
            Beth_Phoenix = 0x8838,
            Matt_Striker = 0x8B44,
            Doctor = 0x8F54,
            Howard_Finkel_ = 0xA4A8,
            Referee = 0xA7B4,
            SUPERSTAR = 0xA8B8,
            DIVA = 0xA9BC,
            Vickie_Guerrero = 0xAAC0,
            Ted_DiBiase = 0xADCC,
            Vladimir_Kozlov = 0xAED0,
            Mike_Knox = 0xAFD4,
            Evan_Bourne = 0xB1DC,
            Jack_Swagger = 0xB3E4,
            Ezekiel_Jackson = 0xB4E8,
            Primo = 0xB7F4,
            R_Truth = 0xB8F8,
            Dolph_Ziggler = 0xBC04,
            Christian = 0xBD08,
            Goldust = 0xBE0C,
            Natalya = 0xCB40,
            Maryse = 0xCC44,
            Eve = 0xCD48,
            Gail_Kim = 0xCE4C,
            Brie_Bella = 0xCF50,
            Nikki_Bella = 0xD054,
            Todd_Grisham = 0xD66C,
            Trish_Stratus = 0xD770,
            Bob_Orton = 0xD874
        }
        public uint[] Stars { get => (uint[])Enum.GetValues(typeof(Stars_e)); }
        public string[] StarsName { get => Enum.GetNames(typeof(Stars_e)); }
    }

}
