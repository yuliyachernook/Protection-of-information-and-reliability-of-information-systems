﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class CaesarCipher { 

    //символы русской азбуки
    const string alfabet = "АБВГДЕЁЖЗІЙКЛМНОПРСТУЎФХЦЧШЩЪЫЬЭЮЯ";

    private static string CodeEncode(string text, int k)
    {
        //добавляем в алфавит маленькие буквы
        var fullAlfabet = alfabet + alfabet.ToLower();
        var letterQty = fullAlfabet.Length;
        var retVal = "";
        for (int i = 0; i < text.Length; i++)
        {
            var c = text[i];
            var index = fullAlfabet.IndexOf(c);
            if (index < 0)
            {
                //если символ не найден, то добавляем его в неизменном виде
                retVal += c.ToString();
            }
            else
            {
                var codeIndex = (letterQty + index + k) % letterQty;
                retVal += fullAlfabet[codeIndex];
            }
        }

        return retVal;
    }

    //шифрование текста
    public static string Encrypt(string plainMessage, int key)
        => CodeEncode(plainMessage, key);

    //дешифрование текста
    public static string Decrypt(string encryptedMessage, int key)
        => CodeEncode(encryptedMessage, -key);
    }
}
