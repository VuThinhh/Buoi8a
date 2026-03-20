using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8a
{
	class Program
	{
        static void COR()
		{
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Danh sách các mệnh giá cần thiết lập
            int[] denominations = { 100, 50, 20, 10, 5, 2, 1 };

            // Tạo mắt xích đầu tiên (gốc của chuỗi)
            MoneyHandler rootHandler = new CurrencyHandler(denominations[0]);
            MoneyHandler current = rootHandler;

            // Tự động kết nối các mắt xích còn lại vào chuỗi
            for (int i = 1; i < denominations.Length; i++)
            {
                var next = new CurrencyHandler(denominations[i]);
                current.SetNext(next);
                current = next; // Di chuyển con trỏ sang mắt xích vừa tạo
            }

            // Thực thi chương trình
            Console.Write("Nhập số tiền cần đổi: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine($"\nKết quả tối ưu cho {n}:");
                rootHandler.Handle(n);
            }

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
		static void Iterator()
		{
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");


            // Create iterator
            Iterator iterator = collection.CreateIterator();


            // Skip every other item
            iterator.Step = 2;


            Console.WriteLine("Iterating over collection:");


            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }


            // Wait for user
            Console.ReadKey();

        }
        static void Main(string[] args)
		{
            Iterator();
            COR();
        }
	}
}
