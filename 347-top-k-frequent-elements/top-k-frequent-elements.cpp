class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int, int> freqMap;
        for (int num : nums) {
            freqMap[num]++;
        }

        priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> minHeap;
        for (auto& entry : freqMap) {
            minHeap.push({entry.second, entry.first}); 
            if (minHeap.size() > k) {
                minHeap.pop(); 
            }
        }

        vector<int> topK;
        while (!minHeap.empty()) {
            topK.push_back(minHeap.top().second);
            minHeap.pop();
        }

        return topK;
    }
};
