using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DES_3DES
{
    public class DES
    {
        // Initial permutation table (IP)
        private int[] IP = {  
			58, 50, 42, 34, 26, 18, 10, 2,
			60, 52, 44, 36, 28, 20, 12, 4,
			62, 54, 46, 38, 30, 22, 14, 6,
			64, 56, 48, 40, 32, 24, 16, 8,
			57, 49, 41, 33, 25, 17,  9, 1,
			59, 51, 43, 35, 27, 19, 11, 3,
			61, 53, 45, 37, 29, 21, 13, 5,
			63, 55, 47, 39, 31, 23, 15, 7  
		};

        // Final permutation table (IP^(-1))
        private int[] IP_1 = {  
			40,  8, 48, 16, 56, 24, 64, 32,
			39,  7, 47, 15, 55, 23, 63, 31,
			38,  6, 46, 14, 54, 22, 62, 30,
			37,  5, 45, 13, 53, 21, 61, 29,
			36,  4, 44, 12, 52, 20, 60, 28,
			35,  3, 43, 11, 51, 19, 59, 27,
			34,  2, 42, 10, 50, 18, 58, 26,
			33,  1, 41,  9, 49, 17, 57, 25  
		};

        // Expansion function to 48 bits 
        private int[] Expand = { 
			32,  1,  2,  3,  4,  5,
			 4,  5,  6,  7,  8,  9,
			 8,  9, 10, 11, 12, 13,
			12, 13, 14, 15, 16, 17,
			16, 17, 18, 19, 20, 21,
			20, 21, 22, 23, 24, 25,
			24, 25, 26, 27, 28, 29,
			28, 29, 30, 31, 32,  1 
		};

        // Substitution boxes (S-Blocks) from S1 to S8
        private int[,,] S_Block =
		{
			//S1
			{
					{  14,  4,  13,  1,   2, 15,  11,  8,   3,  10,   6,  12,  5,  9,  0,  7 },
					{   0, 15,   7,  4,  14,  2,  13,  1,  10,   6,  12,  11,  9,  5,  3,  8 },
					{   4,  1,  14,  8,  13,  6,   2, 11,  15,  12,   9,   7,  3, 10,  5,  0 },
					{  15, 12,   8,  2,   4,  9,   1,  7,   5,  11,   3,  14, 10,  0,  6, 13 }
			},
			//S2
			{
					{  15,  1,   8, 14,   6, 11,   3,  4,   9,   7,   2,  13, 12,  0,  5, 10 },
					{   3, 13,   4,  7,  15,  2,   8, 14,  12,   0,   1,  10,  6,  9, 11,  5 },
					{   0, 14,   7, 11,  10,  4,  13,  1,   5,   8,  12,   6,  9,  3,  2, 15 },
					{  13,  8,  10,  1,   3, 15,   4,  2,  11,   6,   7,  12,  0,  5, 14,  9 }
			},
			//S3
			{
					{  10,  0,   9, 14,   6,  3,  15,  5,   1,  13,  12,   7,  11,  4,  2,  8 },
					{  13,  7,   0,  9,   3,  4,   6, 10,   2,   8,   5,  14,  12, 11, 15,  1 },
					{  13,  6,   4,  9,   8, 15,   3,  0,  11,   1,   2,  12,   5, 10, 14,  7 },
					{   1, 10,  13,  0,   6,  9,   8,  7,   4,  15,  14,   3,  11,  5,  2, 12 }

			},
			//S4
			{
					{   7, 13,  14,  3,   0,  6,   9, 10,   1,   2,   8,   5,  11, 12,  4, 15 },
					{  13,  8,  11,  5,   6, 15,   0,  3,   4,   7,   2,  12,   1, 10, 14,  9 },
					{  10,  6,   9,  0,  12, 11,   7, 13,  15,   1,   3,  14,   5,  2,  8,  4 },
					{   3, 15,   0,  6,  10,  1,  13,  8,   9,   4,   5,  11,  12,  7,  2, 14 }
			},
			//S5
			{
					{   2, 12,   4,  1,   7, 10,  11,  6,   8,   5,   3,  15,  13,  0, 14,  9 },
					{  14, 11,   2, 12,   4,  7,  13,  1,   5,   0,  15,  10,   3,  9,  8,  6 },
					{   4,  2,   1, 11,  10, 13,   7,  8,  15,   9,  12,   5,   6,  3,  0, 14 },
					{  11,  8,  12,  7,   1, 14,   2, 13,   6,  15,   0,   9,  10,  4,  5,  3 }
			},
			//S6
			{
					{  12,  1,  10, 15,   9,  2,   6,  8,   0,  13,   3,   4,  14,  7,  5, 11 },
					{  10, 15,   4,  2,   7, 12,   9,  5,   6,   1,  13,  14,   0, 11,  3,  8 },
					{   9, 14,  15,  5,   2,  8,  12,  3,   7,   0,   4,  10,   1, 13, 11,  6 },
					{   4,  3,   2, 12,   9,  5,  15, 10,  11,  14,   1,   7,   6,  0,  8, 13 }
			},
			//S7
			{
					{   4, 11,   2, 14,  15,  0,   8, 13,   3,  12,   9,   7,   5, 10,  6,  1 },
					{  13,  0,  11,  7,   4,  9,   1, 10,  14,   3,   5,  12,   2, 15,  8,  6 },
					{   1,  4,  11, 13,  12,  3,   7, 14,  10,  15,   6,   8,   0,  5,  9,  2 },
					{   6, 11,  13,  8,   1,  4,  10,  7,   9,   5,   0,  15,  14,  2,  3, 12 }
			},
			//S8
			{
					{   13,  2,   8,  4,   6, 15,  11,  1,  10,   9,   3,  14,   5,  0, 12,  7 },
					{    1, 15,  13,  8,  10,  3,   7,  4,  12,   5,   6,  11,   0, 14,  9,  2 },
					{    7, 11,   4,  1,   9, 12,  14,  2,   0,   6,  10,  13,  15,  3,  5,  8 },
					{    2,  1,  14,  7,   4, 10,   8, 13,  15,  12,   9,   0,   3,  5,  6, 11 }
			}
		};

        // Permutation table
        private int[] P_Result = {
			16,  7, 20, 21,
			29, 12, 28, 17,
			 1, 15, 23, 26,
			 5, 18, 31, 10,
			 2,  8, 24, 14,
			32, 27,  3,  9,
			19, 13, 30,  6,
			22, 11,  4, 25
		};

        // Permuted choice 1 table (PC-1)
        private int[] PC_1 = { 
			57,   49,    41,   33,    25,    17,    9,
			 1,   58,    50,   42,    34,    26,   18,
			10,    2,    59,   51,    43,    35,   27,
			19,   11,     3,   60,    52,    44,   36,
			63,   55,    47,   39,    31,    23,   15,
			 7,   62,    54,   46,    38,    30,   22,
			14,    6,    61,   53,    45,    37,   29,
			21,   13,     5,   28,    20,    12,    4   
		};

        // Permuted choice 2 table (PC-2)
        private int[] PC_2 = { 
			14,    17,   11,    24,     1,    5,
			 3,    28,   15,     6,    21,   10,
			23,    19,   12,     4,    26,    8,
			16,     7,   27,    20,    13,    2,
			41,    52,   31,    37,    47,   55,
			30,    40,   51,    45,    33,   48,
			44,    49,   39,    56,    34,   53,
			46,    42,   50,    36,    29,   32   
		};

		// Bits rotation (Left rotations)
		private int[] ls = { 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1 };

		// List of 64 bits text blocks
		private List<BitArray> source_Text_Blocks = new List<BitArray>();
		
		// List of encoded 64 bits text blocks
		private List<BitArray> encoded_Text_Blocks = new List<BitArray>();

		// Result bit array of encoded/decoded blocks
		private BitArray resultBits = new BitArray(0);

		// Encryption key
		private ulong key;

		// Byte array of a source text block
		private byte[] source_Text_Bytes;

		// Source file path
		private string source_File_Path;

        // Left and right block before encryption iteration
        private BitArray l = new BitArray(32);
		private BitArray r = new BitArray(32);

        // Left and right block data after 1 of 16 subsequent encryption iterations
        private BitArray l_Next = new BitArray(32);
		private BitArray r_Next = new BitArray(32);

        // List of 48-bit K keys
        private List<BitArray> k;

        // 28-bit vectors for key generation before iteration
        private BitArray c = new BitArray(28);
		private BitArray d = new BitArray(28);

        // 28-bit vectors for key generation before iteration after 1 of 16
        // subsequent iterations of encryption key generation
        private BitArray c_Next = new BitArray(28);
		private BitArray d_Next = new BitArray(28);

        // The resulting permutation P of the generatrix of the function 
        private BitArray p = new BitArray(32);

		public DES(ulong key, string file_Path)
		{
			this.key = key;
			source_File_Path = file_Path;
		}

        // Encryption algorithm
        public void Encrypt()
		{
			source_Text_Bytes = System.IO.File.ReadAllBytes(source_File_Path);
            // Completing the message in case of data volume not divisible by 64.
            if (source_Text_Bytes.Length % 8 != 0)
			{
				int last = source_Text_Bytes.Length % 8;
				Array.Resize(ref source_Text_Bytes, source_Text_Bytes.Length + (8 - last));
			}
            // Dividing a message into blocks
            for (int i = 0; i < source_Text_Bytes.Length / 8; i++)
			{
				byte[] text_Block = new byte[8];
				Array.Copy(source_Text_Bytes, i * 8, text_Block, 0, text_Block.Length);
				BitArray block = new BitArray(text_Block);
				source_Text_Blocks.Add(block);
			}
            // Key generation
            k = keys(key);
            // Encryption for each 64-bit block
            foreach (BitArray block in source_Text_Blocks)
			{
				int key_Index = 0;
				BitArray temp_Block = new BitArray(64);
                // Initial Permutation
                for (int i = 0; i < IP.Length; i++)
				{
					temp_Block[i] = block[IP[i] - 1];
				}
				l = Copy(temp_Block, 0, l.Length);
				r = Copy(temp_Block, 32, r.Length);
                // Run blocks 16 times
                for (int i = 0; i < 16; i++)
				{
					l_Next = r;
					r_Next = l.Xor(function(r, k[key_Index]));
					key_Index++;
					l = l_Next;
					r = r_Next;
				}
                // Combining half blocks
                temp_Block = Concat(r, l);
				BitArray result = new BitArray(64);
                // Reverse permutation
                for (int z = 0; z < temp_Block.Length; z++)
				{
					result[z] = temp_Block[IP_1[z] - 1];
				}
                // Adding a finished block to the list
                encoded_Text_Blocks.Add(result);
			}
            // Combining encrypted blocks into a single array of bits
            foreach (BitArray block in encoded_Text_Blocks)
			{
				resultBits = Append(resultBits, block);
			}
		}

        // Decryption algorithm
        public void Decrypt()
		{
			source_Text_Bytes = System.IO.File.ReadAllBytes(source_File_Path);
			if (source_Text_Bytes.Length % 8 != 0)
			{
				int last = source_Text_Bytes.Length % 8;
				Array.Resize(ref source_Text_Bytes, source_Text_Bytes.Length + (8 - last));
			}
			for (int i = 0; i < source_Text_Bytes.Length / 8; i++)
			{
				byte[] text_Block = new byte[8];
				Array.Copy(source_Text_Bytes, i * 8, text_Block, 0, text_Block.Length);
				BitArray block = new BitArray(text_Block);
				source_Text_Blocks.Add(block);
			}
			k = keys(key);
			foreach (BitArray block in source_Text_Blocks)
			{
				int key_Index = 15;
				BitArray temp_Block = new BitArray(64);
				for (int i = 0; i < IP.Length; i++)
				{
					temp_Block[i] = block[IP[i] - 1];
				}
				l = Copy(temp_Block, 0, l.Length);
				r = Copy(temp_Block, 32, r.Length);
				for (int i = 0; i < 16; i++)
				{
					r_Next = l;
					l_Next = r.Xor(function(l, k[key_Index]));
					key_Index--;
					l = l_Next;
					r = r_Next;
				}
				temp_Block = Concat(r, l);
				BitArray result = new BitArray(64);
				for (int z = 0; z < temp_Block.Length; z++)
				{
					result[z] = temp_Block[IP_1[z] - 1];
				}
				encoded_Text_Blocks.Add(result);
			}
			foreach (BitArray block in encoded_Text_Blocks)
			{
				resultBits = Append(resultBits, block);		
			}
		}

        // Bit array expansion
        public static BitArray Append(BitArray current, BitArray after)
		{
			var bools = new bool[current.Count + after.Count];
			current.CopyTo(bools, 0);
			after.CopyTo(bools, current.Count);
			return new BitArray(bools);
		}

        // Copying an array
        public BitArray Copy(BitArray source, int offset, int length)
		{
			BitArray bitArray = new BitArray(length);
			for(int i = 0; i < length; i++)
			{
				bitArray[i] = source[offset + i];
			}
			return bitArray;	
		}

        // Bit Array Concatenation (ONLY for arrays of the same length)
        public BitArray Concat(BitArray first, BitArray second)
		{
			BitArray bitArray = new BitArray(first.Length + second.Length);
			for (int i = 0; i < first.Length; i++)
			{
				bitArray[i] = first[i];
				bitArray[i + first.Length] = second[i];
			}
			return bitArray;
		}

        // Generating function
        public BitArray function(BitArray r_Prev, BitArray k)
		{
			BitArray append = new BitArray(48);
			for (int i = 0; i < append.Length; i++)
			{
				append[i] = r_Prev[Expand[i]-1];
			}
			append.Xor(k);
			BitArray f = new BitArray(32);
			BitArray key_Block;
			string concat;
			for (int i = 0; i < 8; i++)
			{
				key_Block = Copy(append, i * 6, 6);
				concat = Convert.ToInt32(key_Block[0]).ToString() + Convert.ToInt32(key_Block[5]).ToString();
				int y = Convert.ToInt32(concat, 2);
				concat = "";
				for (int index = 1; index < 5; index++)
				{
					concat += Convert.ToInt32(key_Block[index]).ToString();
				}
				int x = Convert.ToInt32(concat, 2);
				int result = S_Block[i, y, x];
				string _double = "";
				while (result != 0)
				{
					_double = ((result % 2).ToString() + _double);
					result /= 2;
				}
				if (_double.Length != 4)
				{
					int zeros = 4 - _double.Length;
					for (int z = 0; z < zeros; z++)
					{
						_double = "0" + _double;
					}
				}
				for (int a = 0; a < 4; a++)
				{
					f[(4 * i) + a] = Convert.ToBoolean(Convert.ToInt32(_double[a]));
				}
			}
			return f;
		}

        // Round key generation
        public List<BitArray> keys(ulong key)
		{
			List<BitArray> keys = new List<BitArray>();
			byte[] key_Bytes = BitConverter.GetBytes(key);
			BitArray key_Bits = new BitArray(key_Bytes);
			BitArray k = new BitArray(56);
			BitArray cd;
			BitArray k_Next = new BitArray(48);
			for (int i = 0; i < k.Length; i++)
			{
				k[i] = key_Bits[PC_1[i] - 1];
			}
			c = Copy(k, 0, c.Length);
			d = Copy(k, 28, d.Length);
			for (int i = 0; i < 16; i++)
			{
				c_Next = BitShift_Left(c, ls[i]);
				d_Next = BitShift_Left(d, ls[i]);
				cd = Concat(c_Next, d_Next);
				for (int j = 0; j < k_Next.Length; j++)
				{
					k_Next[j] = cd[PC_2[j] - 1];
				}
				keys.Add(k_Next);
				c = c_Next;
				d = d_Next;
			}
			return keys;
		}

        // Rotate an array of key bits to the left by shift bits
        public BitArray BitShift_Left(BitArray key, int shift)
		{
			int len = key.Length;
			BitArray bitShift = new BitArray(len);
			for (int k = 0; k < shift; k++)
			{
				for (int i = 0; i < len; i++)
				{
					int index = (len - k + i) % len;
					bitShift[index] = key[i];
				}	
			}
			return bitShift;
		}

        // Saving a file
        public void Save_File(int x)
		{
			byte[] encodedBytes = new byte[resultBits.Length / 8 + (resultBits.Length % 8 == 0 ? 0 : 1)];
			resultBits.CopyTo(encodedBytes, 0);
			switch (x)
			{
				case 0:
					File.WriteAllBytes("DES_encryption.txt", encodedBytes);
					break;
				case 1:
					File.WriteAllBytes("DES_decryption.txt", encodedBytes);
					break;
				case 2:
					File.WriteAllBytes("3DES_encryption.txt", encodedBytes);
					break;
				case 3:
					File.WriteAllBytes("3DES_decryption.txt", encodedBytes);
					break;
			}
		}
	}
}
