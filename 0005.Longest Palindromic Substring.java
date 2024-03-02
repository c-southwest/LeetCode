class Solution {
    public String longestPalindrome(String s) {
        int start=0, end=0;
        for (int i = 0; i < s.length(); i++) {

            // .. x ..
            int a=i, b=i;
            while(a >= 0 && b < s.length()){
                if(s.charAt(a) == s.charAt(b)){
                    if(b-a > end-start){
                        start = a;
                        end = b;
                    }
                }else {
                    break;
                }
                a--;
                b++;
            }

            // .. x x ..
            a=i;
            b=i+1;
            while(a >= 0 && b < s.length()){
                if(s.charAt(a) == s.charAt(b)){
                    if(b-a > end-start){
                        start = a;
                        end = b;
                    }
                }else {
                    break;
                }
                a--;
                b++;
            }
        }
        return s.substring(start, end+1);
    }
}
