class Solution {
    public int countSubstrings2(String s) {
        int count=0;
        for (int i = 0; i < s.length(); i++) {
            int start=i, end=i;
            while(start>=0 && end<=s.length()-1){
                if(s.charAt(start--) == s.charAt(end++)){
                    count++;
                }else {
                    break;
                }
            }
            start=i;
            end=i+1;
            while(start>=0 && end < s.length()){
                if(s.charAt(start--) == s.charAt(end++)){
                    count++;
                }else {
                    break;
                }
            }
        }
        return count;
    }

    public int countSubstrings(String s) {
        int count=0;
        boolean dp[][] = new boolean[s.length()][s.length()];
        for (int i = s.length()-1; i >=0 ; i--) {
            for (int j=i; j<s.length(); j++){
                if(s.charAt(i) == s.charAt(j)){
                    if(j-i <= 1){
                        count++;
                        dp[i][j] = true;
                    }else{
                        if(dp[i+1][j-1]==true){
                            count++;
                            dp[i][j]=true;
                        }
                    }
                }
            }
        }
//        for (boolean[] booleans : dp) {
//            System.out.println(Arrays.toString(booleans));
//        }
        return count;
    }
}
