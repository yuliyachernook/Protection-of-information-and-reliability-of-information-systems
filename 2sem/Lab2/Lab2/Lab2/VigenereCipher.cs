using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class VigenereCipher
    {
        const string letters = "АБВГДЕЁЖЗІЙКЛМНОПРСТУЎФХЦЧШЩЪЫЬЭЮЯ";


        //генерация повторяющегося пароля
        private static string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }

            return p.Substring(0, n);
        }

        private static string Vigenere(string text, string password, bool encrypting = true)
        {
            var gamma = GetRepeatKey(password, text.Length);
            var retValue = "";
            var fullAlfabet = letters + letters.ToLower();
            var q = fullAlfabet.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = fullAlfabet.IndexOf(text[i]);
                var codeIndex = fullAlfabet.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    //если буква не найдена, добавляем её в исходном виде
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += fullAlfabet[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }

            return retValue;
        }

        //шифрование текста
        public static string Encrypt(string plainMessage, string password)
            => Vigenere(plainMessage, password);

        //дешифрование текста
        public static string Decrypt(string encryptedMessage, string password)
            => Vigenere(encryptedMessage, password, false);
    }

}