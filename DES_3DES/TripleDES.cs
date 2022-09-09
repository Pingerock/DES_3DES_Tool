using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES_3DES
{
    public class TripleDES
    {
        private ulong k1;

        private ulong k2;

        private ulong k3;

        private string file_Path;


        public TripleDES(ulong k1, ulong k2, ulong k3, string file_Path)
        {
            this.k1 = k1;
            this.k2 = k2;
            this.k3 = k3;
            this.file_Path = file_Path;
        }

        // 3DES-EDE encryption algorithm
        public void Encrypt()
        {
            DES des1 = new DES(k1, file_Path);
            des1.Encrypt();
            des1.Save_File(0); //"DES_encryption.txt" - a file to show the progress of work
            string save_File_Path = AppDomain.CurrentDomain.BaseDirectory + @"\DES_encryption.txt";
            DES des2 = new DES(k2, save_File_Path);
            des2.Decrypt();
            des2.Save_File(1); //"DES_decryption.txt" - a file to show the progress of work
            save_File_Path = AppDomain.CurrentDomain.BaseDirectory + @"\DES_decryption.txt";
            DES des3 = new DES(k3, save_File_Path);
            des3.Encrypt();
            des3.Save_File(2); //"3DES_encryption.txt" - result file
        }

        // 3DES-EDE decription algorithm
        public void Decrypt()
        {
            DES des1 = new DES(k3, file_Path);
            des1.Decrypt();
            des1.Save_File(1); //"DES_decryption.txt" - a file to show the progress of work
            string save_File_Path = AppDomain.CurrentDomain.BaseDirectory + @"\DES_decryption.txt";
            DES des2 = new DES(k2, save_File_Path);
            des2.Encrypt();
            des2.Save_File(0); //"DES_encryption.txt" - a file to show the progress of work
            save_File_Path = AppDomain.CurrentDomain.BaseDirectory + @"\DES_encryption.txt";
            DES des3 = new DES(k1, save_File_Path);
            des3.Decrypt();
            des3.Save_File(3); //"3DES_decryption.txt" - result file
        }
    }
}
