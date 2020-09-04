using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svr2010
{
    public class Player
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
        public Player(string filename, uint start = 0x0002ACD8) { fs = new fEdit(filename); p = start; }
    }

}
