// Rangkuman Pertemuan 2
using System;
namespace RangkumanPertemuan2{
    class Program{
        static void Main(string[] args){
            //Increment
            int inc_a = 3;
            Console.WriteLine("!!Increment, a=3");
            Console.WriteLine("a awal:"+inc_a);                 //output: 3     
            Console.WriteLine("a setelah increment(++a):"+ ++inc_a); //output: 4 

            Console.WriteLine("===============================");
            //Decrement
            int dec_a = 4;
            Console.WriteLine("!!Decrement, a=4");
            Console.WriteLine("a awal:"+dec_a);                 //output: 4
            Console.WriteLine("a setelah decrement(--a):"+ --dec_a); //output: 3      
        
            Console.WriteLine("===============================");
            //Perbandingan
            int perb_a = 5;
            int perb_b = 10;
            Console.WriteLine("!!Perbandingan, a=5 b=10");
            Console.WriteLine("a==b : "+(perb_a==perb_b));
            Console.WriteLine("a>b : "+(perb_a>perb_b));
            Console.WriteLine("a<b : "+(perb_a<perb_b));
            Console.WriteLine("a>=b : "+(perb_a>=perb_b));
            Console.WriteLine("a<=b : "+(perb_a<=perb_b));

            Console.WriteLine("===============================");
            //Logika
            bool log_a = true;
            bool log_b = false;
            Console.WriteLine("!!Logika, a=True b=False");
            Console.WriteLine("a&&b : "+(log_a&&log_b));
            Console.WriteLine("a||b : "+(log_a||log_b));
            Console.WriteLine("!a : "+(!log_a));

            Console.WriteLine("===============================");
            //Array

            Console.WriteLine("!!Array");
            string[] arr_divisi = {"web","mobile","game","multimedia","jaringan"};
            Console.WriteLine("Divisi dalam DNCC:");
            for(int i=0;i<arr_divisi.Length;i++){
                Console.WriteLine(arr_divisi[i]);
            }

            Console.WriteLine("!!Array2D");
            int[,] arr_numbers = {{1,2,3},{4,5,6}};
            Console.WriteLine(arr_numbers[0,1]); //output 2
            Console.WriteLine(arr_numbers[1,2]); //output 6
            
            Console.WriteLine("!!Array3D");
            int[,,] arr_number = {{{1,2,3},{4,5,6}},{{7,8,9},{10,11,12}}};
            Console.WriteLine(arr_number[0,0,0]); //output 1
            Console.WriteLine(arr_number[1,1,0]); //output 10

            Console.WriteLine("===============================");
            //List
            Console.WriteLine("!!List");
            var list_names = new List<string> {"Game","Mobile","Web"};
            for(int i=0;i<list_names.Count;i++){
                Console.Write(list_names[i]+" ");
            }
            Console.WriteLine("");
            List<int> list_angka = new List<int>();
            //Menambah data pada list
            list_angka.Add(1);
            list_angka.Add(2);
            list_angka.Add(3);
            //Menambah data sekaligus pada list
            list_angka.AddRange(new int[3] {4,5,6});
            //Menghapus data/item pada list
            list_angka.Remove(1);
            //Menghapus data pada list berdadsarkan index
            list_angka.RemoveAt(0);
            //Mengetahui index pada suatu data
            list_angka.IndexOf(3);
            //Mengecek apakah ada data yang sesuai
            Console.WriteLine(list_angka.Contains(10));
            //Mengetahui panjang suatu list
            Console.WriteLine(list_angka.Count());

            Console.WriteLine("===============================");
            
            //Pengkondisian
            int kond_skor = 65;
            Console.WriteLine("!!Pengkondisian, skor=65");
            if(kond_skor>=90){
                Console.WriteLine("Skor sangat bagus!");
            }else if(kond_skor>=75){
                Console.WriteLine("Skor cukup!");
            }else if(kond_skor>=60){
                Console.WriteLine("Skor kurang memuaskan!");
            }else{
                Console.WriteLine("Skor sangat kurang!");
            }

            Console.WriteLine("===============================");
            //Switch
            Console.WriteLine("!!Switch, skor=65");
            int sw_skor = 65;
            switch(sw_skor){
                case >= 90:
                    Console.WriteLine("Skor sangat bagus!");
                break;
                case >= 75:
                    Console.WriteLine("Skor cukup!");
                break;
                case >= 60:
                    Console.WriteLine("Skor kurang memuaskan!");
                break;
                default:
                    Console.WriteLine("Skor sangat kurang!");
                break;
            }
            
            Console.WriteLine("===============================");
        }   
    }
}
