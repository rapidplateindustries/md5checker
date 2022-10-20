using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace rcmd5c
{
    public class FileCheck
    {

        /// <summary>
        /// Calculates a files MD5 Checksum
        /// </summary>
        /// <param name="fileName">The file that is being checked</param>
        /// <returns>(string) The MD5 Checksum of the file</returns>
        public string GetMD5Checksum(string fileName)
        {
            // Initialize variables, assign them and what not
            FileStream fStream = new FileStream(fileName, FileMode.Open);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] returnValue = md5.ComputeHash(fStream);
            
            // Close the FileStream (fStream)
            fStream.Close();

            // Create a string builder
            StringBuilder strBuilder = new StringBuilder();

            // Calculate the MD5
            for (int i = 0; i < returnValue.Length; i++)
            {
                strBuilder.Append(returnValue[i].ToString("x2"));
            }

            // Return the StringBuilder.ToString()
            return strBuilder.ToString();
        }
    }
}
