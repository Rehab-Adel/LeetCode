class Solution {
public:
    bool containsDuplicate(int numbers[], int size) {
        sort(numbers, numbers + size);

        for (int i = 0; i < size - 1; i++) {
            if (numbers[i] == numbers[i + 1]) {
                return true;
            }
        }

        return false;
    }
};
