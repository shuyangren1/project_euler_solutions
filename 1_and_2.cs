    public class Solution
    {
        //Find sum for all multiples of  X and Y no greater than limit
        //If answer should not include limit, input optional bool parameter as "false"
        public int MulXAndY(int x, int y, int limit, bool inclusive = true) 
        {
            //Find all sum of all mul of X
            if (!inclusive)
            {
                return MulXAndY(x, y, limit - 1, inclusive = true);
            }
            return MulXHelper(x, limit) + MulXHelper(y, limit) - MulXHelper(IntLCM(x,y), limit);
        }
        public int MulXHelper(int x, int limit)//Find sum for all multiples of X under limit
        {
            int count = limit / x;
            int highest = count * x;
            return (x + highest) * (count) / 2;
        }
        //Find the greatest common denominator of int x and int y
        public int IntGCD(int x, int y)
        {
            if (x % y == 0) return y;
            return IntGCD(y, x % y);
        }
        //Find the lowest commmon multiple of int x and int y
        public int IntLCM(int x, int y)
        {
            return x * y / IntGCD(x,y);
        }

        public int EvenFib(int limit) //Find sum for Fib terms no greater than limit
        {
            int prev = 0; int curr = 1; int sum = 0;
            while (curr <= limit)
            {
                int temp = prev;
                prev = curr;
                curr += temp;
                if (curr%2 == 0)
                {
                    sum += curr;
                }
            }
            return sum;
        }
    }