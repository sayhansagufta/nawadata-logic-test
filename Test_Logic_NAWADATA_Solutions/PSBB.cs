using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_Logic_NAWADATA_Solutions
{
    class PSBB
    {
        public static void Run()
        {
            // Membaca jumlah keluarga
            Console.Write("Input the number of families: ");
            int n = int.Parse(Console.ReadLine());

            // Membaca ukuran keluarga
            Console.Write("Input the number of members in the family (separated by a space): ");
            string[] input = Console.ReadLine().Split(' ');

            // Validasi jumlah input dengan jumlah keluarga
            if (input.Length != n)
            {
                Console.WriteLine("Input must be equal with count of family");
                return;
            }

            // Parsing ukuran keluarga
            List<int> familySizes = input.Select(int.Parse).ToList();

            // Mengurutkan ukuran keluarga secara descending untuk mempermudah pairing
            familySizes.Sort((a, b) => b.CompareTo(a));

            int busCount = 0;
            int left = 0, right = familySizes.Count - 1;

            // Proses pairing keluarga
            while (left <= right)
            {
                if (familySizes[left] + familySizes[right] <= 4)
                {
                    // Jika dua keluarga bisa digabung dalam satu bus
                    right--; // Keluarga terkecil dipasangkan
                }
                // Keluarga terbesar selalu menggunakan bus
                left++;
                busCount++;
            }

            // Output hasil
            Console.WriteLine($"Minimum bus required is: {busCount}");
            Console.ReadKey();
        }
    }
}
