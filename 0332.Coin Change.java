import java.lang.reflect.Array;
import java.util.Arrays;

public class leetcode {
    public static void main(String[] args) {
        System.out.println(Integer.MAX_VALUE);
    }

    class Solution {
        public int coinChange(int[] coins, int amount) {
            if(amount==0) return 0;
            int[] F = new int[amount+1];
            F[0] = 0;
            for (int i =1; i<=amount; i++){
                int min=Integer.MAX_VALUE;
                for(int coin : coins){
                    if(i-coin>=0){
                        if(F[i - coin] == -1) continue;
                        min = Math.min(F[i - coin], min);
                    }
                }
                if(min==Integer.MAX_VALUE){
                    F[i] = -1;
                }else {
                    F[i] = min + 1;
                }
            }
            return F[amount];
        }
    }
    class Solution2 {
        public int coinChange(int[] coins, int amount) {
            if(amount==0) return 0;

            return coinChange(coins, amount, new int[amount]);

        }
        int coinChange(int[] coins, int rem, int[] count){
            if(rem<0) return -1;
            if(rem==0) return 0;
            if(count[rem-1] != 0) return count[rem-1];
            int min = Integer.MAX_VALUE;
            for(int coin: coins){
                int res = coinChange(coins, rem-coin, count);
                if(res >=0 && res < min){
                    min = 1+res;
                }
            }
            count[rem-1] = (min == Integer.MAX_VALUE) ? -1 : min;
            return count[rem-1];
        }
    }
}
