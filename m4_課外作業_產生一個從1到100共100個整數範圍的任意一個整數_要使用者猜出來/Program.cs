using System;
class Program
{
    static void Main(string[] args)
    {
        int 神秘的整數 , x;

        // fix #1 觀察下一行
        // 產生一個從1到100共100個整數範圍的任意一個整數
        神秘的整數 = (int)(new Random().NextDouble() * 100 + 1);

       // Console.WriteLine("從1到100共100個整數範圍的任意一個整數   為");
       // Console.WriteLine(神秘的整數);

        Console.WriteLine("#################################################");
        String 使用者猜的輸入;
        int 使用者猜的整數;
        bool 使用者輸入的是int;

        // fix #2 觀察下面 while 迴圈
        // fix #3  修改下面 while 迴圈, 使得使用者可比較容易猜出答案.
        //           若猜太大了, 請提示使用者往小一點的方向猜
        //           若猜太小了, 請提示使用者往大一點的方向猜
        //           若猜錯了, 讓使用者繼續猜
        //           若猜對了, 才離開此 while 才可結束程式
        x = 0 ;
        while ( 神秘的整數-x > 0 )
        {
            Console.WriteLine();
            Console.WriteLine("請輸入一個從1到100的整數");
            使用者猜的輸入 = Console.ReadLine();
            // fix #4 觀察下面 TryParse 
            //   , 它可把使用者輸入的字串, 轉成整數存到 "使用者猜的整數" 變數中.
            //   若轉成功, 會算出 true
            //  若轉不成功, 會算出 false
            使用者輸入的是int = int.TryParse(使用者猜的輸入, out 使用者猜的整數);
            if (使用者輸入的是int)
            {
                Console.Write("使用者猜的整數為 ");
                Console.WriteLine(使用者猜的整數);
                if (使用者猜的整數 > 神秘的整數)
                   { Console.WriteLine("太大,讓使用者繼續猜"); }
                if (使用者猜的整數 < 神秘的整數)
                   { Console.WriteLine("太小,讓使用者繼續猜"); }
                if (使用者猜的整數 == 神秘的整數)
                   { Console.WriteLine("恭喜答對了");
                    x = x + 神秘的整數 ;
                   }
                   



            }



        }  //end of 迴圈 while

        Console.WriteLine();
        Console.WriteLine("遊戲結束");
        Console.WriteLine();
        Console.WriteLine();
    }
}

