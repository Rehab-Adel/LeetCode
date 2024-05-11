public class Solution {
    public bool IsHappy(int n) {
        int slow = n, fast = n;

        do {
            slow = SumOfSquares(slow);
            fast = SumOfSquares(SumOfSquares(fast));
        } while (slow != fast);

        return slow == 1;
    }

    private int SumOfSquares(int num) {
        int sum = 0;
        while (num > 0) {
            int digit = num % 10;
            sum += digit * digit;
            num /= 10;
        }
        return sum;
    }
}
