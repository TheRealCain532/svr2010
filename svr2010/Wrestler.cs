using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svr2010
{
    public class Wrestler
    {
        private uint Base; //0x0A14
        private fEdit fEdit;
        public byte Strength { get { return fEdit.ReadByte(Base + 0x34); } set { fEdit.WriteByte(Base + 0x34, value); } }
        public byte Submission { get { return fEdit.ReadByte(Base + 0x35); } set { fEdit.WriteByte(Base + 0x35, value); } }
        public byte Speed { get { return fEdit.ReadByte(Base + 0x36); } set { fEdit.WriteByte(Base + 0x36, value); } }
        public byte Technique { get { return fEdit.ReadByte(Base + 0x37); } set { fEdit.WriteByte(Base + 0x37, value); } }
        public byte Durability { get { return fEdit.ReadByte(Base + 0x38); } set { fEdit.WriteByte(Base + 0x38, value); } }
        public byte Charisma { get { return fEdit.ReadByte(Base + 0x39); } set { fEdit.WriteByte(Base + 0x39, value); } }
        public byte Stamina { get { return fEdit.ReadByte(Base + 0x3A); } set { fEdit.WriteByte(Base + 0x3A, value); } }
        public byte Hardcore { get { return fEdit.ReadByte(Base + 0x3B); } set { fEdit.WriteByte(Base + 0x3B, value); } }
        public string Name { get { return fEdit.ReadString(Base + 0x56); } set { fEdit.WriteString(Base + 0x56, value); } }

        public byte MaxStrength { get { return fEdit.ReadByte(Base + 0x3C); } set { fEdit.WriteByte(Base + 0x3C, value); } }
        public byte MaxSubmission { get { return fEdit.ReadByte(Base + 0x3D); } set { fEdit.WriteByte(Base + 0x3D, value); } }
        public byte MaxSpeed { get { return fEdit.ReadByte(Base + 0x3E); } set { fEdit.WriteByte(Base + 0x3E, value); } }
        public byte MaxTechnique { get { return fEdit.ReadByte(Base + 0x3F); } set { fEdit.WriteByte(Base + 0x3F, value); } }
        public byte MaxDurability { get { return fEdit.ReadByte(Base + 0x40); } set { fEdit.WriteByte(Base + 0x40, value); } }
        public byte MaxCharisma { get { return fEdit.ReadByte(Base + 0x41); } set { fEdit.WriteByte(Base + 0x41, value); } }
        public byte MaxStamina { get { return fEdit.ReadByte(Base + 0x42); } set { fEdit.WriteByte(Base + 0x42, value); } }
        public byte MaxHardcore { get { return fEdit.ReadByte(Base + 0x43); } set { fEdit.WriteByte(Base + 0x43, value); } }

        public Wrestler(string fileName, uint BasePointer)
        {
            fEdit = new fEdit(fileName); Base = BasePointer;
        }
    }
}
