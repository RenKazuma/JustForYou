using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class History
    {
        public List<string> _historie = new List<string>();
        
        public void Clear()
        {
            _historie.Clear();
            Changed?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name der Berechnung</param>
        /// <param name="calculation">Die Rechung als string</param>
        public void Add(string name, string calculation)
        {
            _historie.Add($"{name}: {calculation}");
            Changed?.Invoke(this, new EventArgs());
        }

        public byte[] ToAES()
        {
            StringBuilder history = new StringBuilder();
            foreach (var item in _historie)
                history.AppendLine(item);

            using (Aes aesAlgorithm = Aes.Create())
            {
                Debug.WriteLine($"Aes Cipher Mode : {aesAlgorithm.Mode}");
                Debug.WriteLine($"Aes Padding Mode: {aesAlgorithm.Padding}");
                Debug.WriteLine($"Aes Key Size : {aesAlgorithm.KeySize}");
                Debug.WriteLine($"Aes Block Size : {aesAlgorithm.BlockSize}");

                //set the parameters with out keyword
                aesAlgorithm.Key = Key();
                aesAlgorithm.IV = IVwith128Size();

                // Create encryptor object
                ICryptoTransform encryptor = aesAlgorithm.CreateEncryptor();

                byte[] encryptedData;

                //Encryption will be done in a memory stream through a CryptoStream object
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(history);
                        }
                        encryptedData = ms.ToArray();
                    }
                }

                return encryptedData;
            }
        }

        public static History FromAes(byte[] encrypted_text)
        {
            //History history = new History();

            //using (Aes aesAlg = Aes.Create())
            //{
            //    aesAlg.BlockSize = 128;
            //    aesAlg.Key = Key();
            //    aesAlg.IV = IVwith128Size();
            //    // Create a decryptor to perform the stream transform.
            //    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            //    // Create the streams used for decryption.
            //    using (MemoryStream msDecrypt = new MemoryStream(encrypted_text))
            //    {
            //        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
            //        {
            //            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
            //            {
            //                // Read the decrypted bytes from the decrypting stream
            //                // and place them in a string.
            //                history._historie.Add(srDecrypt.ReadToEnd());
            //            }
            //        }
            //    }
            //}

            //return history;

            History history = new History();

            using (Aes aesAlgorithm = Aes.Create())
            {
                aesAlgorithm.Key = Key();
                aesAlgorithm.IV = IVwith128Size();

                Debug.WriteLine($"Aes Cipher Mode : {aesAlgorithm.Mode}");
                Debug.WriteLine($"Aes Padding Mode: {aesAlgorithm.Padding}");
                Debug.WriteLine($"Aes Key Size : {aesAlgorithm.KeySize}");
                Debug.WriteLine($"Aes Block Size : {aesAlgorithm.BlockSize}");

                // Create decryptor object
                ICryptoTransform decryptor = aesAlgorithm.CreateDecryptor();

                byte[] cipher = encrypted_text;
                string decrypted = "";

                //Decryption will be done in a memory stream through a CryptoStream object
                using (MemoryStream ms = new MemoryStream(cipher))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            decrypted = sr.ReadToEnd();
                        }
                    }
                }

                string[] lines = decrypted.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (var line in lines)
                {
                    history._historie.Add(line);   
                }
            }

            return history;
        }

        static private byte[] Key()
        {
            return Convert.FromBase64String("pooYJobaAVBASMYuYT8z/eqBXUSI6L4g5BEn1caryH0=");
        }

        static private byte[] IVwith128Size()
        {
            byte[] test = new byte[128]; 
            test = Convert.FromBase64String("pW9cQLYe+8BwEDXLjhYRPA==");
            return test;
        }

        //public event EventHandler Added;
        public event EventHandler Changed;
    }
}
