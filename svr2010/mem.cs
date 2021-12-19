using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svr2010
{
    class fEdit
    {
        private string fName;
        public byte[] ReadBytes(uint address, int length)
        {
            var buff = new byte[length];
            Stream fs = File.OpenRead(fName);
            BinaryReader b = new BinaryReader(fs);
            b.BaseStream.Seek(address, SeekOrigin.Begin);
            b.Read(buff, 0, length);
            b.Close();
            fs.Close();
            return buff;
        }
        public string ReadString(uint offset)
        {
            int length = 40;
            int num2 = 0;
            string source = "";
            do
            {
                byte[] bytes = this.ReadBytes(offset + ((uint)num2), length);
                source = source + Encoding.UTF8.GetString(bytes);
                num2 += length;
            }
            while (!source.Contains<char>('\0'));
            int index = source.IndexOf('\0');
            string str2 = source.Substring(0, index);
            source = string.Empty;
            return str2;
        }
        public uint ReadUInt32(uint offset) {
            byte[] buffer = ReadBytes(offset, 4);
            return BitConverter.ToUInt32(buffer, 0);
        }
        public byte ReadByte(uint offset) => ReadBytes(offset, 1)[0];
        public void WriteByte(uint offset, byte data) => WriteBytes(offset, new byte[] { data });
        public void WriteBytes(uint offset, byte[] data)
        {
            FileStream fs = File.OpenWrite(fName);
            BinaryWriter b = new BinaryWriter(fs);
            fs.Position = offset;
            b.Write(data);
            b.Close();
            fs.Close();
        }
        public void WriteString(uint offset, string data) => WriteBytes(offset, ASCIIEncoding.ASCII.GetBytes(data));
        public fEdit(string file) => fName = file;
    }
}
