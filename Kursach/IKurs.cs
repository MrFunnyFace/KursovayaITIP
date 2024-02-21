using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public interface IKurs
    {
        List<Func<string>> GenerateDelegateList();
        public byte[] GetByteArray()
        {
#pragma warning disable SYSLIB0011 // Тип или член устарел
            BinaryFormatter bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Тип или член устарел
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, this);
                return ms.ToArray();
            }
        }
    }
}