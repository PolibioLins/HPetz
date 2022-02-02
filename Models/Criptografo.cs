using System;
using System.Security.Cryptography;
using System.Text;

namespace atv4.Models

{
    public class Criptografo
    {
        
        public static string TextoCriptografado(string textoClaro)
        {
          MD5 MD5Hasher = MD5.Create();

         byte[] By = Encoding.Default.GetBytes(textoClaro);
         byte[] bytesCriptogragado = MD5Hasher.ComputeHash(By);

         StringBuilder SB = new StringBuilder();

         foreach (byte b in bytesCriptogragado)
         {
             string DebugB = b.ToString("x2");
             SB.Append(DebugB);
         }

        return SB.ToString();

        }
        
    }
}