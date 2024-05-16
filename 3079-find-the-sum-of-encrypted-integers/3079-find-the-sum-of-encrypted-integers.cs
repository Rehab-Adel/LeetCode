public class Solution {
    public int SumOfEncryptedInt(int[] nums) {
        int totalSum = 0;
        foreach (int num in nums) {
            int encryptedNum = Encrypt(num);
            totalSum += encryptedNum;
        }
        return totalSum;
    }
    private int Encrypt(int x) {
        int largestDigit = 0;
        int temp = x;
        while (temp > 0) {
            int digit = temp % 10;
            if (digit > largestDigit) {
                largestDigit = digit;
            }
            temp /= 10;
        }
                int encryptedNum = 0;
        int place = 1;
        
        while (x > 0) {
            encryptedNum += largestDigit * place;
            place *= 10;
            x /= 10;
        }
        return encryptedNum;
    }
}
